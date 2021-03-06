﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Switch.Domain.Entities;
using System;

namespace Switch.Infra.Data.Config
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Nome).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Senha).HasMaxLength(100).IsRequired();
            builder.Property(u => u.SobreNome).HasMaxLength(100).IsRequired();
            builder.Property(u => u.Sexo).IsRequired();
            builder.Property(u => u.DataNascimento).IsRequired();
            builder.Property(u => u.UrlFoto).HasMaxLength(400);

            builder.HasOne(u => u.Identificacao)
                .WithOne(i => i.Usuario)
                .HasForeignKey<Identificacao>(i => i.UsuarioId);
            builder.HasOne(u => u.StatusRelacionamento);
            builder.HasOne(u => u.ProcurandoPor);

            builder.HasMany(u => u.Comentarios).WithOne(c => c.Usuario);
            builder.HasMany(u => u.LocaisTrabalho).WithOne(c => c.Usuario);
            builder.HasMany(u => u.IstituicaoEnsinos).WithOne(c => c.Usuario);
            builder.HasMany(u => u.Amigos).WithOne(c => c.Usuario);
        }
    }
}
