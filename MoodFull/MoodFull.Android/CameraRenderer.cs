using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.Hardware;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MoodFull.Views.RateRestaurant), typeof(MoodFull.Droid.CameraRenderer))]
namespace MoodFull.Droid
{
    public class CameraRenderer : PageRenderer, TextureView.ISurfaceTextureListener
    {
        Android.Hardware.Camera camera;
        Android.Widget.Button takePhotoButton;
        Android.Widget.Button toggleFlashButton;
        Android.Widget.Button switchCameraButton;
        Android.Views.View view;
        AppCompatActivity activity;
        TextureView textureView;
        CameraFacing cameraType;
        SurfaceTexture surfaceTexture;

        private bool _flashOn;
        private bool _isCameraStarted = false;

        public CameraRenderer(Context context)
            : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || Element == null)
            {
                return;
            }

            try
            {
                SetupUserInterface();
                SetupEventHandlers();
                AddView(view);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(@"	ERROR: ", ex.Message);
            }
        }

        void SetupUserInterface()
        {
            activity = this.Context as AppCompatActivity;
            view = activity.LayoutInflater.Inflate(Resource.Layout.CameraLayout, this, false);
            cameraType = CameraFacing.Back;

            textureView = view.FindViewById<TextureView>(Resource.Id.textureView);
            textureView.SurfaceTextureListener = this;
        }

        void SetupEventHandlers()
        {
            takePhotoButton = view.FindViewById<Android.Widget.Button>(Resource.Id.takePhotoButton);
            takePhotoButton.Click += TakePhotoButtonTapped;

            switchCameraButton = view.FindViewById<Android.Widget.Button>(Resource.Id.switchCameraButton);
            switchCameraButton.Click += SwitchCameraButtonTapped;

            toggleFlashButton = view.FindViewById<Android.Widget.Button>(Resource.Id.toggleFlashButton);
            toggleFlashButton.Click += ToggleFlashButtonTapped;
        }

        void TakePhotoButtonTapped(object sender, EventArgs e)
        {
            //if camera isn't started
            if (!_isCameraStarted)
            {
                return;
            }

            camera.StopPreview();

            //Gets bitmap from the textureView
            var bitmap = textureView.Bitmap;

            //Converts bitmap to byte[]
            byte[] bitmapData;
            using (var stream = new MemoryStream())
            {
                bitmap.Compress(Bitmap.CompressFormat.Png, 0, stream);
                bitmapData = stream.ToArray();
            }

            //Send a message to App.axml to open next page
            MessagingCenter.Send<App, byte[]>(App.Current as App, "OpenRestaurantResultPage", bitmapData);

            camera.StartPreview();
        }


        //switches between front and back cameras when button is clicked
        void SwitchCameraButtonTapped(object sender, EventArgs e)
        {
            //if camera isn't started
            if (!_isCameraStarted)
            {
                return;
            }

            if (cameraType == CameraFacing.Front)
            {
                cameraType = CameraFacing.Back;

                camera.StopPreview();
                camera.Release();
                camera = Android.Hardware.Camera.Open((int)cameraType);
                camera.SetPreviewTexture(surfaceTexture);
                PrepareAndStartCamera();
            }
            else
            {
                cameraType = CameraFacing.Front;

                camera.StopPreview();
                camera.Release();
                camera = Android.Hardware.Camera.Open((int)cameraType);
                camera.SetPreviewTexture(surfaceTexture);
                PrepareAndStartCamera();
            }
        }

        //turns on or off camera flash
        void ToggleFlashButtonTapped(object sender, EventArgs e)
        {
            //if camera isn't started
            if (!_isCameraStarted)
            {
                return;
            }

            _flashOn = !_flashOn;

            if (_flashOn)
            {
                if (cameraType == CameraFacing.Back)
                {
                    toggleFlashButton.SetBackgroundResource(Resource.Drawable.FlashButton);
                    cameraType = CameraFacing.Back;

                    camera.StopPreview();
                    camera.Release();
                    camera = Android.Hardware.Camera.Open((int)cameraType);
                    var parameters = camera.GetParameters();
                    parameters.FlashMode = Android.Hardware.Camera.Parameters.FlashModeTorch;
                    camera.SetParameters(parameters);
                    camera.SetPreviewTexture(surfaceTexture);
                    PrepareAndStartCamera();
                }
            }
            else
            {
                toggleFlashButton.SetBackgroundResource(Resource.Drawable.NoFlashButton);
                camera.StopPreview();
                camera.Release();

                camera = Android.Hardware.Camera.Open((int)cameraType);
                var parameters = camera.GetParameters();
                parameters.FlashMode = Android.Hardware.Camera.Parameters.FlashModeOff;
                camera.SetParameters(parameters);
                camera.SetPreviewTexture(surfaceTexture);
                PrepareAndStartCamera();
            }
        }

        //Restarts camera
        void PrepareAndStartCamera()
        {
            camera.StopPreview();
            _isCameraStarted = false;

            var display = activity.WindowManager.DefaultDisplay;
            if (display.Rotation == SurfaceOrientation.Rotation0)
            {
                camera.SetDisplayOrientation(90);
            }

            if (display.Rotation == SurfaceOrientation.Rotation270)
            {
                camera.SetDisplayOrientation(180);
            }

            _isCameraStarted = true;
            camera.StartPreview();
        }

        public void OnSurfaceTextureAvailable(SurfaceTexture surface, int width, int height)
        {
            try
            {
                camera = Android.Hardware.Camera.Open((int)cameraType);
                textureView.LayoutParameters = new FrameLayout.LayoutParams(width, height);
                surfaceTexture = surface;

                camera.SetPreviewTexture(surface);
                PrepareAndStartCamera();
            }
            catch (Java.Lang.RuntimeException ex)
            {
                Permission.TryToGetPermissions(activity);
            }
            
        }

        public bool OnSurfaceTextureDestroyed(SurfaceTexture surface)
        {
            if (_isCameraStarted == false)
            {
                return true;
            }

            camera.StopPreview();
            camera.Release();
            return true;
        }

        protected override void OnLayout(bool changed, int l, int t, int r, int b)
        {
            base.OnLayout(changed, l, t, r, b);

            var msw = MeasureSpec.MakeMeasureSpec(r - l, MeasureSpecMode.Exactly);
            var msh = MeasureSpec.MakeMeasureSpec(b - t, MeasureSpecMode.Exactly);

            view.Measure(msw, msh);
            view.Layout(0, 0, r - l, b - t);
        }

        public void OnSurfaceTextureSizeChanged(SurfaceTexture surface, int width, int height)
        {
            PrepareAndStartCamera();
        }

        public void OnSurfaceTextureUpdated(SurfaceTexture surface)
        {

        }
    }
}