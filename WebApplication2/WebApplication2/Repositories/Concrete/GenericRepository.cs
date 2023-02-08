using System.Linq.Expressions;
using WebApplication2.Areas.Identity.Data;
using WebApplication2.Entities;
using WebApplication2.Repositories.Abstract;

namespace WebApplication2.Repositories.Concrete;

public class GenericRepository<T> : IRepository<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _db;

    public GenericRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public bool Add(T entity)
    {
        try
        {
            _db.Set<T>().Add(entity);
            return _db.SaveChanges() > 0;
        }
        catch
        {

            return false;
        }
    }

    public bool Delete(T entity)
    {
        try
        {
            _db.Set<T>().Remove(entity);
            return _db.SaveChanges() > 0;
        }
        catch
        {

            return false;
        }
    }

    public IEnumerable<T> GetAll()
    {
        return _db.Set<T>();
    }

    public T GetById(int id)
    {
        return _db.Set<T>().FirstOrDefault(a => a.ID == id);
        //return db.Set<T>().Find(id);
    }

    public IEnumerable<T> GetWhere(Expression<Func<T, bool>> predicate)
    {
        return _db.Set<T>().Where(predicate);
    }

    public T SingleOrDefault(Expression<Func<T, bool>> predicate)
    {
        return _db.Set<T>().SingleOrDefault(predicate);
    }

    public bool Update(T entity)
    {
        try
        {
            //Update metodu içine gönderilen entity'de id varsa ilgili id'ye sahip entity'yi update eder, id yok ise add gibi çalışır. Bu sebeple tek bir AddOrUpdate metodu da kullanılabilir
            _db.Set<T>().Update(entity);
            return _db.SaveChanges() > 0;
        }
        catch
        {

            return false;
        }
    }
}