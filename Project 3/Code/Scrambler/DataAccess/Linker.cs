using System;
using System.Collections.Generic;
using IData;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Data
{
    public class Linker : ILinker
    {
        #region Internal variables

        private struct wavData //Basic Structure of a wav file
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

        private string sourcePath;

        private SoundPlayer player = new SoundPlayer();

        private wavData wavdata = new wavData();

        #endregion

        #region External getters

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

        #endregion

        #region External Functions

        public bool chooseNewSource()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "WAV files|*.wav";
            ofd.ShowDialog();
            if (ofd.FileName != "")//check if not invalid or exit
            {
                sourcePath = ofd.FileName;
                return true;
            }
            return false;
        }

        public string getCurrentSource()
        {
            return Path.GetFileNameWithoutExtension(sourcePath);
        }
        
        public void newWavData(List<short> newWavData, List<short> rawWavData)
        {
            int oldDataCount = rawWavData.Count;
            int newDataCount = newWavData.Count;

            wavdata.dataSize =(uint) (wavdata.dataSize - oldDataCount + newDataCount);
            wavdata.data = newWavData;
        }
        
        public void playResult()
        {
            saveCurrent(@"C:\Users\Dwight VdV\Desktop\temp.wav");
            player = new SoundPlayer(@"C:\Users\Dwight VdV\Desktop\temp.wav");
            player.Play();
        }

        public void playSource()
        {
            player = new SoundPlayer(sourcePath);
            player.Play();
        }

        public void stopPlayer()
        {
            player.Stop();
        }

        //saves the new Wav data by showing a SFD and calling the private saver
        public void saveResult()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Wav file|*.wav";
            sfd.Title = "Save the edited wav file.";
            sfd.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (sfd.FileName != "")
            {
                saveCurrent(sfd.FileName);
            }
        }

        #endregion

        #region Internal Functions

        //reads the wav placed at the sourcePath
        private void ReadWav()
        {
            try
            {
                wavdata = new wavData();
                wavdata.data = new List<short>();

                //read Wav
                using (FileStream fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
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
                        wavdata.channels = br.ReadUInt16();
                        wavdata.sampleRate = br.ReadUInt32();
                        wavdata.bytePerSec = br.ReadUInt32();
                        wavdata.blockSize = br.ReadUInt16();
                        wavdata.bit = br.ReadUInt16();
                        wavdata.dataID = br.ReadBytes(4);
                        wavdata.dataSize = br.ReadUInt32();

                        for (int i = 0; (i < wavdata.dataSize / wavdata.blockSize); i += wavdata.channels)
                        {
                            wavdata.data.Add((short)br.ReadUInt16());
                            if (wavdata.channels == 2) br.ReadUInt16(); //Skip any second channel
                            if (fs.Position == fs.Length) break;    //stop when end of file
                        }
                        wavdata.channels = 1; //set channels on 1 incase it was 2
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

        private void saveCurrent(string path)
        {
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                using (var writer = new BinaryWriter(fileStream))
                {
                    // Write the header
                    writer.Write(wavdata.riffID);
                    writer.Write(wavdata.size);
                    writer.Write(wavdata.wavID);

                    // Write the format chunk
                    writer.Write(wavdata.fmtID);
                    writer.Write(wavdata.fmtSize);
                    writer.Write(wavdata.format);
                    writer.Write(wavdata.channels);
                    writer.Write(wavdata.sampleRate);
                    writer.Write(wavdata.bytePerSec);
                    writer.Write(wavdata.blockSize);
                    writer.Write(wavdata.bit);

                    // Write the data chunk
                    writer.Write(wavdata.dataID);
                    writer.Write(wavdata.dataSize);


                    foreach (short dataPoint in wavdata.data)
                    {
                        writer.Write(dataPoint);
                    }

                    // Jump back to Header.FileLength and calculate the TOTAL filesize
                    writer.Seek(4, SeekOrigin.Begin);
                    writer.Write((uint)writer.BaseStream.Length - 8); // Header parts are ignore (-8)
                }
            }
        }

        #endregion
    }
}
