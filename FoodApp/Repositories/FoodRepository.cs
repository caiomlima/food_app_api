using FoodApp.Data;
using FoodApp.DTO.Request;
using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace FoodApp.Repositories
{
    public class FoodRepository
    {
        protected DataContext Ctx;

        public FoodRepository(DataContext ctx)
        {
            Ctx = ctx;
        }

        public async Task<List<Food>> GetAllAsync()
        {
            return await Ctx.Food.AsNoTracking().ToListAsync();
        }

        public async Task<List<Food>> GetByTypeAsync(long id)
        {
            return await Ctx.Food.Where(x => ((long)x.FoodType) == id).AsNoTracking().ToListAsync();
        }

        public async Task<Food> GetByIdAsync(long id)
        {
            return await Ctx.Food.SingleAsync(x => x.Id == id);
        }

        public async Task SaveAsync()
        {
            await Ctx.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            Food food = await Ctx.Food.SingleAsync(x => x.Id == id);
            Ctx.Remove(food);
        }
    }
}
