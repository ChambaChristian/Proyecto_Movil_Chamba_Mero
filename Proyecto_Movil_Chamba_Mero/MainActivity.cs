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
        BaseDatos conex = new BaseDatos();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            int contador = 0;

            var usuario = FindViewById<EditText>(Resource.Id.usu);
            var contra = FindViewById<EditText>(Resource.Id.pass);
            var ingresar = FindViewById<Button>(Resource.Id.ing);
            
            ingresar.Click += delegate
            {

                if (conex.Ingresar(usuario.Text, contra.Text) == 1)
                {
                    Toast.MakeText(this, "Bienvenido al Sistema Administrador", ToastLength.Short).Show();
                    Intent intent = new Intent(this, typeof(Admin));
                    StartActivity(intent);
                }
                else if (conex.Ingresar(usuario.Text, contra.Text) == 2)
                {
                    Toast.MakeText(this, "Bienvenido al Sistema Cliente", ToastLength.Short).Show();
                    Intent intent = new Intent(this, typeof(ClienteInicio));
                    StartActivity(intent);
                }
            
                else
                {
                    Toast.MakeText(this, "Datos incorrectos", ToastLength.Short).Show();
                    contador += 1;
                }
                if (contador > 2)
                {
                    Toast.MakeText(this, "Ha execido el numero de intentos", ToastLength.Long).Show();

                    StartActivity(typeof(MainActivity)); Finish();

                }

                //if (usuario.Text == "admin" && password.Text == "12345") DATOS QUEMADOS
                //{
                //    Toast.MakeText(this, "Login hecho", ToastLength.Long).Show();

                //    Intent correo = new Intent(Intent.ActionSendMultiple); ENVIAR CORREO ELECTRONICO
                //    correo.PutExtra(Intent.ExtraEmail, new string[] { "christianCS37@hotmail.com" });
                //    correo.PutExtra(Intent.ExtraSubject, "Verificación exitosa de correo");
                //    correo.PutExtra(Intent.ExtraText, "El Universitario Cordillera les desea exito en sus examenes");
                //    correo.SetType("message/rfc822");
                //    StartActivity(Intent.CreateChooser(correo, "Correo enviado exitosamenete"));



                //}
               
            };
            
        }

 





        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}