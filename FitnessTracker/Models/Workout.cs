using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker.Models
{
    internal class Workout
    {
        public string Type { get; set; }
        public int Duration { get; set; } // Duration in minutes
        public int CaloriesBurned { get; set; }

        public Workout(string type, int duration, int caloriesBurned)
        {
            Type = type;
            Duration = duration;
            CaloriesBurned = caloriesBurned;
        }
    }
}
}
