
using System.Collections.Generic;

namespace MusicProductionWorkflow
{
    public class Synthesizer : IInstrument
    {
        public string name;

        public Synthesizer(string name) => this.name = name;
        public Synthesizer(List<Oscillator> oscillators) => Oscillators = oscillators;

        public List<Oscillator> Oscillators { get; set; }
        public List<IEffect> Effects { get; set; }

        public bool status;
        public void Play() => status = true;
        public void Stop() => status = false;

        public string MakeNoise()
        {
            var noise = string.Empty;
            foreach (Oscillator oscillator in Oscillators)
                noise += $" {oscillator.timbre}";
            return noise;
        }
    }
}
