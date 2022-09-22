using FoodApp.DTO.Request;
using FoodApp.DTO.Response;

namespace FoodApp.Services.Interface
{
    public interface IFoodCrudService
    {
        public Task<List<FoodResponseDto>> GetAllAsync();
        public Task<List<FoodResponseDto>> GetByTypeAsync(long id);
        public Task<FoodResponseDto> GetByIdAsync(long id);
        public Task<FoodResponseDto> CreateAsync(CreateFoodRequestDto inputModel);
        public Task<FoodResponseDto> UpdateAsync(UpdateFoodRequestDto inputModel, long id);
        public Task<FoodResponseDto> DeleteAsync(long id);
    }
}
