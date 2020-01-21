using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Singleton.AbstractFactory
{
    public interface Salad
    {
        void ShowSaladInfo();
    }

    public class RussianSalad : Salad
    {
        public void ShowSaladInfo()
        {
            Console.WriteLine("Русский салат!");
        }
    }

    public class ItalianSalad : Salad
    {
        public void ShowSaladInfo()
        {
            Console.WriteLine("Итальянский салат!");
        }
    }

    public class ChineseSalad : Salad
    {
        public void ShowSaladInfo()
        {
            Console.WriteLine("Китайский салат!");
        }
    }

    public interface Soup
    {
        void ShowSoupInfo();
    }

    public class RussianSoup : Soup
    {
        public void ShowSoupInfo()
        {
            Console.WriteLine("Русский суп!");
        }
    }

    public class ItalianSoup : Soup
    {
        public void ShowSoupInfo()
        {
            Console.WriteLine("Итальянский суп!");
        }
    }

    public class ChineseSoup : Soup
    {
        public void ShowSoupInfo()
        {
            Console.WriteLine("Китайский суп!");
        }
    }

    public interface MainDish
    {
        void ShowMainDishInfo();
    }

    public class RussianMainDish : MainDish
    {
        public void ShowMainDishInfo()
        {
            Console.WriteLine("Русское основное блюдо!");
        }
    }

    public class ItalianMainDish : MainDish
    {
        public void ShowMainDishInfo()
        {
            Console.WriteLine("Итальянское основное блюдо!");
        }
    }

    public class ChineseMainDish : MainDish
    {
        public void ShowMainDishInfo()
        {
            Console.WriteLine("Китайское основное блюдо!");
        }
    }

    public interface Dessert
    {
        void ShowDessertInfo();
    }

    public class RussianDessert : Dessert
    {
        public void ShowDessertInfo()
        {
            Console.WriteLine("Русский десерт!");
        }
    }

    public class ItalianDessert : Dessert
    {
        public void ShowDessertInfo()
        {
            Console.WriteLine("Итальянский десерт!");
        }
    }

    public class ChineseDessert : Dessert
    {
        public void ShowDessertInfo()
        {
            Console.WriteLine("Китайский десерт!");
        }
    }

    public interface Menu
    {
        Salad ShowSalad();
        Soup ShowSoup();
        MainDish ShowMainDish();
        Dessert ShowDessert();
    }

    public class RussianMenu : Menu
    {
        public Salad ShowSalad()
        {
            return new RussianSalad();
        }

        public Soup ShowSoup()
        {
            return new RussianSoup();
        }

        public MainDish ShowMainDish()
        {
            return new RussianMainDish();
        }

        public Dessert ShowDessert()
        {
            return new RussianDessert();
        }
    }

    public class ItalianMenu : Menu
    {
        public Salad ShowSalad()
        {
            return new ItalianSalad();
        }

        public Soup ShowSoup()
        {
            return new ItalianSoup();
        }

        public MainDish ShowMainDish()
        {
            return new ItalianMainDish();
        }

        public Dessert ShowDessert()
        {
            return new ItalianDessert();
        }
    }

    public class ChineseMenu : Menu
    {
        public Salad ShowSalad()
        {
            return new ChineseSalad();
        }

        public Soup ShowSoup()
        {
            return new ChineseSoup();
        }

        public MainDish ShowMainDish()
        {
            return new ChineseMainDish();
        }

        public Dessert ShowDessert()
        {
            return new ChineseDessert();
        }
    }

    public class Restaurant
    {
        private Menu menu;
        private Salad salad;
        private Soup soup;
        private MainDish mainDish;
        private Dessert dessert;
        public Restaurant(Menu _menu)
        {
            menu = _menu;
            salad = menu.ShowSalad();
            soup = menu.ShowSoup();
            mainDish = menu.ShowMainDish();
            dessert = menu.ShowDessert();
        }
        public void ShowMenu()
        {
            salad.ShowSaladInfo();
            soup.ShowSoupInfo();
            mainDish.ShowMainDishInfo();
            dessert.ShowDessertInfo();
        }
    }
}
