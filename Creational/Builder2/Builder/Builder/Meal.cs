using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class Meal
    {
        public string MainCourse { get; set; }
        public List<string> Sides { get; set; } = new List<string>();
        public List<string> Drinks { get; set; } = new List<string>();
        public bool IsVegetarian { get; set; }
        public bool HasDessert { get; set; }

        public override string ToString()
        {
            var mealDescription = $"Main Course: {MainCourse}\n";
            mealDescription += $"Sides: {string.Join(", ", Sides)}\n";
            mealDescription += $"Drinks: {string.Join(", ", Drinks)}\n";
            mealDescription += $"Vegetarian: {(IsVegetarian ? "Yes" : "No")}\n";
            mealDescription += $"Dessert: {(HasDessert ? "Included" : "Not Included")}";
            return mealDescription;
        }
    }

}
