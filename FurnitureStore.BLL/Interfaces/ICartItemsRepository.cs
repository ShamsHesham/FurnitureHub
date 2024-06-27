using FurnitureStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Interfaces
{
    public interface ICartItemsRepository: IGenericRepository<CartItem>
    {
    }
}
