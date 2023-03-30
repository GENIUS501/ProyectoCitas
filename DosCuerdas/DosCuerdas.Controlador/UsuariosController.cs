using DosCuerdas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class UsuariosController
    {
        public List<EUsuarios> Mostrar()
        {
            try
            {
                UsuariosModel db = new UsuariosModel();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
