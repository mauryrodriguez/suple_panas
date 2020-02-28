using System;
using System.Collections.Generic;

namespace supletorio.Models
{
    public partial class Comentarios
    {
        public int Idcometarios { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Descripcion { get; set; }
        public int Identradas { get; set; }

        public virtual Entradas IdentradasNavigation { get; set; }
    }
}
