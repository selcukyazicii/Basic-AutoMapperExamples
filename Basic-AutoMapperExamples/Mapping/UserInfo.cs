using AutoMapper;
using Basic_AutoMapperExamples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_AutoMapperExamples.Mapping
{
    public class UserInfo:Profile
    {

        public UserInfo()
        {
            CreateMap<User, UserInfoDto>()
                .ForMember(destination => destination.Name, operation => operation.MapFrom(source => source.FirstName + " " + source.LastName))
                .ForMember(destination => destination.Address, operation => operation.MapFrom(source => source.Country + " " + source.City))
                .ForMember(destination => destination.Status, operation => operation.MapFrom(source => ((UserStatusEnum)source.Status).ToString()));

        }
    }
}
