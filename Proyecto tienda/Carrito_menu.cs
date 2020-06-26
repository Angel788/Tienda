using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_tienda
{
    public partial class Carrito_menu : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = tienda; Uid = root; Pwd = j3zuzv3;");
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;
        public Carrito_menu()
        {
            InitializeComponent();
            CargarTabla("");
            CargarTabla2("");
        }
        public void CargarTabla(string dato)
        {
            CarritoRelacion Pasar =new CarritoRelacion();
            conexion.Open();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.comando(dato), conexion);
                MySqlDataAdapter reader1 = new MySqlDataAdapter();
                reader1.SelectCommand = select;
                DataTable tabla1 = new DataTable();
                reader1.Fill(tabla1);
                Tabla_Almacen.DataSource = tabla1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocurrio una exepcion de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void CargarTabla2(string dato)
        {
            CarritoBusqueda Pasar = new CarritoBusqueda();
            conexion.Open();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.comando(dato), conexion);
                MySqlDataAdapter reader1 = new MySqlDataAdapter();
                reader1.SelectCommand = select;
                DataTable tabla1 = new DataTable();
                reader1.Fill(tabla1);
                dataGridView1.DataSource = tabla1;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Ocurrio una exepcion de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        public int verificarinformacion(string dato)
        {
            string cmd = "SELECT Stock_PROD FROM almacen_stock WHERE Cod_Producto=" + dato + "";
            conexion.Open();
            int regresar=0;
            try
            {
                MySqlCommand select = new MySqlCommand(cmd, conexion);

                regresar = Convert.ToInt32(select.ExecuteScalar());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Herro de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
            
            return regresar;
        }


        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txt_CodVenta.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_CodVenta1.Text = "";
            txt_CodCliente.Text = "";
            txt_CodEnvio.Text = "";
            txt_CodProd.Text = "";
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            NuevoCarrito add = new NuevoCarrito();
            int cod = int.Parse(txt_CodVenta.Text);
            add.ex1(cod);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NuevoCarrito add = new NuevoCarrito();
            try
            {
                if (verificarinformacion(txt_CodProd.Text)==0)
                {
                    throw new ArgumentException("No exiten unidades del producto seleccionado Porfavor ingrese los datos  en la tabla almacen_stock");
                }
                else
                {
                    if(verificarinformacion(txt_CodProd.Text)>0)
                    {
                        int codVCenta = int.Parse(txt_CodVenta1.Text), CodCliente = int.Parse(txt_CodCliente.Text), CodProducto = int.Parse(txt_CodProd.Text), CodEnvio = int.Parse(txt_CodEnvio.Text), codcat = int.Parse(TXTIDCATALOGO.Text);
                        add.ex2(codcat, codVCenta, CodCliente, CodProducto, CodEnvio);
                    }
                    else
                    {
                        MessageBox.Show("Porfavor agrege el producto a el producto a el stack en la tabla almacen_stock");
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo :" + ex);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarCarrito delete = new EliminarCarrito();
            int Cod = int.Parse(txt_EliminarCod.Text);
            delete.ex1(Cod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = txt_BuscarCarrito.Text;
            CargarTabla(dato);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            CargarTabla("");
            CargarTabla2("");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            string dato = txt_BUSCARRELACION.Text;
            CargarTabla2(dato);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModificarCarrito UPDATE = new ModificarCarrito();
            int IDCATALOGO = int.Parse(TXTIDCATALOGO.Text), IDNUMVENTA = int.Parse(txt_CodVenta1.Text), CODprod = int.Parse(txt_CodProd.Text), CODCLIENTE = int.Parse(txt_CodCliente.Text),codenvio=int.Parse(txt_CodEnvio.Text);
            UPDATE.ex1(IDCATALOGO, IDNUMVENTA, CODCLIENTE, CODprod, codenvio);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            pointMD = MousePosition;
            pointFM = this.Location;
            xDelta = pointMD.X - pointFM.X;
            yDelta = pointMD.Y - pointFM.Y;
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            Point pointNP = new Point();
            if (arrastrar)
            {
                pointNP.X = MousePosition.X - xDelta;
                pointNP.Y = MousePosition.Y - yDelta;
                this.Location = pointNP;
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }
    }
    class NuevoCarrito:Conexion
    {
        private string cm1(int cod) => "INSERT INTO CARRITO VALUES('"+cod+"')";
        public void ex1(int cod)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cm1(cod), conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private string cm2(int idcat,int numventa, int codcliente, int codProd, int numenvio) => "INSERT INTO carrito_relacion(Num_Venta,ID_catalogo,Cod_Cliente,Cod_Producto,Num_Envio) VALUES('" + numventa + "','"+idcat+"','" + codcliente + "','" + codProd + "','" + numenvio + "')";
        public void ex2(int idcat, int numventa, int codcliente, int codProd, int numenvio)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cm2(idcat,numventa,codcliente,codProd,numenvio), conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }

    }
    class ModificarCarrito:Conexion
    {
        private string cm1(int IDcatalogo, int numventa, int codcliente, int codProd, int numenvio) => "UPDATE carrito_relacion SET ID_catalogo='"+IDcatalogo+"' Cod_Cliente='" + codcliente + "', Cod_Producto='" + codProd + "', Num_Envio='" + numenvio + "' WHERE Num_Venta='" + numventa + "'";
        public void ex1(int IDcatalogo, int numventa, int codcliente, int codProd, int numenvio)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cm1(IDcatalogo,numventa, codcliente, codProd, numenvio), conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actualizaron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
    class EliminarCarrito : Conexion
    {
        private string cm1(int numventa) => "DELETE FROM carrito_relacion WHERE Num_Venta='" + numventa + "'";
        private string cm2(int numventa) => "DELETE FROM CARRITO WHERE Num_Venta='" + numventa + "'";
        public void ex1(int numventa)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cm1(numventa), conexion);
                MySqlCommand cmd1 = new MySqlCommand(cm2(numventa), conexion);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Se actualizaron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
