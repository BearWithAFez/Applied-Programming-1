namespace GlobalDataFormats
{
    public class WaveHeader
    {
        public string sGroupID { get; set; }  // RIFF
        public uint dwFileLength { get; set; }  // total file length minus 8, which is taken up by RIFF
        public string sRiffType { get; set; }  // always WAVE


        public WaveHeader()
        {
            dwFileLength = 0;
            sGroupID = "RIFF";
            sRiffType = "WAVE";
        }
    }

    public class WaveFormatChunk
    {
        public string sChunkID { get; set; }         // Four bytes: "fmt "
        public uint dwChunkSize { get; set; }         // Length of header in bytes
        public ushort wFormatTag { get; set; }        // 1 (MS PCM)
        public ushort wChannels { get; set; }         // Number of channels
        public uint dwSamplesPerSec { get; set; }     // Frequency of the audio in Hz... 44100
        public uint dwAvgBytesPerSec { get; set; }    // for estimating RAM allocation
        public ushort wBlockAlign { get; set; }       // sample frame size, in bytes
        public ushort wBitsPerSample { get; set; }     // bits per sample


        public WaveFormatChunk()
        {
            sChunkID = "fmt ";
            dwChunkSize = 16;
            wFormatTag = 1;
            wChannels = 1;
            dwSamplesPerSec = 44100;
            wBitsPerSample = 16;
            wBlockAlign = (ushort)(wChannels * (wBitsPerSample / 8));
            dwAvgBytesPerSec = dwSamplesPerSec * wBlockAlign;
        }
    }

    public class WaveDataChunk
    {
        public string sChunkID { get; set; }      // "data"
        public uint dwChunkSize { get; set; }    // Length of header in bytes
        public short[] shortArray { get; set; }   // 8-bit audio


        public WaveDataChunk()
        {
            shortArray = new short[0];
            dwChunkSize = 0;
            sChunkID = "data";
        }
    }
}
