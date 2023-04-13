using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Modelo.Entidades
{
    public class EReporteBitacoraIngresos
    {
        public int codigo_ingreso_salida { get; set; }
        public System.DateTime fecha_hora_ingreso { get; set; }
        public Nullable<System.DateTime> fecha_hora_salida { get; set; }
        public string Usuario { get; set; }
    }
}
