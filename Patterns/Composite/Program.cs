using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Composite.Composite;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Dish puff = new Dish("Слойка с фруктами");
            Dish dough = new Dish("Бездрожжевое слоёное тесто");
            Ingredient flour = new Ingredient("Мука", 10);
            Ingredient butter = new Ingredient("Сливочное масло", 70);
            Ingredient salt = new Ingredient("Соль", 3);
            dough.Add(flour);
            dough.Add(butter);
            dough.Add(salt);
            Ingredient fruits = new Ingredient("Фрукты", 100);
            Ingredient sugar = new Ingredient("Сахар", 15);
            Ingredient sourCream = new Ingredient("Сметана", 50);
            puff.Add(dough);
            puff.Add(fruits);
            puff.Add(sugar);
            puff.Add(sourCream);

            Console.WriteLine("Состав слойки с фруктами:");
            Console.WriteLine(puff.ShowComposition());
            Console.WriteLine("Количество полезных микроэлементов в слойке с фруктами:");
            Console.WriteLine(puff.GetMicronutrients());

            Console.WriteLine("Состав бездрожжевого слоёного теста:");
            Console.WriteLine(dough.ShowComposition());
            Console.WriteLine("Количество полезных микроэлементов в бездрожжевом слоёном тесте:");
            Console.WriteLine(dough.GetMicronutrients());

            Console.WriteLine("Состав фруктов:");
            Console.WriteLine(fruits.ShowComposition());
            Console.WriteLine("Количество полезных микроэлементов во фруктах:");
            Console.WriteLine(fruits.GetMicronutrients());
        }
    }
}
