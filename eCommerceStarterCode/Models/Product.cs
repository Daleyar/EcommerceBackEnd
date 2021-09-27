using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceStarterCode.Models
{
    public class Product
    {
        public int ProductID {get; set;}
        public string Name{ get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int AverageRating { get; set; }

        [ForeignKey("Categories")]
        public int CategoryID { get; set; }
        public Categories Categories { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Review")]
        public int ReviewID { get; set; }
        public Review Review { get; set; }

    }
}
