using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class StopWorkoutCommand :ICommand
    {
        private FitnessTracker _fitnessTracker;

        public StopWorkoutCommand(FitnessTracker fitnessTracker)
        {
            _fitnessTracker = fitnessTracker;
        }

        public void Execute()
        {
            _fitnessTracker.StopWorkout();
        }
    }
}
