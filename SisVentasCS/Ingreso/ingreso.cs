using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisVentasCS.Ingreso
{
    class ingreso
    {
        public int idingreso { get; set; }
        public int idproveedor { get; set; }
        public string tipo_comprobante { get; set; }
        public string serie_comprobante { get; set; }
        public string num_comprobante { get; set; }
        public string fecha_hora { get; set; }
        public decimal impuesto { get; set; }
        public string estado { get; set; }


        public ingreso() { }

        public ingreso(int idingreso,int idproveedor, string tipo_comprobante, string serie_comprobante, string num_comprobante,string fecha_hora,decimal impuesto, string estado)
        {

            this.idingreso = idingreso;
            this.idproveedor = idproveedor;
            this.tipo_comprobante = tipo_comprobante;
            this.serie_comprobante = serie_comprobante;
            this.num_comprobante = num_comprobante;
            this.fecha_hora = fecha_hora;
            this.impuesto = impuesto;
            this.estado = estado;
        }



    }
}
