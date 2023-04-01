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
    public class ClientesModel
    {
        DosCuerdasEntities db = new DosCuerdasEntities();
        EBitacora_movimientos Entidad_Movimientos = new EBitacora_movimientos();
        DBitacora_movimientos Movimientos = new DBitacora_movimientos();
        #region Agregar
        public int Agregar(EClientes obj, int Id_Usuario)
        {
            try
            {
                PersonasModel personasModel = new PersonasModel();
                var IdPersona = personasModel.Agregar(obj);
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Clientes Objbd = new Clientes();
                    Objbd.ID_PERSONA = IdPersona;
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
        public int Modificar(EClientes obj, int Id_Usuario)
        {
            try
            {
                PersonasModel personasModel = new PersonasModel();
                personasModel.Modificar(obj);
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    var Objbd = db.Clientes.Where(x => x.ID_PERSONA == obj.ID_PERSONA).FirstOrDefault();
                    Objbd.ID_PERSONA = obj.ID_PERSONA;
                    Objbd.Id_Cliente = obj.Id_Cliente;
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
        public int Eliminar(int ID, int Id_Usuario)
        {
            try
            {
                PersonasModel personasModel = new PersonasModel();
                var IdPersona = db.Clientes.Where(x => x.Id_Cliente == ID).FirstOrDefault().Personas.ID_PERSONA;
                
                if (IdPersona > 0)
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
                else
                {
                    return 0;
                }
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
                var clientes = db.Clientes.ToList();
                List<EClientes> Lista = new List<EClientes>();
                if (clientes.Count() > 0)
                {
                    Lista = clientes
                    .Select(Item => new EClientes
                    {
                        ID_PERSONA = Item.Personas.ID_PERSONA,
                        Id_Cliente = Item.Id_Cliente,
                        Cedula = Item.Personas.Cedula,
                        Nombre = Item.Personas.Nombre,
                        PrimerApellido = Item.Personas.PrimerApellido,
                        SegundoApellido = Item.Personas.SegundoApellido,
                        Genero = Item.Personas.Genero,
                        FechaNacimiento = Item.Personas.FechaNacimiento,
                        Correo = Item.Personas.Correo,
                        Telefono = Item.Personas.Telefono,
                        TelefonoAdisional = Item.Personas.TelefonoAdisional
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
