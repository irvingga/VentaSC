using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentasCS.AgregarVenta
{
    class CRUDVenta
    {


        public static MySqlDataReader ConsultaCliente()
        {
            MySqlConnection conectar = BDConexcion.obtenerconexcion();
            MySqlCommand SqlQuery = new MySqlCommand(string.Format("SELECT idpersona,nombre FROM persona where tipo_persona ='Cliente'"), conectar);
            MySqlDataReader Reader = SqlQuery.ExecuteReader(); //Nos de buelve un resultado (Que es uno para saber si se introdujo bien un dato )ExecuteNonQuery();

            return Reader;
        }
        public static MySqlDataReader articludoespecifico(string nombre)
        {

            MySqlCommand comand = new MySqlCommand(string.Format("SELECT idarticulo,presentacion FROM articulo where nombre LIKE '%" + nombre + "%'"), BDConexcion.obtenerconexcion());
            MySqlDataReader reader = comand.ExecuteReader();


            return reader;
        }
        
        public static MySqlDataReader TodosArticulosLista()
        {

          

            MySqlCommand comandoL = new MySqlCommand(string.Format("SELECT idarticulo,nombre,codigo FROM articulo  where estado ='Activo'"), BDConexcion.obtenerconexcion());
            //comandoListarClientes.ExecuteNonQuery();

            MySqlDataReader Reader = comandoL.ExecuteReader();


            return Reader;

        }

    }
}
