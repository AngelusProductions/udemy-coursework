using System;
using System.Collections.Generic;

namespace MusicProductionWorkflow
{
    public class Delay : IEffect
    {
        public string type;
        private bool _status;

        public Delay(string type) => this.type = type;
        public Delay(int times, double feedback) { Times = times; Feedback = feedback; }

        public double Times { get; set; }
        public double Feedback { get; set; }

        public void On() => _status = true;
        public void Off() => _status = false;
        bool IEffect.GetStatus() => _status;

        public string Affect(string input)
        {
            string output = input;
            for(var i = 0; i < Times*(1 +  Feedback); i++)
                output = string.Concat(output, $" {input}");
            return output;
        }
    }
}