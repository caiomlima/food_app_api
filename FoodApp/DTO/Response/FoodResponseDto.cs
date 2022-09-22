using FoodApp.Commons;
using FoodApp.Entities;

namespace FoodApp.DTO.Response
{
    public class FoodResponseDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public FoodType FoodType { get; set; }

        public static explicit operator FoodResponseDto(Food entity)
        {
            return new FoodResponseDto
            {
                Id = entity.Id,
                Name = entity.Name,
                Description = entity.Description,
                FoodType = entity.FoodType,
            };
        }
    }
}