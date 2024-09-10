using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public interface IMealBuilder
    {
        IMealBuilder SetMainCourse(string mainCourse);
        IMealBuilder AddSide(string side);
        IMealBuilder AddDrink(string drink);
        IMealBuilder SetVegetarian(bool isVegetarian);
        IMealBuilder AddDessert();
        Meal Build();
    }

    public class MealBuilder : IMealBuilder
    {
        private readonly Meal _meal;

        public MealBuilder()
        {
            _meal = new Meal();
        }

        public IMealBuilder SetMainCourse(string mainCourse)
        {
            _meal.MainCourse = mainCourse;
            return this;
        }

        public IMealBuilder AddSide(string side)
        {
            _meal.Sides.Add(side);
            return this;
        }

        public IMealBuilder AddDrink(string drink)
        {
            _meal.Drinks.Add(drink);
            return this;
        }

        public IMealBuilder SetVegetarian(bool isVegetarian)
        {
            _meal.IsVegetarian = isVegetarian;
            return this;
        }

        public IMealBuilder AddDessert()
        {
            _meal.HasDessert = true;
            return this;
        }

        public Meal Build()
        {
            return _meal;
        }
    }



}
