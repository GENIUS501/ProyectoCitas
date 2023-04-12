using DosCuerdas.Modelo;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class Bitacora_SesionesController
    {
        #region Agregar
        public int Agregar(EBitacora_Sesiones obj)
        {
            try
            {
                Bitacora_SesionesModel db = new Bitacora_SesionesModel();
                return db.Agregar(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EBitacora_Sesiones obj)
        {
            try
            {
                Bitacora_SesionesModel db = new Bitacora_SesionesModel();
                return db.Modificar(obj);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Listar
        public List<EBitacora_Sesiones> Mostrar()
        {
            try
            {
                Bitacora_SesionesModel db = new Bitacora_SesionesModel();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<dynamic> Mostrara()
        {
            try
            {
                Bitacora_SesionesModel db = new Bitacora_SesionesModel();
                return db.Mostrara();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
