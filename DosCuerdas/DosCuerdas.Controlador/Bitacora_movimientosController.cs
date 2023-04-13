using DosCuerdas.Modelo;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class Bitacora_movimientosController
    {
        public List<EReporteBitacoraMovimientos> Mostrar()
        {
            try
            {
                DBitacora_movimientos db = new DBitacora_movimientos();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
