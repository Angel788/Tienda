using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using MySql.Data.MySqlClient;

namespace Proyecto_tienda
{
    public partial class Form2 : Form
    {
       
        Form1 login = new Form1();
        private Boolean arrastrar;
        private Point pointMD;
        private Point pointFM;
        private int xDelta, yDelta;

        public Form2()
        {
            InitializeComponent();
            
        }

       
        private void cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      
       public Form1 close = new Form1();
       public void close_form1()
       {
            close.Close();
       }
        

        private void tienda_button_Click(object sender, EventArgs e)
        {

            Tienda_menu Tienda = new Tienda_menu();
            Tienda_menu Panel = new Tienda_menu();
            Panel.mostrar();

            Tienda.Show();
        }

       
        

        private void button6_Click(object sender, EventArgs e)
        {
            Provedor_Menu MEN = new Provedor_Menu();
            MEN.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cagalogo_menu Producto = new Cagalogo_menu();
            Producto.Show();
        }

        private void bt_Almacen_Click(object sender, EventArgs e)
        {
            Almacen_menu Almacen = new Almacen_menu();
            Almacen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente_Menu Cliente = new Cliente_Menu();
            Cliente.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Envio_Menu envio = new Envio_Menu();
            envio.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Carrito_menu carrito = new Carrito_menu();
            carrito.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void titulo_MouseUp(object sender, MouseEventArgs e)
        {
            arrastrar = false;
        }
    }
}
