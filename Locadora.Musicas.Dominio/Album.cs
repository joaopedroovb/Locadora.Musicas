using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Musicas.Dominio
{
    public class Album
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
        public string Artista { get; set; }
        public string Genero { get; set; }
        public string Email { get; set; }
        public virtual List<Musica> Musicas { get; set; }
    }
}
