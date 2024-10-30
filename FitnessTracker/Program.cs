using FitnessTracker.Models;

namespace FitnessTracker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get user information
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your fitness goal:");
            string fitnessGoal = Console.ReadLine();

            // Create a user instance
            var user = new User(name, age, fitnessGoal);
            user.DisplayInfo();

            // Create fitness tracker
            var fitnessTracker = new FitnessTracker(user);
            var notificationService = new NotificationService();

            // Attach the notification service to the fitness tracker
            fitnessTracker.Attach(notificationService);

            // Create command instances
            var startCommand = new StartWorkoutCommand(fitnessTracker);
            var stopCommand = new StopWorkoutCommand(fitnessTracker);

            // Simulate user interaction
            Console.WriteLine("Welcome to the Fitness Tracker!");
            Console.WriteLine("Press 1 to start a workout, 2 to stop the workout, or 0 to exit.");

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "1")
                {
                    startCommand.Execute();
                }
                else if (input == "2")
                {
                    stopCommand.Execute();
                }
                else if (input == "0")
                {
                    Console.WriteLine("Exiting Fitness Tracker.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
        }
    }
}
