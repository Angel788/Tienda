using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_tienda
{
    class Conexion
    {
        public MySqlConnection conexion = new MySqlConnection("Server = " + pasar_datos.server + "; Database = " + pasar_datos.BD + "; Uid = " + pasar_datos.user + "; Pwd = " + pasar_datos.pasword + ";");
    }
    class Busqueda
    {
        private int Cod_tienda;
        private string nom_tienda;
        private string direccion;

        
        public string Nom_tienda { get => nom_tienda; set => nom_tienda = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Cod_tienda1 { get => Cod_tienda; set => Cod_tienda = value; }
    }
    class busqueda_tienda:Conexion
    {
        
        public  string  Busqueda_tienda(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select*from tienda ";
            }
            else
            {
                comando = "select *from tienda where Cod_tienda like '" + dato + "' OR Nom_Tienda LIKE '" + dato + "' OR Direccion_Tienda  like'" + dato + "';";
            }
            conexion.Open();

            return comando;
        }
        
    }
    class tienda_contacto1:Conexion
    {
        public string Busqueda_tienda_con(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select*from tienda_contacto order by Cod_tienda";
            }
            else
            {
                comando = "select *from tienda_contacto where Cod_tienda like '" + dato + "' OR Instagram LIKE '" + dato + "' OR Facebook  like'" + dato + "' OR email  like'" + dato + "' OR Telefono  like'" + dato + "' ;";
            }
            conexion.Open();

            return comando;
        }

    }
    class pruducto_1:Conexion
    {
        public string Busqueda_tienda(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select*from PRODUCTO ";
            }
            else
            {
                comando = "select *from PRODUCTO where Cod_Producto like '" + dato + "' OR Nom_Modelo LIKE '" + dato + "' OR Num_Serie  like'" + dato + "' OR Marcha  like'" + dato + "' ;";
            }
           

            return comando;
        }

    }
    class catalogo:Conexion
    {
        public string Comando_Catalogo(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select PRODUCTO.Nom_Modelo as Modelo,CATALOGO.ID,CATALOGO.Cod_Producto,CATALOGO.Talla,CATALOGO.Color,CATALOGO.Material,CATALOGO.CATEGORIA,CATALOGO.Precio from CATALOGO,PRODUCTO WHERE  CATALOGO.Cod_Producto=PRODUCTO.Cod_Producto";
            }
            else
            {
                comando = "select PRODUCTO.Nom_Modelo as Modelo,CATALOGO.ID,CATALOGO.Cod_Producto,CATALOGO.Talla,CATALOGO.Color,CATALOGO.Material,CATALOGO.CATEGORIA,CATALOGO.Precio from CATALOGO,PRODUCTO WHERE  CATALOGO.Cod_Producto=PRODUCTO.Cod_Producto AND (PRODUCTO.Nom_Modelo like '" + dato+"' OR CATALOGO.Cod_Producto like '" + dato + "' OR CATALOGO.Talla LIKE '" + dato + "' OR CATALOGO.Color  like '" + dato + "' OR CATALOGO.Material  like '" + dato + "' OR CATALOGO.CATEGORIA  like '" + dato + "' OR CATALOGO.Precio   like '" + dato + "' OR CATALOGO.ID LIKE '"+dato+"') order by PRODUCTO.Marcha;";
            }
            

            return comando;
        }
    }
    class provedor : Conexion
    {
        public string   Comando_Provedor(string dato)
        {
            string comando;
            if(dato=="")
            {
                comando = "select*from Provedor ";
            }
            else
            {
                comando = "select*from Provedor  where Cod_Provedor like '" + dato + "' OR Nom_Provedor LIKE '" + dato + "' OR Instagram  like'" + dato + "' OR Facebook  like'" + dato + "' OR email  like '" + dato + "' OR Telefono   like'" + dato + "' ;";
            }
            return comando; 
        }
       
    }
    class provedormarca:Conexion
    {
        public string Comado_Marcas(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select Cod_Provedor,Marcas_Maneja,MODELOS from provedor_marcas ORDER BY Cod_Provedor ";
            }
            else
            {
                comando = "select Cod_Provedor,Marcas_Maneja,MODELOS from provedor_marcas  where Cod_Provedor like '" + dato + "' OR Marcas_Maneja LIKE '" + dato + "' OR MODELOS like '" + dato + "' ORDER BY Cod_Provedor ";
            }
            return comando;
        }
    }
    class Almacenocmd:Conexion
    {
        public string comando_Almacen(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select*from almacen ";
            }
            else
            {
                comando = "select*from almacen  where Cod_Almacen like '" + dato + "' OR Nom_Almacen LIKE '" + dato + "' OR Email like '" + dato + "' OR Telefono like '" + dato + "' OR Ubicacion like '" + dato + "' ";
            }
            return comando;
        }

    }
    class AlmacenRelacion:Conexion
    {
        public string comando_relacion(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select Cod_Producto,Cod_Almacen,Cod_Tienda,Cod_Provedor from almacenrelacion ORDER BY Cod_Producto";
            }
            else
            {
                comando = "select Cod_Producto,Cod_Almacen,Cod_Tienda,Cod_Provedor from almacenrelacion  where Cod_Producto like '" + dato + "' OR Cod_Almacen LIKE '" + dato + "' OR Cod_Tienda like '" + dato + "' OR Cod_Provedor like '" + dato + "' ORDER BY Cod_Producto";
            }
            return comando;
        }
    }
    class AlmacenStock:Conexion
    {
        public string comando_stock(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select Cod_Producto,Cod_Almacen,Stock_PROD from almacen_stock ORDER BY Cod_Producto";
            }
            else
            {
                comando = "select Cod_Producto,Cod_Almacen,Stock_PROD from almacen_stock  where Cod_Producto like '" + dato + "' OR Cod_Almacen LIKE '" + dato + "' OR Stock_PROD like '" + dato + "' ORDER BY Cod_Producto";
            }
            return comando;

        }
    }
    class Clientecmd
    {
        public string comando(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select*from cliente ";
            }
            else
            {
                comando = "select*from cliente  where Cod_Cliente like '" + dato + "' OR NOMBRE LIKE '" + dato + "' OR APELLIDO like '" + dato + "' OR Email like '" + dato + "' OR Telefono like '" + dato + "' OR Direccion like '" + dato + "'";
            }
            return comando;

        }

    }
    class Enviocmd
    {
        public string comando(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select*from envio ";
            }
            else
            {
                comando = "select*from envio  where Num_Envio like '" + dato + "' OR Direccion_Envio LIKE '" + dato + "' OR costo like '" + dato + "'";
            }
            return comando;
        }
    }
    class RastreoCmd
    {
        public string comando(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select*from rastreo ";
            }
            else
            {
                comando = "select*from rastreo  where NUM_RASTRO like '"+dato+"' OR Num_Envio like '" + dato + "' OR FECHA_SAL LIKE '" + dato + "' OR FECHA_LLEGADA like '" + dato + "'";
            }
            return comando;
        }
    }
    class UsuarioEnvio
    {
        public string comando(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select envio_usuario.Num_Envio,cliente.NOMBRE AS CLIENTE_NOMBRE,cliente.APELLIDO AS CLIENTE_APELLIDO,envio.Direccion_Envio as DIRECCION_ENVIO from cliente,envio_usuario,envio where  cliente.Cod_Cliente=envio_usuario.Cod_Cliente AND envio.Num_Envio=envio_usuario.Num_Envio ORDER BY cliente.APELLIDO";
            }
            else
            {
                comando = "select envio_usuario.Num_Envio,cliente.NOMBRE AS CLIENTE_NOMBRE,cliente.APELLIDO AS CLIENTE_APELLIDO,envio.Direccion_Envio as DIRECCION_ENVIO from cliente,envio_usuario,envio where  cliente.Cod_Cliente=envio_usuario.Cod_Cliente AND envio.Num_Envio=envio_usuario.Num_Envio AND ( envio_usuario.Num_Envio  like '" + dato + "' OR cliente.NOMBRE like '" + dato + "' OR cliente.APELLIDO like '"+dato+ "' OR envio.Direccion_Envio LIKE '"+dato+"') ORDER BY cliente.APELLIDO ";
            }
            return comando;
        }
    }
    class CarritoRelacion
    {
        public string comando(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select carrito.Num_Venta,cliente.nombre as cliente_nombre,cliente.apellido as cliente_apellido,catalogo.id as cod_catalogo,producto.Marcha as Marca_Seleccionada,producto.Nom_Modelo as Modelo_Seleccionado,rastreo.FECHA_SAL as Fecha_de_Salida_del_Paquete,rastreo.FECHA_LLEGADA as Fecha_de_Llegada_del_Paquete,envio.Direccion_Envio as DIRECCION_ENVIO,(envio.costo+catalogo.precio) as Total_a_Pagar from carrito_relacion  INNER JOIN CARRITO ON CARRITO.Num_Venta=CARRITO_RELACION.Num_Venta  INNER JOIN Cliente On cliente.Cod_Cliente = carrito_relacion.Cod_Cliente  INNER JOIN Producto ON producto.Cod_Producto= carrito_relacion.Cod_Producto INNER JOIN rastreo ON rastreo.Num_Envio= carrito_relacion.Num_Envio INNER JOIN envio ON ENVIO.Num_Envio= carrito_relacion.Num_Envio INNER JOIN catalogo ON CATALOGO.ID=carrito_relacion.ID_catalogo  ORDER BY cliente.nombre";
            }
            else
            {
                comando= "select carrito.Num_Venta,cliente.nombre as cliente_nombre,cliente.apellido as cliente_apellido,catalogo.id as cod_catalogo,producto.Marcha as Marca_Seleccionada,producto.Nom_Modelo as Modelo_Seleccionado,rastreo.FECHA_SAL as Fecha_de_Salida_del_Paquete,rastreo.FECHA_LLEGADA as Fecha_de_Llegada_del_Paquete,envio.Direccion_Envio as DIRECCION_ENVIO,(envio.costo+catalogo.precio) as Total_a_Pagar from carrito_relacion INNER JOIN CARRITO ON CARRITO.Num_Venta=CARRITO_RELACION.Num_Venta INNER JOIN Cliente On cliente.Cod_Cliente = carrito_relacion.Cod_Cliente  INNER JOIN Producto ON producto.Cod_Producto= carrito_relacion.Cod_Producto INNER JOIN rastreo ON rastreo.Num_Envio= carrito_relacion.Num_Envio INNER JOIN envio ON ENVIO.Num_Envio= carrito_relacion.Num_Envio INNER JOIN catalogo ON CATALOGO.ID=carrito_relacion.ID_catalogo WHERE  CARRITO.Num_Venta='"+dato+"' OR cliente.nombre='" + dato + "' OR cliente.apellido='" + dato + "' OR cliente.apellido='" + dato + "' OR producto.Marcha='" + dato + "' OR producto.Nom_Modelo='" + dato + "'  OR cliente.nombre='" + dato + "' ORDER BY cliente.nombre";
            }
            return comando;
        }
    }
    class CarritoBusqueda
    {
        public string comando(string dato)
        {
            string comando;
            if (dato == "")
            {
                comando = "select Num_Venta,ID_catalogo,Cod_Cliente,Cod_Producto,Num_Envio from carrito_relacion ";
            }
            else
            {
                comando = "select Num_Venta,ID_catalogo,Cod_Cliente,Cod_Producto,Num_Envio from carrito_relacion where  Num_Venta='" + dato + "' OR Cod_Cliente='" + dato + "' OR Cod_Producto='" + dato + "' OR Num_Envio='" + dato + "' OR ID_catalogo='"+dato+"'";
            }
            return comando;
        }
    }

}
