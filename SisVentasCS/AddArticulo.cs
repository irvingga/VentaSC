using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace SisVentasCS
{
    public partial class AddArticulo : Form
    {
        public AddArticulo()
        {
            InitializeComponent();
            bntclosebuscar.Hide();
            groupBoxListaArticulos.Hide();
            llamadocategoria();
            comboBoxestado.Visible = false;
            labelEstado.Visible = false;
            
        }

        string IdCategoriaCombobox;
        private void llamadocategoria()
        {
            List<string> lista = new List<string>();
          
            MySqlDataReader reader = AgregarProducto.CRUDArticulo.Categorias();
            while (reader.Read())
            {
                // articuloselecionado.idcategoria = reader.GetInt32(0);

                
                lista.Add(reader.GetString(0) +"-"+ reader.GetString(1));

               
            }
           comboBox1.DataSource =lista;
           



        }

        String ubicacion;
        OpenFileDialog open = new OpenFileDialog();

        public  AgregarProducto.Articulo articuloselec { get; set; }
        public  AgregarProducto.Articulo articuloActual { get; set; }

     
        int ValorId = 0;

        private void btnAddArticulo_Click(object sender, EventArgs e)
        {
            AgregarProducto.Articulo articulonuevo = new AgregarProducto.Articulo();

            articulonuevo.idcategoria = int.Parse(IdCategoriaCombobox);
            articulonuevo.codigo = IdCategoriaCombobox;
            articulonuevo.stock_menudeo = 0;
            articulonuevo.stock_mayoreo = 0;
            articulonuevo.nombre = txtnombre.Text;
            articulonuevo.presentacion = txtpresentacion.Text; 
            articulonuevo.descripcion = txtdescripcion.Text;

            /*
            FileStream stream = new FileStream(txtphatimagen.Text, FileMode.Open, FileAccess.Read);
            //Se inicailiza un flujo de archivo con la imagen seleccionada desde el disco.
            BinaryReader br = new BinaryReader(stream);
            FileInfo fi = new FileInfo(txtphatimagen.Text);

            //Se inicializa un arreglo de Bytes del tamaño de la imagen
            byte[] binData = new byte[stream.Length];
            //Se almacena en el arreglo de bytes la informacion que se obtiene del flujo de archivos(foto)
            //Lee el bloque de bytes del flujo y escribe los datos en un búfer dado.
            stream.Read(binData, 0, Convert.ToInt32(stream.Length));

            ////Se muetra la imagen obtenida desde el flujo de datos
            pictureproducto.Image = Image.FromStream(stream);*/
            
            articulonuevo.imagen = txtphatimagen.Text; 
           // articulonuevo.imagen = txtphatimagen.Text;
            articulonuevo.estado = "activo";

            int resultado = AgregarProducto.CRUDArticulo.addarticulo(articulonuevo);
            if (resultado > 0)
            {
                MessageBox.Show("Articulo Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("No se pudo guardar el articulo", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void limpiar()
        {
           comboBox1.Text = "";
            txtcodigo.Text = "";
            txtnombre.Text = "";
            txtpresentacion.Text = "";
            txtdescripcion.Text = "";
            comboBoxestado.Text = "";
        }

        private void AddArticulo_Load(object sender, EventArgs e)
        {
            ListarProductoExistente();
        }

        private void ListarProductoExistente()
        {
            AgregarProducto.CRUDArticulo crudarticulo = new AgregarProducto.CRUDArticulo();
            try
            {
                dataGridView1.DataSource = crudarticulo.TodosArticulos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de consulta No ahi datos " + ex);
            }
        }

        private void btncargarimagen_Click(object sender, EventArgs e)
        {
            open.Title = "Abrir";
            open.Filter = "Jpg files(*.jpg)|*.jpg|Gif files(*.gif)|*.gif|Bitmap files(*.Bmp)|*.bmp|PNG files (*.png)|*.png";
            if(open.ShowDialog()==DialogResult.OK)
            {
                ubicacion = open.FileName;

               
                //Bitmap picture = new Bitmap(ubicacion);
                pictureproducto.Image = Image.FromFile(ubicacion);
                txtphatimagen.Text =ubicacion ;
                MessageBox.Show("Esto es ala ubicacion"+ubicacion);

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnbuscar_MouseClick(object sender, MouseEventArgs e)
        {
            btnAddArticulo.Hide();
            btnbuscar.Hide();
            bntclosebuscar.Show();
            groupBoxListaArticulos.Show();

           
            

        }

        private void bntclosebuscar_Click(object sender, EventArgs e)
        {
            btnAddArticulo.Show();
            btnbuscar.Show();
            bntclosebuscar.Hide();
            groupBoxListaArticulos.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = AgregarProducto.CRUDArticulo.TodosArticulos(txtbusquedaBD.Text);

            //List<AgregarProducto.Articulo> lista = new List<AgregarProducto.Articulo>();


               
        }


        public static Image Bytes_A_Imagen(byte[] ImgBytes)
        {
            Bitmap imagen = null;
            byte[] bytes = (byte[])(ImgBytes);
            try
            {
                MemoryStream ms = new MemoryStream(bytes);
                imagen = new Bitmap(ms);
            }
           
            catch(Exception e)
            {
                MessageBox.Show("Erorro fatal "+ e);
            }
            return imagen;
        }

        public static  byte[] Imagen_A_Bytes(String ruta)
        {
            byte[] Img2bytes;
            FileStream foto = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            int LonByts = (int)foto.Length;
            Img2bytes = new byte[LonByts];
            foto.Read(Img2bytes,0,(int)LonByts);
            
            
            
            return Img2bytes;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            string simbolo = "-";
            int index = comboBox1.Text.IndexOf(simbolo);

            string subcadena = comboBox1.Text.Substring(0,index);
            IdCategoriaCombobox = subcadena;
           // MessageBox.Show(subcadena);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            labelEstado.Visible = true;
            comboBoxestado.Visible = true;

            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            articuloselec = AgregarProducto.CRUDArticulo.articludoespecifico(id);

            articuloActual = articuloselec;
            txtnombre.Text = articuloselec.nombre;
            comboBox1.Text = Convert.ToString(articuloselec.idcategoria);
            txtcodigo.Text = articuloselec.codigo;
            txtpresentacion.Text = articuloselec.presentacion;
            txtdescripcion.Text = articuloselec.descripcion;
            comboBoxestado.Text = articuloselec.estado;
            ValorId = id;
           

            //  byte[] MyData = new byte[0];
            // MyData = articuloselec.imagen;
            //MemoryStream stream = new MemoryStream(articuloselec.imagen);
            // pictureproducto.Image = Image.FromFile(articuloselec.imagen);
            // pictureproducto.Image = Image.FromFile(stream);
            //MemoryStream ms = new MemoryStream();
            //Image devolverImagen = Image.FromStream(ms);
           
            
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
          
            AgregarProducto.Articulo AMoficicado = new  AgregarProducto.Articulo();

            AMoficicado.idcategoria = int.Parse(IdCategoriaCombobox);
            AMoficicado.codigo = IdCategoriaCombobox;
            AMoficicado.stock_menudeo = 0;
            AMoficicado.stock_mayoreo = 0;
            AMoficicado.nombre = txtnombre.Text;
            AMoficicado.presentacion = txtpresentacion.Text;
            AMoficicado.descripcion = txtdescripcion.Text;


            AMoficicado.imagen = txtphatimagen.Text;
            // articulonuevo.imagen = txtphatimagen.Text;
            AMoficicado.estado = comboBoxestado.Text;
            AMoficicado.idarticulo =ValorId;

            //MessageBox.Show("IdArticulo " + txtnombre.Text);
            int retotno = AgregarProducto.CRUDArticulo.ActualizarArticulo(AMoficicado);
            
            if (retotno > 0)
            {
                MessageBox.Show("El Articulo Se Actualizo Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                ListarProductoExistente();
            }
            else
            {
                MessageBox.Show("No se pudo Actualizar  el Articulo", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            int retorno = AgregarProducto.CRUDArticulo.EliminarArticulo(ValorId);
            if (MessageBox.Show("Estas Seguro que deseas eliminar el Articulo Actual", "Estas Seguro??",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (retorno > 0)
                {
                    MessageBox.Show("Articulo Eliminado Correctamente!!", "Articulo Elimina!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else
                {
                    MessageBox.Show("No se Puedoe Elminar el articulo !!", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else
            {
                MessageBox.Show("Se Cancelo la Elmininacion", "Cancelado!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
    }

}
