using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Proyecto_tienda
{
    public partial class Form1 : Form
    {
        
        public string conexxion() => $"Server = {txt_host.Text}; Database = {txt_bd.Text}; Uid = {txt_user.Text}; Pwd = {txt_pasword.Text};";
        public  MySqlConnection conexion = new MySqlConnection();
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;


        public Form1()
        {
            InitializeComponent();
        }
        public void Mysql()
        {
           
            conexion.ConnectionString = conexxion();
        }
        



        private void button1_Click(object sender, EventArgs e)
        {

            conexion.ConnectionString = conexxion();
            Form menu = new Form2();
            Form acceso = new Form1();
            try
            {
                conexion.Open();
                pasar_datos.server = txt_host.Text;
                pasar_datos.BD = txt_bd.Text;
                pasar_datos.user = txt_user.Text;
                pasar_datos.pasword = txt_pasword.Text;
                MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (conexion.State == System.Data.ConnectionState.Open)
            {
              
                menu.Show();
                this.WindowState = FormWindowState.Minimized;
                conexion.Close();
                

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                {
                    conexion.Close();
                    MessageBox.Show("Se ha cerrado conexion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            restaurar.Visible = true;
            maxi.Visible = false;
        }

        private void mini_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
        }

        private void restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restaurar.Visible = false;
            maxi.Visible = true;
        }

        private void mini_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void titulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titulo_MouseDown(object sender, MouseEventArgs e)
        {
            arrastrar = true;
            pointMD = MousePosition;
            pointFM = this.Location;
            xDelta = pointMD.X - pointFM.X;
            yDelta = pointMD.Y - pointFM.Y;
        }

        private void titulo_MouseMove(object sender, MouseEventArgs e)
        {
            Point pointNP = new Point();
            if (arrastrar)
            {
                pointNP.X = MousePosition.X - xDelta;
                pointNP.Y = MousePosition.Y - yDelta;
                this.Location = pointNP;
            }
        }

        private void txt_host_Enter(object sender, EventArgs e)
        {
            if(txt_host.Text=="INTRODUZCA EL HOST")
            {
                txt_host.Text = "";
            }
        }

        private void txt_bd_Enter(object sender, EventArgs e)
        {
            if (txt_bd.Text == "INTRODUZCA EL NOMBRE DE LA BASE DE DATOS")
            {
                txt_bd.Text = "";
            }
        }

        private void txt_user_Enter(object sender, EventArgs e)
        {
            if (txt_user.Text == "INTRODUZCA EL USUARIO")
            {
                txt_user.Text = "";
            }
        }

        private void txt_pasword_Enter(object sender, EventArgs e)
        {
            if (txt_pasword.Text == "INTRODUZCA EL PASWORD")
            {
                txt_pasword.Text = "";
            }
        }

        private void titulo_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar=false;
        }
    }
}
