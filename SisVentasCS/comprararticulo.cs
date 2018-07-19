using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentasCS
{
    public partial class comprararticulo : Form
    {
        public comprararticulo()
        {
            InitializeComponent();
            dataGridViewIngreso.Columns.Add("idarticulo", "idarticulo");
            dataGridViewIngreso.Columns.Add("cantidad_cajas", "cantidad_cajas");
            dataGridViewIngreso.Columns.Add("pieza_caja", "pieza_caja");
            dataGridViewIngreso.Columns.Add("total_articulos", "total_articulos");
            dataGridViewIngreso.Columns.Add("precio_compra_caja", "precio_compra_caja");
            dataGridViewIngreso.Columns.Add("precio_venta_caja", "precio_venta_caja");
            dataGridViewIngreso.Columns.Add("precio_venta_unidad", "precio_venta_unidad");

        }
        string subcadena = "";
        int idArticulo =0;
        DataTable dtarticulo;
        List<Ingreso.detalleingreso> listaDI = new List<Ingreso.detalleingreso>();
        private void comprararticulo_Load(object sender, EventArgs e)
        {
            MySqlDataReader Reader = AgregarProducto.CRUDArticulo.TodosArticulosLista();

            while (Reader.Read())
            {

                dtarticulo = new DataTable();

                dtarticulo.Columns.Add("nombre", typeof(string));
                while (Reader.Read())
                {
                    //Esta forma es oara agrrgar a un lisbox atrabes de la creaion de una tabla y luego asignarcela


                    dtarticulo.Rows.Add( Reader.GetString(1));

                }

                Reader.NextResult();
                // listBox1.DisplayMember = "nombre";//Esto es para llenar el listbox por medio de Items
                //listBox1.Items.Add(Reader.GetString(1));
                //Reader.NextResult(); //debemos checar bien que sucedd con esto

            }
            Reader.Close();
            listBox1.DataSource = dtarticulo;
            listBox1.DisplayMember = "nombre";

            carcargCombo();

        }

        private void carcargCombo()
        {

            List<string> lista = new List<string>();

            MySqlDataReader reader = Ingreso.CRUDIngreso.ConsultaProveedor();
            while (reader.Read())
            {
                // articuloselecionado.idcategoria = reader.GetInt32(0);


                lista.Add(reader.GetString(0)+"-"+reader.GetString(1));


            }
            comboBoxProveedor.DataSource = lista;
        }
        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string simbolo = "-";
            int index = comboBoxProveedor.Text.IndexOf(simbolo);

            subcadena = comboBoxProveedor.Text.Substring(0, index);
            //IdCategoriaCombobox = subcadena;
            //MessageBox.Show(subcadena);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataView dvArticulo = dtarticulo.DefaultView;
            dvArticulo.RowFilter = "nombre LIKE '%" + txtSearch.Text + "%'";
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            String valueOfItem = drv["nombre"].ToString();

            txtSearch.Text = valueOfItem;

            ConsultaArtDescripcion(valueOfItem);

        }

        private void ConsultaArtDescripcion(string nombre)
        {
            MySqlDataReader reader = Ingreso.CRUDIngreso.articludoespecifico(nombre);
            while (reader.Read())
            {
                
                labelCC.Text = "Cantidad X " + reader.GetString(1);
                labelPC.Text = "Piezas X " + reader.GetString(1);
                labelPCC.Text = "Precio Compra X " + reader.GetString(1);
                labelPVC.Text = "Precio Venta  X " + reader.GetString(1);

                idArticulo = reader.GetInt32(0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            List<Ingreso.detalleingreso> listaDI = new List<Ingreso.detalleingreso>();

            Ingreso.detalleingreso dingreso = new Ingreso.detalleingreso();

            int cantidad_cajas = int.Parse(txtcantidad_cajas.Text);
            int pieza_caja = int.Parse(txtPiezas_caja.Text);
            dingreso.idarticulo = idArticulo;
            dingreso.cantidad_cajas = cantidad_cajas;
            dingreso.pieza_caja = pieza_caja;
            dingreso.total_articulos = cantidad_cajas * pieza_caja;
            dingreso.precio_compra_caja = int.Parse( txtprecio_compra_caja.Text);
            dingreso.precio_venta_caja = int.Parse(txtprecio_venta_cajas.Text);
            dingreso.precio_venta_unidad = Convert.ToDecimal(txtprecio_venta_unidad.Text);

            listaDI.Add(dingreso);
            
            DataTable dtingreso = new DataTable();
            /*
             * 
             *
             dtingreso.Columns.Add("nombre", typeof(string));
             dtingreso.Columns.Add("piezas", typeof(string));

             //Esta forma es oara agrrgar a un lisbox atrabes de la creaion de una tabla y luego asignarcela


             dtingreso.Rows.Add( listaDI);
             */
            int cantidad_cajas = int.Parse(txtcantidad_cajas.Text);
            int pieza_caja = int.Parse(txtPiezas_caja.Text);
            int idarticulo = idArticulo;
           
            int total_articulos = cantidad_cajas * pieza_caja;
            int precio_compra_caja = int.Parse(txtprecio_compra_caja.Text);
            int precio_venta_caja = int.Parse(txtprecio_venta_cajas.Text);
            decimal precio_venta_unidad = Convert.ToDecimal(txtprecio_venta_unidad.Text);
            dataGridViewIngreso.Rows.Add(idarticulo,cantidad_cajas,pieza_caja,total_articulos,precio_compra_caja,precio_venta_caja,precio_venta_unidad);
           // dataGridViewIngreso.DataSource= dtingreso;

        }

        private void dataGridViewIngreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //llamar al metodo fila
            int fila = dataGridViewIngreso.CurrentCell.RowIndex;//llamar atrael el idice de la columna seleccionada
            dataGridViewIngreso.Rows.RemoveAt(fila);

           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ingreso.ingreso ingreso = new Ingreso.ingreso();
            ingreso.idproveedor = int.Parse(subcadena);
            ingreso.tipo_comprobante = txtcomprovante.Text;
            ingreso.serie_comprobante = txtseria_comprobante.Text;
            ingreso.num_comprobante = txtnumerocomprovante.Text;
            ingreso.fecha_hora = "2018-06-04";
            ingreso.impuesto = Convert.ToDecimal(".012");
            ingreso.estado = "Paso";
            /* 
             foreach (DataGridViewRow row in dataGridViewIngreso.Rows)
             {





                 Ingreso.detalleingreso dingreso = new Ingreso.detalleingreso();


                 dingreso.idarticulo = int.Parse( row.Cells["idarticulo"].Value.ToString());
                 dingreso.cantidad_cajas = int.Parse(row.Cells["cantidad_cajas"].Value.ToString());
                 dingreso.pieza_caja = int.Parse(row.Cells["pieza_caja"].Value.ToString());
                 dingreso.total_articulos = int.Parse(row.Cells["total_articulos"].Value.ToString());
                 dingreso.precio_compra_caja = int.Parse(row.Cells["precio_compra_caja"].Value.ToString());
                 dingreso.precio_venta_caja = int.Parse(row.Cells["precio_venta_caja"].Value.ToString());
                 dingreso.precio_venta_unidad = Convert.ToDecimal(row.Cells["precio_venta_unidad"].Value.ToString());


                 listaDI.Add(dingreso);
             }
             */
            for (int fila = 0; fila < dataGridViewIngreso.Rows.Count - 1; fila++)
            {
                //for (int col = 0; col < dataGridViewIngreso.Rows[fila].Cells.Count; col++)
                //{
                    /*string valor = dataGridViewIngreso.Rows[fila].Cells["idarticulo"].Value.ToString();
                string valor2 = dataGridViewIngreso.Rows[fila].Cells["cantidad_cajas"].Value.ToString();
                string valor3 = dataGridViewIngreso.Rows[fila].Cells["pieza_caja"].Value.ToString();
                string valor4 = dataGridViewIngreso.Rows[fila].Cells["total_articulos"].Value.ToString();
                string valor5 = dataGridViewIngreso.Rows[fila].Cells["precio_compra_caja"].Value.ToString();
                string valor6 = dataGridViewIngreso.Rows[fila].Cells["precio_venta_caja"].Value.ToString();
                string valor7 = dataGridViewIngreso.Rows[fila].Cells["precio_venta_unidad"].Value.ToString();
               */
               // MessageBox.Show(valor + " "+ valor2 + " " + valor3 + " " + valor4 + " " + valor5 + " " + valor6 + " " + valor7);
                Ingreso.detalleingreso dingreso = new Ingreso.detalleingreso();


                dingreso.idarticulo = int.Parse(dataGridViewIngreso.Rows[fila].Cells["idarticulo"].Value.ToString());
                dingreso.cantidad_cajas = int.Parse(dataGridViewIngreso.Rows[fila].Cells["cantidad_cajas"].Value.ToString());
                dingreso.pieza_caja = int.Parse(dataGridViewIngreso.Rows[fila].Cells["pieza_caja"].Value.ToString());
                dingreso.total_articulos = int.Parse(dataGridViewIngreso.Rows[fila].Cells["total_articulos"].Value.ToString());
                dingreso.precio_compra_caja = int.Parse(dataGridViewIngreso.Rows[fila].Cells["precio_compra_caja"].Value.ToString());
                dingreso.precio_venta_caja = int.Parse(dataGridViewIngreso.Rows[fila].Cells["precio_venta_caja"].Value.ToString());
                dingreso.precio_venta_unidad = Convert.ToDecimal(dataGridViewIngreso.Rows[fila].Cells["precio_venta_unidad"].Value.ToString());


                listaDI.Add(dingreso);
                //}
            }
           int retotno = Registrar(ingreso ,listaDI);
            MessageBox.Show(""+ retotno);


        }

        private static int Registrar(Ingreso.ingreso ingreso, List<Ingreso.detalleingreso> dingreso)
        {
           // MessageBox.Show("hola que paso");
            int retorno=0;
            int idingresoconsulta =0;
            //MySqlTransaction tr = null;
            MySqlConnection conexcion = BDConexcion.obtenerconexcion();

            MySqlTransaction tr = conexcion.BeginTransaction();

            try
            {


                MySqlCommand QuerySqlingreso = new MySqlCommand(string.Format("INSERT INTO ingreso(idproveedor,tipo_comprobante,serie_comprobante,num_comprobante,fecha_hora,impuesto,estado)  VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}')", ingreso.idproveedor, ingreso.tipo_comprobante, ingreso.serie_comprobante, ingreso.num_comprobante, ingreso.fecha_hora, ingreso.impuesto, ingreso.estado), conexcion, tr);
                // idingresoconsulta =(int) QuerySqlingreso.ExecuteScalar();
                //MessageBox.Show("Id ingreso nuevo"+ idingresoconsulta.ToString());
                QuerySqlingreso.ExecuteNonQuery();

                MySqlCommand comando = new MySqlCommand(string.Format("SELECT MAX(idingreso) FROM ingreso"), conexcion,tr);
                // MySqlDataReader reader = comando.ExecuteReader();
                idingresoconsulta = (int)comando.ExecuteScalar();
                MessageBox.Show("id -Z" + idingresoconsulta);


                foreach (Ingreso.detalleingreso dingresos in dingreso)
                {
                   /* MessageBox.Show("idarticulo" + dingresos.idarticulo);
                    MessageBox.Show("cantidad_cajas" + dingresos.cantidad_cajas);
                    MessageBox.Show("pieza_caja" + dingresos.pieza_caja);
                    MessageBox.Show("total_articulos" + dingresos.total_articulos);
                    MessageBox.Show("precio_compra_caja" + dingresos.precio_compra_caja);
                    MessageBox.Show("precio_venta_caja" + dingresos.precio_venta_caja);
                    MessageBox.Show("precio_venta_unidad" + dingresos.precio_venta_unidad);
                    MessageBox.Show("idingreso" + idingresoconsulta);
                    */


                    MySqlCommand QuerySqldingreso = new MySqlCommand(string.Format("INSERT INTO detalle_ingreso(idarticulo,cantidad_cajas,pieza_caja,total_articulos,precio_compra_caja,precio_venta_caja,precio_venta_unidad,idingreso) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", dingresos.idarticulo, dingresos.cantidad_cajas, dingresos.pieza_caja, dingresos.total_articulos, dingresos.precio_compra_caja, dingresos.precio_venta_caja, dingresos.precio_venta_unidad, idingresoconsulta), conexcion, tr);
                    retorno = QuerySqldingreso.ExecuteNonQuery();
                   
                   
                }
                tr.Commit();



            }
            catch (Exception e)
            {
                tr.Rollback();
                
                MessageBox.Show("Error"+e);
                
            }
            finally
            {
                conexcion.Close();
            }
            return retorno;
        }

        private void comboBoxProveedor_MouseClick(object sender, MouseEventArgs e)
        {

        }


        
    }
}
