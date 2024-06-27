using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.DAL.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public Product Product { get; set; }
        public Customers Customer { get; set; }
    }
}
