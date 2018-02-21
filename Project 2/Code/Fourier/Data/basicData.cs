using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Data_interface;

namespace Data
{
    public class basicData : IbasicData
    {
        /// <summary>
        ///     Where the data of the Wav file is kept. (samplerate, samples etc....)
        /// </summary>
        private struct wavData
        {
            public byte[] riffID;
            public uint size;
            public byte[] wavID;
            public byte[] fmtID;
            public uint fmtSize;
            public ushort format;
            public ushort channels;
            public uint sampleRate;
            public uint bytePerSec;
            public ushort blockSize;
            public ushort bit;
            public byte[] dataID;
            public uint dataSize;
            public List<short> data;
        }

        /// <summary>
        ///     Current CSV path
        /// </summary>
        private string csvPath;

        /// <summary>
        ///     Current WAV path
        /// </summary>
        private string wavPath;

        /// <summary>
        ///     The current Seperator char
        /// </summary>
        private char csvSeperator = ',';

        /// <summary>
        ///     Used instance of the WavData struct
        /// </summary>
        private wavData wavdata = new wavData();

        /// <summary>
        ///     The current version of the CSV dictionary
        /// </summary>
        private Dictionary<char, double> csv;
        
        // public get fields
        public int sampleRate
        {
            get
            {
                ReadWav();
                return (int)wavdata.sampleRate;
            }
        }
        
        public List<short> WAVdata
        {
            get
            {
                ReadWav();
                return wavdata.data;
            }
        }
        
        public Dictionary<char, double> csvDictionary
        {
            get
            {
                readCsv();
                return csv;
            }
        }
        
        // public methodes
        public void changeCsv(string path)
        {
            csvPath = path;
        }

        public void changeWav(string path)
        {
            wavPath = path;
        }

        public void setSeperator(bool seperatorIsComma)
        {
            csvSeperator = (seperatorIsComma) ? ',' : ';';
        }

        // internally used methodes
        /// <summary>
        ///     update all WAV data
        /// </summary>
        private void ReadWav()
        {
            try
            {
                wavdata = new wavData();
                wavdata.data = new List<short>(); //just to be sure idk maybe the pointer ain't forgotten...

                //read Wav
                using (FileStream fs = new FileStream(wavPath, FileMode.Open, FileAccess.Read))
                using (BinaryReader br = new BinaryReader(fs))
                {
                    try
                    {
                        wavdata.riffID = br.ReadBytes(4);
                        wavdata.size = br.ReadUInt32();
                        wavdata.wavID = br.ReadBytes(4);
                        wavdata.fmtID = br.ReadBytes(4);
                        wavdata.fmtSize = br.ReadUInt32();
                        wavdata.format = br.ReadUInt16();
                        wavdata.channels = br.ReadUInt16(); //important!
                        wavdata.sampleRate = br.ReadUInt32();
                        wavdata.bytePerSec = br.ReadUInt32();
                        wavdata.blockSize = br.ReadUInt16();//important!
                        wavdata.bit = br.ReadUInt16();
                        wavdata.dataID = br.ReadBytes(4);
                        wavdata.dataSize = br.ReadUInt32();//important!

                        for (int i = 0; (i < wavdata.dataSize / wavdata.blockSize); i += wavdata.channels)
                        {
                            wavdata.data.Add((short)br.ReadUInt16());
                            if (wavdata.channels == 2) br.ReadUInt16();//throw away 2nd channel
                        }
                    }
                    finally
                    {
                        if (br != null) br.Close();
                        if (fs != null) fs.Close();
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("trouble reading WAV file! Perhaps your wav file is corrupt.");
            }
        }

        /// <summary>
        ///     Update all SCV data
        /// </summary>
        private void readCsv()
        {
            try
            {
                csv = new Dictionary<char, double>();
                using (StreamReader ss = new StreamReader(csvPath))
                {
                    while (!ss.EndOfStream)
                    {
                        var line = ss.ReadLine().TrimEnd();
                        if (line[0] != '\\')
                        {
                            var values = line.Split(csvSeperator);
                            csv.Add(values[0][0], double.Parse(values[1], CultureInfo.InvariantCulture));
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Trouble reading CSV file! Try choosing a different seperator.");
            }
        }
    }
}