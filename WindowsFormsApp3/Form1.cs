using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        Conexion c = new Conexion();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion c = new Conexion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c.MercaderiaRegistrada(Convert.ToInt32(txtCod.Text))==0)
            { 
                MessageBox.Show(c.insertar(Convert.ToInt32(txtCod.Text), txtNombre.Text, txtTipo.Text, Convert.ToInt32(txtPrecio.Text)));
            }
            else
            {
                MessageBox.Show("El registro ya existe");
            }
        }
    }
}
