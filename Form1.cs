using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usua = usa.Text;
            string contrase = contra.Text;

            if (usua == "admin" && contrase == "admin")
            {
                MessageBox.Show("¡Bienvenido: "+usa.Text+"!", "INICIO",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form formulario = new Menu_db();
                formulario.Show();
                usa.Clear();
                contra.Clear();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrectas", "ERROR!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString("HH:mm");
            fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}