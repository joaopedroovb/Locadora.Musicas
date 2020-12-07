using Locadora.Musicas.Dominio;
using Locadora.Musicas.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Musicas.Dados.Entity.TypeConfiguration
{
    class AlbumTypeConfiguration : LocadoraEntityAbstractConfig<Album>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");

            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");

            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("Ano");

            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("Descricao");

            Property(p => p.Artista)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Artista");

            Property(p => p.Genero)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Genero");

            Property(p => p.Email)
                .IsRequired()
                .HasColumnName("Email");

        }

        protected override void ConfigurarChaveEstrangeira()
        {
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("Album");
        }
    }
}
