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
    public class ProfesoresModel
    {
        DosCuerdasEntities db = new DosCuerdasEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EProfesores obj, int? Id_Usuario)
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
                    var Existente = db.Profesores.Where(x => x.Id_Profesor == obj.Id_Profesor && x.ID_PERSONA == obj.ID_PERSONA).FirstOrDefault();
                    if (Existente != null)
                    {
                        Ts.Dispose();
                        throw new Exception("El estudiante ya existe.");
                    }
                    Profesores Objbd = new Profesores();
                    Objbd.ID_PERSONA = IdPersona;
                    Objbd.instrumento = obj.instrumento;
                    Objbd.Profesion = obj.Profesion;
                    db.Entry(Objbd).State = EntityState.Added;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Clientes";
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
        public int Modificar(EProfesores obj, int? Id_Usuario)
        {
            try
            {
                PersonasModel personasModel = new PersonasModel();
                personasModel.Modificar(obj);
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Profesores.Where(x => x.Id_Profesor == obj.Id_Profesor).FirstOrDefault();
                    Objbd.ID_PERSONA = obj.ID_PERSONA;
                    Objbd.instrumento = obj.instrumento;
                    Objbd.Profesion = obj.Profesion; ;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Clientes";
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
                    var Objbd = db.Profesores.Where(x => x.Id_Profesor == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Clientes";
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

        #region Mostrar
        public List<EProfesores> Mostrar()
        {
            try
            {
                var Objbd = db.Profesores.ToList();
                List<EProfesores> Lista = new List<EProfesores>();
                if (Objbd.Count() > 0)
                {
                    Lista = Objbd
                    .Select(Item => new EProfesores
                    {
                        ID_PERSONA = Item.Personas.ID_PERSONA,
                        Id_Profesor = Item.Id_Profesor,
                        Cedula = Item.Personas.Cedula,
                        Nombre = Item.Personas.Nombre,
                        PrimerApellido = Item.Personas.PrimerApellido,
                        SegundoApellido = Item.Personas.SegundoApellido,
                        Genero = Item.Personas.Genero,
                        FechaNacimiento = Item.Personas.FechaNacimiento,
                        Correo = Item.Personas.Correo,
                        Telefono = Item.Personas.Telefono,
                        TelefonoAdisional = Item.Personas.TelefonoAdisional,
                        instrumento = Item.instrumento,
                        Profesion = Item.Profesion
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
