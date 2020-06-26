using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;
using System.Drawing;

namespace Proyecto_tienda
{
    class conexion_marca
    {
       public  MySqlConnection Modelo = new MySqlConnection("Server = "+pasar_datos.server+"; Database = marca; Uid = "+pasar_datos.user+"; Pwd = "+pasar_datos.pasword+";");
    }
    class CONEXION_ESTADOS
    {
        public MySqlConnection CONEXION = new MySqlConnection("Server = " + pasar_datos.server + "; Database = mexico; Uid = " + pasar_datos.user + "; Pwd = " + pasar_datos.pasword + ";");
        
    }
    
    class pasar_datos
    {
        static public string BD;
        static public string user;
        static public string pasword;
        static public string server;
    }
    
    
}
