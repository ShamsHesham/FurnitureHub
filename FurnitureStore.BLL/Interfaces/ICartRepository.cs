using FurnitureStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Interfaces
{
    public interface ICartRepository: IGenericRepository<Cart>
    {

        Cart GetCartByUserId(string userId);
        void AddCartItem(ShoppingCart cartItem);
    }
}
