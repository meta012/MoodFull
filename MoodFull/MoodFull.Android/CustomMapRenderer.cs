using System;
using System.Collections.Generic;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Graphics;
using Android.Views;
using Android.Widget;
using MoodFull.CustomizedMap;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;

[assembly: ExportRenderer(typeof(CustomMap), typeof(MoodFull.Droid.CustomMapRenderer))]
namespace MoodFull.Droid
{
    [Obsolete]
    public class CustomMapRenderer : MapRenderer, GoogleMap.IInfoWindowAdapter
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
            NativeMap.SetInfoWindowAdapter(this);

        }
        protected override MarkerOptions CreateMarker(Pin pin)
        {
            var marker = new MarkerOptions();
            marker.SetPosition(new LatLng(pin.Position.Latitude, pin.Position.Longitude));
            marker.SetTitle(pin.Label);
            
            float color;
            if (pin is CustomPin customPin)
            {
                if (customPin.Label == "Your current possition")
                {
                    color = BitmapDescriptorFactory.HueBlue;
                }
                else
                {
                    color = BitmapDescriptorFactory.HueRed;
                    marker.SetSnippet(customPin.Address);
                }
                marker.SetIcon(BitmapDescriptorFactory.DefaultMarker(color));
            }
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

        public Android.Views.View GetInfoContents(Marker marker)
        {
            var context = Android.App.Application.Context;
            LinearLayout info = new LinearLayout(context);
            info.Orientation = Orientation.Vertical;

            TextView title = new TextView(context);
            title.SetTextColor(Android.Graphics.Color.Black);
            title.Gravity = GravityFlags.Center;
            title.SetTypeface(null, TypefaceStyle.Bold);
            title.Text = marker.Title;

            TextView snippet = new TextView(context);
            snippet.SetTextColor(Android.Graphics.Color.Gray);
            snippet.Text = marker.Snippet;

            info.AddView(title);
            info.AddView(snippet);

            return info;
        }

        public Android.Views.View GetInfoWindow(Marker marker)
        {
            return null;
        }
        
    }
}
