using FurnitureStore.BLL.Interfaces;
using FurnitureStore.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly FurnitureDbContext _dbContext;

        public ICategoryRepository CategoryRepository { get ; set ; }
        public IProductRepository ProductRepository { get ; set ; }

        public ICartRepository CartRepository { get ; set ; }

        public ICartItemsRepository CartItemsRepository { get ; set ; }

        public IShoppingCartRepository ShoppingCartRepository { get ; set ; }

        public IOrderReopsitory OrderReopsitory { get ; set ; } 

        public UnitOfWork(FurnitureDbContext dbContext)
        {
            CategoryRepository= new CategoryRepository(dbContext);
            ProductRepository= new ProductRepository(dbContext);
            CartRepository= new CartRepository(dbContext);
            CartItemsRepository= new CartItemsRepository(dbContext);
            ShoppingCartRepository= new ShoppingCartRepository(dbContext);
            OrderReopsitory= new OrderRepository(dbContext);
            this._dbContext = dbContext;
        }

        public int Save()
        {
           return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
