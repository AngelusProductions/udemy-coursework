
namespace MusicProductionWorkflow
{
    public interface ISound
    {
        void Play();
        void Pause();
        string MakeNoise();
    }

    public interface IInstrument
    {
        void Play();
        void Stop();
        string MakeNoise();
    }

    public interface IEffect
    {
        void On();
        void Off();
        bool GetStatus();
        string Affect(string input);
    }
}
