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
            var txtColor = FindViewById<EditText>(Resource.Id.color);
            var txtTalla = FindViewById<EditText>(Resource.Id.talla);
            var btnIngresar = FindViewById<Button>(Resource.Id.btningresar);

            btnIngresar.Click += delegate
            {
                conex.AgregarProducto(txtCodigo.Text, txtNombre.Text, Convert.ToDouble(txtPrecio), Convert.ToInt32(txtCategoria), Convert.ToInt32(txtColor), Convert.ToInt32(txtTalla));
                CrossLocalNotifications.Current.Show("Nuevo producto ingresado", "Se ha ingresado un nuevo producto a la base de datos", 0, DateTime.Now.AddSeconds(0));
            };
        }
    }
}