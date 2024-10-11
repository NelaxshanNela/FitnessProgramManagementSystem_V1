using System;
using System.Collections.Generic;
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
