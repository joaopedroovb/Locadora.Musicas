using Locadora.Musicas.Dominio;
using Locadora.Musicas.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Musicas.Dados.Entity.TypeConfiguration
{
    class MusicaTypeConfiguration : LocadoraEntityAbstractConfig<Musica>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.IdMusica)
                .HasColumnName("IdFilme")
                .HasDatabaseGeneratedOption(System.ComponentModel
                                            .DataAnnotations.Schema
                                            .DatabaseGeneratedOption.Identity)
                 .IsRequired();

            Property(p => p.NomeMusica)
                .HasColumnName("NomeMusica")
                .HasMaxLength(100)
                .IsRequired();

            Property(p => p.IdAlbum)
                .HasColumnName("IdAlbum")
                .IsRequired();
        }

        protected override void ConfigurarChaveEstrangeira()
        {
            HasRequired(p => p.Album)
                .WithMany(p => p.Musicas)
                .HasForeignKey(fk => fk.IdAlbum);
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdMusica);
        }

        protected override void ConfigurarNomeTabela()
        {
            throw new NotImplementedException();
        }
    }
}
