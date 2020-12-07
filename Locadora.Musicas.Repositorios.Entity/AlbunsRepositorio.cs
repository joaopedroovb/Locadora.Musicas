using Locadora.Musicas.Dados.Entity.Context;
using Locadora.Musicas.Dominio;
using Locadora.Repositorios.Comum.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Musicas.Repositorios.Entity
{
    public class AlbunsRepositorio : RepositorioGenericoEntity<Album, int>
    {
        public AlbunsRepositorio(MusicaDbContext contexto)
            : base(contexto)
        {

        }

    }
}
