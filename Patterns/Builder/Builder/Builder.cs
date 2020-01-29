using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
   //мука масло вода дрожжи слоеное дожевое

    public interface Builder
    {
        void TakeFlour();
        void TakeButter();
        void TakeWater();
        void TakeYeast();
        void TakeSugar();
        void TakePuffPastryRecipe(); // слоеное
        void TakeYeastDoughRecipe(); // дрожжевое
        void TakePuffYeastDoughRecipe(); // слоеное дрожжевое
        void TakeJam();
        void TakeFruits();
        void TakeCheese();
        void TakeHam();
        void TakeSauceForSweetPastries();
        void TakeKetchup();
        void TakeMayonnaise();
        void Reset();
    }

    public class BakingBuilder : Builder
    {
        private Baking baking;
        public BakingBuilder()
        {
            Reset();
        }
        public void TakeFlour()
        {
            baking.Add("Мука");
        }
        public void TakeButter()
        {
            baking.Add("Масло");
        }
        public void TakeWater()
        {
            baking.Add("Вода");
        }
        public void TakeYeast()
        {
            baking.Add("Дрожжи");
        }
        public void TakeSugar()
        {
            baking.Add("Сахар");
        }
        public void TakePuffPastryRecipe()
        {
            baking.Add("Рецепт слоеного теста");
        }
        public void TakeYeastDoughRecipe()
        {
            baking.Add("Рецепт дрожжевого теста");
        }
        public void TakePuffYeastDoughRecipe()
        {
            baking.Add("Рецепт слоеного дрожжевого теста");
        }
        public void TakeJam()
        {
            baking.Add("Джем");
        }
        public void TakeFruits()
        {
            baking.Add("Фрукты");
        }
        public void TakeCheese()
        {
            baking.Add("Сыр");
        }
        public void TakeHam()
        {
            baking.Add("Ветчина");
        }
        public void TakeSauceForSweetPastries()
        {
            baking.Add("Соус для сладкой выпечки");
        }
        public void TakeKetchup()
        {
            baking.Add("Кетчуп");
        }
        public void TakeMayonnaise()
        {
            baking.Add("Майонез");
        }
        public void Reset()
        {
            baking = new Baking();
        }
        public Baking GetBaking()
        {
            Baking baking_ = baking;
            Reset();
            return baking_;
        }
    }
    public class Baking
    {
        private List<string> ingredients = new List<string>();
        public void Add(string ingredient)
        {
            ingredients.Add(ingredient);
        }
        public void Show()
        {
            string result = "";
            bool first = true;
            for (int i = 0; i < ingredients.Count; i++)
            {
                if (first)
                {
                    result += ingredients[i];
                    first = false;
                    continue;
                }
                result += " ";
                result += ingredients[i];
            }
            Console.WriteLine(result);
        }
    }
    public class Director
    {
        private Builder builder;
        public Builder Builder
        {
            set
            {
                builder = value;
            }
        }
        public void MakeSweetPie()
        {
            builder.TakeFlour();
            builder.TakeButter();
            builder.TakePuffPastryRecipe();
            builder.TakeSugar();
            builder.TakeJam();
            builder.TakeFruits();
            builder.TakeSauceForSweetPastries();
        }
        public void MakeHamCheesePasty()
        {
            builder.TakeFlour();
            builder.TakeWater();
            builder.TakeYeast();
            builder.TakeYeastDoughRecipe();
            builder.TakeCheese();
            builder.TakeHam();
            builder.TakeKetchup();
            builder.TakeMayonnaise();
        }
        public void MakeFruitPie()
        {
            builder.TakeFlour();
            builder.TakeWater();
            builder.TakeButter();
            builder.TakeYeast();
            builder.TakePuffYeastDoughRecipe();
            builder.TakeSugar();
            builder.TakeFruits();
        }
    }
}
