namespace SisVentasCS.AgregarCategoria
{
    public class Categoria
    {

        public int idcategoria { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public string condicion { get; set; }


        public Categoria(){ }

        public Categoria(int idcategoria,string nombre,string descripcion,string condicion)
        {
            this.idcategoria = idcategoria;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.condicion = condicion;
        }
    }
}
