using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using DosCuerdas.Modelo.Entidades;
using System.Transactions;
using System.Data.Entity;

namespace DosCuerdas.Modelo
{
    public class UsuariosModel
    {
        DosCuerdasEntities db = new DosCuerdasEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EUsuarios obj, int? Id_Usuario)
        {
            try
            {
                PersonasModel personasModel = new PersonasModel();
                var PersonaExiste = personasModel.Mostrar().Where(x => x.Cedula == obj.Cedula).FirstOrDefault();
                int IdPersona = 0;
                if (PersonaExiste != null)
                {
                    IdPersona = PersonaExiste.ID_PERSONA;
                }
                else
                {
                    IdPersona = personasModel.Agregar(obj);
                }
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Existente = db.Usuarios.Where(x => x.Id_Usuario == obj.Id_Usuario && x.ID_PERSONA == obj.ID_PERSONA).FirstOrDefault();
                    if (Existente != null)
                    {
                        Ts.Dispose();
                        throw new Exception("El usuario ya existe.");
                    }
                    Usuarios Objbd = new Usuarios();
                    Objbd.ID_PERSONA = IdPersona;
                    Objbd.Usuario = obj.Usuario;
                    Objbd.Contrasena = obj.Contrasena;
                    Objbd.Id_Rol = obj.Id_Rol;
                    Objbd.Estado = 1;
                    db.Entry(Objbd).State = EntityState.Added;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Usuarios";
                        //Entidad_Movimientos.tipo_movimiento = "Agregar";
                        //Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        //Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    else
                    {
                        Ts.Dispose();
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Modificar
        public int Modificar(EUsuarios obj, int? Id_Usuario)
        {
            try
            {
                PersonasModel personasModel = new PersonasModel();
                personasModel.Modificar(obj);
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Usuarios.Where(x => x.Id_Usuario == obj.Id_Usuario).FirstOrDefault();
                    Objbd.Id_Usuario = obj.Id_Usuario;
                    Objbd.ID_PERSONA = obj.ID_PERSONA;
                    Objbd.Usuario = obj.Usuario;
                    Objbd.Id_Rol = obj.Id_Rol;
                    if (obj.Contrasena == "********")
                    {

                    }
                    else
                    {
                        Objbd.Contrasena = obj.Contrasena;
                    }
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Usuarios";
                        //Entidad_Movimientos.tipo_movimiento = "Modificar";
                        //Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        //Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    Ts.Dispose();
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Eliminar
        public int Eliminar(int ID, int? Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Usuarios.Where(x => x.Id_Usuario == ID).FirstOrDefault();
                    Objbd.Estado = 0;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Usuarios";
                        //Entidad_Movimientos.tipo_movimiento = "Eliminar";
                        //Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        //Movimientos.Agregar(Entidad_Movimientos);
                        return Resultado;
                    }
                    Ts.Dispose();
                    return Resultado;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Mostrar varios
        public List<EUsuarios> Mostrar()
        {
            try
            {
                List<EUsuarios> Lista = new List<EUsuarios>();
                Lista = db.Usuarios
                .Select(x => new EUsuarios
                {
                    ID_PERSONA = x.Personas.ID_PERSONA,
                    Cedula = x.Personas.Cedula,
                    Nombre = x.Personas.Nombre,
                    PrimerApellido = x.Personas.PrimerApellido,
                    SegundoApellido = x.Personas.SegundoApellido,
                    Genero = x.Personas.Genero,
                    FechaNacimiento = x.Personas.FechaNacimiento,
                    Correo = x.Personas.Correo,
                    Telefono = x.Personas.Telefono,
                    TelefonoAdisional = x.Personas.TelefonoAdisional,
                    Usuario = x.Usuario,
                    Contrasena = x.Contrasena,
                    Id_Rol = x.Id_Rol,
                    Id_Usuario = x.Id_Usuario,
                    Estado = x.Estado
                }).Where(j => j.Estado == 1).ToList();
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion

        #region Login
        public EUsuarios Login(string User, string Pass)
        {
            try
            {
                EUsuarios Obj = new EUsuarios();
                Obj = db.Usuarios
                .Select(x => new EUsuarios
                {
                    ID_PERSONA = x.Personas.ID_PERSONA,
                    Cedula = x.Personas.Cedula,
                    Nombre = x.Personas.Nombre,
                    PrimerApellido = x.Personas.PrimerApellido,
                    SegundoApellido = x.Personas.SegundoApellido,
                    Genero = x.Personas.Genero,
                    FechaNacimiento = x.Personas.FechaNacimiento,
                    Correo = x.Personas.Correo,
                    Telefono = x.Personas.Telefono,
                    TelefonoAdisional = x.Personas.TelefonoAdisional,
                    Usuario = x.Usuario,
                    Contrasena = x.Contrasena,
                    Id_Rol = x.Id_Rol,
                    Id_Usuario = x.Id_Usuario,
                    Estado = x.Estado
                }).Where(x => x.Usuario == User && x.Contrasena == Pass && x.Estado == 1).FirstOrDefault();
                return Obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}
