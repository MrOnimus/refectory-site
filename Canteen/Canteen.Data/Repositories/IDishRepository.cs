using Canteen.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Data.Repositories
{
    public interface IDishRepository
    {
        Task<List<Dish>> GetAllAsync();
        Task<Dish> GetByIdAsync(Guid id);
        Task<List<Dish>> GetByCategoryAsync(Guid id);
        Task<List<Dish>> GetByCookShopAsync(Guid id);
        Task<Dish> CreateAsync(Dish item);
        Task<bool> UpdateAsync(Dish item);
        Task<bool> DeleteAsync(Guid id);
    }
}
