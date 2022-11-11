using FoodApp.Commons;
using FoodApp.DTO.Request;

namespace FoodApp.Entities
{
    public class Food
    {
        public long Id { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public TypeOfFood FoodType { get; internal set; }

        public Food() { }

        public Food(string name, string description, TypeOfFood foodType)
        {
            Name = name;
            Description = description;
            FoodType = foodType;
        }


        public void UpdateFrom(UpdateFoodRequestDto inputModel)
        {
            Name = inputModel.Name;
            Description = inputModel.Description;
            FoodType = inputModel.FoodType;
        }


        public enum TypeOfFood
        {
            Fritura = 1,
            Pizza = 2,
            Frios = 3,
            Sobremesa = 4,
            Massa = 5
        }
    }
}
