using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp3
{
    public class Hobbies
    {
        private readonly Dictionary<string, string[]> hobbies = new Dictionary<string, string[]>();

        public void Add(string hobbyist, params string[] hobbies)
        {
            this.hobbies.Add(hobbyist, hobbies);
        }
        public List<string> FindHobbyists(string hobby)
        {
            List<string> res = new List<string>();
            foreach (var item in hobbies)
            {
                if (item.Value.Contains(hobby))
                {
                    res.Add(item.Key);
                }
            }
            return res;
        }
    }        
    class Program
    {
        static void Main(string[] args)
        {
            Hobbies hobbies = new Hobbies();
            hobbies.Add("Jhon", "Piano", "Puzzles", "Yoga");
            hobbies.Add("Adam", "Drama", "Fashion", "Pets");
            hobbies.Add("Mary", "Magic", "Pets", "Reading");

            hobbies.FindHobbyists("Pets").ForEach(item=>Console.WriteLine(item));
            Console.ReadKey();
        }
    }
}
