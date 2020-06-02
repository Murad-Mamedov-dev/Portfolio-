using AutoMapper;
using CvPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositeries.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.ViewComponents
{
    public class InfoViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public InfoViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;

        }
        public IViewComponentResult Invoke()
        {
            var infos = _contentRepository.GetInfos();

            var model = _mapper.Map<Info,InfoViewModel>(infos);

            return View(model);

        }
    }
}
