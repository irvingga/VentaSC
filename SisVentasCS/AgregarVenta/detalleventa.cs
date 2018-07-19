using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentasCS.AgregarVenta
{
    class detalleventa
    {
        public int iddetalleventa { get; set; }
        public int idventa { get; set; }
        public int idarticulo { get; set; }
        public int cantidad_cajas { get; set; }
        public int cantidad_piezas { get; set; }
        public decimal precio_venta { get; set; }
        public decimal descuento { get; set; }

        public detalleventa() { }

        public detalleventa(int iddetalleventa, int idventa,int idarticulo,int cantidad_cajas, int cantidad_piezas,decimal precio_venta,decimal descuento )
        {
            this.iddetalleventa = iddetalleventa;
            this.idventa = idventa;
            this.idarticulo = idarticulo;
            this.cantidad_cajas = cantidad_cajas;
            this.cantidad_piezas = cantidad_piezas;
            this.precio_venta = precio_venta;
            this.descuento = descuento;
        }

    }
}
