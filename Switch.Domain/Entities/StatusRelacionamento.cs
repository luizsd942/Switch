using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Domain.Entities
{
    public class StatusRelacionamento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public int ComUsuarioId { get; set; }
        public virtual Usuario ComUsuario { get; set; }
        public StatusRelacionamentoEnum Status { get; set; }
    }
}
