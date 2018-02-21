using GlobalDataFormats;
using System.IO;

namespace Data
{
    public class fileSaver
    {
        public fileSaver(WaveHeader header, WaveFormatChunk format, WaveDataChunk data, string filePath)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Create))
            {
                using (var writer = new BinaryWriter(fileStream))
                {
                    // Write the header
                    writer.Write(header.sGroupID.ToCharArray());
                    writer.Write(header.dwFileLength);
                    writer.Write(header.sRiffType.ToCharArray());

                    // Write the format chunk
                    writer.Write(format.sChunkID.ToCharArray());
                    writer.Write(format.dwChunkSize);
                    writer.Write(format.wFormatTag);
                    writer.Write(format.wChannels);
                    writer.Write(format.dwSamplesPerSec);
                    writer.Write(format.dwAvgBytesPerSec);
                    writer.Write(format.wBlockAlign);
                    writer.Write(format.wBitsPerSample);

                    // Write the data chunk
                    writer.Write(data.sChunkID.ToCharArray());
                    writer.Write(data.dwChunkSize);
                    foreach (short dataPoint in data.shortArray)
                    {
                        writer.Write(dataPoint);
                    }
                    
                    // Jump back to Header.FileLength and calculate the TOTAL filesize
                    writer.Seek(4, SeekOrigin.Begin);
                    writer.Write((uint)writer.BaseStream.Length - 8); // Header parts are ignore (-8)
                }
            }
        }
    }
}
