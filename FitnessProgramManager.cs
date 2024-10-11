using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V1
{
    internal class FitnessProgramManager
    {
        List<FitnessProgram> fitnessProgramList = new List<FitnessProgram>();

        public void CreateFitnessProgram()
        {
            Console.WriteLine("Enter FitnessProgram type:");
            Console.WriteLine("1. Indiviual Fitness Program");
            Console.WriteLine("2. Group Fitness Program");
            Console.Write("Choose an option: ");
            int type = int.Parse(Console.ReadLine());

            Console.Write("Enter FitnessProgram ID: ");
            string programId = Console.ReadLine();
            Console.Write("Enter FitnessProgram Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter FitnessProgram Duration: ");
            string duration = Console.ReadLine();

            string price = ValidateFitnessProgramPrice();

            if (type == 1)
            {
                Console.Write("Enter FitnessProgram SubscriptionType: ");
                string SubscriptionType = Console.ReadLine();
                Console.Write("Enter FitnessProgram needPersonalTrainer: ");
                string needPersonalTrainer = Console.ReadLine();

                IndividualFitnessProgram program = new IndividualFitnessProgram(programId, title, duration, price, SubscriptionType, needPersonalTrainer);
                fitnessProgramList.Add(program);
                Console.WriteLine("Indiviual FitnessProgram added successfully.");

            }
            else
            {
                Console.Write("Enter FitnessProgram Schedule: ");
                string Schedule = Console.ReadLine();
                Console.Write("Enter FitnessProgram GroupCapacity: ");
                string GroupCapacity = Console.ReadLine();

                GroupFitnessProgram program = new GroupFitnessProgram(programId, title, duration, price, Schedule, GroupCapacity);
                fitnessProgramList.Add(program);
                Console.WriteLine("Group FitnessProgram added successfully.");
            }

        }

        public void ReadFitnessPrograms()
        {
            Console.WriteLine("List of FitnessPrograms:");
            if (fitnessProgramList.Count > 0)
            {
                foreach (var item in fitnessProgramList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }

        public void UpdateFitnessProgram()
        {
            Console.Write("Enter the FitnessProgram ID to update: ");
            string programId = Console.ReadLine();
            var findProgram = fitnessProgramList.Find(f => f.fitnessProgramId == programId);
            if (findProgram != null)
            {
                fitnessProgramList.Remove(findProgram);

                Console.WriteLine("Enter FitnessProgram type:");
                Console.WriteLine("1. Indiviual Fitness Program");
                Console.WriteLine("2. Group Fitness Program");
                Console.Write("Choose an option: ");
                int type = int.Parse(Console.ReadLine());

                Console.Write("Enter FitnessProgram Title: ");
                string title = Console.ReadLine();
                Console.Write("Enter FitnessProgram Duration: ");
                string duration = Console.ReadLine();

                string price = ValidateFitnessProgramPrice();

                if (type == 1)
                {
                    Console.Write("Enter FitnessProgram SubscriptionType: ");
                    string SubscriptionType = Console.ReadLine();
                    Console.Write("Enter FitnessProgram needPersonalTrainer: ");
                    string needPersonalTrainer = Console.ReadLine();

                    IndividualFitnessProgram program = new IndividualFitnessProgram(programId, title, duration, price, SubscriptionType, needPersonalTrainer);
                    fitnessProgramList.Add(program);
                    Console.WriteLine("Indiviual FitnessProgram added successfully.");

                }
                else
                {
                    Console.Write("Enter FitnessProgram Schedule: ");
                    string Schedule = Console.ReadLine();
                    Console.Write("Enter FitnessProgram GroupCapacity: ");
                    string GroupCapacity = Console.ReadLine();

                    GroupFitnessProgram program = new GroupFitnessProgram(programId, title, duration, price, Schedule, GroupCapacity);
                    fitnessProgramList.Add(program);
                    Console.WriteLine("Group FitnessProgram added successfully.");
                }
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }

        public void DeleteFitnessProgram()
        {
            Console.Write("Enter the FitnessProgram ID to delete: ");
            string programId = Console.ReadLine();
            var findProgram = fitnessProgramList.Find(f => f.fitnessProgramId == programId);
            if (findProgram != null)
            {
                fitnessProgramList.Remove(findProgram);
                Console.WriteLine("FitnessProgram deleted successfully");
            }
            else
            {
                Console.WriteLine("Invalid ID");
            }
        }

        public string ValidateFitnessProgramPrice()
        {
            int validatePrice = 0;
            Console.Write("Enter FitnessProgram Price: ");
            int price = int.Parse(Console.ReadLine());

            if (price < 0)
            {
                Console.WriteLine("Enter positive value");
            }
            else
            {
                validatePrice = price;
            }
            return validatePrice.ToString();
        }
    }
}
