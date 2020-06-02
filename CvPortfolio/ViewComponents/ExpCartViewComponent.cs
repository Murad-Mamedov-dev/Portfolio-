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
    public class ExpCartViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public ExpCartViewComponent(IMapper mapper, IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }
        public IViewComponentResult Invoke()
        {
            var eCarts = _contentRepository.GetexpCarts();

            var model = _mapper.Map<IEnumerable<EECart>, IEnumerable<EECartViewModel>>(eCarts);

            return View(model);

        }
    }
}
