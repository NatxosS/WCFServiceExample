using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService_Favoritos
{
    [ServiceContract]
    interface IUsuarioService
    {
        [OperationContract]
        List<Usuario> ObtenerUsuarios();
        [OperationContract]
        void InsertarUsuario(Usuario u);
        [OperationContract]
        void ModificarUsuario(Usuario u);
        [OperationContract]
        void EliminarUsuario(Usuario u);
    }
}
