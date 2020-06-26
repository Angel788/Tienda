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
    public partial class Almacen_menu : Form
    {
        MySqlConnection conexion = new MySqlConnection("Server = localhost; Database = tienda; Uid = root; Pwd = j3zuzv3;");
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;
        private Boolean activo;
        public Almacen_menu()
        {
            InitializeComponent();
            CargarTablaAlmacen("");
            CargarTablaRelacion("");
            CargarTablaStock("");
            Estado();
        }
        public void CargarTablaAlmacen(string dato)
        {
            Almacenocmd Pasar = new Almacenocmd();
            conexion.Open();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.comando_Almacen(dato), conexion);
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
        public void CargarTablaRelacion(string dato)
        {
            AlmacenRelacion Pasar = new AlmacenRelacion();
            conexion.Open();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.comando_relacion(dato), conexion);
                MySqlDataAdapter reader1 = new MySqlDataAdapter();
                reader1.SelectCommand = select;
                DataTable tabla1 = new DataTable();
                reader1.Fill(tabla1);
                tabla_Almacenrela.DataSource = tabla1;
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
        public void CargarTablaStock(string dato)
        {
            NumAlmacen confir = new NumAlmacen();
            if(confir.IsNumeric(dato)==true)
            {
                CargarTablaStocktrue(dato);
            }
            else {
                CargarTablaStockfalse(dato);
            }
            
        }
        private void CargarTablaStocktrue(string dato)
        {
            AlmacenStock Pasar = new AlmacenStock();
            conexion.Open();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.comando_stock(dato), conexion);
                MySqlDataAdapter reader1 = new MySqlDataAdapter();
                reader1.SelectCommand = select;
                DataTable tabla1 = new DataTable();
                reader1.Fill(tabla1);
                tabla_stock.DataSource = tabla1;
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
        private void CargarTablaStockfalse(string dato)
        {
            AlmacenStock Pasar = new AlmacenStock();
            conexion.Open();
            try
            {
                MySqlCommand select = new MySqlCommand(Pasar.comando_stock(dato), conexion);
                MySqlDataAdapter reader1 = new MySqlDataAdapter();
                reader1.SelectCommand = select;
                DataTable tabla1 = new DataTable();
                reader1.Fill(tabla1);
                tabla_stock.DataSource = tabla1;
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
        public void Localidad(string id_municipio)
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

        private void Almacen_menu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
         string comand = txt_BuscarAlmacen.Text;
         CargarTablaAlmacen(comand);
           

        }

        private void Buscar_catalogo_Click(object sender, EventArgs e)
        {
            string cmd = txt_BUSCARRela.Text;
            CargarTablaRelacion(cmd);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string cmd = txt_BuscarStock.Text;
            int codprod = int.Parse(txt_BuscarStock.Text);
            NumAlmacen almacen = new NumAlmacen();
            if(almacen.IsNumeric(codprod)==true)
            {
                MessageBox.Show("Es un numero");
            }
            CargarTablaStock(cmd);
        }

        private void bt_limpiar_Click(object sender, EventArgs e)
        {
            txt_CodAlmacen.Text = "";
            txt_NomAlmacen.Text = "";
            txt_TelefonoAlmacen.Text = "";
            txt_EmailAlmacen.Text = "";
            txtEstado.Text = "";
            txtMunicipio.Text = "";
            txtLocalidad.Text = "";
            txtdatosExtra.Text = "";
        }

        private void limpiar_Click(object sender, EventArgs e)
        {
            txt_CodAlmacen1.Text = "";
            txt_CodProvedor.Text = "";
            txtcodproducto.Text = "";
            txt_CodTienda.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txt_CodProducto2.Text = "";
            txt_CODALMACEN2.Text = "";
            txt_Stock.Text = "";
        }

        private void bt_nuevo_Click(object sender, EventArgs e)
        {
            int cod = int.Parse(txt_CodAlmacen.Text);
            string DIRECCION = "" + txtEstado.Text + ", " + txtMunicipio.Text + ", " + txtLocalidad.Text + ", " + txtdatosExtra.Text;
            Nuevo_Almacen add = new Nuevo_Almacen();
            add.ex1(cod, txt_NomAlmacen.Text, txt_EmailAlmacen.Text, txt_TelefonoAlmacen.Text, DIRECCION);
        }

        private void bt_actualizar_Click(object sender, EventArgs e)
        {
            int COD = int.Parse(txt_CodAlmacen.Text);
            string DIRECCION = "" + txtEstado.Text + ", " + txtMunicipio.Text + ", " + txtLocalidad.Text + ", " + txtdatosExtra.Text;
            Actualizar_Almacen act = new Actualizar_Almacen();
            act.ex1(COD, txt_NomAlmacen.Text, txt_EmailAlmacen.Text, txt_TelefonoAlmacen.Text, DIRECCION);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int codprod = int.Parse(txtcodproducto.Text), codalma = int.Parse(txt_CodAlmacen1.Text), codtienda = int.Parse(txt_CodTienda.Text), codprov = int.Parse(txt_CodProvedor.Text);
            Nuevo_Almacen add = new Nuevo_Almacen();
            add.ex2(codprod, codalma, codtienda, codprov);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int codprod = int.Parse(txtcodproducto.Text), codalma = int.Parse(txt_CodAlmacen1.Text), codtienda = int.Parse(txt_CodTienda.Text), codprov = int.Parse(txt_CodProvedor.Text);
            Actualizar_Almacen UPDATE = new Actualizar_Almacen();
            UPDATE.ex2(codprod, codalma, codtienda, codprov);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int codprod = int.Parse(txt_CodProducto2.Text), codalma = int.Parse(txt_CODALMACEN2.Text), stock = int.Parse(txt_Stock.Text);
            Nuevo_Almacen add = new Nuevo_Almacen();
            add.ex3(codprod, codalma, stock);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int codprod = int.Parse(txt_CodProducto2.Text), codalma = int.Parse(txt_CODALMACEN2.Text), stock = int.Parse(txt_Stock.Text);
            Actualizar_Almacen add = new Actualizar_Almacen();
            add.ex3(codprod, codalma, stock);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cod1 = int.Parse(txt_EliminarCod.Text), cod2 = int.Parse(txt_EliminarCod.Text), cod3 = int.Parse(txt_EliminarCod.Text);
            Eliminar_almacen DELETE = new Eliminar_almacen();
            DELETE.ex(cod1, cod2, cod3);
        }

        private void txtEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Municipio(txtEstado.SelectedValue.ToString());
        }

        private void txtMunicipio_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtMunicipio.SelectedValue.ToString()!=null)
                {
                    Localidad(txtMunicipio.SelectedValue.ToString());
                }
            }
            catch
            {

            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void tabla_Almacenrela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            CargarTablaAlmacen("");
            CargarTablaRelacion("");
            CargarTablaStock("");
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }
    }
    class Actualizar_Almacen:Conexion
    {
        string cmd1(int Cod, string nom, string email, string tel, string dire) => "UPDATE almacen SET Nom_Almacen='" + nom + "', Email='" + email + "', Telefono='" + tel + "', Ubicacion='" + dire + "' WHERE Cod_Almacen='"+Cod+"'";
        public void ex1(int Cod, string nom, string email, string tel, string dire)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cmd1(Cod,nom, email,tel,dire), conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actulizaron los datos correctamente");
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
        string cmd2(int cod_prod, int cod_almacen, int cod_tienda, int codprov) => "UPDATE almacenrelacion SET Cod_Producto='" + cod_prod + "', Cod_Tienda='" + cod_tienda + "', Cod_Provedor='" + codprov + "' WHERE Cod_Almacen='" + cod_almacen + "'";
        public void ex2(int cod_prod, int cod_almacen, int cod_tienda, int codprov)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cmd2(cod_prod, cod_almacen, cod_tienda, codprov), conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actulizaron los datos correctamente");
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
        string cmd3(int cod_prod, int cod_almacen, int stock) => "UPDATE almacen_stock set  Cod_Producto='" + cod_prod + "', Stock_PROD='" + stock + "' WHERE  Cod_Almacen='" + cod_almacen + "'";
        public void ex3(int cod_prod, int cod_almacen, int stock)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cmd3(cod_prod, cod_almacen, stock), conexion);
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
    class Nuevo_Almacen:Conexion
    {
        string cmd1(int Cod, string nom, string email, string tel, string dire) => "INSERT INTO almacen VALUES('" + Cod + "','" + nom + "', '" + email + "', '" + tel + "', '" + dire + "')";
        public void ex1(int Cod, string nom, string email, string tel, string dire)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cmd1(Cod, nom, email, tel, dire), conexion);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se actulizaron los datos correctamente");
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
        string cmd2(int cod_prod, int cod_almacen, int cod_tienda, int codprov) => "INSERT INTO almacenrelacion(Cod_Producto,Cod_Almacen,Cod_Tienda,Cod_Provedor) VALUES('" + cod_prod + "','" + cod_almacen + "','" + cod_tienda + "','" + codprov + "')";
        public void ex2(int cod_prod, int cod_almacen, int cod_tienda, int codprov)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cmd2(cod_prod,cod_almacen,cod_tienda,codprov), conexion);
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
        string cmd3(int cod_prod, int cod_almacen, int stock) => "INSERT INTO almacen_stock(Cod_Producto,Cod_Almacen,Stock_PROD) VALUES('" + cod_prod + "','" + cod_almacen + "','" + stock + "')";
        public void ex3(int cod_prod, int cod_almacen, int stock)
        {
            conexion.Open();
            try
            {
                MySqlCommand cmd = new MySqlCommand(cmd3(cod_prod, cod_almacen,stock), conexion);
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
    class Eliminar_almacen:Conexion
    {
        string cmd1(int cod_almacen) => "DELETE FROM almacen WHERE Cod_Almacen='"+cod_almacen+"'";
        string cmd2(int cod_almacen) => "DELETE FROM almacenrelacion WHERE Cod_Almacen='" + cod_almacen + "'";
        string cmd3(int cod_almacen) => "DELETE FROM  almacen_stock WHERE Cod_Almacen='" + cod_almacen + "'";
        public void ex(int cod1, int cod2, int cod3)
        {
            conexion.Open();
            try
            {
                MySqlCommand delete = new MySqlCommand(cmd1(cod1), conexion);
                MySqlCommand delete1 = new MySqlCommand(cmd2(cod1), conexion);
                MySqlCommand delete2 = new MySqlCommand(cmd3(cod1), conexion);
                delete2.ExecuteNonQuery();
                delete1.ExecuteNonQuery();
                delete.ExecuteNonQuery();
                MessageBox.Show("Se eliminaron los datos correctamnete");
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
    class NumAlmacen
    {
        public void CodProd()
        {
            
        }
        public bool IsNumeric(object Expression)
        {
            bool isNum;
            double retNum;
            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }
    }
    
}
