using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SisVentasCS
{
    public class BDConexcion
    {

        public static MySqlConnection obtenerconexcion()
        {
            
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=ventasvisual; Uid=root; pwd=;");

           
                conectar.Open();

           
             
           
            

            
            return conectar;
        }
        public static MySqlConnection cerrarconexcion()
        {

            MySqlConnection cerrar = new MySqlConnection("server=127.0.0.1; database=ventasvisual; Uid=root; pwd=;");

            cerrar.Close();


            return cerrar;
        }


    }
}
