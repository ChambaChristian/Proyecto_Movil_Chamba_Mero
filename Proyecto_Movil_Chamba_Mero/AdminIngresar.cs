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
    [Activity(Label = "AdminIngresar")]
    public class AdminIngresar : Activity
    {
        BaseDatos conex = new BaseDatos();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Insert);
            var txtCodigo = FindViewById<EditText>(Resource.Id.cod);
            var txtNombre = FindViewById<EditText>(Resource.Id.nom);
            var txtPrecio = FindViewById<EditText>(Resource.Id.precio);
            var txtCategoria = FindViewById<EditText>(Resource.Id.cat);
            var btnIngresar = FindViewById<Button>(Resource.Id.btningresar);

            btnIngresar.Click += delegate
            {
                conex.AgregarProducto(txtCodigo.Text, txtNombre.Text, Convert.ToDouble(txtPrecio), Convert.ToInt32(txtCategoria ));
            };
        }
    }
}