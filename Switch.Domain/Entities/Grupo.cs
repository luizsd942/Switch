using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Switch.Domain.Entities
{
    public class Grupo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string UriFoto { get; set; }        
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<GrupoUsuario> GrupoUsuarios { get; set; }
    }
}