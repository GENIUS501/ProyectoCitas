using DosCuerdas.Modelo;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class PersonasController
    {
        public List<EPersonas> Mostrar()
        {
            try
            {
                PersonasModel db = new PersonasModel();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
