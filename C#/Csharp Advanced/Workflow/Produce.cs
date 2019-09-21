
namespace Workflow
{
    public class Produce
    {
        public Produce(Song song) => Song = song;
        public Produce(Song song, IInstrument instrument ) { Instrument = instrument; Song = song; }

        public IInstrument Instrument { get; set; }
        public Song Song { get; set; }
        public string Project { get; set; }

        private bool _producing;
        public void Start() => _producing = true;
        public void Stop() => _producing = false;
    }
}
