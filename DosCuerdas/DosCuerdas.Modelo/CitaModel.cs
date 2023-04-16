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
    public class CitaModel
    {
        DosCuerdasEntities db = new DosCuerdasEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(ECita obj, int? Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Existente = db.Cita.Where(x => x.Id_Profesor == obj.Id_Profesor && x.Id_Estudiante == obj.Id_Estudiante && x.HORA_CITA==obj.HORA_CITA && x.FECHACITA.Date==obj.FECHACITA.Date|| x.Id_Estudiante == obj.Id_Estudiante && x.HORA_CITA == obj.HORA_CITA && x.FECHACITA.Date == obj.FECHACITA.Date).FirstOrDefault();
                    if (Existente != null)
                    {
                        Ts.Dispose();
                        throw new Exception("El Estudiante ya inscribio una clase en este horario o el profesor no esta disponible en ese horario.");
                    }
                    Cita Objbd = new Cita();
                    Objbd.Id_Usuario = obj.Id_Usuario;
                    Objbd.Id_Profesor = obj.Id_Profesor;
                    Objbd.Id_Estudiante = obj.Id_Estudiante;
                    Objbd.FECHACITA = obj.FECHACITA;
                    Objbd.DURACION = obj.DURACION;
                    Objbd.HORA_CITA = obj.HORA_CITA;
                    Objbd.ESTADO = "Pendiente";
                    Objbd.Observaciones = obj.Observaciones;
                    db.Entry(Objbd).State = EntityState.Added;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Citas";
                        Entidad_Movimientos.tipo_movimiento = "Agendar";
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
        public int Modificar(ECita obj, int? Id_Usuario)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    //if(obj.ESTADO="")
                    //var Existente = db.Cita.Where(x => x.Id_Profesor == obj.Id_Profesor && x.Id_Estudiante == obj.Id_Estudiante && x.HORA_CITA == obj.HORA_CITA && x.FECHACITA.Date == obj.FECHACITA.Date || x.Id_Estudiante == obj.Id_Estudiante && x.HORA_CITA == obj.HORA_CITA && x.FECHACITA.Date == obj.FECHACITA.Date).FirstOrDefault();
                    //if (Existente != null)
                    //{
                    //    Ts.Dispose();
                    //    throw new Exception("El Estudiante ya inscribio una clase en este horario o el profesor no esta disponible en ese horario.");
                    //}
                    var Objbd = db.Cita.Where(x => x.IDCITA == obj.IDCITA).FirstOrDefault();
                    Objbd.Id_Usuario = obj.Id_Usuario;
                    Objbd.Id_Profesor = obj.Id_Profesor;
                    Objbd.Id_Estudiante = obj.Id_Estudiante;
                    Objbd.FECHACITA = obj.FECHACITA;
                    Objbd.DURACION = obj.DURACION;
                    Objbd.HORA_CITA = obj.HORA_CITA;
                    Objbd.ESTADO = obj.ESTADO;
                    Objbd.Observaciones = obj.Observaciones;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        Entidad_Movimientos.modulo = "Clientes";
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

        #region Mostrar
        public List<EReporteCita> Mostrar()
        {
            try
            {
                var Citas = db.Cita.ToList();
                List<EReporteCita> Lista = new List<EReporteCita>();
                if (Citas.Count() > 0)
                {
                    Lista = Citas
                    .Select(Item => new EReporteCita
                    {
                        IDCITA = Item.IDCITA,
                        Estudiante = Item.Estudiantes.Personas.Nombre+" "+ Item.Estudiantes.Personas.PrimerApellido+" "+Item.Estudiantes.Personas.SegundoApellido,
                        Profesor = Item.Profesores.Personas.Nombre + " " + Item.Profesores.Personas.PrimerApellido + " " + Item.Profesores.Personas.SegundoApellido,
                        Usuario = Item.Usuarios.Usuario,
                        FECHACITA = Item.FECHACITA,
                        HORA_CITA = Item.HORA_CITA,
                        DURACION = Item.DURACION,
                        ESTADO = Item.ESTADO
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
