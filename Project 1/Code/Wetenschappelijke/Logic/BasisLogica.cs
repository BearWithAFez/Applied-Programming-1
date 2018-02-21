using Data;
using System;

namespace Logic
{
    public class BasisLogica
    {
        private WaveGenerator wavegen;
        private translate tr = new translate();
        private BasisData backend =  new BasisData();

        public void setCsv(String path)
        {
            tr.guide = backend.getCsv(path);
        }

        public void generate(string text, int duration,float volume, string path)
        {
            wavegen = new WaveGenerator(tr.stringToNoteList(text, duration),volume);
            backend.save(wavegen.header, wavegen.format, wavegen.data, path);
        }
    }
}
