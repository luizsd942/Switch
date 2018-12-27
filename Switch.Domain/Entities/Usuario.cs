﻿using System;
using System.Collections.Generic;
using System.Text;
using Switch.Domain.Enums;

namespace Switch.Domain.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataNascimento { get; set; }        
        public SexoEnum Sexo { get; set; }
        public string UrlFoto { get; set; }
        public virtual Identificacao Identificacao { get; set; }
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<GrupoUsuario> GrupoUsuarios { get; set; }
    }
}
