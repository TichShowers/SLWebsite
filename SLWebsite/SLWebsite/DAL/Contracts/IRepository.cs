using System.Linq;
using System.Web.DynamicData;

namespace SLWebsite.DAL.Contracts
{
    public interface IRepository<T> where T : class 
    {
        IQueryable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void SaveChanges();
    }
}