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
    public class EduCartViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public EduCartViewComponent(IMapper mapper, IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;
        }
        public IViewComponentResult Invoke()
        {
            var eECarts = _contentRepository.GetEduCarts();

            var model = _mapper.Map<IEnumerable<EECart>, IEnumerable<EECartViewModel>>(eECarts);

            return View(model);

        }
    }
}
