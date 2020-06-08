using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;
using Android;
using DacodesTest.Droid.DependencyServices;
using Android.Widget;

namespace DacodesTest.Droid
{
    [Activity(Label = "Venados Test", Icon = "@mipmap/icon", Theme = "@style/MainTheme", ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation, ScreenOrientation = ScreenOrientation.Portrait)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(savedInstanceState);

            AndroidUtils.Context = this;

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            Rg.Plugins.Popup.Popup.Init(this, savedInstanceState);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: true);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnStart()
        {
            base.OnStart();
            const string permission = Manifest.Permission.AccessFineLocation;
            if (Android.Support.V4.Content.ContextCompat.CheckSelfPermission(this, permission) != Permission.Granted)
            {
                Android.Support.V4.App.ActivityCompat.RequestPermissions(this, new string[] { Manifest.Permission.ReadCalendar, Manifest.Permission.WriteCalendar }, 0);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("Permission Granted!!!");
            }
        }
    }
}