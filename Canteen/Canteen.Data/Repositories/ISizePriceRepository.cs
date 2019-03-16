using Canteen.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Data.Repositories
{
    public interface ISizePriceRepository
    {
        Task<List<SizePrice>> GetAllAsync();
        Task<SizePrice> GetByIdAsync(Guid id);
        Task<List<SizePrice>> GetByDishAsync(Guid id);
        Task<SizePrice> CreateAsync(SizePrice item);
        Task<bool> CreateRangeAsync(List<SizePrice> item);
        Task<bool> UpdateAsync(SizePrice item);
        Task<bool> UpdateRangeAsync(List<SizePrice> item);
        Task<bool> DeleteAsync(Guid id);
    }
}
