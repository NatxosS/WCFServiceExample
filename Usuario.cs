using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Importamos la libreria para serialización
using System.Runtime.Serialization;

namespace WcfService_Favoritos
{
    /// <summary>
    ///  Descripción breve de usuario
    /// </summary>
    /// 
    [DataContract]
    public class Usuario
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nombre { get; set; }
        [DataMember]
        public int Anio { get; set; }

        public Usuario()
        {

        }
    }
}
