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
    public partial class Envio_Menu : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = tienda; Uid = root; Pwd = j3zuzv3;");
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;
        public Envio_Menu()
        {
            InitializeComponent();
            CargartablaEnvio("");
            CargarTablaRastreo("");
            CargartablaProdEnv("");
            Estado();
        }

        void CargartablaEnvio(string dato)
        {
            Enviocmd Pasar = new Enviocmd();
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
        void CargarTablaRastreo(string dato)
        {
            RastreoCmd Pasar = new RastreoCmd();
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
        void CargartablaProdEnv(string dato)
        {
            UsuarioEnvio Pasar = new UsuarioEnvio();
            conexion.Open();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.comando(dato), conexion);
                MySqlDataAdapter reader1 = new MySqlDataAdapter();
                reader1.SelectCommand = select;
                DataTable tabla1 = new DataTable();
                reader1.Fill(tabla1);
                dataGridView2.DataSource = tabla1;
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);
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
            string mysql = "SELECT id_municipio,municipio FROM t_municipio where id_Estado='" + id_Estado + "' order by municipio ";
            txtMunicipio.DataSource = null;
            txtMunicipio.Items.Clear();
            try
            {
                MySqlCommand select1 = new MySqlCommand(mysql, con.CONEXION);
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
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error: " + ex);
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
            string mysql = "SELECT*FROM t_localidad where id_municipio='" + id_municipio + "' order by localidad";
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


        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txt_CodEnvio.Text = "";
            txtEstado.Text = "";
            txtMunicipio.Text = "";
            txtLocalidad.Text = "";
            txtdatosextra.Text = "";
            txt_EnvioCosto.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txt_CodEnvio1.Text = "";
            txt_NumRastre.Text = "";
            txt_ano.Text = "";
            txt_mes.Text = "";
            txt_dia.Text = "";
            txt_hora.Text = "";
            txt_min.Text = "";
            txt_seg.Text = "";
            txt_ano1.Text = "";
            txt_mes1.Text = "";
            txt_dia1.Text = "";
            txt_hora1.Text = "";
            txt_min1.Text = "";
            txt_seg1.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txt_EnviarCod2.Text = "";
            txt_ClienteCod.Text = "";
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            NuevoEnvio add = new NuevoEnvio();
            int cod = int.Parse(txt_CodEnvio.Text);
            float costo = float.Parse(txt_EnvioCosto.Text);
            string dire = "" + txtEstado.Text + ", " + txtMunicipio.Text + ", " + txtLocalidad.Text + ", " + txtdatosextra.Text;
            add.ex1(cod, dire, costo);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NuevoEnvio add = new NuevoEnvio();
            int numras = int.Parse(txt_NumRastre.Text);
            int cod = int.Parse(txt_CodEnvio1.Text);
            string fecha1 = "" + txt_ano.Text + "-" + txt_mes.Text + "-"+txt_dia.Text+" " + txt_hora.Text + ":" + txt_min.Text + ":" + txt_seg.Text;
            string fecha2 = "" + txt_ano1.Text + "-" + txt_mes1.Text + "-"+txt_dia1.Text+" " + txt_hora1.Text + ":" + txt_min1.Text + ":" + txt_seg1.Text;
            add.ex2(numras, cod, fecha1, fecha2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NuevoEnvio add = new NuevoEnvio();
            int cod = int.Parse(txt_EnviarCod2.Text);
            int cod1 = int.Parse(txt_ClienteCod.Text);
            add.ex3(cod1, cod);

        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            ActualizarEnvio update = new ActualizarEnvio();
            int cod = int.Parse(txt_CodEnvio.Text);
            float costo = float.Parse(txt_EnvioCosto.Text);
            string dire = "" + txtEstado.Text + ", " + txtMunicipio.Text + ", " + txtLocalidad.Text + ", " + txtdatosextra.Text;
            update.ex1(cod, dire, costo);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ActualizarEnvio update = new ActualizarEnvio();
            int numras = int.Parse(txt_NumRastre.Text);
            int cod = int.Parse(txt_CodEnvio1.Text);
            string fecha1 = "" + txt_ano.Text + "-" + txt_mes.Text + "-" + txt_dia.Text + " " + txt_hora.Text + ":" + txt_min.Text + ":" + txt_seg.Text;
            string fecha2 = "" + txt_ano1.Text + "-" + txt_mes1.Text + "-" + txt_dia1.Text + " " + txt_hora1.Text + ":" + txt_min1.Text + ":" + txt_seg1.Text;
            update.ex2(numras, cod, fecha1, fecha2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dato = txt_BuscarEnvio.Text;
            CargartablaEnvio(dato);
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            CargartablaEnvio("");
            CargarTablaRastreo("");
            CargartablaProdEnv("");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string dato = txt_BuscarRastreo.Text;
            CargarTablaRastreo(dato);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActualizarEnvio update = new ActualizarEnvio();
            int cod = int.Parse(txt_ClienteCod.Text);
            int cod1 = int.Parse(txt_EnviarCod2.Text);
            update.ex3(cod, cod1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string dato = txt_BuscarProd.Text;
            CargartablaProdEnv(dato);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EliminarEnvio delete = new EliminarEnvio();
            string dato = txt_EliminarCod.Text;
            delete.ex(dato);
        }

        private void txtEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Municipio(txtEstado.SelectedValue.ToString());
        }

        private void txtLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdatosextra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtMunicipio.SelectedValue.ToString()!=null)
                {
                    int id = int.Parse(txtMunicipio.SelectedValue.ToString());
                    Localidad(id);
                }
               
            }
            catch
            {

            }
        }

        private void talla_Click(object sender, EventArgs e)
        {

        }

        private void txt_dia_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            pointMD = MousePosition;
            pointFM = this.Location;
            xDelta = pointMD.X - pointFM.X;
            yDelta = pointMD.Y - pointFM.Y;
        }

        private void panel4_MouseMove(object sender, MouseEventArgs e)
        {
            Point pointNP = new Point();
            if (arrastrar)
            {
                pointNP.X = MousePosition.X - xDelta;
                pointNP.Y = MousePosition.Y - yDelta;
                this.Location = pointNP;
            }
        }

        private void panel4_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }
    }
    class NuevoEnvio:Conexion
    {
        string cm1(int codenvio,string dire, float costo) => "INSERT INTO ENVIO VALUES('"+codenvio+"','"+dire+"','"+costo+"')";
        public void ex1(int codenvio, string dire, float costo)
        {
            conexion.Open();
            try
            {
                if (costo < 90)
                {
                    throw new ArgumentOutOfRangeException("Los envios no pueden costar menos de 90 pesos");
                }
                MySqlCommand cmd = new MySqlCommand(cm1(codenvio, dire, costo), conexion);
                cmd.ExecuteNonQuery();
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
        string cm2(int numras,int codenvio, string fs, string fll) => "INSERT INTO RASTREO VALUES('"+numras+"','" + codenvio + "','" + fs + "','" + fll + "')";
        public void ex2(int numras,int codenvio, string fs, string fll)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cm2(numras,codenvio, fs, fll), conexion);
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
        string cm3(int codcleinte, int codenvio) => "INSERT INTO ENVIO_USUARIO(Cod_Cliente,Num_Envio)VALUES('" + codcleinte + "','" + codenvio + "')";
        public void ex3(int codcleinte, int codenvio)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cm3(codcleinte, codenvio), conexion);
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
    class ActualizarEnvio:Conexion
    {
        string cm1(int codenvio, string dire, float costo) => "UPDATE ENVIO SET Direccion_Envio='" + dire + "', COSTO='" + costo + "' WHERE NUM_ENVIO='" + codenvio + "'";
        public void ex1(int codenvio, string dire, float costo)
        {
            conexion.Open();
            try
            {
                if (costo < 90)
                {
                    throw new ArgumentOutOfRangeException("Los envios no pueden costar menos de 90 pesos");
                }
                MySqlCommand cmd = new MySqlCommand(cm1(codenvio, dire, costo), conexion);
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
        string cm2(int numras, int codenvio, string fs, string fll) => "UPDATE  RASTREO SET Num_Envio='" + codenvio + "', FECHA_SAL='" + fs + "', FECHA_LLEGADA='" + fll + "' WHERE  NUM_RASTRO='" + numras + "'";
        public void ex2(int numras, int codenvio, string fs, string fll)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cm2(numras, codenvio, fs, fll), conexion);
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
        string cm3(int codcleinte, int codenvio) => "UPDATE ENVIO_USUARIO SET Num_Envio='" + codenvio + "' WHERE  Cod_Cliente='" + codcleinte + "'";
        public void ex3(int codcleinte, int codenvio)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cm3(codcleinte, codenvio), conexion);
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
    class EliminarEnvio:Conexion
    {
        string cm1(string cod) => "DELETE FROM ENVIO WHERE  Num_Envio='" + cod+"'";
        string cm2(string cod) => "DELETE FROM RASTREO WHERE  Num_Envio='" + cod + "'";
        string cm3(string cod) => "DELETE FROM envio_usuario WHERE  Num_Envio='" + cod + "'";
        public void ex(string cod)
        {
            conexion.Open();
            try
            {
                MySqlCommand delete = new MySqlCommand(cm1(cod), conexion);
                MySqlCommand delete1 = new MySqlCommand(cm2(cod), conexion);
                MySqlCommand delete2 = new MySqlCommand(cm3(cod), conexion);
                delete2.ExecuteNonQuery();
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
    }
}
