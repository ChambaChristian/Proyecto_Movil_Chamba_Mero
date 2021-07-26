using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_Movil_Chamba_Mero
{
    [Activity(Label = "AdminEditar")]
    public class AdminEditar : Activity
    {
        BaseDatos conex = new BaseDatos();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Edit);
            var txtCodigo2 = FindViewById<EditText>(Resource.Id.codigo);
            var txtPrecio2 = FindViewById<EditText>(Resource.Id.precio2);
            var btnEditar = FindViewById<Button>(Resource.Id.btneditar);

            btnEditar.Click += delegate
            {
                conex.EditarProducto(txtCodigo2.Text, Convert.ToDouble(txtPrecio2));
            };
        }
    }
}