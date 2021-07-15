using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using LearnMVC.Dtos;
using LearnMVC.Models;

namespace LearnMVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }
    }
}