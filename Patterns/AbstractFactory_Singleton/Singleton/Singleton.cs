using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory_Singleton.AbstractFactory;

namespace AbstractFactory_Singleton.Singleton
{
    public class RestaurantManager
    {
        private static RestaurantManager manager = null;
        private Restaurant mainRestaurant;
        private RestaurantManager()
        {
            mainRestaurant = new Restaurant(new RussianMenu());
        }
        public static RestaurantManager Manager
        {
            get
            {
                if (manager == null)
                {
                    manager = new RestaurantManager();
                }
                return manager;
            }
        }
        public void ShowFullMenu()
        {
            mainRestaurant.ShowMenu();
        }
    }
}
