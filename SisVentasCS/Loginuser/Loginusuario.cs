using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentasCS.Loginuser

{
     class Loginusuario
    {

        private string _usuario;
        private string _contraseña;

        public  string Usuario
        {
            set {
                if (value == "USUARIO") { _usuario = "no ha ingresado usuario"; }
                else { _usuario = value; }
                 }
            get { return _usuario; }
        }
        public string Contraseña
        {
            set
            {
                if (value == "CONTRASEÑA") { _contraseña = "no ha ingresado contraseña"; }
                else { _contraseña = value; }
            }
            get { return _contraseña; }
        }


       public MySqlDataReader xx()
        {
            MySqlDataReader leer = CrudUsuarios.ConsultaUsuario(Usuario,Contraseña);
            return leer;
        }


    }
}
