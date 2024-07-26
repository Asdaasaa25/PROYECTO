using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace PROYECTO_FINAL
{
    public partial class Menu_db : Form
    {
        public Menu_db()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            añadir anadir = new añadir();
            anadir.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            consultar consul = new consultar();
            consul.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eliminar eliminar = new eliminar();
            eliminar.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "- El Boton Añadir ayudara al empleado a ingresar nueva mercancia\n\n" +
                "- El Boton Actualizar cambiara un dato especifico del guardado\n\n" +
                "- El Boton Consultar realizara una busqueda dependiendo de que elija el empleado\n\n" +
                "- El Boton Eliminar buscara el elemento especificado por el usuario eliminando asi todos sus datos \n\n" +
                "- El Boton Cerrar sesion unicamente te enviara al login principal\n\n" +
                "- El Boton Salir cerrara la aplicacion en su totalidad", "Ayuda", MessageBoxButtons.OK);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 si = new Form1();
            si.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           actualizar act = new actualizar();
            act.Show();
        }
    }
}
