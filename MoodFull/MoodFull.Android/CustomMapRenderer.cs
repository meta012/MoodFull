using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.OS;
using System;
using System.Collections.Generic;
using Android.Content;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Maps.Android;
using static Android.Gms.Maps.GoogleMap;
using Android.Views;
using MoodFull.CustomizedMap;

[assembly: ExportRenderer(typeof(CustomMap), typeof(MoodFull.Droid.CustomMapRenderer))]
namespace MoodFull.Droid
{
    [Obsolete]
    public class CustomMapRenderer : MapRenderer
    {
        public CustomMapRenderer(Context context) : base(context)
        {
        }
        protected override MarkerOptions CreateMarker(Pin pin)
        {
            MarkerOptions marker = base.CreateMarker(pin);

            if (pin is CustomPin customPin && customPin.Label == "Your current possition")
            {
                var color = BitmapDescriptorFactory.HueBlue;
                marker.SetIcon(BitmapDescriptorFactory.DefaultMarker(color));
            }
            return marker;
        }
        /*
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

        protected override MarkerOptions CreateMarker(Pin pin)
        {
            var marker = new MarkerOptions();
            marker.SetPosition(new LatLng(pin.Position.Latitude, pin.Position.Longitude));
            marker.SetTitle(pin.Label);
            marker.SetSnippet(pin.Address);
            var color = BitmapDescriptorFactory.HueGreen;
            marker.SetIcon(BitmapDescriptorFactory.DefaultMarker(color));
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

        public Android.Views.View GetInfoWindow(Marker marker)
        {
            return null;
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
        */
    }
}
