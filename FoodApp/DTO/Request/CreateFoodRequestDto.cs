using FoodApp.Commons;
using System.ComponentModel.DataAnnotations;

namespace FoodApp.DTO.Request
{
    public class CreateFoodRequestDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public FoodType FoodType{ get; set; }
    }