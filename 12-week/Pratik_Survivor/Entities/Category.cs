using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Survivor.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        // Bir Category birden fazla Competitor'a sahip olabilir.
        public ICollection<Competitor> Competitors { get; set; }
    }
}