﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProgramManagementSystem_V1
{
    internal class FitnessProgram
    {
        public string fitnessProgramId { get; set; }
        private string title { get; set; }
        private string duration { get; set; }
        private string price { get; set; }

        public FitnessProgram(string fitnessProgramId, string title, string duration, string price)
        {
            this.fitnessProgramId = fitnessProgramId;
            this.title = title;
            this.duration = duration;
            this.price = price;

        }
        public override string ToString()
        {
            return ($"fitnessProgramId: {fitnessProgramId}, Title:{title}, Duration: {duration}, Price: {price}");
        }

    }
}
