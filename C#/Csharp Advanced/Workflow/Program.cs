using System;
using System.Collections.Generic;
using static System.Console;

namespace MusicProductionWorkflow
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var track = new Track("C# Blues", "Angelus");

            var oscillators = new List<Oscillator>
            {
                new Oscillator ("triangle", "△tri△" ),
                new Oscillator ( "square", "❏sqr❏"),
                new Oscillator ( "sine", "∿sin∿")
            };

            var effects = new List<IEffect>
            {
                new Filter(10000, 5, true),
                new Delay (1, 0.33),
                new Tremolo(oscillators[1], 0.9, 0.25)
            };

            var synth = new Synthesizer("Massive")
            {
                Oscillators = oscillators,
                Effects = effects
            };

            var audioOut = synth.MakeNoise();

            foreach (IEffect effect in effects)
                audioOut += $"\n{effect.Affect(audioOut)}";

            WriteLine(audioOut);
        }
    }
}
