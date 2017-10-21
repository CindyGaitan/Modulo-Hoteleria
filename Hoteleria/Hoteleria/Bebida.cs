using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Hoteleria
{
    public partial class Bebida : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        string id_bebida;

        public Bebida()
        {
            InitializeComponent();
            mostrar_bebida();
        }

        public void mostrar_bebida()
        {
            try
            {
                da = new OdbcDataAdapter("select idBebida as No, nombreBebida as Bebida, costoBebida as Costo, descripcionBebida as Descripcion from Bebida", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_bebida.DataSource = dt;
                dgv_bebida.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_bebida.Rows[e.RowIndex];
                this.id_bebida = dgv.Cells[0].Value.ToString();
                txt_nombreBebida.Text = dgv.Cells[1].Value.ToString();
                txt_costoBebida.Text = dgv.Cells[2].Value.ToString();
                txt_descripcionBebida.Text = dgv.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OdbcCommand("insert into Bebida (nombreBebida, descripcionBebida, costoBebida) values ('" + txt_nombreBebida.Text + "','"+ txt_descripcionBebida.Text +"', "+ Convert.ToDecimal(txt_costoBebida.Text) +")", con.conexion());
                com.ExecuteNonQuery();
                txt_nombreBebida.Text = "";
                txt_costoBebida.Text = "";
                txt_descripcionBebida.Text = "";
                mostrar_bebida();
                MessageBox.Show("Datos ingresados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información. ");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {

            try
            {
                com = new OdbcCommand("update Bebida set nombreBebida='" + txt_nombreBebida.Text + "', descripcionBebida='" + txt_descripcionBebida.Text + "', costoBebida="+ Convert.ToDecimal(txt_costoBebida.Text) +" where idBebida=" + Convert.ToInt32(this.id_bebida) + " ", con.conexion());
                com.ExecuteNonQuery();
                txt_nombreBebida.Text = "";
                txt_costoBebida.Text = "";
                txt_descripcionBebida.Text = "";
                mostrar_bebida();
                MessageBox.Show("Datos actualizados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO actualizados, verifique la información. " + ex.ToString());
            }           
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OdbcCommand("delete from bebida where idBebida=" + Convert.ToInt32(this.id_bebida) + " ", con.conexion());
                com.ExecuteNonQuery();
                txt_nombreBebida.Text = "";
                txt_costoBebida.Text = "";
                txt_descripcionBebida.Text = "";
                mostrar_bebida();
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }          
        }
    }
}
