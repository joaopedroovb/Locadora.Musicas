using Locadora.Musicas.Web.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Locadora.Musicas.Web.ViewModels.Album
{
    public class AlbumViewModel
    {
        [Required(ErrorMessage ="O Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome deve ser obrigatório")]
        [MaxLength(100, ErrorMessage ="O nome deve ter no máximo 100 caracteres")]
        [Display(Name = "Nome do álbum")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O ano deve ser obrigatório")]
        [Display(Name = "Ano do álbum")]
        public int Ano { get; set; }

        [MaxLength(1000, ErrorMessage ="A descrição deve ter no máximo 1000 caracteres")]
        [Display(Name = "Descrição do álbum")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O nome do artista deve ser obrigatório")]
        [MaxLength(100, ErrorMessage ="O nome do artista deve ter no máximo 100 caracteres")]
        [Display(Name = "Artista do álbum")]
        public string Artista { get; set; }

        [Required(ErrorMessage = "O gênero do álbum deve ser obrigatório")]
        [MaxLength(100, ErrorMessage ="O nome do gênero do álbum deve ter no máximo 100 caracteres")]
        [Display(Name = "Gênero do álbum")]
        public string Genero { get; set; }

        [Display(Name = "Email para contato")]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "O E-mail é obrigatório")]
        [Email(ErrorMessage ="O domínio do e-mail deve ser @unipam.edu.br")]
        public string Email { get; set; }
    }
}