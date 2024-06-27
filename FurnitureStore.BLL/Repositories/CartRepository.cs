using FurnitureStore.BLL.Interfaces;
using FurnitureStore.DAL.Context;
using FurnitureStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Repositories
{
    public class CartRepository : GenericRepository<Cart>, ICartRepository
    {
        private readonly FurnitureDbContext _dbContext;
        public CartRepository(FurnitureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public void AddCartItem(ShoppingCart cartItem)
        {
            _dbContext.shoppingCarts.Add(cartItem);
            _dbContext.SaveChanges();
        }

        public Cart GetCartByUserId(string userId)
        {
            return _dbContext.Carts.Include(c => c.CartItem)
                                       .FirstOrDefault(c => c.CustomerID == userId);
        }

    }


    
}
