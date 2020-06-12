using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Observer
{
    public interface Observable
    {
        void AddObserver(Observer observer);
        void RemoveObserver(Observer observer);
        void NotifyObservers();
    }

    public interface Observer
    {
        void CheckDashboard(Information information);
    }

    public class Analyst : Observer
    {
        private string fullName;

        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }

        public Analyst(string _fullName)
        {
            FullName = _fullName;
        }
        
        public void CheckDashboard(Information information)
        {
            Console.WriteLine(FullName + " " + "Проверка дашборда!");
            information.ShowDashboardData();
        }
    }

    public class Dashboard : Observable
    {
        private List<Observer> observers;

        public Dashboard()
        {
            observers = new List<Observer>();
        }

        public void AddObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            List<string> data = new List<string>()
            {
                "Температура",
                "Влажность",
                "Электропотребление"
            };
            Information information = new Information(data);
            foreach (Observer observer in observers)
            {
                observer.CheckDashboard(information);
            }
        }
    }

    public class Information
    {
        private List<string> dashboardData;

        public List<string> DashboardData
        {
            get
            {
                return dashboardData;
            }
            set
            {
                dashboardData = value;
            }
        }

        public Information()
        {
            DashboardData = new List<string>();
        }

        public Information(List<string> data)
        {
            DashboardData = data;
        }

        public void ShowDashboardData()
        {
            string result = "";
            for (int i = 0; i < DashboardData.Count; i++)
            {
                result += DashboardData[i];
                if (i != DashboardData.Count - 1)
                {
                    result += ", ";
                }
            }
            Console.WriteLine("Информация с дашборда: " + result);
        }
    }
}
