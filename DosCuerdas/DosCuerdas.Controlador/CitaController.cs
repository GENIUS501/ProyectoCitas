using DosCuerdas.Modelo;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class CitaController
    {
        #region Agregar
        public int Agregar(ECita obj, int? Usuario)
        {
            try
            {
                CitaModel db = new CitaModel();
                return db.Agregar(obj, Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(ECita obj, int? Idusuario)
        {
            try
            {
                CitaModel db = new CitaModel();
                return db.Modificar(obj, Idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<EReporteCita> Mostrar()
        {
            try
            {
                CitaModel db = new CitaModel();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
