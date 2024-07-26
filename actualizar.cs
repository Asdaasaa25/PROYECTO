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
    public partial class actualizar : Form
    {
        public actualizar()
        {
            InitializeComponent();
        }

        private void actualizar_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            int r = dataGridView1.CurrentCell.RowIndex;
            string id = dataGridView1.Rows[r].Cells[0].Value.ToString();
            SqlConnection conn = new
               SqlConnection("Data Source = SACAELVICIO\\PRUEBA; Initial Catalog = PROYECTO_FINAL;User ID=sa; Password=123456; TrustServerCertificate = True");
             try
            {
                conn.Open();
                string consull =  
                "UPDATE agregar SET seccion = ' " + txtSeccion.Text + "', categoria = ' " + txtCategoria.Text + " ', color = ' " + txtColor.Text + "  ', talla = ' " + txtTalla.Text + " ' , precio = " + txtPrecio.Text+ ", stock =" + txtStock.Text +" where id =" + id;
                SqlCommand cmd = new SqlCommand(consull, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Datos actualizados correctamente", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            Menu_db menu = new Menu_db();
            menu.Show(this);
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSeccion.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtCategoria.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtColor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtTalla.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtPrecio.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtStock.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
