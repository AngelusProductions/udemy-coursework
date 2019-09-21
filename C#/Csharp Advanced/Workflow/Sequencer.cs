namespace MusicProductionWorkflow
{
    public class Sequencer : IInstrument
    {
        public bool playing;
        public string status;
        public string kit;

        public void Play() => playing = true;
        public void Stop() { playing = false; status = "off"; }
        public string MakeNoise() { return "boom chicka boom"; }

        public bool IsPlaying()
        {
            return playing;
        }
    }
}