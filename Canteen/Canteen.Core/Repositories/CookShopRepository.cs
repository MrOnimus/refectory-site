using Canteen.Core.EF;
using Canteen.Data.Entities;
using Canteen.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Canteen.Core.Repositories
{
    public class CookShopRepository: ICookShopRepository
    {
        private readonly CanteenDbContext _context;

        public CookShopRepository(CanteenDbContext context)
        {
            _context = context;
        }

        public async Task<List<CookShop>> GetAllAsync()
        {
            return await _context.CookShops.ToListAsync();
        }

        public async Task<CookShop> GetByIdAsync(Guid id)
        {
            return await _context.CookShops
                .Include(x => x.Categories)
                .FirstAsync(y => y.Id == id);
        }

        public async Task<CookShop> CreateAsync(CookShop item)
        {
            var result = await _context.CookShops.AddAsync(item);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<bool> UpdateAsync(CookShop item)
        {
            _context.CookShops.Update(item);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            CookShop cs = await _context.CookShops.FindAsync(id);
            if (cs == null)
                return false;
            _context.CookShops.Remove(cs);
            return true;
        }
    }
}
