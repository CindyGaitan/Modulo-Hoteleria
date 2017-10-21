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
    public partial class AsignacionReceta : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();
        string ingrediente, receta, pesoCantidad;

        public AsignacionReceta()
        {
            InitializeComponent();
            mostrar_Asignacion();
            llenar_ingrediente();
            llenar_receta();
            cmb_receta.Text = "SELECCIONE OPCION";
            cmb_ingrediente.Text = "SELECCIONE OPCION";
        }

        public void mostrar_Asignacion()
        {
            try
            {
                da = new OdbcDataAdapter("select  R.nombre as Receta, I.nombre as Ingrediente, D.pesoOcantidad Peso_Cantidad, I.unidadMedida as Unidad_Medida from detallerecetaingrediente D inner join ingrediente I on D.ingrediente_idIngrediente=I.idIngrediente inner join Receta R on D.receta_idReceta = R.idReceta; ", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_asignacion.DataSource = dt;
                dgv_asignacion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        public void llenar_unidad()
        {
            try
            {
                com = new OdbcCommand("select unidadMedida from Ingrediente where nombre='"+cmb_ingrediente.Text+"' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    lbl_Medida.Text=(dr["unidadMedida"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        public void llenar_receta()
        {
            try
            {
                com = new OdbcCommand("select Nombre from Receta", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_receta.Items.Add(dr["Nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        public void llenar_ingrediente()
        {
            try
            {
                com = new OdbcCommand("select nombre from ingrediente", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_ingrediente.Items.Add(dr["nombre"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_ingrediente; int id_ing = 0;
                com = new OdbcCommand("select idIngrediente from Ingrediente where nombre ='" + cmb_ingrediente.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_ingrediente = dr["idIngrediente"].ToString();
                    id_ing = Convert.ToInt32(id_ingrediente);
                }
                dr.Close();

                string id_receta; int id_rec = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" + cmb_receta.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta = dr["idReceta"].ToString();
                    id_rec = Convert.ToInt32(id_receta);
                }
                dr.Close();

                com = new OdbcCommand("insert into detalleRecetaIngrediente (ingrediente_idIngrediente, receta_idReceta, pesoOcantidad) values ("+id_ing+","+id_rec+",'"+txt_cantidad.Text+"')", con.conexion());
                com.ExecuteNonQuery();
                txt_cantidad.Text = "";
                cmb_ingrediente.Text = "SELECCIONE OPCION";
                cmb_receta.Text = "SELECCIONE OPCION";
                mostrar_Asignacion();
                MessageBox.Show("Datos ingresados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información." + ex.ToString());
            }
        }

        private void cmb_ingrediente_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenar_unidad();
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                string id_ingrediente; int id_ing = 0;
                com = new OdbcCommand("select idIngrediente from Ingrediente where nombre ='" + this.ingrediente + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_ingrediente = dr["idIngrediente"].ToString();
                    id_ing = Convert.ToInt32(id_ingrediente);
                }
                dr.Close();

                string id_receta; int id_rec = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" + this.receta + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta = dr["idReceta"].ToString();
                    id_rec = Convert.ToInt32(id_receta);
                }
                dr.Close();

                com = new OdbcCommand("delete from detalleRecetaIngrediente where ingrediente_idIngrediente=" +id_ing+ " and receta_idReceta="+id_rec+" ", con.conexion());
                com.ExecuteNonQuery();
                txt_cantidad.Text = "";
                cmb_ingrediente.Text = "SELECCIONE OPCION";
                cmb_receta.Text = "SELECCIONE OPCION";
                mostrar_Asignacion();
                MessageBox.Show("Datos eliminados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO eliminados, verifique la información. " + ex.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow dgv = dgv_asignacion.Rows[e.RowIndex];
                cmb_receta.Text = dgv.Cells[0].Value.ToString();
                receta = dgv.Cells[0].Value.ToString();
                cmb_ingrediente.Text = dgv.Cells[1].Value.ToString();
                ingrediente = dgv.Cells[1].Value.ToString();
                txt_cantidad.Text = dgv.Cells[2].Value.ToString();
                pesoCantidad = dgv.Cells[2].Value.ToString();
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
                string id_ingrediente; int id_ing = 0;
                com = new OdbcCommand("select idIngrediente from Ingrediente where nombre ='" + cmb_ingrediente.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_ingrediente = dr["idIngrediente"].ToString();
                    id_ing = Convert.ToInt32(id_ingrediente);
                }
                dr.Close();

                string id_ingrediente2; int id_ing2 = 0;
                com = new OdbcCommand("select idIngrediente from Ingrediente where nombre ='" + this.ingrediente + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_ingrediente2 = dr["idIngrediente"].ToString();
                    id_ing2 = Convert.ToInt32(id_ingrediente2);
                }
                dr.Close();

                string id_receta; int id_rec = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" + cmb_receta.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta = dr["idReceta"].ToString();
                    id_rec = Convert.ToInt32(id_receta);
                }
                dr.Close();

                string id_receta2; int id_rec2 = 0;
                com = new OdbcCommand("select idReceta from Receta where Nombre ='" + this.receta + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    id_receta2 = dr["idReceta"].ToString();
                    id_rec2 = Convert.ToInt32(id_receta2);
                }
                dr.Close();

                com = new OdbcCommand("update detalleRecetaIngrediente set ingrediente_idIngrediente=" + id_ing + ", receta_idReceta="+id_rec+", pesoOcantidad='"+txt_cantidad.Text+"' where ingrediente_idIngrediente="+id_ing2+" and receta_idReceta="+id_rec2+" ", con.conexion());
                com.ExecuteNonQuery();
                txt_cantidad.Text = "";
                cmb_ingrediente.Text = "SELECCIONE OPCION";
                cmb_receta.Text = "SELECCIONE OPCION";
                mostrar_Asignacion();
                MessageBox.Show("Datos actualizados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO actualizados, verifique la información. " + ex.ToString());
            }
        }
    }
}
