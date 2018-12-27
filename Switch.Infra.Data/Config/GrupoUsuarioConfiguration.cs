using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Switch.Infra.Data.Config
{
    public class GrupoUsuarioConfiguration : IEntityTypeConfiguration<GrupoUsuario>
    {
        public void Configure(EntityTypeBuilder<GrupoUsuario> builder)
        {
            builder.HasKey(g => new { g.GrupoId, g.UsuarioId});

            builder.Property(g => g.DataCriacao)
                .IsRequired();
            builder.Property(g => g.EhAdministrador)
                .IsRequired().HasColumnName("IsAdmin");
            
            builder.HasOne(g => g.Usuario).WithMany(u => u.GrupoUsuarios);
            builder.HasOne(g => g.Grupo).WithMany(g => g.GrupoUsuarios);

        }
    }
}
