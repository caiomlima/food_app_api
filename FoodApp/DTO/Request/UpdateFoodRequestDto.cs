using FoodApp.Commons;
using FoodApp.DTO.Response;
using FoodApp.Entities;
using System.ComponentModel.DataAnnotations;
using static FoodApp.Entities.Food;

namespace FoodApp.DTO.Request
{
    public class UpdateFoodRequestDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TypeOfFood FoodType { get; set; }

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