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
    internal class CategoryRepository :GenericRepository<Category>,ICategoryRepository
    {
        private readonly FurnitureDbContext _dbContext;

        public CategoryRepository(FurnitureDbContext dbContext):base(dbContext) 
        {
            _dbContext = dbContext;
        }

        public object Find(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
