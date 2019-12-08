using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace MoodFull.Droid
{
    static class Permission
    {
        const int RequestLocationId = 0;

        public static void TryToGetPermissions(AppCompatActivity activity)
        {   
            //Checks the build version
            if ((int)Build.VERSION.SdkInt >= 23)
            {
                //All permissions that we want to request
                string[] permissionsGroupLocation =
                {
                    Android.Manifest.Permission.Camera,
                    Android.Manifest.Permission.AccessFineLocation
                };

                GetPermissions(Android.Manifest.Permission.Camera, activity, permissionsGroupLocation);
                GetPermissions(Android.Manifest.Permission.AccessFineLocation, activity, permissionsGroupLocation);
                return;
            }
        }

        private static void GetPermissions(string permission, AppCompatActivity activity, string[] permissionsGroupLocation)
        {
            if (activity.CheckSelfPermission(permission) == (int)Android.Content.PM.Permission.Granted)
            {
                Toast.MakeText(activity, "Permission granted", ToastLength.Short).Show();
                return;
            }

            if (activity.ShouldShowRequestPermissionRationale(permission))
            {
                //set Alert for executing task
                Android.App.AlertDialog.Builder alert = new Android.App.AlertDialog.Builder(activity);
                alert.SetTitle("Permission Needed");
                alert.SetMessage("Need permission to continue");
                alert.SetPositiveButton("Request permission", (senderAlert, args) =>
                {
                    activity.RequestPermissions(permissionsGroupLocation, RequestLocationId);
                });

                alert.SetNegativeButton("Cancel", (sendAlert, args) =>
                {
                    Toast.MakeText(activity, "Cancelled", ToastLength.Short).Show();
                });

                Dialog dialog = alert.Create();
                dialog.Show();

                return;
            }
            activity.RequestPermissions(permissionsGroupLocation, RequestLocationId);
        }
    }
}