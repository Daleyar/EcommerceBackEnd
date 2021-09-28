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

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Review")]
        public int ReviewID { get; set; }
        public Review Review { get; set; }

    }
}
