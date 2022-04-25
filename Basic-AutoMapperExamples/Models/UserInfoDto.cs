using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic_AutoMapperExamples.Models
{
    public class UserInfoDto
    {
        public string Name { get; set; }
        public string Status { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }
    public enum UserStatusEnum
    {
        Active=0,
        Pending=1,
        Passive=2
    }
}
