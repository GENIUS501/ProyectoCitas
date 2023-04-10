using DosCuerdas.Modelo;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class ProfesoresController
    {
        #region Agregar
        public int Agregar(EProfesores obj, int? Usuario)
        {
            try
            {
                ProfesoresModel db = new ProfesoresModel();
                return db.Agregar(obj, Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EProfesores obj, int? Idusuario)
        {
            try
            {
                ProfesoresModel db = new ProfesoresModel();
                return db.Modificar(obj, Idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar
        public int Eliminar(int ID, int? Idusuario)
        {
            try
            {
                ProfesoresModel db = new ProfesoresModel();
                return db.Eliminar(ID, Idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<EProfesores> Mostrar()
        {
            try
            {
                ProfesoresModel db = new ProfesoresModel();
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
