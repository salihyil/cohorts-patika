using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Survivor.Dtos.Competitor
{
    public class GetCompetitorDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}