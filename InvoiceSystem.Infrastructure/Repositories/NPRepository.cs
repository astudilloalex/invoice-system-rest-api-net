using InvoiceSystem.CommonCRUD.Interfaces;
using InvoiceSystem.CommonCRUD.Models;
using InvoiceSystem.Infrastructure.Connections;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Reflection;

namespace InvoiceSystem.Infrastructure.Repositories;

public class NPRepository<T, ID> : INPRepository<T, ID> where T : class
{
    private readonly PostgreSQLContext _context;

    public NPRepository(PostgreSQLContext context)
    {
        _context = context;
    }

    public long Count()
    {
        return _context?.Set<T>().AsNoTracking().LongCount() ?? 0;
    }

    public Task<long> CountAsync()
    {
        return _context.Set<T>().AsNoTracking().LongCountAsync();
    }

    public Task<long> CountAsync(Expression<Func<T, bool>> predicate)
    {
        return _context.Set<T>().AsNoTracking().LongCountAsync(predicate);
    }

    public int Delete(T entity)
    {
        _context.Set<T>().Remove(entity);
        return _context.SaveChanges();
    }

    public int DeleteAll()
    {
        return _context.Set<T>().ExecuteDelete();
    }

    public int DeleteAll(IEnumerable<T> entities)
    {
        int affectedRows = 0;
        foreach (T entity in entities)
        {
            _context?.Set<T>().Remove(entity);
            affectedRows += _context?.SaveChanges() ?? 0;
        }
        return affectedRows;
    }

    public Task<int> DeleteAllAsync()
    {
        return _context.Set<T>().ExecuteDeleteAsync();
    }

    public async Task<int> DeleteAllAsync(IEnumerable<T> entities)
    {
        int affectedRows = 0;
        foreach (T entity in entities)
        {
            _context.Set<T>().Remove(entity);
            if (_context == null) return 0;
            affectedRows += await _context.SaveChangesAsync();
        }
        return affectedRows;
    }

    public int DeleteAllById(IEnumerable<ID> ids)
    {
        int affectedRows = 0;
        foreach (ID id in ids)
        {
            T? t = _context?.Set<T>().Find(id);
            if (t != null) _context?.Remove(t);
            affectedRows += _context?.SaveChanges() ?? 0;
        }
        return affectedRows;
    }

    public async Task<int> DeleteAllByIdAsync(IEnumerable<ID> ids)
    {
        int affectedRows = 0;
        foreach (ID id in ids)
        {
            T? t = await _context.Set<T>().FindAsync(id);
            if (t != null) _context?.Remove(t);
            affectedRows += await _context!.SaveChangesAsync(); ;

        }
        return affectedRows;
    }

    public Task<int> DeleteAsync(T entity)
    {
        _context.Set<T>().Remove(entity);
        return _context.SaveChangesAsync();
    }

    public int DeleteById(ID id)
    {
        T? t = _context?.Set<T>().Find(id);
        if (t != null) _context?.Remove(t);
        return _context?.SaveChanges() ?? 0;
    }

    public async Task<int> DeleteByIdAsync(ID id)
    {
        int affectedRows = 0;
        T? t = await _context.Set<T>().FindAsync(id);
        if (t != null) _context.Remove(t);
        affectedRows += await _context.SaveChangesAsync();
        return affectedRows;
    }

    public bool ExistsById(ID id)
    {
        return _context?.Set<T>().Find(id) != null;

    }

    public async Task<bool> ExistsByIdAsync(ID id)
    {
        T? t = await _context.Set<T>().FindAsync(id);
        return t != null;
    }

    public IPage<T> FindAll(IPageable pageable)
    {   // Get the offset and page size.
        int skip = Convert.ToInt32(pageable.GetOffset());
        int pageSize = pageable.GetPageSize();

        List<T> data = new();
        // Get sort from pageable.
        if (pageable.GetSort().IsSorted())
        {
            Sort sort = pageable.GetSort();
            List<Order> orders = sort.GetOrders();
            DbSet<T> set = _context.Set<T>();
            foreach (Order order in orders)
            {
                if (order.IsAscending())
                {
                    set.OrderBy(t => t.GetType().GetProperty(order.GetProperty()));
                }
                else
                {
                    set.OrderByDescending(t => t.GetType().GetProperty(order.GetProperty()));
                }
            }
            data.AddRange(set.AsNoTracking().Skip(skip).Take(pageSize).ToList());
        }
        else
        {
            data.AddRange(_context.Set<T>().AsNoTracking().Skip(skip).Take(pageSize).ToList());
        }
        return new Page<T>(data, pageable, Count());
    }

    public IEnumerable<T> FindAll()
    {
        return _context?.Set<T>().AsNoTracking().ToList() ?? new();
    }

    public async Task<IPage<T>> FindAllAsync(IPageable pageable)
    {
        // Get the offset and page size.
        int skip = Convert.ToInt32(pageable.GetOffset());
        int pageSize = pageable.GetPageSize();
        List<T> data = new();
        // Get sort from pageable.
        if (pageable.GetSort().IsSorted())
        {
            Sort sort = pageable.GetSort();
            List<Order> orders = sort.GetOrders();
            DbSet<T> set = _context.Set<T>();
            foreach (Order order in orders)
            {
                if (order.IsAscending())
                {
                    set.OrderBy(t => t.GetType().GetProperty(order.GetProperty()));
                }
                else
                {
                    set.OrderByDescending(t => t.GetType().GetProperty(order.GetProperty()));
                }
            }
            data.AddRange(await set.AsNoTracking().Skip(skip).Take(pageSize).ToListAsync());
        }
        else
        {
            data.AddRange(await _context.Set<T>().AsNoTracking().Skip(skip).Take(pageSize).ToListAsync());
        }
        return new Page<T>(data, pageable, await CountAsync());
    }

    public async Task<IEnumerable<T>> FindAllAsync()
    {
        return await _context.Set<T>().AsNoTracking().ToListAsync();
    }

    public IEnumerable<T> FindAllById(IEnumerable<ID> ids)
    {
        return _context.Set<T>().AsNoTracking().AsEnumerable().Where(t =>
        {
            PropertyInfo property = t.GetType().GetProperties().First(prop =>
            {
                return prop.PropertyType == ids.First()!.GetType() || prop.Name.Equals("Id");
            });
            return ids.Contains((ID?)property.GetValue(t, null));
        }).ToList();
    }

    //public Task<IEnumerable<T>> FindAllByIdAsync(IEnumerable<ID> ids)
    //{
    //    //using PostgreSQL_context? _context = _serviceProvider.GetService<PostgreSQL_context>();
    //    //if (_context == null) throw new ArgumentNullException(nameof(_context), "The database _context is null");
    //    //return _context.Set<T>().AsEnumerable().Where(t =>
    //    //{
    //    //    PropertyInfo property = t.GetType().GetProperties().First(prop =>
    //    //    {
    //    //        return prop.PropertyType == ids.First()!.GetType() || prop.Name.Equals("Id");
    //    //    });
    //    //    return ids.Contains((ID?)property.GetValue(t, null));
    //    //}).ToList();
    //    throw new NotImplementedException();
    //}

    public T? FindById(ID id)
    {
        T? entity = _context.Set<T>().Find(id);
        return entity;
    }

    public ValueTask<T?> FindByIdAsync(ID id)
    {
        return _context.Set<T>().FindAsync(id);
    }

    public T Save(T entity)
    {
        T saved = _context.Set<T>().Add(entity).Entity;
        _context.SaveChanges();
        return saved;
    }

    public IEnumerable<T> SaveAll(IEnumerable<T> entities)
    {
        List<T> saved = new();
        foreach (T entity in entities)
        {
            T t = _context.Set<T>().Add(entity).Entity ?? entity;
            _context.SaveChanges();
            saved.Add(t);
        }
        return saved;
    }

    public async Task<IEnumerable<T>> SaveAllAsync(IEnumerable<T> entities)
    {
        List<T> saved = new();
        foreach (T entity in entities)
        {
            T t = (await _context.Set<T>().AddAsync(entity)).Entity;
            _ = await _context.SaveChangesAsync();
            saved.Add(t);
        }
        return saved;
    }

    public async ValueTask<T> SaveAsync(T entity)
    {
        T saved = (await _context.Set<T>().AddAsync(entity)).Entity;
        await _context.SaveChangesAsync();
        return saved;
    }

    public T Update(T entity)
    {
        T updated = _context.Set<T>().Update(entity).Entity ?? entity;
        _context.SaveChanges();
        return updated;
    }

    public IEnumerable<T> UpdateAll(IEnumerable<T> entities)
    {
        List<T> updated = new();
        foreach (T entity in entities)
        {
            T t = _context.Set<T>().Update(entity).Entity;
            _context.SaveChanges();
            updated.Add(t);
        }
        return updated;
    }

    public async Task<IEnumerable<T>> UpdateAllAsync(IEnumerable<T> entities)
    {
        List<T> updated = new();
        foreach (T entity in entities)
        {
            T t = _context.Set<T>().Update(entity).Entity;
            await _context.SaveChangesAsync();
            updated.Add(t);
        }
        return updated;
    }

    public async ValueTask<T> UpdateAsync(T entity)
    {
        T updated = _context.Set<T>().Update(entity).Entity;
        await _context.SaveChangesAsync();
        return updated;
    }
}