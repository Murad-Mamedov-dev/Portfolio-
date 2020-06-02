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
    public class ServiceViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IContentRepository _contentRepository;
        public ServiceViewComponent(IMapper mapper,
          IContentRepository contentRepository)
        {
            _mapper = mapper;
            _contentRepository = contentRepository;

        }
        public IViewComponentResult Invoke()
        {
            var services = _contentRepository.GetServices();

            var model = _mapper.Map<IEnumerable<Service>, IEnumerable<ServiceViewModel>>(services);

            return View(model);

        }
    }
}
