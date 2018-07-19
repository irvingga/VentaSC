using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentasCS.AgregarProducto
{
    public class Articulo
    {

        public int idarticulo { get; set; }
        public int idcategoria { get; set; }
        public string codigo { get; set; }
        public int stock_menudeo { get; set; }
        public int stock_mayoreo { get; set; }
        public string nombre { get; set; }
        public string presentacion { get; set; }
        public string descripcion { get; set; }
        public string imagen { get; set; }
        public string estado { get; set; }
       


        public Articulo()
        {

        }

        public Articulo(int idarticulo, int idcategoria, string codigo, int stock_menudeo, int stock_mayoreo, string nombre, string presentacion, string descripcion, string imagen, string estado)
        {
            this.idarticulo = idarticulo;
            this.idcategoria = idcategoria;
            this.codigo = codigo;
            this.stock_menudeo = stock_menudeo;
            this.stock_mayoreo = stock_mayoreo;
            this.nombre = nombre;
            this.presentacion = presentacion;
            this.descripcion = descripcion;
            this.imagen = imagen;
            this.estado = estado;

        }

    }
}
