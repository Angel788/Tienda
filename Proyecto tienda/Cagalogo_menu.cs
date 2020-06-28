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
using System.IO;
using System.Drawing.Imaging;

namespace Proyecto_tienda
{
    public partial class Cagalogo_menu : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = tienda; Uid = root; Pwd = j3zuzv3;");
        MySqlConnection MARCA = new MySqlConnection("Server = localhost; Database = marca; Uid = root; Pwd = j3zuzv3;");
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;
        private Boolean activo;

        public Cagalogo_menu()
        {
            InitializeComponent();
            busqueda_Producto("");
            MARCA1();
            busqueda_Catalogo("");
            
        }
        public void busqueda_Producto(string dato)
        {
            pruducto_1 Pasar = new pruducto_1();
            conexion.Open();
            try
            {
                
                MySqlCommand select = new MySqlCommand(Pasar.Busqueda_tienda(dato), conexion);

                MySqlDataAdapter reader1 = new MySqlDataAdapter();

                reader1.SelectCommand = select;

                DataTable tabla1 = new DataTable();

                reader1.Fill(tabla1);

                Tabla_producto.DataSource = tabla1;

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
        public void busqueda_Catalogo(string dato)
        {
            catalogo Pasar = new catalogo(); 
            conexion.Open();
            try
            {

                MySqlCommand select = new MySqlCommand(Pasar.Comando_Catalogo(dato), conexion);

                MySqlDataAdapter reader1 = new MySqlDataAdapter();

                reader1.SelectCommand = select;

                DataTable tabla1 = new DataTable();

                reader1.Fill(tabla1);

                tabla_registro1.DataSource = tabla1;

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
        

        private void Tabla_registro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dato = textBox4.Text;
            busqueda_Producto(dato);
        }

      
        

        private void txt_Marca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txt_Marca.SelectedValue.ToString() != null)
            {
                string id_marca = txt_Marca.SelectedValue.ToString();
                Modelo(id_marca);
            }

        }

        private void txt_Modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

        private void limpiar_Click(object sender, EventArgs e)
        {
            txt_CodProducto1.Text = "";
            txt_categoria.Text = "";
            txt_color.Text = "";
            txt_material.Text = "";
            txt_talla.Text = "";
            txt_precio.Text = "";
        }
        
        public void agregarprod()
        {
            int codProd = int.Parse(txt_CodProducto.Text);
            string mysql = "insert into PRODUCTO values ('" + codProd + "','" + txt_Modelo.Text + "','" + txt_serie.Text + "','" + txt_Marca.Text + "');";
            conexion.Open();
            try
            {
                MySqlCommand insertvalues = new MySqlCommand(mysql, conexion);
                insertvalues.ExecuteNonQuery();
                MessageBox.Show("Se agrego corectamente");
            }
            catch (Exception ex)
            {
                string marca = txt_Marca.Text;
                
                /*if (txt_Marca.Text == "Selecione la marca" || txt_Modelo.Text== "Selecione el modelo")
                {
                    throw new ArgumentOutOfRangeException("Valores sin parametros");
                }*/
                MessageBox.Show("Hubo un error: " + ex);
            }

            
            finally
            {
                conexion.Close();
            }
        }
        public void agregarcatalogo()
        {
            MemoryStream picture = new MemoryStream();
            byte[] aByte;
            try
            {
                picImagen.Image.Save(picture, ImageFormat.Jpeg);
               
            }
            catch
            {

            }
            aByte = picture.ToArray();
            float precio = float.Parse(txt_precio.Text);
            
            int Codproducto = int.Parse(txt_CodProducto1.Text);
            float talla = float.Parse(txt_talla.Text);
            conexion.Open();
            string insert = "INSERT INTO CATALOGO(Cod_Producto,Talla,Color,Material,CATEGORIA,Precio,Imagen) VALUES('" + Codproducto + "','" + talla + "','" + txt_color.Text + "','" + txt_material.Text + "','" + txt_categoria.Text + "','" + precio + "','" + aByte + "');";
            try
            {
                if (precio < 900)
                {
                    throw new ArgumentOutOfRangeException("El valor del producto no puede costar menos de 900 varos");
                }
                MySqlCommand insertar = new MySqlCommand(insert, conexion);
                insertar.ExecuteNonQuery();
                MessageBox.Show("Se agregaron los datos correctamente");
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


        private void button1_Click(object sender, EventArgs e)
        {
            agregarcatalogo();
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            busqueda_Producto("");
            busqueda_Catalogo("");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Actualizar_Catalogo UPDATE = new Actualizar_Catalogo();
            MemoryStream picture = new MemoryStream();
            try
            {
                picImagen.Image.Save(picture, ImageFormat.Jpeg);
            }
            catch
            {

            }
            byte[] aByte = picture.ToArray();
            float precio = float.Parse(txt_precio.Text);
            float talla = float.Parse(txt_talla.Text);
            int CodProd = int.Parse(txt_CodProducto1.Text);
            try
            {
                UPDATE.ex2(CodProd, talla, txt_color.Text, txt_material.Text, txt_categoria.Text, precio, aByte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un errror de tipo: " + ex);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string sql = "DELETE FROM PRODUCTO  WHERE  Cod_Producto='" + txt_Eliminar.Text + "';";
            string SQL1= "DELETE FROM CATALOGO WHERE Cod_Producto='" + txt_Eliminar.Text + "';";
            try
            {
                MySqlCommand DELETE = new MySqlCommand(sql,conexion);
                MySqlCommand DELETE1 = new MySqlCommand(SQL1, conexion);
                DELETE1.ExecuteNonQuery();
                DELETE.ExecuteNonQuery();
                MessageBox.Show("Se borro correctamnete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un erro de tipo : " + ex);
            }
            finally
            {
                conexion.Close();
            }

        }

        private void SELECIONAR_Click(object sender, EventArgs e)
        {
            OpenFileDialog OPEN = new OpenFileDialog();
            OPEN.Filter = "Imagenes |*.jpg; *.png ";
            OPEN.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            OPEN.Title = "Selecciona una imagen";
            if(OPEN.ShowDialog()==DialogResult.OK)
            {
                picImagen.Image = Image.FromFile(OPEN.FileName);
            }
        }

        private void Buscar_catalogo_Click(object sender, EventArgs e)
        {
            string comand = txt_BUSCAR.Text;
            busqueda_Catalogo(comand);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cagalogo_menu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_CodProducto.Text = "";
            txt_Marca.Text = "";
            txt_Modelo.Text = "";
            serie.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            agregarprod();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Actualizar_Catalogo update = new Actualizar_Catalogo();
            int Codproducto = int.Parse(txt_CodProducto.Text);
            update.ex1(Codproducto,txt_Marca.Text,txt_Modelo.Text,txt_serie.Text);
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            pointMD = MousePosition;
            pointFM = this.Location;
            xDelta = pointMD.X - pointFM.X;
            yDelta = pointMD.Y - pointFM.Y;
        }
    }
    class Actualizar_Catalogo:Conexion
    {
        private string cm1(int CodProd, string Marca, string Modelo, string numserie) => "update producto set  Nom_Modelo='" + Modelo + "', Num_Serie='" + numserie + "', Marcha='" + Marca + "' where Cod_Producto='" + CodProd + "';";
        public void ex1(int CodProd, string Marca, string Modelo, string numserie)
        {
            conexion.Open();
            try
            {
                MySqlCommand update = new MySqlCommand(cm1(CodProd, Marca, Modelo, numserie), conexion);
                update.ExecuteNonQuery();
                MessageBox.Show("Se actualizaron los datos correctamente");
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Ocurrio un error de tipo: " + ex);
            }
            finally
            {
                conexion.Close();
            }
        }
        private string cm2(int CodProd, float talla, string color, string Material,string cataegoria, float precio, byte[] aByte)=> " update catalogo set Talla='" + talla + "',Color='" + color+ "',Material='" + Material + "',CATEGORIA='" + cataegoria+ "',Precio='" + precio + "',Imagen='" + aByte + "' where Cod_Producto= '" + CodProd + "'";
        public void ex2(int CodProd, float talla, string color, string Material, string cataegoria, float precio, byte[] aByte)
        {
            conexion.Open();
            try
            {
                MySqlCommand update = new MySqlCommand(cm2(CodProd, talla, color, Material,cataegoria,precio,aByte), conexion);
                update.ExecuteNonQuery();
                MessageBox.Show("Se actualizaron los datos correctamente");
            }
            catch (MySqlException ex)
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
