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
            Console.Write("Enter FitnessProgram ID: ");
            string programId = Console.ReadLine();
            Console.Write("Enter FitnessProgram Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter FitnessProgram Duration: ");
            string duration = Console.ReadLine();
            Console.Write("Enter FitnessProgram Price: ");
            string price = Console.ReadLine();

            FitnessProgram program = new FitnessProgram(programId, title, duration, price);
            fitnessProgramList.Add(program);
            Console.WriteLine("FitnessProgram added successfully.");
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
                Console.Write("Enter FitnessProgram Title: ");
                string title = Console.ReadLine();
                Console.Write("Enter FitnessProgram Duration: ");
                string duration = Console.ReadLine();
                Console.Write("Enter FitnessProgram Price: ");
                string price = Console.ReadLine();

                FitnessProgram program = new FitnessProgram(programId, title, duration, price);
                fitnessProgramList.Add(program);
                Console.WriteLine("FitnessProgram updated successfully");
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
    }
}
