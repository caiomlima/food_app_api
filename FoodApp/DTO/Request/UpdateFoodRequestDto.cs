using FoodApp.Commons;
using FoodApp.DTO.Response;
using FoodApp.Entities;

namespace FoodApp.DTO.Request
{
    public class UpdateFoodRequestDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }

        public static explicit operator UpdateFoodRequestDto(Food entity)
        {
            return new UpdateFoodRequestDto
            {
                Name = entity.Name,
                Description = entity.Description,
                FoodType = entity.FoodType,
            };
        }
    }
}