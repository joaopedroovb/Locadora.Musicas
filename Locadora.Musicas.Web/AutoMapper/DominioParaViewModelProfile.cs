﻿using AutoMapper;
using Locadora.Musicas.Dominio;
using Locadora.Musicas.Web.ViewModels.Album;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;

namespace Locadora.Musicas.Web.AutoMapper
{
    public class DominioParaViewModelProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Album, AlbumIndexViewModel>()
                .ForMember(p => p.Nome, opt =>
                {
                    opt.MapFrom(src =>
                    string.Format("{0} {1}", src.Nome, src.Ano.ToString())
                    );
                });
            Mapper.CreateMap<Album, AlbumViewModel>();
        }
    }
}