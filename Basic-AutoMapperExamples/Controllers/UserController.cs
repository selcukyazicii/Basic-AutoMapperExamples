using AutoMapper;
using Basic_AutoMapperExamples.Mapping;
using Basic_AutoMapperExamples.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_AutoMapperExamples.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public UserInfoDto Get()
        {
            var user = new User
            {
               Id=1,
               FirstName="Mark",
               LastName="Zuckerberg",
               Age=20,
               Status=1,
               City="Colarado",
               Country="U.S.A"
            };
            var userInfo = _mapper.Map<UserInfoDto>(user);
            return userInfo;
        }
    }
}
