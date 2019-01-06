using Switch.Domain.Enums;

namespace Switch.Domain.Entities
{
    public class ProcurandoPor
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        //public TipoRelacionamentoEnum BuscandoPor { get; set; }

        public bool NaoEspecificado { get { return Id == (int)TipoRelacionamentoProcuradoEnum.NaoEspecificado; }  }
        public bool Amizade { get { return Id == (int)TipoRelacionamentoProcuradoEnum.Amizade; } }
        public bool Namoro { get { return Id == (int)TipoRelacionamentoProcuradoEnum.Namoro; } }
        public bool RelacionamentoSerio { get { return Id == (int)TipoRelacionamentoProcuradoEnum.RelacionamentoSerio; } }
    }
}
