using System.Collections.Generic;

namespace IData
{
    public interface ILinker
    {
        int sampleRate { get; }
        List<short> WAVdata { get; }

        bool chooseNewSource();
        string getCurrentSource();
        void playSource();
        void stopPlayer();
        void newWavData(List<short> newWavData, List<short> rawWavData);
        void playResult();
        void saveResult();
    }
}
