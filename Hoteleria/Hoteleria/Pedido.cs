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
    public partial class Pedido : Form
    {
        OdbcCommand com;
        OdbcDataAdapter da;
        DataTable dt;
        OdbcDataReader dr;
        Conexion con = new Conexion();

        public Pedido()
        {
            InitializeComponent();
            mostrar_pedido();
            llendao_mesa();
            llenado_platillo();
            llenado_cliente();
            llenado_bebida();
            cmb_bebida.Text = "SELECCIONE OPCION";
            cmb_cliente.Text = "SELECCIONE OPCION";
            cmb_mesa.Text = "SELECCIONE OPCION";
            cmb_platillo.Text = "SELECCIONE OPCION";
        }

        public void mostrar_pedido()
        {
            try
            {
                da = new OdbcDataAdapter("select P.idPedido as No, P.fechaPedido as Fecha, M.noMesa as Mesa, C.idCliente as Cliente, Pl.nombrePlatillo as Platillo, DPP.cantidadPlatillo as Cantidad_Platillo, B.nombreBebida as Bebida, DPB.cantidadBebida as Cantidad_Bebida from pedido P inner join detallepedidoplatillo DPP on P.idPedido=DPP.pedido_idPedido inner join detallepedidobebida DPB on P.idPedido = DPB.pedido_idPedido inner join mesa M on P.mesa_idMesa = M.idMesa inner join Cliente C on P.cliente_idCliente = C.idCliente inner join Bebida B on B.idBebida = DPB.bebida_idBebida inner join platillo PL on PL.idPlatillo = DPP.pedido_idPedido", con.conexion());
                dt = new DataTable();
                da.Fill(dt);
                dgv_pedido.DataSource = dt;
                dgv_pedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR");
            }
        }

        public void llendao_mesa()
        {
            try
            {
                com = new OdbcCommand("select noMesa from Mesa", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_mesa.Items.Add(dr["noMesa"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        public void llenado_cliente()
        {
            try
            {
                com = new OdbcCommand("select nombreCliente from Cliente", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_cliente.Items.Add(dr["nombreCliente"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        public void llenado_platillo()
        {
            try
            {
                com = new OdbcCommand("select nombrePlatillo from Platillo", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_platillo.Items.Add(dr["nombrePlatillo"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        public void llenado_bebida()
        {
            try
            {
                com = new OdbcCommand("select nombreBebida from Bebida", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cmb_bebida.Items.Add(dr["nombreBebida"].ToString());
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void dgv_pedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {   //MESA
                string mesa; int id_mesa = 0;
                com = new OdbcCommand("select noMesa from Mesa where noMesa ='" + cmb_mesa.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    mesa = dr["noMesa"].ToString();
                    id_mesa = Convert.ToInt32(mesa);
                }
                dr.Close();
                
                //Cliente
                string cliente; int id_cliente = 0;
                com = new OdbcCommand("select idCliente from cliente where nombreCliente ='" + cmb_cliente.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    cliente = dr["idCliente"].ToString();
                    id_cliente = Convert.ToInt32(cliente);
                }
                dr.Close();

                //Platillo
                string platillo; int id_platillo = 0;
                com = new OdbcCommand("select idPlatillo from Platillo where nombrePlatillo ='" + cmb_platillo.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    platillo = dr["idPlatillo"].ToString();
                    id_platillo = Convert.ToInt32(platillo);
                }
                dr.Close();

                //Bebida
                string bebida; int id_bebida = 0;
                com = new OdbcCommand("select idBebida from Bebida where nombreBebida ='" + cmb_bebida.Text + "' ", con.conexion());
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    bebida = dr["idBebida"].ToString();
                    id_bebida = Convert.ToInt32(bebida);
                }
                dr.Close();
               
                //INGRESO PEDIDO
                com = new OdbcCommand("insert into Pedido (fechaPedido, mesa_idMesa, cliente_idCliente) values ('" + dtp_fecha.Value.ToString("d/M/yyyy") + "'," + id_mesa + "," + id_cliente + ")", con.conexion());
                com.ExecuteNonQuery();

                //PEDIDO
                string pedido; int id_pedido = 0;
                com = new OdbcCommand("select max(idPedido) from pedido", con.conexion());
                pedido=com.ExecuteScalar().ToString();
                id_pedido = Convert.ToInt32(pedido);
                

                if (id_pedido == 0)
                {
                    id_pedido = 1;
                }

                //INGRESO DETALLE_PEDIDO_PLATILLO
                com = new OdbcCommand("insert into detallepedidoplatillo (cantidadPlatillo, pedido_idPedido, pedido_idPlatillo) values ("+txt_cantPlatillo.Text+","+id_pedido+","+id_platillo+")", con.conexion());
                com.ExecuteNonQuery();

                //INGRESO DETALLE_PEDIDO_BEBIDA
                com = new OdbcCommand("insert into detallepedidobebida (cantidadbebida, pedido_idPedido, bebida_idBebida) values (" + txt_cantBebida.Text + "," + id_pedido + "," + id_bebida + ")", con.conexion());
                com.ExecuteNonQuery();

                mostrar_pedido();
                llendao_mesa();
                llenado_platillo();
                llenado_cliente();
                llenado_bebida();
                cmb_bebida.Text = "SELECCIONE OPCION";
                cmb_cliente.Text = "SELECCIONE OPCION";
                cmb_mesa.Text = "SELECCIONE OPCION";
                cmb_platillo.Text = "SELECCIONE OPCION";
                txt_cantBebida.Text = "";
                txt_cantPlatillo.Text = "";
                MessageBox.Show("Datos ingresados. ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Datos NO ingresados, verifique la información." + ex.ToString());
            }
        }
    }
}
