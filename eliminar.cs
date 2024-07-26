using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL
{
    public partial class eliminar : Form
    {
        public eliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = dataGridView2.CurrentCell.RowIndex;
            string id = dataGridView2.Rows[r].Cells[0].Value.ToString();
            SqlConnection conn = new
               SqlConnection("Data Source = SACAELVICIO\\PRUEBA; Initial Catalog = PROYECTO_FINAL;User ID=sa; Password=123456; TrustServerCertificate = True");
            try
            {
                conn.Open();
                string consull =
                "DELETE from agregar where id =" + id;
                SqlCommand cmd = new SqlCommand(consull, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos eliminados correctamente", "DELETE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCategoria.Clear();
                txtSeccion.Clear();
                txtColor.Clear();
                txtPrecio.Clear();
                txtTalla.Clear();
                txtStock.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("OPERACION FALLIDA", "LLAMEN A DIOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                conn.Close();
            }

        }
        



        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSeccion.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            txtCategoria.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            txtColor.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            txtTalla.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            txtPrecio.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            txtStock.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new
               SqlConnection("Data Source = SACAELVICIO\\PRUEBA; Initial Catalog = PROYECTO_FINAL;User ID=sa; Password=123456; TrustServerCertificate = True");

            conn.Open();
            string consulta = "select * from agregar";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Menu_db menu = new Menu_db();
            menu.Show();
            this.Close();
        }

        private void eliminar_Load_1(object sender, EventArgs e)
        {
            SqlConnection conn = new
               SqlConnection("Data Source = SACAELVICIO\\PRUEBA; Initial Catalog = PROYECTO_FINAL;User ID=sa; Password=123456; TrustServerCertificate = True");

            conn.Open();
            string consulta = "select * from agregar";
            SqlDataAdapter adapter = new SqlDataAdapter(consulta, conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();
        }
    }
}
