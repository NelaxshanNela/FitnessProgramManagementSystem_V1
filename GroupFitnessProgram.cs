using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V1
{
    internal class GroupFitnessProgram : FitnessProgram
    {
        public string Schedule { get; set; }
        public string GroupCapacity { get; set; }

        public GroupFitnessProgram(string schedule, string groupCapacity)
        {
            Schedule = schedule;
            GroupCapacity = groupCapacity;
            TotalFitnessPrograms++;
        }
        public GroupFitnessProgram() { TotalFitnessPrograms++; }

        public GroupFitnessProgram(string programId, string title, string duration, string price, string schedule, string groupCapacity) : base()
        {
            this.fitnessProgramId = programId;
            this.title = title;
            this.duration = duration;
            this.price = price;
            Schedule = schedule;
            GroupCapacity = groupCapacity;
            TotalFitnessPrograms++;
        }

        public string DisplayGroupFitnessProgramInfo()
        {
            return $"fitnessProgramId: {fitnessProgramId}, Title:{title}, Duration: {duration}, Price: {price}, Schedule: {Schedule}, GroupCapacity: {GroupCapacity}";

        }

        public override string DisplayFitnessProgramInfo()
        {
            return $"{DisplayFitnessProgramInfo()}, SubscriptionType: Schedule: {Schedule}, GroupCapacity: {GroupCapacity}";
        }
    }
}
