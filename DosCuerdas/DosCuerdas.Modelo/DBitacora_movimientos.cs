using DosCuerdas.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace DosCuerdas.Modelo
{
    public class DBitacora_movimientos
    {
        DosCuerdasEntities db = new DosCuerdasEntities();
        #region Agregar
        public int Agregar(EBitacora_movimientos obj)//Viene de la vista obj
        {
            try
            {
                using (TransactionScope Ts = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    Bitacora_Movimientos Objbd = new Bitacora_Movimientos();//Viene de la base de datos
                    Objbd.Id_Usuario = obj.Id_Usuario;
                    Objbd.fecha_hora_movimiento = obj.fecha_hora_movimiento;
                    Objbd.tipo_movimiento = obj.tipo_movimiento;
                    Objbd.modulo = obj.modulo;
                    db.Bitacora_Movimientos.Add(Objbd);

                    int Resultado = db.SaveChanges();//Commit

                    if (Resultado > 0)
                    {
                        Ts.Complete();
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
        #region Listar
        public List<EBitacora_movimientos> Mostrar()
        {
            try
            {
                List<EBitacora_movimientos> Obj = new List<EBitacora_movimientos>();
                var Objbd = db.Bitacora_Movimientos.ToList();
                Obj = db.Bitacora_Movimientos
                .Select(Item => new EBitacora_movimientos
                {
                    Id_Usuario = Item.Id_Usuario,
                    fecha_hora_movimiento = Item.fecha_hora_movimiento,
                    tipo_movimiento = Item.tipo_movimiento,
                    modulo = Item.modulo,
                    codigo_movimiento_usuario = Item.codigo_movimiento_usuario
                }).ToList();
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
