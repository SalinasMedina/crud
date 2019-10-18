using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;

namespace CRUD
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "funciones" en el código, en svc y en el archivo de configuración a la vez.
    public class funciones : Ifunciones
    {
        public void guardar(int a, string b, int c, float d, string e)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Inventario;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "insert into Producto1 values('" + a + "','" + b + "','" + c + "','" + d + "','" + e + "')";
            cmd = new SqlCommand(cadena, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public List<string> leer()
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dato;
            string cadena = "";
            var datos = new string[5];
            var consulta = new List<string>();
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Inventario;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "select * from Producto1";
            cmd = new SqlCommand(cadena, con);
            dato = cmd.ExecuteReader();
            int i = 0;
            while (dato.Read())
            {
                datos[0] = dato.GetInt32(0).ToString();
                datos[1] = dato.GetString(1);
                datos[2] = dato.GetInt32(2).ToString();
                datos[3] = dato.GetDecimal(3).ToString();
                datos[4] = dato.GetString(4);
                consulta.InsertRange(i, datos);
                i = i + 5;
            }
            con.Close();
            return consulta;
        }
        public bool modificar(int a, string b, int c, float d, string e)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Inventario;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "UPDATE Producto1 SET ID_Producto= ('" + a + "'), Nombre = ('" + b + "'), Cantidad = ('" + c + "'), Precio = ('" + d + "'), Proveedor = ('" + e + "')where ID_Producto = ('"+ a +"')";
            cmd = new SqlCommand(cadena, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            con.Close();

        }
        public bool eliminar(int a)
        {
            SqlConnection con;
            SqlCommand cmd;
            string cadena = "";
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Inventario;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "delete from Producto1 where ID_Producto=" + a;
            cmd = new SqlCommand(cadena, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
            
            con.Close();
        }
        public string[] buscar(int cla)
        {
            SqlConnection con;
            SqlCommand cmd;
            SqlDataReader dato;
            string cadena = "";
            string[] datos = new string[6];
            con = new SqlConnection("Data Source=DESKTOP-CABRK5M; Initial Catalog=Inventario;Integrated Security=false;user=nery;password=12345;");
            con.Open();
            cadena = "select * from Producto1 where Id_Producto=" + cla;
            cmd = new SqlCommand(cadena, con);
            dato = cmd.ExecuteReader();
                if (dato.Read())
                {
                    datos[0] = dato.GetInt32(0).ToString();
                    datos[1] = dato.GetString(1);
                    datos[2] = dato.GetInt32(2).ToString();
                    datos[3] = dato.GetDecimal(3).ToString();
                    datos[4] = dato.GetString(4);
                }
                con.Close();
                return datos;
        }
    }
}
