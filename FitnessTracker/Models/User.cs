using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    internal class User 
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string FitnessGoal { get; set; } // e.g., "Lose weight", "Build muscle"

        public User(string name, int age, string fitnessGoal)
        {
            Name = name;
            Age = age;
            FitnessGoal = fitnessGoal;
        }

        
        public void DisplayInfo()
        {
            Console.WriteLine($"User: {Name}, Age: {Age}, Goal: {FitnessGoal}");
        }
    }
}
