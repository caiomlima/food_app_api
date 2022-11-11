using FoodApp.Data;
using FoodApp.DTO.Request;
using FoodApp.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
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

        public async Task<List<Food>> GetByTypeAsync(long id, CancellationToken cancellationToken)
        {
            return await Ctx.Food.Where(x => ((long)x.FoodType) == id).AsNoTracking().ToListAsync(cancellationToken);
        }

        public async Task<Food> GetByIdAsync(long id)
        {
            return await Ctx.Food.SingleAsync(x => x.Id == id);
        }

        public async Task CreateAsync(Food food, CancellationToken cancellationToken)
        {
            await Ctx.AddAsync(food, cancellationToken);
            await Ctx.SaveChangesAsync();
        }

        public async Task UpdateAsync(Food food)
        {
            Ctx.Update(food);
            await Ctx.SaveChangesAsync();
        }

        public async Task<bool> DeleteAsync(long id, CancellationToken cancellationToken)
        {
            var food = await Ctx.Food.SingleAsync(x => x.Id == id);
            Ctx.Remove(food);

            return (await Ctx.SaveChangesAsync(cancellationToken)) > 0;
        }
    }
}
