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
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new
                SqlConnection("Data Source = SACAELVICIO\\PRUEBA; Initial Catalog = PROYECTO_FINAL;User ID=sa; Password=123456; TrustServerCertificate = True");
            try
            {
                conn.Open();

                string consulta = "select * from agregar where " + cbxBusqueda.SelectedItem.ToString() + "=@busqueda";
                SqlCommand cmd = new SqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@busqueda", txtBuscar.Text);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL REALIZAR LA OPERACION", "NO MAMES LLAMEN A DIOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally { conn.Close(); }
        }

        private void consultar_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new
               SqlConnection("Data Source = SACAELVICIO\\PRUEBA; Initial Catalog = PROYECTO_FINAL;User ID=sa; Password=123456; TrustServerCertificate = True");

            conn.Open();
            string consulta = "select * from agregar";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Menu_db menu = new Menu_db();
            menu.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new
               SqlConnection("Data Source = SACAELVICIO\\PRUEBA; Initial Catalog = PROYECTO_FINAL;User ID=sa; Password=123456; TrustServerCertificate = True");

            conn.Open();
            string consulta = "select * from agregar";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
