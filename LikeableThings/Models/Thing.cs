using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LikeableThings.Models
{
    public class Thing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
