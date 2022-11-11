using FoodApp.DTO.Request;
using FoodApp.DTO.Response;

namespace FoodApp.Services.Interface
{
    public interface IFoodCrudService
    {
        public Task<List<FoodResponseDto>> GetAllAsync(CancellationToken cancellationToken);
        public Task<List<FoodResponseDto>> GetByTypeAsync(long typeId, CancellationToken cancellationToken);
        public Task<FoodResponseDto> GetByIdAsync(long id, CancellationToken cancellationToken);
        public Task<FoodResponseDto> CreateAsync(CreateFoodRequestDto inputModel, CancellationToken cancellationToken);
        public Task<FoodResponseDto> UpdateAsync(long id, UpdateFoodRequestDto inputModel, CancellationToken cancellationToken);
        public Task<bool> DeleteAsync(long id, CancellationToken cancellationToken);
    }
}
