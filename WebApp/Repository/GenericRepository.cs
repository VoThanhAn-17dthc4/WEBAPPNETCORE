using WebApp.Models;
using WebApp.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public WebAppBanHangContext _db { get; set; }
        public DbSet<T> _table;
        public GenericRepository()
        {
            _db = new WebAppBanHangContext();
            _table = _db.Set<T>();
        }
        public GenericRepository(WebAppBanHangContext db)
        {
            _db = db;
            _table = _db.Set<T>();
        }

        public IEnumerable<T> SelectAll()
        {
            return _table.ToList();
        }

        public T SelectById(object id)
        {
            try
            {
                return _table.Find(id);
            }
            catch
            {
                return null;
            }
        }

        public void Insert(T obj)
        {
            _table.Add(obj);
        }

        public void Update(T obj)
        {
            _table.Attach(obj);
            _db.Entry(obj).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
        }

        public void Delete(object id)
        {
            T existing = _table.Find(id);
            _table.Remove(existing);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}