using System;

namespace Switch.Domain.Entities
{
    public class IstituicaoEnsino
    { 
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public string NomeInstituicao { get; set; }
        public DateTime? AnoFormacao { get; set; }

    }
}
