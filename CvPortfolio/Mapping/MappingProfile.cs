using AutoMapper;
using CvPortfolio.Models;
using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvPortfolio.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Caption, CaptionViewModel>();
            CreateMap<PortfolioPhoto, PortfolioPhotoViewModel>();
            CreateMap<Service, ServiceViewModel>();
            CreateMap<SkillValue, SkillViewModel>();
            CreateMap<PortfolioDetail, DetailViewModel>();
            CreateMap<EECart, EECartViewModel>();
            CreateMap<Info, InfoViewModel>();
            CreateMap<PortfolioLevel, PortCateViewModel>();
            CreateMap<User, UserViewModel>();
            CreateMap<UserViewModel,User >();
            CreateMap<CreateUserViewModel, User>();

        }
    }
}
