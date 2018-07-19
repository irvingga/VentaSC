using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WL;

namespace SisVentasCS
{
    public partial class PrincipalMenu : Form
    {
        Tickets ticket1 = new Tickets();
        public PrincipalMenu()
        {
            InitializeComponent();
           
            
             
            dataGridViewVentaS.Columns.Add("id", "Id");
            dataGridViewVentaS.Columns.Add("idarticulo", "Articulo");
            dataGridViewVentaS.Columns.Add("cantidad_cajas", "cantidad_cajas");
            dataGridViewVentaS.Columns.Add("cantidad_pieza", "cantidad_pieza");

            dataGridViewVentaS.Columns.Add("precio_venta", "precio_venta");
            dataGridViewVentaS.Columns.Add("total", "total");
            dataGridViewVentaS.Columns.Add("descuento", "descuento");
            
        }

        public PrincipalMenu( string nombre,string apellido, string cargo, string email)
        {
            InitializeComponent();
            if(cargo=="administrador")
            {
                groupBoxAdminReport.Visible = true;
            }
            else
            {
                groupBoxAdminReport.Visible = false;
            }

            labelNombre.Text = nombre;
            labelApellido.Text = apellido;
            labelEmail.Text = email;
            labelTipoUsuario.Text = cargo;
        }
        int idClientecombobox;
        DataTable dtarticulo;
        int idArticulo;
        string subcadena = "";
        int unidadesxcaja;
        int cajasventa;
        int unidadesventa;
        decimal precioventaunidad;
        decimal precioventacajas;
        decimal TotalVenta;
        int CantidadpiezaVentaEnData = 0;
        List<AgregarVenta.detalleventa> listaDVenta = new List<AgregarVenta.detalleventa>();
        private void llamadoclientes()
        {
            List<string> lista = new List<string>();

            MySqlDataReader reader = AgregarVenta.CRUDVenta.ConsultaCliente();
            while (reader.Read())
            {
                // articuloselecionado.idcategoria = reader.GetInt32(0);
                MessageBox.Show(reader.GetString(0));

                lista.Add(reader.GetString(0) + "-" + reader.GetString(1));


            }
            comboBoxcliente.DataSource = lista;




        }

        private void btnAddArticulo_Click(object sender, EventArgs e)
        {
            AddArticulo ventanaarticulo = new AddArticulo();
            ventanaarticulo.ShowDialog();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AddCategoria ventanaCategoria = new AddCategoria();
            ventanaCategoria.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comprararticulo ingreso = new comprararticulo();
            ingreso.ShowDialog();
        }

        private void comboBoxcliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            string simbolo = "-";
            int index = comboBoxcliente.Text.IndexOf(simbolo);
           // MessageBox.Show("index Of "+index );
            string subcadena = comboBoxcliente.Text.Substring(0, index);
             idClientecombobox= int.Parse(subcadena);
        }

        private void PrincipalMenu_Load(object sender, EventArgs e)
        {
            MySqlDataReader Reader = AgregarVenta.CRUDVenta.TodosArticulosLista();

            while (Reader.Read())
            {

                dtarticulo = new DataTable();

                dtarticulo.Columns.Add("nombre", typeof(string));
                while (Reader.Read())
                {
                    //Esta forma es oara agrrgar a un lisbox atrabes de la creaion de una tabla y luego asignarcela

                  
                    dtarticulo.Rows.Add(Reader.GetString(1) +"_"+ Reader.GetString(2));

                }

                Reader.NextResult();
                // listBox1.DisplayMember = "nombre";//Esto es para llenar el listbox por medio de Items
                //listBox1.Items.Add(Reader.GetString(1));
                //Reader.NextResult(); //debemos checar bien que sucedd con esto

            }
            Reader.Close();
            listBox1.DataSource = dtarticulo;
            listBox1.DisplayMember = "nombre";

            //carcargCombo();
           // llamadoclientes();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dvArticulo = dtarticulo.DefaultView;
            dvArticulo.RowFilter = "nombre LIKE '%" + txtSearch.Text + "%'";
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            DataRowView drv = (DataRowView)listBox1.SelectedItem;
            String valueOfItem = drv["nombre"].ToString();

            txtSearch.Text = valueOfItem;

           

            string simbolo = "_";
            int index = listBox1.Text.IndexOf(simbolo);

            subcadena = listBox1.Text.Substring(0, index);
            //MessageBox.Show("Es el nomnbre " +subcadena );
            ConsultaArtDescripcion(subcadena);
        }
        private void ConsultaArtDescripcion(string nombre)
        {
            MySqlDataReader reader = Ingreso.CRUDIngreso.articludoespecifico(nombre);
            while (reader.Read())
            {

                txtstock.Text = reader.GetString(2);
                
                idArticulo = reader.GetInt32(0);
            }
            unidadesXarticulo();
        }

        private void unidadesXarticulo ()
            {
            try
            {
                MySqlDataReader reader = Ingreso.CRUDIngreso.unidadesXarticulo(idArticulo);
                while (reader.Read())
                {
                    unidadesxcaja = reader.GetInt32(1);
                    precioventacajas = reader.GetDecimal(2);
                    precioventaunidad = reader.GetDecimal(3);
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show("Error" + e);

            }
           
            }

        private void txtcantidad_cajas_TextChanged(object sender, EventArgs e)
        {
           
           
        }

        private void btnAgragarArticuloVenta_Click(object sender, EventArgs e)
        {

            if (radioButtonBulto.Checked)
            {
                CantidadpiezaVentaEnData = int.Parse(txtcantidad_cajas.Text) * unidadesxcaja;
                cajasventa = int.Parse(txtcantidad_cajas.Text);
                unidadesventa = 0;
                TotalVenta = cajasventa * precioventacajas;

                int id = idArticulo;
                string nombre = subcadena;
                int cajas = cajasventa;
                int unidades = CantidadpiezaVentaEnData;
                decimal precio = Convert.ToDecimal(txtprecio_venta.Text);
                decimal TotalVentaAdd = TotalVenta;
                decimal desceunto = int.Parse(txtdesceunto.Text);


                dataGridViewVentaS.Rows.Add(id, nombre, cajas, unidades, precio, TotalVenta, desceunto);

            }
            else
            {
                if (radioButtonUnidades.Checked)
                {
                    unidadesventa = int.Parse(txtcantidad_cajas.Text);
                    cajasventa = 0;
                    TotalVenta = unidadesventa * precioventaunidad;
                    int id = idArticulo;
                    string nombre = subcadena;
                    int cajas = cajasventa;
                    int unidades = unidadesventa;
                    decimal precio = Convert.ToDecimal(txtprecio_venta.Text);
                    decimal TotalVentaAdd = TotalVenta;
                    decimal desceunto = int.Parse(txtdesceunto.Text);


                    dataGridViewVentaS.Rows.Add(id, nombre, cajas, unidades, precio, TotalVenta, desceunto);
                }
                else
                {
                    MessageBox.Show("Selecione el tipo de venta");
                }
            }
          

            SumaTotal();

          

        }

        private void radioButtonBulto_Click(object sender, EventArgs e)
        {
            txtprecio_venta.Text = precioventacajas.ToString();
           
    }

        private void radioButtonUnidades_Click(object sender, EventArgs e)
        {
            txtprecio_venta.Text = precioventaunidad.ToString();
        }

        private void btnhacerventa_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show("" + DateTime.Now.ToString("hh:mm:ss"));
            MessageBox.Show("" + DateTime.Now.ToString("dd/MM/yyyy") );

            AgregarVenta.venta venta = new AgregarVenta.venta();
            venta.idcliente = idClientecombobox;
            venta.tipo_comprobante = txtcomprovante.Text;
            venta.serie_comprobante = txtseria_comprobante.Text;
            venta.num_comprobante = txtnumerocomprovante.Text;
            venta.fecha_hora =  DateTime.Now.ToString("hh:mm:ss") + DateTime.Now.ToString("dd/MM/yyyy");
            venta.impuesto = Convert.ToDecimal( .001);
            venta.total_venta = Convert.ToDecimal(labelTotal.Text);
            venta.estado = "paso";


            for (int fila = 0; fila < dataGridViewVentaS.Rows.Count - 1; fila++)
            {
                AgregarVenta.detalleventa detalleventa = new AgregarVenta.detalleventa();

            
                detalleventa.idarticulo = int.Parse(dataGridViewVentaS.Rows[fila].Cells["id"].Value.ToString());
                detalleventa.cantidad_cajas = int.Parse(dataGridViewVentaS.Rows[fila].Cells["cantidad_cajas"].Value.ToString());
                detalleventa.cantidad_piezas = int.Parse(dataGridViewVentaS.Rows[fila].Cells["cantidad_pieza"].Value.ToString());
                detalleventa.precio_venta = Convert.ToDecimal (dataGridViewVentaS.Rows[fila].Cells["precio_venta"].Value.ToString());
                detalleventa.descuento =  Convert.ToDecimal (dataGridViewVentaS.Rows[fila].Cells["descuento"].Value.ToString());


                listaDVenta.Add(detalleventa);
                
            }

            int retotno = Registrar(venta,listaDVenta);
            MessageBox.Show("" + retotno);

        }

        private static int Registrar(AgregarVenta.venta venta, List<AgregarVenta.detalleventa> detalleVenta)
        {
            // MessageBox.Show("hola que paso");
            int retorno = 0;
            int idventaconsulta = 0;
            //MySqlTransaction tr = null;
            MySqlConnection conexcion = BDConexcion.obtenerconexcion();

            MySqlTransaction tr = conexcion.BeginTransaction();

            try
            {


                MySqlCommand QuerySqlingreso = new MySqlCommand(string.Format("INSERT INTO venta(idcliente,tipo_comprobante,serie_comprobante,num_comprobante,fecha_hora,impuesto,total_venta,estado)  VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", venta.idcliente, venta.tipo_comprobante, venta.serie_comprobante, venta.num_comprobante, venta.fecha_hora, venta.impuesto, venta.total_venta, venta.estado), conexcion, tr);
                // idingresoconsulta =(int) QuerySqlingreso.ExecuteScalar();
                //MessageBox.Show("Id ingreso nuevo"+ idingresoconsulta.ToString());
                QuerySqlingreso.ExecuteNonQuery();

                MySqlCommand comando = new MySqlCommand(string.Format("SELECT MAX(idventa) FROM venta"), conexcion, tr);
                // MySqlDataReader reader = comando.ExecuteReader();
                idventaconsulta = (int)comando.ExecuteScalar();
               


                foreach (AgregarVenta.detalleventa dv in detalleVenta)
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


                    MySqlCommand QuerySqldingreso = new MySqlCommand(string.Format("INSERT INTO detalle_venta(idarticulo,cantidad_cajas,cantidad_pieza,precio_venta,descuento,idventa) VALUES('{0}','{1}','{2}','{3}','{4}','{5}')", dv.idarticulo, dv.cantidad_cajas, dv.cantidad_piezas, dv.precio_venta,dv.descuento,idventaconsulta), conexcion, tr);
                    retorno = QuerySqldingreso.ExecuteNonQuery();


                }
                tr.Commit();



            }
            catch (Exception e)
            {
                tr.Rollback();

                MessageBox.Show("Error" + e);

            }
            finally
            {
                conexcion.Close();
            }
            return retorno;
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridViewVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //llamar al metodo fila
            int fila = dataGridViewVentaS.CurrentCell.RowIndex;//llamar atrael el idice de la columna seleccionada
            if(fila!=0)
            {
                dataGridViewVentaS.Rows.RemoveAt(fila);
                SumaTotal();
            }else
            {
                MessageBox.Show("Ya no puedes eliminar mas filas");
            }
           
        }


        public void SumaTotal()
        {

            decimal suma = 0;

            for (int fila = 0; fila < dataGridViewVentaS.Rows.Count - 1; fila++)
            {
                suma = suma + Convert.ToDecimal(dataGridViewVentaS.Rows[fila].Cells["total"].Value.ToString());
            }

            labelTotal.Text = suma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // cargartikect();
            //ticket1.VistaPrevia();
        }

        private void cargartikect()
        {

            ticket1.Logo("buy.png");
            ticket1.Titulo("TITULO DE PRUEBA");
            ticket1.Encabezado("DIRECCION");
            ticket1.Encabezado("CIUDAD CODIGO POSTAL");
            ticket1.Encabezado("RFC: ABC12345678");
            ticket1.Encabezado("FECHA: " + DateTime.Now.ToShortDateString());


            for (int fila = 0; fila < dataGridViewVentaS.Rows.Count - 1; fila++)
            {



                ticket1.Articulo(dataGridViewVentaS.Rows[fila].Cells["Articulo"].Value.ToString(), dataGridViewVentaS.Rows[fila].Cells["cantidad_cajas"].Value.ToString(), dataGridViewVentaS.Rows[fila].Cells["cantidad_pieza"].Value.ToString(), dataGridViewVentaS.Rows[fila].Cells["precio_venta"].Value.ToString(), dataGridViewVentaS.Rows[fila].Cells["total"].Value.ToString());
                


                

            }
            /* ticket1.Articulo("123456789", "1 PZ", "ARTICULO DE PRUEBA NUMERO UNO", "10", "10");
             * 
             ticket1.Articulo("123453254", "2 PZ", "ARTICULO DE PRUEBA NUMERO DOS", "15", "30");*/
            ticket1.NumArticulos("2");
            ticket1.Total("40");
            ticket1.Pago("EFECTIVO:", "10");
            ticket1.Pago("DOLARES ($18.50) :", "0");
            ticket1.Pago("TARJETA:", "10");
            ticket1.Pago("VALES:", "20");
            ticket1.Pago("CAMBIO:", "0");
            ticket1.Pie("=================================================");
            ticket1.Pie("GRACIAS POR SU PREFERENCIA!!");
        }
    }
    }
