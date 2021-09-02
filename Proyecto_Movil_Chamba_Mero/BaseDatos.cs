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
using System.Data.SqlClient;
using System.Data;

namespace Proyecto_Movil_Chamba_Mero
{
    class BaseDatos
    {
        static string url = "workstation id=DBCLOTHES.mssql.somee.com;packet size=4096;user id=chamba_SQLLogin_1;pwd=qkajlj3o33;data source=DBCLOTHES.mssql.somee.com;persist security info=False;initial catalog=DBCLOTHES";
        SqlConnection con = new SqlConnection(url);
        int valor = 0;
        public void Conexion()
        {
            con.Open();
            con.Close();
        }
        public int Ingresar(string usuario, string contra)
        {
            
            string consulta = "Select * from Tbl_usuario where usu_usu='"+usuario+"' and usu_pass='"+contra+"'";
            con.Open();
            SqlCommand Command = new SqlCommand(consulta, con);
            SqlDataReader rs = Command.ExecuteReader();
            while (rs.Read())
            {
                if (rs["usu_usu"].ToString().Equals(usuario) && rs["usu_pass"].ToString().Equals(contra))
                {
                    if (rs["roles_id"].ToString().Equals("1"))
                    {
                        valor = 1;

                    }
                    if (rs["roles_id"].ToString().Equals("2"))
                    {
                        valor = 2;
                    }
                }
                else
                {

                    valor = 0;
                }
            }
            rs.Close();
            con.Close();
            return valor;
        }
        public void AgregarProducto(string codigo, string nombre, double precio, int categoria, int color, int tallas)
        {
            string url = "INSERT INTO Tbl_producto prod_cod, prod_nombre, prod_precio, cat_id, color_id, tallas_Id VALUES (@codigo, @nombre, @precio, @categoria, @color, @tallas)";
            con.Open();
            SqlCommand command = new SqlCommand(url, con);
            command.Parameters.Add("@codigo", SqlDbType.VarChar, 10).Value = codigo;
            command.Parameters.Add("@nombre", SqlDbType.VarChar, 30).Value = nombre;
            command.Parameters.Add("@precio", SqlDbType.Float, 30).Value = precio;
            command.Parameters.Add("@categoria", SqlDbType.Int).Value = categoria;
            command.Parameters.Add("@color", SqlDbType.Int).Value = color;
            command.Parameters.Add("@tallas", SqlDbType.Int).Value = tallas;
            command.ExecuteReader();
            con.Close();
        }
        public void EliminarProducto(string codigo)
        {
            string consulta = "Delete from  Tbl_productos where prod_cod=' " + codigo + "'";
            con.Open();
            SqlCommand command = new SqlCommand(consulta, con);
            command.ExecuteNonQuery();
            con.Close();
        }
        public void EditarProducto(string codigo, double precio)
        {
            string consulta = "Update from  Tbl_productos set prod_precio='"+precio+"' where prod_cod=' " + codigo + "'";
            con.Open();
            SqlCommand command = new SqlCommand(consulta, con);
            command.ExecuteNonQuery();
            con.Close();
        }
    }

}