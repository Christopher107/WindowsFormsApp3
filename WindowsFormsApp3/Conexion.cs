using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    class Conexion
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;

        public Conexion()
        {
            try
            {
                cn = new SqlConnection("Data Source=.;Initial Catalog=Practicando2;Integrated Security=True");
                cn.Open();
                MessageBox.Show("Conexion realizada con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar :" + ex.ToString());
            }
        }
        public string insertar(int Cod, string Marca, string Tipo, int Precio)
        {
            string salida = "se inserto";
            try
            {
                cmd = new SqlCommand("insert into REGISTROMER(Cod,Marca,Tipo,Precio) values{" + Cod + ",'" + Marca + "','" + Tipo + "'," + Precio + "}", cn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                salida = "no se conecto" + ex.ToString();
            }
            return salida;
        }
        public int MercaderiaRegistrada(int Cod)
        {
            int contador = 0;
            try
            {
                cmd = new SqlCommand("Select * from REGISTROMER where Cod=" + Cod + "", cn);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("no se pudo consultar bien" + ex.ToString());
            }
            return contador;
        }
    }
}

