using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService_Favoritos
{
    [ServiceBehavior]
    public class UsuarioService : IUsuarioService
    {
        private static List<Usuario> listaUsu = new List<Usuario>();

        public void EliminarUsuario(Usuario u)
        {
            Usuario usuarioModif = listaUsu.Where((usuario) => { return usuario.Id == u.Id; }).First();

            if (usuarioModif != null)
            {
                listaUsu.Remove(usuarioModif);
            }
        }

        public void InsertarUsuario(Usuario u)
        {
            if (listaUsu.Count == 0)
            {
                u.Id = 1;
            } else
            {
                u.Id = listaUsu.Max(usuario => usuario.Id) + 1;
                /*  int funAnonima(Usuario usuario) { return usuario.id}
                */
            }

            listaUsu.Add(u);
        }

        public void ModificarUsuario(Usuario u)
        {
            Usuario usuarioModif = listaUsu.Where((usuario) => { return usuario.Id == u.Id; }).First();

            if (usuarioModif != null)
            {
                usuarioModif.Nombre = u.Nombre;
                usuarioModif.Anio = u.Anio;
            }
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return listaUsu;
        }
    }
}
