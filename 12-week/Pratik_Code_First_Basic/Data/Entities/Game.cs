using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pratik_Code_First_Basic.Data.Entities
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Platform { get; set; }
        public decimal Rating { get; set; }
    }
}