using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Mail;

namespace SisVentasCS.Loginuser


{
   public class CrudUsuarios
    {

        private string Email,nombres,contraseña, mensaje;

        public static MySqlDataReader ConsultaUsuario(string curp,string contraseña)
        {
            MySqlConnection conectar = BDConexcion.obtenerconexcion();
            MySqlCommand SqlQuery = new MySqlCommand(string.Format("SELECT * FROM usuarios where curp='"+curp +"' and contraseña='"+contraseña+"' "), conectar);
            MySqlDataReader Reader = SqlQuery.ExecuteReader(); //Nos de buelve un resultado (Que es uno para saber si se introdujo bien un dato )ExecuteNonQuery();
            BDConexcion.cerrarconexcion();
            return Reader;
        }

        public  string RecuperarContraseña(string curp)
        {
            MySqlConnection conectar = BDConexcion.obtenerconexcion();
            MySqlCommand SqlQuery = new MySqlCommand(string.Format("SELECT * FROM usuarios where curp='"+curp+"'"), conectar);
            MySqlDataReader Reader = SqlQuery.ExecuteReader(); //Nos de buelve un resultado (Que es uno para saber si se introdujo bien un dato )ExecuteNonQuery();

            if(Reader.Read()==true)
            {
                Email = Reader["email"].ToString();
                nombres = Reader["nombres"].ToString() + "," + Reader["apellidos"].ToString();
                contraseña = Reader.GetString(6);
                enviarmensaje();
                mensaje = "Estimado"+nombres+", Se ha enviado su contraseña a su correo: "+Email+", revise su bandeja de entrada";
                Reader.Close();
            }
            else
            {
                mensaje = "No se encontraron datos ";
            }
            BDConexcion.cerrarconexcion();
            return mensaje;
        }

        public void enviarmensaje()
        {
            MailMessage Correo = new MailMessage();
            Correo.From = new MailAddress("nivir_15@hotmail.com");//Quien enviara el correo
            Correo.To.Add(Email);//quin se le enviara
            Correo.Subject= ("RECUPERAR CONTRASEÑA");// Nombre del asusnyto
            Correo.Body = "Hola, "+ nombres+" Usted solicito recuperar contraseña \n su Contraseña es : "+contraseña+"";//Mensaje como tal
            Correo.Priority = MailPriority.Normal; //prioridad dek correo
            //protocolo de comunicacion
            SmtpClient serverEmail = new SmtpClient();
            serverEmail.Credentials = new NetworkCredential("nivir_15@hotmail.com","teamolupe");
            serverEmail.Host = "smtp-mail.outlook.com";
            serverEmail.Port = 587;
            serverEmail.EnableSsl = true;

            try
            {
                serverEmail.Send(Correo);
            }catch(Exception xx)
            {

            }
            Correo.Dispose();
        }

    }
}
