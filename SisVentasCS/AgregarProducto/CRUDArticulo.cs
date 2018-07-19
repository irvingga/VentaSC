using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;
using System.Data;

namespace SisVentasCS.AgregarProducto
{
    class CRUDArticulo
    {
        public void conexionBD()
        {
           BDConexcion.obtenerconexcion();
        }

        public static int addarticulo(Articulo articulo)
        {

            int retorno = 0;
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO articulo (idcategoria,codigo,stock_menudeo, stock_mayoreo, nombre,presentacion,descripcion,imagen, estado) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}')",
                articulo.idcategoria, articulo.codigo, articulo.stock_menudeo, articulo.stock_mayoreo, articulo.nombre, articulo.presentacion, articulo.descripcion, articulo.imagen, articulo.estado), BDConexcion.obtenerconexcion());
            retorno = comando.ExecuteNonQuery();
            return retorno;

        }

        public DataTable TodosArticulos()
        {

            DataTable tabla = new DataTable();

            MySqlCommand comandoListarClientes = new MySqlCommand(string.Format("SELECT a.idarticulo as Articulo,a.nombre as Producto ,c.nombre as Categoria ,a.codigo as Codigo,a.presentacion as Presentacion ,a.descripcion as Descripcion ,a.estado as Estado FROM articulo a,categoria c  where (a.estado ='activo' and  a.idcategoria = c.idcategoria)"), BDConexcion.obtenerconexcion());
            comandoListarClientes.ExecuteNonQuery();
            Articulo articulo = new Articulo();
            MySqlDataReader reader = comandoListarClientes.ExecuteReader();
            //El Execute Reader nos devuelve filas
            tabla.Load(reader);
            BDConexcion.cerrarconexcion();

            return tabla;

        }

        //Buscar el cliente selecionado 
        public static Articulo articludoespecifico(int id)
        {
            Articulo articuloselecionado = new Articulo();
            MySqlCommand comand = new MySqlCommand(string.Format("SELECT idcategoria,codigo,nombre,presentacion,descripcion,estado FROM articulo where idarticulo='{0}'", id), BDConexcion.obtenerconexcion());
            MySqlDataReader reader = comand.ExecuteReader();

            while (reader.Read())
            {
                articuloselecionado.idcategoria = reader.GetInt32(0);
                articuloselecionado.codigo = reader.GetString(1);
                articuloselecionado.nombre = reader.GetString(2);
                articuloselecionado.presentacion = reader.GetString(3);
                articuloselecionado.descripcion = reader.GetString(4);
                // articuloselecionado.imagen = reader.GetString(5);
                articuloselecionado.estado = reader.GetString(5);

            }
            return articuloselecionado;
        }

        public static MySqlDataReader Categorias()
        {

            MySqlCommand comandoadapter = new MySqlCommand(string.Format("SELECT * FROM categoria"), BDConexcion.obtenerconexcion());
            MySqlDataReader reader = comandoadapter.ExecuteReader();

            return reader;
        }

        public static int ActualizarArticulo(Articulo articuloM)
        {
            int retorno = 0;

            MySqlConnection conextar = BDConexcion.obtenerconexcion();


            MySqlCommand SqlQueryComando = new MySqlCommand(string.Format("UPDATE articulo set idcategoria='{0}',codigo='{1}',stock_menudeo='{2}', stock_mayoreo='{3}', nombre='{4}',presentacion='{5}',descripcion='{6}',imagen='{7}', estado='{8}' WHERE idarticulo='{9}'", articuloM.idcategoria, articuloM.codigo, articuloM.stock_menudeo, articuloM.stock_mayoreo, articuloM.nombre, articuloM.presentacion, articuloM.descripcion, articuloM.imagen, articuloM.estado, articuloM.idarticulo), conextar);
            retorno = SqlQueryComando.ExecuteNonQuery();
            conextar.Close();

            return retorno;
        }

        public static int EliminarArticulo(int Id)
        {
            MySqlConnection conectar = BDConexcion.obtenerconexcion();
            int retorno = 0;
            MySqlCommand SqlComandoEliminar = new MySqlCommand(string.Format("DELETE FROM articulo WHERE idarticulo='{0}'", Id), conectar);
            retorno = SqlComandoEliminar.ExecuteNonQuery();
            conectar.Close();
            return retorno;
        }

        public static MySqlDataReader TodosArticulosLista()
        {

            List<Articulo> lista = new List<Articulo>();

            MySqlCommand comandoListarClientes = new MySqlCommand(string.Format("SELECT idarticulo,nombre FROM articulo  where estado ='Activo'"), BDConexcion.obtenerconexcion());
            //comandoListarClientes.ExecuteNonQuery();

            MySqlDataReader Reader = comandoListarClientes.ExecuteReader();


            return Reader;

        }

        /*
          public static List<Articulo> TodosArticulos(string parametro)
        {

           List<Articulo> lista = new List<Articulo>();

            MySqlCommand comandoListarClientes = new MySqlCommand(string.Format("SELECT idarticulo,idcategoria,codigo,stock_menudeo,stock_mayoreo,nombre,presentacion,descripcion,estado FROM articulo where nombre ='{0}' or codigo='{0}'",parametro), BDConexcion.obtenerconexcion());
            comandoListarClientes.ExecuteNonQuery();
           Articulo articulo = new Articulo();
            MySqlDataReader reader = comandoListarClientes.ExecuteReader();
             do
             {while(reader.Read())
                 articulo.idarticulo = reader.GetInt32(0);
                 articulo.idcategoria = reader.GetInt32(1);
                 articulo.codigo = reader.GetString(2);
                 articulo.stock_menudeo = reader.GetInt32(3);
                 articulo.stock_mayoreo = reader.GetInt32(4);
                 articulo.nombre = reader.GetString(5);
                 articulo.presentacion = reader.GetString(6);
                 articulo.descripcion = reader.GetString(7);
                // byte[] avatarByte = (byte[])reader["imagen"];
                 //MemoryStream ms = new MemoryStream();
                 //Image devolverImagen = Image.FromStream(ms);
                 //return devolverImagen;
                 //MemoryStream ms2 = new MemoryStream(avatarByte);


                //Image devolverImagen = Image.FromStream(ms2);

                 //articulo.imagen =  avatarByte;
                 // articulo.imagen = reader.GetString(8);

                 articulo.estado = reader.GetString(8);


                 lista.Add(articulo);

             }
             while (reader.NextResult());

                 //reader.NextResult();


             reader.Close();

             return lista;
            
        }

         */
        
    }

   
}
