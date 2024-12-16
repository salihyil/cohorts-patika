using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Code_First_Relation.Dtos.UserDto
{
    public class UserListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int PostCount { get; set; }
    }
}