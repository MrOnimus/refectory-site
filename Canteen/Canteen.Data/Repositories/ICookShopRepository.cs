using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Canteen.Data.Entities;

namespace Canteen.Data.Repositories
{
    public interface ICookShopRepository
    {
        Task<List<CookShop>> GetAllAsync();
        Task<CookShop> GetByIdAsync(Guid id);
        Task<CookShop> CreateAsync(CookShop item);
        Task<bool> UpdateAsync(CookShop item);
        Task<bool> DeleteAsync(Guid id);
    }
}
