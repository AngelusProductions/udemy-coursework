using System;

namespace MusicProductionWorkflow
{
    public class Filter : IEffect
    {
        public Filter(bool type) { }
        public Filter(int cuttoff, int q, bool direction)
        {
            Cuttoff = cuttoff; Q = q; Direction = direction;
        }

        public int Q { get; set; }
        public int Cuttoff { get; set; }
        public bool Direction { get; set; }

        private bool _status;
        public void On() => _status = true;
        public void Off() => _status = false;
        public bool GetStatus(){ return _status; }

        public string Affect(string input)
        {
            string audio = input;
            //if (GetStatus())
            //{
            //    string[] audioToArray = audio.Split();
            //    int index = input.Length * Cuttoff / 20000;
            //    int radius = Q * (input.Length / 3);
            //    for(var i = index - radius; i < index + radius; i++)
            //    {
            //        if (i > 3) 
            //    }
            //    audio = audioToArray.ToString();
            //}
            return audio;
        } 
    }
}