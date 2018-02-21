using GlobalDataFormats;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class WaveGenerator
    {
        // Header, Format, Data chunks
        public WaveHeader header;
        public WaveFormatChunk format;
        public WaveDataChunk data;

        public WaveGenerator(List<Note> notes, float volume)
        {
            // Init chunks
            header = new WaveHeader();
            format = new WaveFormatChunk();
            data = new WaveDataChunk();

            var milliseconds = notes.Select((x) => x.Duration.TotalMilliseconds).Sum();
            uint numSamples = (uint)(((format.dwSamplesPerSec * milliseconds) / 1000));
            int amplitude = 32760;  // Max amplitude for 16-bit audio
            uint sampleCount = 0;   // used as a "cursor" in the next Foreach

            // Initialize the 16-bit array and Calculate the repsective values
            data.shortArray = new short[numSamples];   
            foreach (var n in notes)
            {
                // the time-steps the sine wave takes (period [2 pi f]) divided by the steps per period
                double t = (Math.PI * 2 * n.Frequency) / format.dwSamplesPerSec;

                // Calculate the amount of samples you will use for said Note
                var samplesThisNote = format.dwSamplesPerSec * n.Duration.TotalSeconds;

                // Loop over sampleCount as said before (it acts as u cursor)
                for (uint i = sampleCount; i < (samplesThisNote + sampleCount) - 1; i++)
                {
                    data.shortArray[i] = Convert.ToInt16(amplitude * Math.Sin(t * i) * volume);
                }
                sampleCount += (uint)samplesThisNote;
            }

            // Calculate data chunk size in bytes
            data.dwChunkSize = (uint)(data.shortArray.Length * (format.wBitsPerSample / 8));
        }
    }      
        
}