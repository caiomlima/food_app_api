using FoodApp.Commons;

namespace FoodApp.Entities
{
    public class Food
    {
        public long Id { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public FoodType FoodType { get; internal set; }

        public Food(long id, string name, string description, FoodType foodType)
        {
            Id = id;
            Name = name;
            Description = description;
            FoodType = foodType;
        }

        public Food(){}
    }
}
