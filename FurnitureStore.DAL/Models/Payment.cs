using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.DAL.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public int OrderID { get; set; }
        public int Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public ICollection<PaymentMethod> paymentMethod { get; set; }

        public Order Order { get; set; }
    }
}
