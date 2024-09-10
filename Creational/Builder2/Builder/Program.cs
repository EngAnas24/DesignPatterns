using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main()
        {
            // إنشاء وجبة مخصصة باستخدام Builder
            var builder = new MealBuilder();
            Meal customMeal = builder
                .SetMainCourse("Grilled Chicken")
                .AddSide("Caesar Salad")
                .AddSide("Garlic Bread")
                .AddDrink("Iced Tea")
                .SetVegetarian(false)
                .AddDessert()
                .Build();

            // طباعة تفاصيل الوجبة
            Console.WriteLine("Your custom meal:");
            Console.WriteLine(customMeal);

            Console.ReadKey();
        }
    }

}
