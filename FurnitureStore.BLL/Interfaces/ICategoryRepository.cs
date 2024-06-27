using FurnitureStore.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        object Find(Func<object, bool> value);
    }
}
