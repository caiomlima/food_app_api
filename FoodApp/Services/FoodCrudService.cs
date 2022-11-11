using Api.Domain;
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
        private readonly INotificationContext _notificationContext;

        public FoodCrudService(FoodRepository foodRepository, INotificationContext notificationContext)
        {
            _foodRepository = foodRepository;
            _notificationContext = notificationContext;
        }

        public async Task<List<FoodResponseDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            var response = await _foodRepository.GetAllAsync();

            return response.Select(x => (FoodResponseDto)x).ToList();
        }

        public async Task<List<FoodResponseDto>> GetByTypeAsync(long typeId, CancellationToken cancellationToken)
        {
            var response = await _foodRepository.GetByTypeAsync(typeId, cancellationToken);

            return response.Select(x => (FoodResponseDto)x).ToList();
        }

        public async Task<FoodResponseDto> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            if(id == 0)
            {
                //_notificationContext.AddNotification("InvalidId");
                return default;
            }

            var response = await _foodRepository.GetByIdAsync(id);

            return (FoodResponseDto)response;
        }

        public async Task<FoodResponseDto> CreateAsync(CreateFoodRequestDto inputModel, CancellationToken cancellationToken)
        {
            var newFood = (Food)inputModel;
            await _foodRepository.CreateAsync(newFood, cancellationToken);

            return (FoodResponseDto)newFood;
        }

        public async Task<FoodResponseDto> UpdateAsync(long id, UpdateFoodRequestDto inputModel, CancellationToken cancellationToken)
        {
            var food = await _foodRepository.GetByIdAsync(id);

            if(food == null)
            {
                //_notificationContext.AddNotification("InvalidFoodItem");
                return default;
            }

            food.UpdateFrom(inputModel);
            await _foodRepository.UpdateAsync(food);

            return (FoodResponseDto)food;
        }

        public async Task<bool> DeleteAsync(long id, CancellationToken cancellationToken)
        {
            if(id == 0)
            {
                //_notificationContext.AddNotification("InvalidFoodItem");
                return default;
            }

            var response = await _foodRepository.DeleteAsync(id, cancellationToken);

            return response;
        }

    }
}
