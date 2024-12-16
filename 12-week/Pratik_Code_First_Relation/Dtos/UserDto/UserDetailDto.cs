using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Pratik_Code_First_Relation.Dtos.PostDto;

namespace Pratik_Code_First_Relation.Dtos.UserDto
{
    public class UserDetailDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public List<PostDetailDto> Posts { get; set; }
    }
}