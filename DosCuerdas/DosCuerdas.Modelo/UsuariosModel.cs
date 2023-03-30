using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DosCuerdas.Modelo
{
    public class UsuariosModel
    {
        DosCuerdasEntities db = new DosCuerdasEntities();
        public List<EUsuarios> Mostrar()
        {
            try
            {
                List<EUsuarios> Obj = new List<EUsuarios>();
                var Objbd = db.Usuarios.ToList();
                Obj = Objbd.Select(x=> new EUsuarios
                {
                    ID_PERSONA=x.ID_PERSONA,
                    Contrasena=x.Contrasena,
                    Estado=x.Estado,
                    Id_Rol=x.Id_Rol,
                    Id_Usuario=x.Id_Usuario,
                    Usuario=x.Usuario
                }).ToList();
                return Obj;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
