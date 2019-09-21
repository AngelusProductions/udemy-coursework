using System.Collections.Generic;

namespace MusicProductionWorkflow
{
    public class Track
    {
        public string title;
        public int length;

        public Track(string title) => this.title = title;
        public Track(string title, string producer)
            { this.title = title; Producer = producer; }

        public string Producer { get; set; }
        public List<IInstrument> Instruments { get; set; }
    }
}