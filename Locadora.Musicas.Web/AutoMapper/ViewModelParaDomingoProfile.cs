using AutoMapper;
using Locadora.Musicas.Dominio;
using Locadora.Musicas.Web.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Locadora.Musicas.Web.AutoMapper
{
    public class ViewModelParaDomingoProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<AlbumViewModel, Album>();
        }
    }
}