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
    public partial class Cliente_Menu : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = " + pasar_datos.server + "; Database = " + pasar_datos.BD + "; Uid = " + pasar_datos.user + "; Pwd = j" + pasar_datos.pasword + ";");
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;
        public Cliente_Menu()
        {
            InitializeComponent();
            CargarTablaCliente("");
            Estado();
        }
        public void CargarTablaCliente(string dato)
        {
            Clientecmd Pasar = new Clientecmd();
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
        public void Estado()
        {
            CONEXION_ESTADOS con = new CONEXION_ESTADOS();
            con.CONEXION.Open();
            string mysql = "SELECT*from t_estado order by estado";
            txtEstado.DataSource = null;
            txtEstado.Items.Clear();
            try
            {
                MySqlCommand select = new MySqlCommand(mysql, con.CONEXION);
                MySqlDataAdapter reader = new MySqlDataAdapter(select);
                DataTable tabla = new DataTable();
                DataRow FILA = tabla.NewRow();
                reader.Fill(tabla);
                FILA["estado"] = "Seleccione un estado";
                tabla.Rows.InsertAt(FILA, 0);
                txtEstado.ValueMember = "id_estado";
                txtEstado.DisplayMember = "estado";
                txtEstado.DataSource = tabla;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: "+ex);
            }
            finally
            {
                con.CONEXION.Close();
            }

        }
        public void Municipio(string id_Estado)
        {
            CONEXION_ESTADOS con = new CONEXION_ESTADOS();
            con.CONEXION.Open();
            string mysql = "SELECT id_municipio,municipio FROM t_municipio where id_Estado='" + id_Estado+ "' order by municipio ";
            txtMunicipio.DataSource = null;
            txtMunicipio.Items.Clear();
            try
            {
                MySqlCommand select1 = new MySqlCommand(mysql,con.CONEXION);
                MySqlDataAdapter reader = new MySqlDataAdapter(select1);
                DataTable tabla = new DataTable();
                DataRow fila = tabla.NewRow();
                reader.Fill(tabla);
                fila["municipio"] = "Seleccione un Municipio";
                tabla.Rows.InsertAt(fila, 0);
                txtMunicipio.ValueMember = "id_municipio";
                txtMunicipio.DisplayMember = "municipio";
                txtMunicipio.DataSource = tabla;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un error: "+ex);
            }
            finally
            {
                con.CONEXION.Close();
            }
        }
        public void Localidad(int id_municipio)
        {
            CONEXION_ESTADOS con = new CONEXION_ESTADOS();
            con.CONEXION.Open();
            string mysql = "SELECT*FROM t_localidad where id_municipio='" + id_municipio+ "' order by localidad";
            txtLocalidad.DataSource = null;
            txtLocalidad.Items.Clear();
            try
            {
                MySqlCommand select1 = new MySqlCommand(mysql, con.CONEXION);
                MySqlDataAdapter reader = new MySqlDataAdapter(select1);
                DataTable tabla = new DataTable();
                DataRow fila = tabla.NewRow();
                reader.Fill(tabla);
                fila["localidad"] = "Seleccione una localidad";
                tabla.Rows.InsertAt(fila, 0);
                txtLocalidad.ValueMember = "id_localidad";
                txtLocalidad.DisplayMember = "localidad";
                txtLocalidad.DataSource = tabla;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex);
            }
            finally
            {
                con.CONEXION.Close();
            }
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txtdatosExtra.Text = "";
            txtEstado.Text = "";
            txtLocalidad.Text = "";
            txtMunicipio.Text = "";
            txt_ApellidoCliente.Text = "";
            txt_CodCliente.Text = "";
            txt_NomCliente.Text = "";
            txt_TelefonoCliente.Text = "";
            txt_EmailCliente.Text = "";
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            AgregarCliente add = new AgregarCliente();
            int Codcliente = int.Parse(txt_CodCliente.Text);
            string dire = "" + txtEstado.Text + ", " + txtMunicipio.Text + ", " + txtLocalidad.Text + ", " + txtdatosExtra.Text;
            add.ex1(Codcliente,txt_NomCliente.Text,txt_ApellidoCliente.Text, txt_EmailCliente.Text,txt_TelefonoCliente.Text,dire);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int Cod = int.Parse(txt_EliminarCod.Text);
            EliminarCliente add = new EliminarCliente();
            add.ex1(Cod);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = txt_BuscarAlmacen.Text;
            CargarTablaCliente(dato);
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            ActualizarCliente update = new ActualizarCliente();
            int Codcliente = int.Parse(txt_CodCliente.Text);
            string dire = "" + txtEstado.Text + ", " + txtMunicipio.Text + ", " + txtLocalidad.Text + ", " + txtdatosExtra.Text;
            update.ex1(Codcliente, txt_NomCliente.Text, txt_ApellidoCliente.Text, txt_EmailCliente.Text, txt_TelefonoCliente.Text, dire);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            CargarTablaCliente("");
        }

        private void actualizar_Click_1(object sender, EventArgs e)
        {
            CargarTablaCliente("");
        }



        private void txtEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Municipio(txtEstado.SelectedValue.ToString());
        }
        private void txtMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMunicipio.SelectedValue.ToString() != null)
                {
                    int id = int.Parse(txtMunicipio.SelectedValue.ToString());
                    Localidad(id);
                }
            }
            catch
            {

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

        private void Tabla_Almacen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }
    }
    class AgregarCliente:Conexion
    {
        private string cm1(int CodCliente, string nombre, string apellido, string email, string telefono, string dire) => "INSERT INTO cliente VALUES('" + CodCliente + "','" + nombre + "','" + apellido + "','" + email + "','" + telefono + "','" + dire + "')";
        public void ex1(int CodCliente, string nombre, string apellido, string email, string telefono, string dire)
        {
            conexion.Open();

            try
            {
                MySqlCommand insert = new MySqlCommand(cm1(CodCliente, nombre, apellido, email, telefono, dire),conexion);
                insert.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrio un erro de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
    class EliminarCliente : Conexion
    {
        private string cm1(int CodCliente) => "DELETE FROM CLIENTE WHERE Cod_Cliente='" + CodCliente + "'";
        public void ex1(int CodCliente)
        {
            conexion.Open();

            try
            {
                MySqlCommand insert = new MySqlCommand(cm1(CodCliente), conexion);
                insert.ExecuteNonQuery();
                MessageBox.Show("Se eliminaron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un erro de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
    }
    class ActualizarCliente:Conexion
    {
        private string cm1(int CodCliente, string nombre, string apellido, string email, string telefono, string dire) => "update cliente set nombre='" + nombre + "',  apellido='" + apellido + "', email='" + email + "', telefono='" + telefono + "', direccion='" + dire + "' WHERE Cod_Cliente='"+CodCliente+"'";
        public void ex1(int CodCliente, string nombre, string apellido, string email, string telefono, string dire)
        {
            conexion.Open();

            try
            {
                MySqlCommand insert = new MySqlCommand(cm1(CodCliente, nombre, apellido, email, telefono, dire), conexion);
                insert.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un erro de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }

    }

}
