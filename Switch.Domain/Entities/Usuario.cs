using System;
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
        public virtual StatusRelacionamento StatusRelacionamento { get; set; }
        public virtual ProcurandoPor ProcurandoPor { get; set; }
        
        public virtual ICollection<Postagem> Postagens { get; set; }
        public virtual ICollection<GrupoUsuario> GrupoUsuarios { get; set; }
        public virtual ICollection<LocalTrabalho> LocaisTrabalho { get; set; }
        public virtual ICollection<InstituicaoEnsino> IstituicaoEnsinos { get; set; }
        public virtual ICollection<Amigo> Amigos { get; set; }
        public virtual ICollection<Comentario> Comentarios { get; set; }

        public Usuario()
        {
            Postagens = new List<Postagem>();
            GrupoUsuarios = new List<GrupoUsuario>();
            LocaisTrabalho = new List<LocalTrabalho>();
            IstituicaoEnsinos = new List<InstituicaoEnsino>();
            Amigos = new List<Amigo>();
            Comentarios = new List<Comentario>();
        }
    }
}
