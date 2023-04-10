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
    public class PersonasModel
    {
        DosCuerdasEntities db = new DosCuerdasEntities();
        //EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        //DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar

        public int Agregar(EPersonas obj)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Personas Objbd = new Personas();
                    Objbd.Cedula = obj.Cedula;
                    Objbd.Nombre = obj.Nombre;
                    Objbd.PrimerApellido = obj.PrimerApellido;
                    Objbd.SegundoApellido = obj.SegundoApellido;
                    Objbd.Genero = obj.Genero;
                    Objbd.FechaNacimiento = obj.FechaNacimiento;
                    Objbd.Correo = obj.Correo;
                    Objbd.Telefono = obj.Telefono;
                    Objbd.TelefonoAdisional = obj.TelefonoAdisional;
                    db.Entry(Objbd).State = EntityState.Added;
                    //db.Roles.Add(Objbd);

                    db.SaveChanges();

                    int Resultado = Objbd.ID_PERSONA;

                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Roles";
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
        public int Modificar(EPersonas obj)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Personas.Where(x => x.ID_PERSONA == obj.ID_PERSONA).FirstOrDefault();
                    Objbd.Cedula = obj.Cedula;
                    Objbd.Nombre = obj.Nombre;
                    Objbd.PrimerApellido = obj.PrimerApellido;
                    Objbd.SegundoApellido = obj.SegundoApellido;
                    Objbd.Genero = obj.Genero;
                    Objbd.FechaNacimiento = obj.FechaNacimiento;
                    Objbd.Correo = obj.Correo;
                    Objbd.Telefono = obj.Telefono;
                    Objbd.TelefonoAdisional = obj.TelefonoAdisional;
                    db.Entry(Objbd).State = EntityState.Modified;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Roles";
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
        public int Eliminar(int ID)
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Personas.Where(x => x.ID_PERSONA == ID).FirstOrDefault();
                    db.Entry(Objbd).State = EntityState.Deleted;
                    int Resultado = db.SaveChanges();
                    if (Resultado > 0)
                    {
                        Ts.Complete();
                        //Entidad_Movimientos.Id_Usuario = Id_Usuario;
                        //Entidad_Movimientos.modulo = "Roles";
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
        public List<EPersonas> Mostrar()
        {
            try
            {
                List<EPersonas> Lista = new List<EPersonas>();
                Lista = db.Personas
                .Select(Item => new EPersonas
                {
                    ID_PERSONA=Item.ID_PERSONA,
                    Cedula = Item.Cedula,
                    Nombre = Item.Nombre,
                    PrimerApellido = Item.PrimerApellido,
                    SegundoApellido = Item.SegundoApellido,
                    Genero = Item.Genero,
                    FechaNacimiento = Item.FechaNacimiento,
                    Correo = Item.Correo,
                    Telefono = Item.Telefono,
                    TelefonoAdisional = Item.TelefonoAdisional
                }).ToList();
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
