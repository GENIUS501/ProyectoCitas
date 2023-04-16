using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Modelo.Entidades
{
    public class ECita
    {
        public int IDCITA { get; set; }
        public string HORA_CITA { get; set; }
        public double DURACION { get; set; }
        public string ESTADO { get; set; }
        public System.DateTime FECHACITA { get; set; }
        public string Observaciones { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Profesor { get; set; }
        public int Id_Estudiante { get; set; }
    }
}
