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
   
    public partial class Tienda_menu : Form
    {

        MySqlConnection  conexion = new MySqlConnection("Server = " + pasar_datos.server + "; Database = " + pasar_datos.BD + "; Uid = " + pasar_datos.user + "; Pwd = " + pasar_datos.pasword + ";");
        MySqlCommand select = new MySqlCommand();
        MySqlDataAdapter reader = new MySqlDataAdapter();
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;

        public int codigo;
        
        public Tienda_menu()
        {
            
            InitializeComponent();
           cargartabla("");
            cargarContacto("");
        }
        public void cargartabla(string dato)
        {
            
            busqueda_tienda Pasar = new busqueda_tienda();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.Busqueda_tienda(dato), conexion);

                MySqlDataAdapter reader1 = new MySqlDataAdapter();

                reader1.SelectCommand = select;

                DataTable tabla1 = new DataTable();

                reader1.Fill(tabla1);

                Tabla_registro.DataSource = tabla1;

            }
            catch (MySqlException ex)
            {
                if(dato!= "")
                {
                    MessageBox.Show("Ocurrio una exepcion de tipo: " + ex);
                }
                
            }
            finally
            {
                conexion.Close();
            }
        }
        public void cargarContacto(string dato)
        {
           
            tienda_contacto1 Pasar = new tienda_contacto1();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.Busqueda_tienda_con(dato), conexion);

                MySqlDataAdapter reader1 = new MySqlDataAdapter();

                reader1.SelectCommand = select;

                DataTable tabla1 = new DataTable();

                reader1.Fill(tabla1);

                tabla_registro1.DataSource = tabla1;

            }
            catch (MySqlException ex)
            {
                if (dato != "")
                {
                    MessageBox.Show("Ocurrio una exepcion de tipo: " + ex);
                }

            }
            finally
            {
                conexion.Close();
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ingresar_tienda(ref codigo);
            ingresar_tienda1();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Tabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mostrar = $"select Cod_tienda,Nom_Tienda,Direccion_Tienda from tienda";
            
            conexion.Open();
             select = new MySqlCommand(mostrar, conexion);
           
            reader.SelectCommand = select;
            DataTable tabla = new DataTable();
            reader.Fill(tabla);
            Tabla_registro.DataSource = tabla;

            conexion.Close();
            mostrar1();
        }
        public void mostrar()
        {
            string mostrar = $"select Cod_tienda,Nom_Tienda,Direccion_Tienda from tienda";
            conexion.Open();
            select = new MySqlCommand(mostrar, conexion);
            reader.SelectCommand = select;
            DataTable tabla = new DataTable();
            reader.Fill(tabla);
            Tabla_registro.DataSource = tabla;

            conexion.Close();
        }
        public void mostrar1()
        {
            string mostrar1 = $"select Cod_tienda,Instagram,Facebook,email,Telefono from tienda_contacto";
            conexion.Open();
            MySqlCommand select1 = new MySqlCommand(mostrar1, conexion);
            MySqlDataAdapter reader1 = new MySqlDataAdapter();
            reader1.SelectCommand = select1;
            DataTable tabla1 = new DataTable();
            reader1.Fill(tabla1);
            tabla_registro1.DataSource = tabla1;

            
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string update2= "UPDATE TIENDA_CONTACTO SET   Instagram='" + Instagram_Tienda.Text + "',Facebook='" + Facebook_Tienda.Text + "',email='" + correo_tienda.Text + "',Telefono='" + telefono_tienda.Text + "' WHERE COD_TIENDA='" + textBox1.Text + "';";
            string update1 = "UPDATE TIENDA SET   Nom_Tienda='" + textBox2.Text + "',Direccion_Tienda='" + textBox3.Text + "' WHERE COD_TIENDA='" + textBox1.Text + "';";
            try
            {
                conexion.Open();
                MySqlCommand update = new MySqlCommand(update1, conexion);
                MySqlCommand update3 = new MySqlCommand(update2, conexion);
                update3.ExecuteNonQuery();
                update.ExecuteNonQuery();
                MessageBox.Show("Se actualizo correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hubo un error de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }

        private void tabla_registro1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dato = textBox4.Text;
            cargartabla(dato);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string Borrar = "DELETE FROM TIENDA WHERE Cod_tienda='" + txt_Eliminar.Text + "';";
            //Creo comandos de MYSQL
            string Borrar1 = "DELETE FROM TIENDA_CONTACTO WHERE Cod_tienda='" + txt_Eliminar.Text + "';";

            try
            {
                MySqlCommand DELATE1 = new MySqlCommand(Borrar1, conexion);
                // AGO UN COMANDO
                DELATE1.ExecuteNonQuery();
                // EXECUTO EL COMANDO
                MySqlCommand DELATE = new MySqlCommand(Borrar, conexion);
                //OTRO COMANDO
                DELATE.ExecuteNonQuery();
                //EJECUTO EL COMADO
                MessageBox.Show("se ha borrado exitosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio una exepcion de tipo: " + ex);
            }
            finally
            {
                conexion.Close();

            }
        }
        private void ingresar_tienda(ref int codigo)
        {
            codigo = int.Parse(textBox1.Text);
            string nombre = textBox2.Text;
            string direccion = textBox3.Text;
            conexion.Open();

            string SQL = $" INSERT INTO TIENDA(Cod_tienda,Nom_Tienda,Direccion_Tienda) VALUES ('" + codigo + "','" + nombre + "','" + direccion + "'); ";
            try
            {
                MySqlCommand agregar = new MySqlCommand(SQL, conexion);
                agregar.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos corectamente");

            }
            catch (Exception EX)
            {
                MessageBox.Show("Ocurrio un erro de tipo: " + EX);
            }

            conexion.Close();
        }
        private void ingresar_tienda1()
        {

            int telefono = int.Parse(telefono_tienda.Text);
            string instagram = Instagram_Tienda.Text;
            string facebbok = Facebook_Tienda.Text;
            string correo = correo_tienda.Text;

            conexion.Open();

            string SQL = $" INSERT INTO TIENDA_CONTACTO VALUES ('" + codigo + "','" + instagram + "','" + facebbok + "','" + correo + "','" + telefono + "'); ";
            try
            {
                MySqlCommand agregar = new MySqlCommand(SQL, conexion);
                agregar.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos corectamente");

            }
            catch (Exception EX)
            {
                MessageBox.Show("Ocurrio un erro de tipo: " + EX);
            }
            conexion.Close();
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            telefono_tienda.Text = "";
            Instagram_Tienda.Text="";
            Facebook_Tienda.Text = "";
            correo_tienda.Text = "";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tablaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void data_busca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Buscar_contacto_Click(object sender, EventArgs e)
        {
            string dato = txt_Contacto.Text;
            cargarContacto(dato);
        }

        private void txt_Contacto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Eliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            pointMD = MousePosition;
            pointFM = this.Location;
            xDelta = pointMD.X - pointFM.X;
            yDelta = pointMD.Y - pointFM.Y;
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

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

    }
}
