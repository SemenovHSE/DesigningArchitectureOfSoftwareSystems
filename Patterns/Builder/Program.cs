using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.Builder;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            BakingBuilder bakingBuilder = new BakingBuilder();
            director.Builder = bakingBuilder;

            director.MakeSweetPie();
            Console.WriteLine("Ингредиенты сладкого пирога:");
            bakingBuilder.GetBaking().Show();

            director.MakeHamCheesePasty();
            Console.WriteLine("Ингредиенты пирожка с ветчиной и сыром:");
            bakingBuilder.GetBaking().Show();

            director.MakeFruitPie();
            Console.WriteLine("Ингредиенты фруктового пирога:");
            bakingBuilder.GetBaking().Show();
        }
    }
}
