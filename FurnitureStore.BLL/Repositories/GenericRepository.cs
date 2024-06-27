using FurnitureStore.BLL.Interfaces;
using FurnitureStore.DAL.Context;
using FurnitureStore.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureStore.BLL.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly FurnitureDbContext _dbContext;
        private DbSet<T> _dbSet;

        public GenericRepository(FurnitureDbContext furnitureDbContext) 
        {
            _dbContext = furnitureDbContext;
            _dbSet = _dbContext.Set<T>();    
        }

        public void Add(T item)
        {
            _dbContext.Set<T>().Add(item);
            
            

            
        }

        public void Delete(T item)
        {
            _dbContext.Set<T>().Remove(item);
            
        }

        public T Get(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

      

        public IEnumerable<T> GetAll()
        {
            return _dbContext.Set<T>().ToList();
            
        }

       

        public void Update(T item)
        {
            _dbContext.Set<T>().Update(item);
            
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _dbContext.Set<T>().Where(predicate).ToList();
        }

      
        public T GetOnly(Expression<Func<T, bool>>? predicate = null, string? includeword = null)

        {

            IQueryable<T> querry = _dbSet;

            if (predicate != null)

            {

                querry = querry.Where(predicate);

            }

            if (includeword != null)

            {

                foreach (var item in includeword.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))

                {

                    querry = querry.Include(item);

                }

            }

            return querry.SingleOrDefault();

        }

        public IEnumerable<T> GetAlls(Expression<Func<T, bool>>? predicate = null, string? includeword = null)

        {

            IQueryable<T> querry = _dbSet;

            if (predicate != null)

            {

                querry = querry.Where(predicate);

            }

            if (includeword != null)

            {

                foreach (var item in includeword.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))

                {

                    querry = querry.Include(item);

                }

            }

            return querry.ToList();

        }



    }
}
