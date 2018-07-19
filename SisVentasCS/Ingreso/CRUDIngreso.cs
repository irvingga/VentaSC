using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace SisVentasCS.Ingreso
{
    class CRUDIngreso
    {

        //Consulta de proveedor

        public static MySqlDataReader ConsultaProveedor()
        {
            MySqlConnection conectar = BDConexcion.obtenerconexcion();
            MySqlCommand SqlQuery = new MySqlCommand(string.Format("SELECT * FROM persona where tipo_persona ='Proveedor'"),conectar);
            MySqlDataReader Reader = SqlQuery.ExecuteReader(); //Nos de buelve un resultado (Que es uno para saber si se introdujo bien un dato )ExecuteNonQuery();
            
            return Reader;
        }

        public static MySqlDataReader  articludoespecifico(string nombre)
        {
           
            MySqlCommand comand = new MySqlCommand(string.Format("SELECT idarticulo,presentacion,stock_menudeo FROM articulo where nombre LIKE '%" + nombre + "%'"), BDConexcion.obtenerconexcion());
            MySqlDataReader reader = comand.ExecuteReader();

            BDConexcion.cerrarconexcion();
            return reader;
        }

        public static MySqlDataReader unidadesXarticulo(int id)
        {
           

            MySqlCommand comand = new MySqlCommand(string.Format("SELECT idarticulo,pieza_caja,precio_venta_caja,precio_venta_unidad FROM detalle_ingreso where idarticulo LIKE '%" + id + "%' LIMIT 1"), BDConexcion.obtenerconexcion());
            MySqlDataReader reader = comand.ExecuteReader();


            return reader;
        }



    }
}
