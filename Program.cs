namespace FitnessProgramManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgram fitnessProgram1 = new FitnessProgram("FIT_001", "YOGA", "3 months ", "10.00 ");
            Console.WriteLine(fitnessProgram1.ToString());

            FitnessProgramManager fitnessProgramManager = new FitnessProgramManager();
            bool exit = true;

            while (exit)
            {
                Console.WriteLine("FitnessProgram Management System:");
                Console.WriteLine("1. Add a FitnessProgram");
                Console.WriteLine("2. View All FitnessPrograms");
                Console.WriteLine("3. Update a FitnessProgram");
                Console.WriteLine("4. Delete a FitnessProgram");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        fitnessProgramManager.CreateFitnessProgram();
                        break;
                    case "2":
                        fitnessProgramManager.ReadFitnessPrograms();
                        break;
                    case "3":
                        fitnessProgramManager.UpdateFitnessProgram();
                        break;
                    case "4":
                        fitnessProgramManager.DeleteFitnessProgram();
                        break;
                    case "5":
                        Console.WriteLine("Program existing Thank you");
                        exit = false;
                        break;
                    default:
                        Console.WriteLine("Enter the correct number");
                        break;
                }
            }

        }
    }
}
