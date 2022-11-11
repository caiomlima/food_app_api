using FoodApp.Commons;
using FoodApp.Entities;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using static FoodApp.Entities.Food;

namespace FoodApp.DTO.Request
{
    public class CreateFoodRequestDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public TypeOfFood FoodType { get; set; }

        public static explicit operator Food(CreateFoodRequestDto inputModel)
        {
            return new Food
            (
                inputModel.Name,
                inputModel.Description,
                inputModel.FoodType
            );
        }
    }
}