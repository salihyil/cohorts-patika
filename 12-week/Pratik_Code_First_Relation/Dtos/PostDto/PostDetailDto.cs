using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Code_First_Relation.Dtos.PostDto
{
    public class PostDetailDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}