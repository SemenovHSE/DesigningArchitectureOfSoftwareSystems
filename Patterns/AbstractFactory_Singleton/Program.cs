using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Singleton.AbstractFactory;
using AbstractFactory_Singleton.Singleton;

namespace AbstractFactory_Singleton
{
    public enum RestaurantType
    {
        Russian = 1,
        Italian = 2,
        Chinese = 3
    }

    class Program
    {
        static void Main(string[] args)
        {
            Restaurant currentRestaurant;
            Console.WriteLine("Какой ресторан желаете посетить?\n1. Русский\n2. Итальянский\n3. Китайский");
            int number = Convert.ToInt32(Console.ReadLine());
            RestaurantType type = (RestaurantType)number;
            switch (type)
            {
                case RestaurantType.Russian:
                    currentRestaurant = new Restaurant(new RussianMenu());
                    break;
                case RestaurantType.Italian:
                    currentRestaurant = new Restaurant(new ItalianMenu());
                    break;
                case RestaurantType.Chinese:
                    currentRestaurant = new Restaurant(new ChineseMenu());
                    break;
                default:
                    throw new Exception("Сделан некорректный выбор!");
            }
            currentRestaurant.ShowMenu();
            RestaurantManager manager_ = RestaurantManager.Manager;
            RestaurantManager manager1 = RestaurantManager.Manager;
            if (manager_ == manager1)
            {
                Console.WriteLine("Переменные указывают на один и тот же объект!");
            }
            else
            {
                Console.WriteLine("Переменные указывают на разные объекты!");
            }
            manager_.ShowFullMenu();
        }
    }
}
