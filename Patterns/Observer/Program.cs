using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Observer.Observer;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Analyst analyst1 = new Analyst("Аналитик1");
            Analyst analyst2 = new Analyst("Аналитик2");
            Analyst analyst3 = new Analyst("Аналитик3");
            Analyst analyst4 = new Analyst("Аналитик4");
            Dashboard dashboard = new Dashboard();
            dashboard.AddObserver(analyst1);
            dashboard.AddObserver(analyst2);
            dashboard.AddObserver(analyst3);
            dashboard.AddObserver(analyst4);
            dashboard.NotifyObservers();
            dashboard.RemoveObserver(analyst2);
            dashboard.NotifyObservers();
        }
    }
}
