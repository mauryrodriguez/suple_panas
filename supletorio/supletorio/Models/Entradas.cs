using System;
using System.Collections.Generic;

namespace supletorio.Models
{
    public partial class Entradas
    {
        public Entradas()
        {
            Comentarios = new HashSet<Comentarios>();
        }

        public int Identradas { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public virtual ICollection<Comentarios> Comentarios { get; set; }
    }
}
