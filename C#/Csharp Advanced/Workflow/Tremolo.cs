namespace MusicProductionWorkflow
{
    public class Tremolo : IEffect
    {
        public Tremolo () {}
        public Tremolo (Oscillator wave, double amplitude, double frequency)
            { Wave = wave; Amplitude = amplitude; Frequency = frequency; }

        public Oscillator Wave { get; set; }
        public double Amplitude { get; set; }
        public double Frequency { get; set; }

        private bool _status;
        public void On() => _status = true;
        public void Off() => _status = false;
        public bool GetStatus() { return _status; }

        public string Affect (string input)
        {
            string output = input;
            if (GetStatus())
            {
                int i = 0;
                foreach(string letter in input.Split())
                    { output += i % 2 == 0 ? letter.ToUpper() : letter.ToLower(); i++; }
            }
            return output;
        }
    }
}