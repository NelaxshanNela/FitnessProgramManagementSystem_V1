using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V1
{
    internal class IndividualFitnessProgram : FitnessProgram
    {
        public IndividualFitnessProgram(string subscriptionType, string needPersonalTrainer)
        {
            
            this.SubscriptionType = subscriptionType;
            this.needPersonalTrainer = needPersonalTrainer;
            TotalFitnessPrograms++;
        }
        public IndividualFitnessProgram()
        {
            TotalFitnessPrograms++;
        }
        public IndividualFitnessProgram(string programId, string title, string duration, string price, string subscriptionType, string needPersonalTrainer) : base()
        {
            this.fitnessProgramId = programId;
            this.title = title;
            this.duration = duration;
            this.price = price;
            this.SubscriptionType = subscriptionType;
            this.needPersonalTrainer = needPersonalTrainer;
            this.TotalFitnessPrograms++;
        }

        public string SubscriptionType { get; set; }
        public string needPersonalTrainer { get; set; }

        public string DisplayIndividualFitnessProgramInfo()
        {
            return $"fitnessProgramId: {fitnessProgramId}, Title:{title}, Duration: {duration}, Price: {price}, SubscriptionType: {SubscriptionType}, needPersonalTrainer: {needPersonalTrainer}";

        }

        public override string DisplayFitnessProgramInfo()
        {
            return $"{DisplayFitnessProgramInfo()}, SubscriptionType: {SubscriptionType}, needPersonalTrainer: {needPersonalTrainer}";
        }
    }
}
