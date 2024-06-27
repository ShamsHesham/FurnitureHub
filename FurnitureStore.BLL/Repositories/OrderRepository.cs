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
    public class OrderRepository :GenericRepository<Order>,IOrderReopsitory
    {
        private readonly FurnitureDbContext _dbContext;
        public OrderRepository(FurnitureDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
        public Order GetOrderById(int id, string includeProperties = "")
        {
            IQueryable<Order> query = _dbContext.Orders;

            foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
            {
                query = query.Include(includeProperty);
            }

            return query.FirstOrDefault(o => o.Id == id);
        }

    }
}
