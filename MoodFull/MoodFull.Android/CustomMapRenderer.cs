using System;
using System.Collections.Generic;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Views;
using Android.Widget;
using MoodFull.CustomizedMap;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using static Android.Gms.Maps.GoogleMap;
using View = Xamarin.Forms.View;

[assembly: ExportRenderer(typeof(CustomMap), typeof(MoodFull.Droid.CustomMapRenderer))]
namespace MoodFull.Droid
{
    [Obsolete]
    public class CustomMapRenderer : MapRenderer
    {
        List<CustomPin> customPins;
        public CustomMapRenderer(Context context) : base(context)
        {
        }
        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Map> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null)
            {
                NativeMap.InfoWindowClick -= OnInfoWindowClick;
            }

            if (e.NewElement != null)
            {
                var formsMap = (CustomMap)e.NewElement;
                customPins = formsMap.CustomPins;
            }
        }

        protected override void OnMapReady(GoogleMap map)
        {
            base.OnMapReady(map);

            NativeMap.InfoWindowClick += OnInfoWindowClick;

        }
        protected override MarkerOptions CreateMarker(Pin pin)
        {
            var marker = new MarkerOptions();
            marker.SetPosition(new LatLng(pin.Position.Latitude, pin.Position.Longitude));
            marker.SetTitle(pin.Label);
            marker.SetSnippet(pin.Address + "\n" + "Vienas");
            float color;
            if (pin is CustomPin customPin && customPin.Label == "Your current possition")
            {
                color = BitmapDescriptorFactory.HueBlue;
            }
            else
            {
                color = BitmapDescriptorFactory.HueRed;
            }
            marker.SetIcon(BitmapDescriptorFactory.DefaultMarker(color));
            customPins.Add(pin as CustomPin);
            return marker;
        }

        void OnInfoWindowClick(object sender, GoogleMap.InfoWindowClickEventArgs e)
        {
            var customPin = GetCustomPin(e.Marker);
            if (customPin == null)
            {
                throw new Exception("Custom pin not found");
            }

            if (!string.IsNullOrWhiteSpace(customPin.Url))
            {
                var url = Android.Net.Uri.Parse(customPin.Url);
                var intent = new Intent(Intent.ActionView, url);
                intent.AddFlags(ActivityFlags.NewTask);
                Android.App.Application.Context.StartActivity(intent);
            }
        }

        CustomPin GetCustomPin(Marker annotation)
        {
            var position = new Position(annotation.Position.Latitude, annotation.Position.Longitude);
            foreach (var pin in customPins)
            {
                if (pin.Position == position)
                {
                    return pin;
                }
            }
            return null;
        }
        /*
        public Android.Views.View GetInfoContents(Marker marker)
        {
            Android.Views.View view;
            var inflater = Android.App.Application.Context.GetSystemService(Context.LayoutInflaterService) as Android.Views.LayoutInflater;
            if (inflater != null)
            {
                Android.Views.View view;

                var customPin = GetCustomPin(marker);
                view.
                if (customPin == null)
                {
                    throw new Exception("Custom pin not found");
                }

                if (customPin.Id == "Xamarin")
                {
                    view = inflater.Inflate(Resource.Layout.XamarinMapInfoWindow, null);
                }

                return view;
            }
            return null;
        }

        public Android.Views.View GetInfoWindow(Marker marker)
        {
            return null;
        }
        */
    }
}
