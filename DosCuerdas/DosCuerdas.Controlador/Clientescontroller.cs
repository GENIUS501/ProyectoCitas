using DosCuerdas.Modelo.Entidades;
using DosCuerdas.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DosCuerdas.Controlador
{
    public class Clientescontroller
    {
        #region Agregar
        public int Agregar(EClientes obj, int Usuario)
        {
            try
            {
                ClientesModel db = new ClientesModel();
                return db.Agregar(obj, Usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public int AgregarPermisos(List<EPermisos> obj, int Idrol)
        //{
        //    try
        //    {
        //        DPermisos db = new DPermisos();
        //        return db.Agregar(obj, Idrol);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion

        #region Modificar
        public int Modificar(EClientes obj, int Idusuario)
        {
            try
            {
                ClientesModel db = new ClientesModel();
                return db.Modificar(obj, Idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar
        public int Eliminar(int ID, int Idusuario)
        {
            try
            {
                ClientesModel db = new ClientesModel();
                return db.Eliminar(ID, Idusuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Mostrar
        public List<EClientes> Mostrar()
        {
            try
            {
                ClientesModel db = new ClientesModel();
                return db.Mostrar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public List<EPermisos> llenar_Permisos(int ID)
        //{
        //    try
        //    {
        //        DPermisos db = new DPermisos();
        //        return db.Mostrar(ID);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        //public List<EPermisos> llenar_Permisos(int ID, string Modulo)
        //{
        //    try
        //    {
        //        DPermisos db = new DPermisos();
        //        return db.Mostrar(ID, Modulo);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
        #endregion
    }
}
