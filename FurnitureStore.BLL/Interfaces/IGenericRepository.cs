using FurnitureStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Interfaces
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();

        T Get(int id);

        void Add(T item);
        void Update(T item);
        void Delete(T item);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);

        IEnumerable<T> GetAlls(Expression<Func<T, bool>>? predicate = null, string? includeword = null);
        T GetOnly(Expression<Func<T, bool>>? predicate = null, string? includeword = null);






    }
}
