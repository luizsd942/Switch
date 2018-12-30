using Switch.Domain.Enums;

namespace Switch.Domain.Entities
{
    class ProcurandoPor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public TipoRelacionamentoEnum BuscandoPor { get; set; }

        //public bool NaoEspecificado { get { return Id == (int)TipoRelacionamentoEnum.NaoEspecificado; }  }
        //public bool Amizade { get { return Id == (int)TipoRelacionamentoEnum.Amizade; } }
        //public bool Namoro { get { return Id == (int)TipoRelacionamentoEnum.Namoro; } }
        //public bool RelacionamentoSerio { get { return Id == (int)TipoRelacionamentoEnum.RelacionamentoSerio; } }
    }
}
