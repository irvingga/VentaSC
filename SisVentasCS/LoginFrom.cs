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

namespace SisVentasCS
{
    public partial class LoginFrom : Form
    {
        public LoginFrom()
        {
            InitializeComponent();
        }

        [DllImport("User32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("User32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam );
        


        private void txtuser_Enter(object sender, EventArgs e)
        {
            //Cuando el cursor este dentro de la caja de texto (FOCO ENTER)
            if(txtuser.Text=="USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }

        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            //Cuando el cursor sale de la caja de textp(FOCO LEAVE)
            if(txtuser.Text=="")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.DimGray;
            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text=="CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if(txtpass.Text=="")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.DimGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        
        private void btnlogin_Click_1(object sender, EventArgs e)
        {


            //this.Hide();
           // PrincipalMenu menu = new PrincipalMenu();

            //menu.Show();
            

            Loginuser.Loginusuario x = new Loginuser.Loginusuario();
            x.Usuario= txtuser.Text;
            x.Contraseña = txtpass.Text;
            try { 
            if (x.Usuario == txtuser.Text)
            {
                lbusuario.Visible = false;
                if (x.Contraseña == txtpass.Text)
                {
                    lbcontraseña.Visible = false;
               

                        MySqlDataReader reader = x.xx();

                        if (reader.Read() == true)
                        {
                          
                            this.Hide();
                            PrincipalMenu menu = new PrincipalMenu(reader.GetString(2), reader.GetString(3),reader.GetString(4), reader.GetString(5));

                            menu.Show();

                        }
                        else
                        {
                            lblogin.Text = "Usuario o contraseña  invalido, intente de nuevo";
                            lblogin.Visible = true;
                            txtpass.Text = "";
                            txtuser_Leave(null, e);
                            txtuser.Focus();
                            txtpass_Leave(null,e);
                        }
                   

                }
                else
                    lbcontraseña.Visible = true;
                lbcontraseña.Text = x.Contraseña;
             
            }
            else

                lbusuario.Visible = true;
            lbusuario.Text = x.Usuario;

        }
                    catch (Exception a)
                    {
                        MessageBox.Show("Error al entar" + a);
                    }

        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRecuperarContraseña form = new FormRecuperarContraseña();
            form.ShowDialog();

        }
    }
}
