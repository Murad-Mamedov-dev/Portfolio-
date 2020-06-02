using AutoMapper;
using CvPortfolio.Models;
using Microsoft.AspNetCore.Mvc;
using Repository.Models;

using Repository.Repositories.UserRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.ViewComponents
{
    public class UserViewComponent:ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _userRepository;
        public UserViewComponent(IMapper mapper,
                                  IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;

        }
        public IViewComponentResult Invoke()
        {
            var users = _userRepository.GetUsers();

            var model = _mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(users);

            return View(model);

        }
    }
}
