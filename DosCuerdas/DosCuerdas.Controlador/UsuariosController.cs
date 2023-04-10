using DosCuerdas.Modelo;
using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class UsuariosController
    {
        #region Agregar
        public int Agregar(EUsuarios obj, int? IdUsuario)
        {
            try
            {
                UsuariosModel db = new UsuariosModel();
                return db.Agregar(obj, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EUsuarios obj, int? IdUsuario)
        {
            try
            {
                UsuariosModel db = new UsuariosModel();
                return db.Modificar(obj, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar

        public int Eliminar(int ID, int? IdUsuario)
        {
            try
            {
                UsuariosModel db = new UsuariosModel();
                return db.Eliminar(ID, IdUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar varios.
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
        public EUsuarios Login(string User, string Pass)
        {
            try
            {
                UsuariosModel db = new UsuariosModel();
                return db.Login(User, Pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
