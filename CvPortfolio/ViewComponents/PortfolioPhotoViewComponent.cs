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
    public class PortfolioPhotoViewComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public PortfolioPhotoViewComponent(IMapper mapper,
          IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;

        }
        public IViewComponentResult Invoke()
        {
            var photos = _contentRepository.GetPortfolioPhotos();

            var model = _mapper.Map<IEnumerable<PortfolioPhoto>, IEnumerable<PortfolioPhotoViewModel>>(photos);

            return View(model);

        }
    }
}
