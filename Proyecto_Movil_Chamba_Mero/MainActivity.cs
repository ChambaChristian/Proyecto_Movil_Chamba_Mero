using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using System;
using Android.Content;

namespace Proyecto_Movil_Chamba_Mero
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            //var registrar = FindViewById<TextView>(Resource.Id.txt_regis);
            //registrar.Click += Txt_Click;
            SetContentView(Resource.Layout.activity_main);

        }

        //private void Txt_Click(object sender, EventArgs e)
        //{
        //    Intent intent = new Intent(Intent.ActionView, Android.Net.Uri.Parse("http://wwww.google.com"));
        //    StartActivity(intent);
        //}
        //Proyecto_Movil_Chamba_Mero

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}