using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2hw3
{
    public class Present
    {
        private Candy[] _candyArr = new Candy[]
        {
            new ChocolateCandies { Calories = 535, Weight = 45, Name = "Chocolate Candies" },
            new BlackChocolateCandies { Calories = 505, Weight = 40, Name = "Black Chocolate Candies" },
            new BlackChocolateCandiesWithNuts { Calories = 575, Weight = 50, Name = "Black Chocolate Candies with nuts" },
            new AeratedBlackChocolatesCandiesWithNuts { Calories = 575, Weight = 60, Name = "Aerated Black Chocolates Candies With Nuts" },
            new BlackChocolateCandiesWithNuts { Calories = 575, Weight = 30, Name = "Black Chocolate Candies with nuts" }
        };
        private Consider1 _consider = new Consider1();
        public void Print()
        {
            Console.WriteLine("Present:");
            var weight = 0;
            var i = 0;
            foreach (var item in _candyArr)
            {
                i++;
                var x = _consider.ConsiderCalories(item.Weight, item.Calories);
                weight += item.Weight;
                Console.WriteLine($"{i}){item.Name},{item.Calories} Kk,{item.Weight} Gr,calories on weiht = {x}");
            }

            Console.WriteLine($"Weight box is {weight},gram");
            Console.WriteLine("-------------------------------");
        }

        public void PrintSortArray()
        {
            Console.WriteLine("Sort Array by parametr Weight:");
            Array.Sort(_candyArr);
            foreach (var item in _candyArr)
            {
                Console.WriteLine($"{item.Name},{item.Calories}Kk,{item.Weight}gr");
            }

            Console.WriteLine("-----------------------");
        }

        public string TakeCandy(string name)
        {
            Console.Write("I take its: ");
            var candy = string.Empty;
            foreach (var item in _candyArr)
            {
                if (item.Name == name)
                {
                    candy = item.Name;
                }
            }

            return candy;
        }
    }
}
