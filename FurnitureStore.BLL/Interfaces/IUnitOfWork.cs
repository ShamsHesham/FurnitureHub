using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        public ICategoryRepository CategoryRepository { get; set; }      //signature for property
        public IProductRepository ProductRepository { get; set; }

        public  ICartRepository CartRepository { get; set; }
        public ICartItemsRepository CartItemsRepository { get; set; }

        public IShoppingCartRepository ShoppingCartRepository { get; set; }

        public IOrderReopsitory OrderReopsitory { get; set; }

        int Save();
        
    }
}
