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
    public partial class Provedor_Menu : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = " + pasar_datos.server + "; Database = " + pasar_datos.BD + "; Uid = " + pasar_datos.user+"; Pwd = "+pasar_datos.pasword+";");
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;
        public Provedor_Menu()
        {
            InitializeComponent();
            provedortabla("");
            provedormarca("");
            MARCA1();
        }
        public  void provedortabla(string dato)
        {
            provedor Pasar = new provedor();
            conexion.Open();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.Comando_Provedor(dato), conexion);

                MySqlDataAdapter reader1 = new MySqlDataAdapter();

                reader1.SelectCommand = select;

                DataTable tabla1 = new DataTable();

                reader1.Fill(tabla1);

                Tabla_producto.DataSource = tabla1;
            }
            catch(Exception  ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        public void provedormarca(string dato)
        {
            provedormarca Pasar1 = new provedormarca();
            conexion.Open();
            try
            {
                MySqlCommand select1 = new MySqlCommand(Pasar1.Comado_Marcas(dato), conexion);

                MySqlDataAdapter reader11 = new MySqlDataAdapter();

                reader11.SelectCommand = select1;

                DataTable tabla11 = new DataTable();

                reader11.Fill(tabla11);

                tabla_registro1.DataSource = tabla11;
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
        private void MARCA1()
        {
            conexion_marca con = new conexion_marca();
            con.Modelo.Open();
            txt_Marca.DataSource = null;
            txt_Marca.Items.Clear();
            string SELECT = "SELECT * FROM marca ;";

            try
            {

                MySqlCommand select1 = new MySqlCommand(SELECT, con.Modelo);

                MySqlDataAdapter reader11 = new MySqlDataAdapter(select1);

                DataTable tabla11 = new DataTable();
                DataRow fila = tabla11.NewRow();
                reader11.Fill(tabla11);
                fila["MARCA"] = "Selecione la marca";
                tabla11.Rows.InsertAt(fila, 0);
                txt_Marca.ValueMember = "id";
                txt_Marca.DisplayMember = "marca";
                txt_Marca.DataSource = tabla11;



            }
            catch (Exception ex)
            {
                MessageBox.Show("Exite un error de tipo: " + ex);
            }

            con.Modelo.Close();

        }
        
        private void Modelo(string iD_MARCA)
        {
            conexion_marca con = new conexion_marca();
            con.Modelo.Open();
            string select = "select*from modelo where id_marca='" + iD_MARCA + "';";
            txt_Modelo.DataSource = null;
            txt_Modelo.Items.Clear();

            try
            {

                MySqlCommand select_mod = new MySqlCommand(select, con.Modelo);
                MySqlDataAdapter reader_mod = new MySqlDataAdapter(select_mod);
                DataTable tabla_mod = new DataTable();
                DataRow fila = tabla_mod.NewRow();
                reader_mod.Fill(tabla_mod);
                fila["Modelo"] = "Selecione el modelo";
                tabla_mod.Rows.InsertAt(fila, 0);
                txt_Modelo.ValueMember = "id";
                txt_Modelo.DisplayMember = "modelo";
                txt_Modelo.DataSource = tabla_mod;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ocuurrio algo");
                MessageBox.Show("" + ex);
            }

            con.Modelo.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Tabla_producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            conexion.Open();
            try
            {
                int codprov = int.Parse(txtcodprovedor1.Text);
                string sql1 = "INSERT INTO provedor_marcas(Marcas_Maneja,MODELOS,Cod_Provedor) VALUES('" + txt_Marca.Text + "','" + txt_Modelo.Text + "','" + codprov + "')";
                MySqlCommand INSERT1 = new MySqlCommand(sql1, conexion);
                INSERT1.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string buscar = textBuscarPro.Text;
            provedortabla(buscar);
        }

        private void Buscar_catalogo_Click(object sender, EventArgs e)
        {
            string buscar = txt_BUSCARMarcas.Text;
            provedormarca(buscar);
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txt_Marca.Text = "";
            txt_Modelo.Text = "";
            txtcodprovedor1.Text = "";
        }

        private void txt_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_Marca.SelectedValue.ToString() != null)
            {
                string id_marca = txt_Marca.SelectedValue.ToString();
                Modelo(id_marca);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string comando1 = "UPDATE provedor_marcas SET Marcas_Maneja='" + txt_Marca.Text + "', MODELOS='" + txt_Modelo.Text + "' WHERE Cod_Provedor='" + txtcodprovedor1.Text + "'";
            conexion.Open();
            
            try
            {
                MySqlCommand UPDATE1 = new MySqlCommand(comando1, conexion);
                UPDATE1.ExecuteNonQuery();
                MessageBox.Show("Se acualizaron los datos");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un errror de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
               
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txt_CodProvedor.Text = "";
            txt_email.Text = "";
            txt_facebook.Text="";
            txt_instagram.Text = "";
            txt_telefono.Text = "";
            txt_nomprovedor.Text = "";
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            conexion.Open();
            try
            {
                int codprov = int.Parse(txt_CodProvedor.Text);
                string sql = "insert into provedor values('" + codprov + "','" + txt_nomprovedor.Text + "','" + txt_instagram.Text + "','" + txt_facebook.Text + "','" + txt_email.Text + "','" + txt_telefono.Text + "')";
                MySqlCommand insert = new MySqlCommand(sql, conexion);
                insert.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            int CodProv = int.Parse(txt_CodProvedor.Text), Num=int.Parse(txt_telefono.Text);
            string comando = "UPDATE provedor SET Nom_Provedor='" + txt_nomprovedor.Text + "', Instagram='" + txt_instagram.Text + "', Facebook='" + txt_facebook.Text + "', email='" + txt_email.Text + "', Telefono='" + Num + "' WHERE Cod_Provedor='" + CodProv + "'";
            conexion.Open();
            try
            {
                MySqlCommand update = new MySqlCommand(comando, conexion);
                update.ExecuteNonQuery();
                MessageBox.Show("Se actualizaron los datos");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un errror de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string SQL = "DELETE FROM provedor where Cod_Provedor='" + txt_EliminarCod.Text + "'";
            string sql1 = "DELETE FROM  provedor_marcas WHERE Cod_Provedor='" + txt_EliminarCod.Text + "'";
            conexion.Open();
            try
            {
                MySqlCommand delete = new MySqlCommand(SQL, conexion);
                MySqlCommand delete1 = new MySqlCommand(sql1, conexion);
                delete1.ExecuteNonQuery();
                delete.ExecuteNonQuery();
                MessageBox.Show("Se eliminaron los datos correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);

            }
            finally
            {
                conexion.Close();
            }
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            pointMD = MousePosition;
            pointFM = this.Location;
            xDelta = pointMD.X - pointFM.X;
            yDelta = pointMD.Y - pointFM.Y;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            Point pointNP = new Point();
            if (arrastrar)
            {
                pointNP.X = MousePosition.X - xDelta;
                pointNP.Y = MousePosition.Y - yDelta;
                this.Location = pointNP;
            }
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            provedortabla("");
            provedormarca("");
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }
    }
}
