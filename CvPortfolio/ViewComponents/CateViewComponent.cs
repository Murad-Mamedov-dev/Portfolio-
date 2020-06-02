using AutoMapper;
using CvPortfolio.Models;
using Microsoft.AspNetCore.Mvc;

using Repository.Models;
using Repository.Repositeries.ContentRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.ViewComponents
{
    public class CateViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public CateViewComponent(IMapper mapper,
                                   IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;

        }
        public IViewComponentResult Invoke()
        {
            var levels = _contentRepository.GetPortfolioLevels();

            var model = _mapper.Map<IEnumerable<PortfolioLevel>, IEnumerable<PortCateViewModel>>(levels);

            return View(model);

        }
    }
}

