﻿using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Modelo.Entidades
{
    public class EUsuarios: EPersonas
    {
        public int Id_Usuario { get; set; }
        public Nullable<int> Id_Rol { get; set; }
      //  public Nullable<int> ID_PERSONA { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public Nullable<int> Estado { get; set; }
    }
}
