namespace FitnessProgramManagementSystem_V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessProgram fitnessProgram1 = new FitnessProgram("FIT_001", "YOGA", "3 months ", "10.00 ");
            Console.WriteLine(fitnessProgram1.ToString());

        }
    }
}
