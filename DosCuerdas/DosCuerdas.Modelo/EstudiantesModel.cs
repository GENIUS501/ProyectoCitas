using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DosCuerdas.Modelo
{
    public class EstudiantesModel
    {
        DosCuerdasEntities db = new DosCuerdasEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EEstudiantes obj, int? Id_Usuario)
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
                    var EstudianteExistente = db.Estudiantes.Where(x => x.Id_Estudiante == obj.Id_Estudiante && x.ID_PERSONA == obj.ID_PERSONA).FirstOrDefault();
                    if (EstudianteExistente != null)
                    {
                        Ts.Dispose();
                        throw new Exception("El estudiante ya existe.");
                    }
                    Estudiantes Objbd = new Estudiantes();
                    Objbd.ID_PERSONA = IdPersona;
                    Objbd.Horario = obj.Horario;
                    Objbd.Sucursal = obj.Sucursal;
                    Objbd.TipoClase = obj.TipoClase;
                    db.Entry(Objbd).State = EntityState.Added;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Estudiantes";
                        Entidad_Movimientos.tipo_movimiento = "Agregar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
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
        public int Modificar(EEstudiantes obj, int? Id_Usuario)
        {
            try
            {
                PersonasModel personasModel = new PersonasModel();
                personasModel.Modificar(obj);
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Estudiantes.Where(x => x.Id_Estudiante == obj.Id_Estudiante).FirstOrDefault();
                    Objbd.ID_PERSONA = obj.ID_PERSONA;
                    Objbd.Horario = obj.Horario;
                    Objbd.Sucursal = obj.Sucursal;
                    Objbd.TipoClase = obj.TipoClase;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Estudiantes";
                        Entidad_Movimientos.tipo_movimiento = "Modificar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
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
                    var Objbd = db.Estudiantes.Where(x => x.Id_Estudiante == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Estudiantes";
                        Entidad_Movimientos.tipo_movimiento = "Eliminar";
                        Entidad_Movimientos.fecha_hora_movimiento = DateTime.Now;
                        Movimientos.Agregar(Entidad_Movimientos);
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

        #region Mostrar
        public List<EEstudiantes> Mostrar()
        {
            try
            {
                var Objbd = db.Estudiantes.ToList();
                List<EEstudiantes> Lista = new List<EEstudiantes>();
                if (Objbd.Count() > 0)
                {
                    Lista = Objbd
                    .Select(Item => new EEstudiantes
                    {
                        ID_PERSONA = Item.Personas.ID_PERSONA,
                        Id_Estudiante = Item.Id_Estudiante,
                        Cedula = Item.Personas.Cedula,
                        Nombre = Item.Personas.Nombre,
                        PrimerApellido = Item.Personas.PrimerApellido,
                        SegundoApellido = Item.Personas.SegundoApellido,
                        Genero = Item.Personas.Genero,
                        FechaNacimiento = Item.Personas.FechaNacimiento,
                        Correo = Item.Personas.Correo,
                        Telefono = Item.Personas.Telefono,
                        TelefonoAdisional = Item.Personas.TelefonoAdisional,
                        Horario = Item.Horario,
                        Sucursal = Item.Sucursal,
                        TipoClase = Item.TipoClase
                    }).ToList();
                }
                return Lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
