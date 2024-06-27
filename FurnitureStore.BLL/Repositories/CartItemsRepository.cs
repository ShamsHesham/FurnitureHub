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
    public class CartItemsRepository : GenericRepository<CartItem>, ICartItemsRepository
    {
        private readonly FurnitureDbContext _dbContext;
        public CartItemsRepository(FurnitureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
    
    
}
