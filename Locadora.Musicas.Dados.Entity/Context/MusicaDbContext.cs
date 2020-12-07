using Locadora.Musicas.Dados.Entity.TypeConfiguration;
using Locadora.Musicas.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Musicas.Dados.Entity.Context
{
    public class MusicaDbContext : DbContext
    {
        public DbSet<Album> Albuns { get; set; }
        public MusicaDbContext() 
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AlbumTypeConfiguration());
            modelBuilder.Configurations.Add(new MusicaTypeConfiguration());
        }
    }
}
