using DosCuerdas.Modelo;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class EstudiantesController
    {
        #region Agregar
        public int Agregar(EEstudiantes obj, int? Usuario)
        {
            try
            {
                EstudiantesModel db = new EstudiantesModel();
                return db.Agregar(obj, Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EEstudiantes obj, int? Idusuario)
        {
            try
            {
                EstudiantesModel db = new EstudiantesModel();
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
                EstudiantesModel db = new EstudiantesModel();
                return db.Eliminar(ID, Idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<EEstudiantes> Mostrar()
        {
            try
            {
                EstudiantesModel db = new EstudiantesModel();
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
