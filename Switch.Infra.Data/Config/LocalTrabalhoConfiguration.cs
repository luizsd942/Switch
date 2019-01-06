using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class LocalTrabalhoConfiguration : IEntityTypeConfiguration<LocalTrabalho>
    {
        public void Configure(EntityTypeBuilder<LocalTrabalho> builder)
        {
            builder.HasKey(l => l.Id);
            builder.Property(l => l.Nome);
            builder.Property(l => l.DataAdmissao).HasColumnName("DtAdmissao");
            builder.Property(l => l.DataSaida).HasColumnName("DtDemissao");
            builder.Property(l => l.EmpresaAtual);
        }
    }
}
