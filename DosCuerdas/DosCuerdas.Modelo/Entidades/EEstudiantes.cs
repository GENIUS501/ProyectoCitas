using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Modelo.Entidades
{
    public class EEstudiantes:EPersonas
    {
        public int Id_Estudiante { get; set; }
        public string Sucursal { get; set; }
        public string TipoClase { get; set; }
        public Nullable<System.DateTime> Horario { get; set; }
    }
}
