using Canteen.Core.EF;
using Canteen.Data.Entities;
using Canteen.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Core.Repositories
{
    public class DishRepository : IDishRepository
    {
        private readonly CanteenDbContext _context;
        private readonly ISizePriceRepository _repoSP;
        private readonly ICategoryRepository _repoCtg;

        public DishRepository(CanteenDbContext context, ISizePriceRepository repoSP, ICategoryRepository repoCtg)
        {
            _context = context;
            _repoSP = repoSP;
            _repoCtg = repoCtg;
        }

        public async Task<List<Dish>> GetAllAsync()
        {
            return await _context.Dishes.ToListAsync();
        }

        public async Task<Dish> GetByIdAsync(Guid id)
        {
            return await _context.Dishes.FindAsync(id);
        }

        public async Task<List<Dish>> GetByCategoryAsync(Guid id)
        {
            return await _context.Dishes.Where(x => x.CategoryId == id).ToListAsync();
        }

        public async Task<List<Dish>> GetByCookShopAsync(Guid id)
        {
            List<Category> categories = await _repoCtg.GetByCookShopAsync(id);
            List<Dish> result = new List<Dish>();
            foreach(Category c in categories)
            {
                List<Dish> dishes = await GetByCategoryAsync(c.Id);
                if (dishes.Count > 0)
                    result.AddRange(dishes);
            }
            return result;
        }
        public async Task<Dish> CreateAsync(Dish item)
        {
            var result = await _context.Dishes.AddAsync(item);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> UpdateAsync(Dish item)
        {
            _context.Dishes.Update(item);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            Dish d = await _context.Dishes.FindAsync(id);
            if (d == null)
                return false;
            _context.Dishes.Remove(d);
            return true;
        }  
    }
}
