using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentasCS.Ingreso
{
    class detalleingreso
    {
        public int iddetalle_ingreso { get; set; }
        public int idingreso { get; set; }
        public int idarticulo { get; set; }
        public int cantidad_cajas { get; set; }
        public int pieza_caja { get; set; }
        public int total_articulos { get; set; }
        public int precio_compra_caja { get; set; }
        public int precio_venta_caja { get; set; }
        public decimal precio_venta_unidad { get; set; }

        public detalleingreso() { }
        public detalleingreso(int iddetalle_ingreso,int idingreso,int idarticulo ,int cantidad_cajas, int pieza_caja, int total_articulos, int precio_compra_caja, int precio_venta_caja ,decimal precio_venta_unidad )
        {
            this.iddetalle_ingreso = iddetalle_ingreso;
            this.idingreso = idingreso;
            this.idarticulo = idarticulo;
            this.cantidad_cajas = cantidad_cajas;
            this.pieza_caja = pieza_caja;
            this.total_articulos = total_articulos;
            this.precio_compra_caja = precio_compra_caja;
            this.precio_venta_caja = precio_venta_caja;
            this.precio_venta_unidad = precio_venta_unidad;

        }

    }
}
