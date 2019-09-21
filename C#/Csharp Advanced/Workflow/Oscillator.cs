namespace MusicProductionWorkflow
{
    public class Oscillator
    {
        public string type;
        public string timbre;

        public Oscillator(string type) => this.type = type;
        public Oscillator(string type, string timbre) { this.type = type; this.timbre = timbre; }

        public double Amplitude { get; set; }
        public double Frequency { get; set; }
    }
}