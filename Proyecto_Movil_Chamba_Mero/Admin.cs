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
    [Activity(Label = "Admin")]
    public class Admin : Activity
    {
        BaseDatos conex = new BaseDatos();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Inicio);
            var ingresar = FindViewById<Button>(Resource.Id.btningresarya);
            var modificar = FindViewById<Button>(Resource.Id.btnmodi);
            var eliminar = FindViewById<Button>(Resource.Id.btneli);
            ingresar.Click += delegate
            {
                Intent intent = new Intent(this, typeof(AdminIngresar));
                StartActivity(intent);
            };
            modificar.Click += delegate
            {
                Intent intent = new Intent(this, typeof(AdminEditar));
                StartActivity(intent);
            };
            eliminar.Click += delegate
            {
                Intent intent = new Intent(this, typeof(AdminEliminar));
                StartActivity(intent);
            };
        }
    }
}