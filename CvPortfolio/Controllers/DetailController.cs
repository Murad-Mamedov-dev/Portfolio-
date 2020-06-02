using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CvPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.DetailRepositories;
using Repository.Repositories.UserRepositories;

namespace CvPortfolio.Controllers
{
    public class DetailController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IDetailRepository _detailRepository;
        private readonly IUserRepository _userRepository;
        public DetailController(IMapper map, IDetailRepository detailRepository, IUserRepository userRepository)
        {
            _mapper = map;
           _detailRepository = detailRepository;
            _userRepository = userRepository;
        }
        
      
      
        public IActionResult Index(int id)
        {
            var detail = _detailRepository.GetPortfolioDetailById(id);
            if (detail == null) return NotFound();
            var model = new RouteDetailViewModel {
                Detail = _mapper.Map<PortfolioDetail, DetailViewModel > (detail)

            };    
            return View(model);
        }
      
        [HttpPost]
        public IActionResult Index(CreateUserViewModel user)
        {
            user.AddedDate = DateTime.Now;

            var ar = _mapper.Map<CreateUserViewModel, User>(user);
            _userRepository.CreateUser(ar);


            return RedirectToAction("Index");
        }
     

    }
  
         
    
}