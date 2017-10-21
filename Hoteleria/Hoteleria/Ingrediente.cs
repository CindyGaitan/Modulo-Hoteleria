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
    public partial class Ingrediente : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        string id_ingrediente;

        public Ingrediente()
        {
            InitializeComponent();
            mostrar_ingrediente();
            cmb_UnidadMedida.Text = "SELECCIONE OPCION";
        }

        public void mostrar_ingrediente()
        {
            try
            {
                da = new OdbcDataAdapter("select idIngrediente as No, nombre as Nombre, unidadMedida as UnidadMedida, descripcion as Descripcion from Ingrediente", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_ingrediente.DataSource = dt;
                dgv_ingrediente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void Ingrediente_Load(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OdbcCommand("insert into Ingrediente (nombre, descripcion, unidadMedida) values ('"+txt_nombreIngrediente.Text+"', '"+txt_descripcionIngrediente.Text+"','"+cmb_UnidadMedida.Text+"')", con.conexion());
                com.ExecuteNonQuery();
                mostrar_ingrediente();
                txt_nombreIngrediente.Text = "";
                txt_descripcionIngrediente.Text = "";
                cmb_UnidadMedida.Text = "SELECCIONE OPCION";
                MessageBox.Show("Datos ingresados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información."+ex.ToString());
            }
           
        }

        private void dgv_Ingrediente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_ingrediente.Rows[e.RowIndex];
                this.id_ingrediente = dgv.Cells[0].Value.ToString();
                txt_nombreIngrediente.Text = dgv.Cells[1].Value.ToString();
                cmb_UnidadMedida.Text = dgv.Cells[2].Value.ToString();
                txt_descripcionIngrediente.Text = dgv.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            try
            {
                com = new OdbcCommand("update Ingrediente set nombre='" + txt_nombreIngrediente.Text + "', descripcion='" + txt_descripcionIngrediente.Text + "', unidadMedida='" + cmb_UnidadMedida.Text + "' where idIngrediente=" + Convert.ToInt32(this.id_ingrediente) + " ", con.conexion());
                com.ExecuteNonQuery();
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
                com = new OdbcCommand("delete from Ingrediente where idIngrediente=" + Convert.ToInt32(this.id_ingrediente) + " ", con.conexion());
                com.ExecuteNonQuery();
                mostrar_ingrediente();
                txt_nombreIngrediente.Text = "";
                txt_descripcionIngrediente.Text = "";
                cmb_UnidadMedida.Text = "SELECCIONE OPCION";
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }
        }
    }
}
