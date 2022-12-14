using InvoiceSystem.CommonCRUD.Interfaces;

namespace InvoiceSystem.Domain.Interfaces.Services;

public interface INPService<T, ID> where T : class
{
    public Task<T> AddAsync(T entity);
    public Task<T> UpdateAsync(T entity);
    public Task<List<T>> GetAllAsync();
    public Task<IPage<T>> GetAllAsync(IPageable pageable);
    public Task<T?> GetByIdAsync(ID id);
}
