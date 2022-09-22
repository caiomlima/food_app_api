using FoodApp.DTO.Request;
using FoodApp.DTO.Response;
using FoodApp.Entities;
using FoodApp.Repositories;
using FoodApp.Services.Interface;

namespace FoodApp.Services
{
    public class FoodCrudService : IFoodCrudService
    {
        private readonly FoodRepository _foodRepository;

        public FoodCrudService(FoodRepository foodRepository)
        {
            _foodRepository = foodRepository;
        }

        public async Task<List<FoodResponseDto>> GetAllAsync()
        {
            var response = await _foodRepository.GetAllAsync();
            return response.Select(x => (FoodResponseDto)x).ToList();
        }

        public async Task<List<FoodResponseDto>> GetByTypeAsync(long id)
        {
            var response = await _foodRepository.GetByTypeAsync(id);
            return response.Select(x => (FoodResponseDto)x).ToList();
        }

        public async Task<FoodResponseDto> GetByIdAsync(long id)
        {
            var response = await _foodRepository.GetByIdAsync(id);
            return (FoodResponseDto)response;
        }

        public async Task<FoodResponseDto> CreateAsync(CreateFoodRequestDto inputModel)
        {
            //return (FoodResponseDto)await _foodRepository.SaveAsync(
            //    new Food
            //    (
            //        inputModel.Name,
            //        inputModel.Description,
            //        inputModel.FoodType
            //    )
            //);

            throw new NotImplementedException();
        }

        public Task<FoodResponseDto> UpdateAsync(UpdateFoodRequestDto inputModel, long id)
        {
            throw new NotImplementedException();
        }

        public async Task<FoodResponseDto> DeleteAsync(long id)
        {
            //return await _foodRepository.DeleteAsync(id);

            throw new NotImplementedException();
        }

    }
}
