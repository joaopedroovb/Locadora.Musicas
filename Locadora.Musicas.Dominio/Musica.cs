using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Musicas.Dominio
{
    public class Musica
    {
        public long IdMusica { get; set; }
        public string NomeMusica { get; set; }
        public virtual Album Album { get; set; }
        public int IdAlbum { get; set; }
    }
}
