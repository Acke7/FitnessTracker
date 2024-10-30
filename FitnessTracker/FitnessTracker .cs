using FitnessTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTracker
{
    internal class FitnessTracker
    {
        private List<IObserver> _observers = new List<IObserver>();
        private List<Workout> _workouts = new List<Workout>();
        private Workout _currentWorkout;
        public User User { get; set; }
    
        public FitnessTracker(User user)
        {
            User = user;
        }
        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
        public void StopWorkout()
        {
            if (_currentWorkout != null)
            {
                Notify($"Workout stopped! Type: {_currentWorkout.Type}, Duration: {_currentWorkout.Duration} min, Calories Burned: {_currentWorkout.CaloriesBurned}");
                _currentWorkout = null;
            }
            else
            {
                Notify("No workout is currently in progress.");
            }
        }
        public void StartWorkout()
        {
            // Example workout details
            _currentWorkout = new Workout("Running", 30, 300);
            _workouts.Add(_currentWorkout);
            Notify("Workout started!");
        }
    }
}
