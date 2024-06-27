using FurnitureStore.BLL.Interfaces;
using FurnitureStore.DAL.Context;
using FurnitureStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly FurnitureDbContext _dbContext;
        public ProductRepository(FurnitureDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
    }
}
