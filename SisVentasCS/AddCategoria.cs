using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentasCS
{
    public partial class AddCategoria : Form
    {
        public AddCategoria()
        {
            InitializeComponent();
            bntclosebuscar.Hide();
            groupBoxListaCategoria.Hide();
        }
           public AgregarCategoria.Categoria categoriaselec { get; set; }
        public AgregarCategoria.Categoria categoriaActual { get; set; }
       
        private void AddCategoria_Load(object sender, EventArgs e)
        {

        }

        private void btnAddArticulo_Click(object sender, EventArgs e)
        {
            AgregarCategoria.Categoria categoria = new AgregarCategoria.Categoria();

           
                categoria.nombre = txtnombre.Text;
                categoria.descripcion = txtdescipcion.Text;
                categoria.condicion = comboBoxcondicion.Text;
           

            int resultado = AgregarCategoria.CRUDCategoria.AgregarCategoria(categoria);
            if (resultado > 0)
            {
                MessageBox.Show("Categoria Guardado Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
                this.Hide();

            }
            else
            {
                MessageBox.Show("No se pudo guardar el Categoria", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void limpiar()
        {
            txtnombre.Text = "";
            txtdescipcion.Text = "";
            comboBoxcondicion.Text = "";

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            btnAddCategoria.Hide();
            btnbuscar.Hide();
            bntclosebuscar.Show();
            groupBoxListaCategoria.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntclosebuscar_Click(object sender, EventArgs e)
        {
            btnAddCategoria.Show();
            btnbuscar.Show();
            bntclosebuscar.Hide();
            groupBoxListaCategoria.Hide();
        }

        private void btnbuscarr_Click(object sender, EventArgs e)
        {
            List<AgregarCategoria.Categoria> lista = new List<AgregarCategoria.Categoria>();
            

                dataGridView1.DataSource = AgregarCategoria.CRUDCategoria.LlenarlistaNombre(txtbusquedaBD.Text);
            
            
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            categoriaselec = AgregarCategoria.CRUDCategoria.categoriaespecifica(id);

             categoriaActual= categoriaselec;
            txtnombre.Text = categoriaselec.nombre;
            txtdescipcion.Text = categoriaselec.descripcion;
            comboBoxcondicion.Text = categoriaselec.condicion;
           
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            AgregarCategoria.Categoria categorianueva = new AgregarCategoria.Categoria();

            categorianueva.nombre=txtnombre.Text;
            categorianueva.descripcion=txtdescipcion.Text;
            categorianueva.condicion=comboBoxcondicion.Text;
            categorianueva.idcategoria = categoriaActual.idcategoria;
            MessageBox.Show("id Actualizar"+ categoriaActual.idcategoria);

            int retorno =AgregarCategoria.CRUDCategoria.Actualizar(categorianueva);

            if (retorno > 0)
            {
                MessageBox.Show("El Categoria Se Actualizo Con Exito!!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo Categoria  el Articulo", "Fallo!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            int retorno = AgregarCategoria.CRUDCategoria.Eliminar(categoriaActual.idcategoria);
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
