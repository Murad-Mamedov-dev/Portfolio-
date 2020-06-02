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
    public class CaptionViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public CaptionViewComponent(IMapper mapper,
          IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;

        }
        public IViewComponentResult Invoke()
        {
            var captions = _contentRepository.GetCaptions();

            var model = _mapper.Map<IEnumerable<Caption>, IEnumerable<CaptionViewModel>>(captions);

            return View(model);

        }
    }
}
