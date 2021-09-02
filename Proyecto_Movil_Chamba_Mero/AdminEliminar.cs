using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Plugin.LocalNotifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Movil_Chamba_Mero
{
    [Activity(Label = "AdminEliminar")]
    public class AdminEliminar : Activity
    {
        BaseDatos conex = new BaseDatos();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Delete);
            var txtCodigo3 = FindViewById<EditText>(Resource.Id.codigoE);

            var btnEliminar = FindViewById<Button>(Resource.Id.btneliminar);

            btnEliminar.Click += delegate
            {
                conex.EliminarProducto(txtCodigo3.Text);
                CrossLocalNotifications.Current.Show("Producto eliminado", "Se ha eliminado un producto de la base de datos", 0, DateTime.Now.AddSeconds(0));
            };
        }
    }
}