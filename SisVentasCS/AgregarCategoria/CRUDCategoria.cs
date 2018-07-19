
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace SisVentasCS.AgregarCategoria
{
    class CRUDCategoria
    {
        //Conescion ala base de datos 

      

        public static int AgregarCategoria(Categoria categoria)
        {
            int retorno = 0;

            MySqlCommand SqlComando = new MySqlCommand(string.Format("INSERT INTO categoria(idcategoria,nombre,descripcion,condicion) values('{0}','{1}','{2}','{3}') ",categoria.idcategoria,categoria.nombre,categoria.descripcion,categoria.condicion),BDConexcion.obtenerconexcion());
           retorno  = SqlComando.ExecuteNonQuery();

            return retorno;
        }

        public static List<Categoria> Llenarlista()
        {
            List<Categoria> lista = new List<Categoria>();
            Categoria categoriaB = new Categoria();
            MySqlCommand SqlComando = new MySqlCommand(string.Format("SELECT * from categoria "),BDConexcion.obtenerconexcion());
            MySqlDataReader reader = SqlComando.ExecuteReader();
            do
            {
                reader.Read();
                categoriaB.idcategoria = reader.GetInt32(0);
                categoriaB.nombre = reader.GetString(1);
                categoriaB.descripcion = reader.GetString(2);
                categoriaB.condicion = reader.GetString(3);
                lista.Add(categoriaB);
                
            }
            while (reader.NextResult());
           



            return lista;
        }
        public static List<Categoria> LlenarlistaNombre(string nombre)
        {
            List<Categoria> lista = new List<Categoria>();
            Categoria categoriaB = new Categoria();
            MySqlCommand SqlComando = new MySqlCommand(string.Format("SELECT * from categoria WHERE nombre='{0}'",nombre), BDConexcion.obtenerconexcion());
            MySqlDataReader reader = SqlComando.ExecuteReader();

            
                reader.Read();
                categoriaB.idcategoria = reader.GetInt32(0);
                categoriaB.nombre = reader.GetString(1);
                categoriaB.descripcion = reader.GetString(2);
                categoriaB.condicion = reader.GetString(3);

                lista.Add(categoriaB);

            



            return lista;
        }

        public static AgregarCategoria.Categoria categoriaespecifica(int id)
        {
            Categoria categoriaSelecionada = new Categoria();
            MySqlCommand SqlComando = new MySqlCommand(string.Format("SELECT * from categoria WHERE idcategoria='{0}'", id), BDConexcion.obtenerconexcion());
            MySqlDataReader reader = SqlComando.ExecuteReader();
            reader.Read();
            categoriaSelecionada.idcategoria = reader.GetInt32(0);
            categoriaSelecionada.nombre = reader.GetString(1);
            categoriaSelecionada.descripcion = reader.GetString(2);
            categoriaSelecionada.condicion = reader.GetString(3);


            return categoriaSelecionada;
        }

        public static int Actualizar(Categoria categoria)
        {
            int retorno = 0;

            MySqlCommand SqlComando = new MySqlCommand(string.Format("UPDATE categoria set nombre='{0}',descripcion='{1}',condicion='{2}' WHERE idcategoria='{3}'",categoria.nombre,categoria.descripcion,categoria.condicion,categoria.idcategoria),BDConexcion.obtenerconexcion());
            retorno = SqlComando.ExecuteNonQuery();

            BDConexcion.obtenerconexcion().Close();

            return retorno;
        }

        public static int Eliminar(int id)
        {
            int retorno = 0;
            MySqlCommand Sqlcomando = new MySqlCommand(string.Format("DELETE FROM categoria WHERE idcategoria='{0}'",id),BDConexcion.obtenerconexcion());
            retorno = Sqlcomando.ExecuteNonQuery();
            BDConexcion.obtenerconexcion().Close();
            return retorno;
        }



    }
}
