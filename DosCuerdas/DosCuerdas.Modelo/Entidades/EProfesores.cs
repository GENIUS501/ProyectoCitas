using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Modelo.Entidades
{
    public class EProfesores:EPersonas
    {
        public int Id_Profesor { get; set; }
        public string Profesion { get; set; }
        public string instrumento { get; set; }
    }
}
