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
    public partial class añadir : Form
    {
        public añadir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new 
                SqlConnection("Data Source = SACAELVICIO\\PRUEBA; Initial Catalog = PROYECTO_FINAL;User ID=sa; Password=123456; TrustServerCertificate = True");
            SqlCommand cmd = new SqlCommand("INSERT INTO agregar (seccion, categoria, color, talla, precio, stock)" +
              "VALUES (@seccion, @categoria, @color, @talla, @precio, @stock)", conn);

            cmd.Parameters.AddWithValue("@seccion", txtSeccion.Text);
            cmd.Parameters.AddWithValue("@categoria", txtCategoria.Text);
            cmd.Parameters.AddWithValue("@color", txtColor.Text);
            cmd.Parameters.AddWithValue("@talla", txtTalla.Text);
            cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
            cmd.Parameters.AddWithValue("@stock", txtStock.Text);

            conn.Open();
            try
            {

                if (txtSeccion.Text == "" || txtCategoria.Text == "" || txtColor.Text == "" || txtTalla.Text == "" || txtPrecio.Text == "" || txtStock.Text == "")
                {
                    MessageBox.Show("Favor de llenar todos los campos porfavor", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Datos guardados de manera existosa", "EXITO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSeccion.Clear();
                    txtCategoria.Clear();
                    txtPrecio.Clear();
                    txtColor.Clear();
                    txtTalla.Clear();
                    txtStock.Clear();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR AL CARGAR!!", "Llamen a dios", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void añadir_Load(object sender, EventArgs e)
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

        private void llenar_grid()
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

        private void button2_Click(object sender, EventArgs e)
        {
            llenar_grid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Menu_db mun = new Menu_db();
            mun.Show();
            this.Close();
        }

    
    }
}
