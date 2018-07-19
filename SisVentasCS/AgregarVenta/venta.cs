using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentasCS.AgregarVenta
{
    class venta
    {
        public int idventa { get; set; }
        public int idcliente { get; set; }
        public string tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }
        public string num_comprobante { get; set; }
        public string fecha_hora { get; set; }
        public decimal impuesto { get; set; }
        public decimal total_venta { get; set; }
        public string estado { get; set; }

        public venta() { }
        public venta(int idventa,int idcliente,string tipo_comprobante,string serie_comprobante,string num_comprobante, string fecha_hora,decimal impuesto,decimal total_venta,string estado)
        {
            this.idventa = idventa;
            this.idcliente = idcliente;
            this.tipo_comprobante = tipo_comprobante;
            this.serie_comprobante = serie_comprobante;
            this.num_comprobante = num_comprobante;
            this.fecha_hora = fecha_hora;
            this.impuesto = impuesto;
            this.total_venta = total_venta;
            this.estado = estado;
        }

    }
}
