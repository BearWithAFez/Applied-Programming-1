using System.Collections.Generic;
using GlobalDataFormats;

namespace Data
{
    public class BasisData
    {
        csvReader reader = new csvReader();

        public Dictionary<char, float> getCsv(string path)
        {
            return reader.readCsvFile(path);
        }
        public void save(WaveHeader h, WaveFormatChunk f, WaveDataChunk d, string path)
        {
            fileSaver fs = new fileSaver(h,f,d,path);
        }
    }
}
