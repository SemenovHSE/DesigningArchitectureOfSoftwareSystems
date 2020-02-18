using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Composite
{
    public interface Food
    {
        string Name { get; }
        int GetMicronutrients();
        string ShowComposition();
    }
    public class Ingredient : Food
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private int micronutrients;
        public Ingredient(string _name, int _micronutrients)
        {
            name = _name;
            micronutrients = _micronutrients;
        }
        public int GetMicronutrients()
        {
            return micronutrients;
        }
        public string ShowComposition()
        {
            return name;
        }
    }
    public class Dish : Food
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }
        }
        private List<Food> parts;
        public List<Food> Parts
        {
            get
            {
                return parts;
            }
            private set
            {
                parts = value;
            }
        }
        public Dish(string _name)
        {
            name = _name;
            parts = new List<Food>();
        }
        public Dish(string _name, List<Food> _parts)
        {
            name = _name;
            parts = _parts;
        }
        public void Add(Food part)
        {
            parts.Add(part);
        }
        public void Remove(Food part)
        {
            parts.Remove(part);
        }
        public int GetMicronutrients()
        {
            int micronutrients = 0;
            foreach (Food part in parts)
            {
                micronutrients += part.GetMicronutrients();
            }
            return micronutrients;
        }
        public string ShowComposition()
        {
            string result = "";
            bool first = true;
            foreach (Food part in parts)
            {
                if (first)
                {
                    result += part.ShowComposition();
                    first = false;
                    continue;
                }
                result += " ";
                result += part.ShowComposition();
            }
            return result;
        }
    }
}
