using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            var countryList = Country.GetCountries();
            var sortedByName = countryList.OrderBy(x => x.Name).ToList();
            var sortedByResources = countryList.OrderByDescending(x => x.Resources.Count()).ToList();
            var borderWithArgentina = countryList.Where(x => x.Borders.Contains("Argentina"));
            var over10MilPop = countryList.Where(x => x.Population > 10000000).ToList();
            var highestPopulation = countryList.OrderByDescending(x => x.Population).FirstOrDefault();
            var sortedReligions = countryList.SelectMany(x => x.Religions).Distinct().ToList();
            sortedReligions.Sort();

            Console.WriteLine("Countries Sorted By Name");
            foreach (var element in sortedByName)
            {
                Console.WriteLine(element.Name);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Countries Sorted By Number of Resources");
            foreach (var element in sortedByResources)
            {
                Console.WriteLine(element.Name);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Countries That Share a Border With Argentina");
            foreach (var element in borderWithArgentina)
            {
                Console.WriteLine(element.Name);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Countries With a Population That Exceeds 10,000,000");
            foreach (var element in over10MilPop)
            {
                Console.WriteLine(element.Name);
            }
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("The Country With The Highest Population");            
            Console.WriteLine(highestPopulation.Name);
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("South American Religions By Dicitonary Order");
            foreach (var element in sortedReligions)
            {
                Console.WriteLine(element);
            }
            Console.ReadLine();
        }
    }
}
