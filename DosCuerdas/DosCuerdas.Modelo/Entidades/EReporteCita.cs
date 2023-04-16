using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Modelo.Entidades
{
    public class EReporteCita
    {
        public int IDCITA { get; set; }
        public string HORA_CITA { get; set; }
        public double DURACION { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FECHACITA { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public string Profesor { get; set; }
        public string Estudiante { get; set; }
    }
}
