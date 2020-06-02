using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CvPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;
using Repository.Repositories.UserRepositories;

namespace CvPortfolio.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserController(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }
        
        public IActionResult Index()
        {
       
        
            return View();
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