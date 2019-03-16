using Canteen.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(Guid id);
        Task<List<Category>> GetByCookShopAsync(Guid id);
        Task<Category> CreateAsync(Category item);
        Task<bool> UpdateAsync(Category item);
        Task<bool> DeleteAsync(Guid id);
    }
}
