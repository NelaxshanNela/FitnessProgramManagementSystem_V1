using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V1
{
    internal class FitnessProgram
    {
        public string fitnessProgramId { get; set; }
        public string title { get; set; }
        public string duration { get; set; }
        public string price { get; set; }
        public int TotalFitnessPrograms { get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            this.fitnessProgramId = fitnessProgramId;
            this.title = title;
            this.duration = duration;
            this.price = price;
            this.TotalFitnessPrograms++;

        }
        public FitnessProgram() { this.TotalFitnessPrograms++; }
        public override string ToString()
        {
            return ($"fitnessProgramId: {fitnessProgramId}, Title:{title}, Duration: {duration}, Price: {price}");
        }

        public virtual string DisplayFitnessProgramInfo()
        {
            return ($"fitnessProgramId: {fitnessProgramId}, Title:{title}, Duration: {duration}, Price: {price}");
        }

    }
}
