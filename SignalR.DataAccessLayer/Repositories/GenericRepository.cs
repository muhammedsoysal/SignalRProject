using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalR.DataAccessLayer.Abstract;
using SignalR.DataAccessLayer.Concrete;

namespace SignalR.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private readonly SignalRContext _context;

        public GenericRepository(SignalRContext signalRContext)
        {
            _context = signalRContext;
        }


        public void Add(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }

        public T GetById(int id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return _context.Find<T>(id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public List<T> GetListAll()
        {
            return _context.Set<T>().ToList();
        }
    }
}
