using FurnitureStore.BLL.Interfaces;
using FurnitureStore.DAL.Context;
using FurnitureStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Repositories
{
    public class ShoppingCartRepository : GenericRepository<ShoppingCart>, IShoppingCartRepository
    {
        private readonly FurnitureDbContext _dbContext;
        public ShoppingCartRepository(FurnitureDbContext furnitureDbContext) : base(furnitureDbContext)
        {
            _dbContext = furnitureDbContext;
        }

    }
        
}
