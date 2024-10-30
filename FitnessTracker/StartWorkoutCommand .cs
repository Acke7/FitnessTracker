using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class StartWorkoutCommand : ICommand
    {
        private FitnessTracker _fitnessTracker;

        public StartWorkoutCommand(FitnessTracker fitnessTracker)
        {
            _fitnessTracker = fitnessTracker;
        }

        public void Execute()
        {
            _fitnessTracker.StartWorkout();
        }
    }
}
