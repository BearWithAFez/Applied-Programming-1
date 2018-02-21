using System;
using System.Collections.Generic;
using FourierLib;

namespace Logic
{
    public class Linker:ILogic.ILinker
    {
        private IData.ILinker backend = new Data.Linker();
        private const int RESOLUTION = 5; //resolution of hz wich the arrays are split in

        #region Linking functions
        public bool chooseNewSource()
        {
            return backend.chooseNewSource();
        }

        public string getSourceFileName()
        {
            return backend.getCurrentSource();
        }

        public void playResult()
        {
            backend.playResult();
        }

        public void playSource()
        {
            backend.playSource();
        }

        public void saveResult()
        {
            backend.saveResult();
        }

        public void stopResult()
        {
            backend.stopPlayer();
        }

        public void stopSource()
        {
            backend.stopPlayer();
        }
        #endregion

        #region External Functions
        public void scramble()
        {
            //Create necessary variables
            List<short> rawWavData = backend.WAVdata; //get the data dump of wav file
            int sampleRateWav = backend.sampleRate; //get samplerate of wav file
            List<float[]> dataPerNote = convertRawData(rawWavData, sampleRateWav); //convert dump into split arrays

            //foreach sample do: a Forward FFT, Flip the values, Backwards FFT
            foreach (float[] noteSamples in dataPerNote)
            {
                //Forward FFT
                Fourier.RFFT(noteSamples, FourierDirection.Forward);
                
                //Flip the values, (in pairs Real and Imaginary)
                float[] temporary = new float[noteSamples.Length];                
                for (int i = 0; i < noteSamples.Length; i += 2)
                {
                    temporary[i] = noteSamples[noteSamples.Length - 2 - i];
                    temporary[i+1] = noteSamples[noteSamples.Length - 1 - i];
                }
                Array.Copy(temporary, noteSamples, noteSamples.Length);
                
                //Forward FFT and Compensate for distortion due to Fourier Transformation
                Fourier.RFFT(noteSamples, FourierDirection.Backward);
                for (int i = 0; i < noteSamples.Length; i++)
                {
                    noteSamples[i] /= noteSamples.Length / 2;
                    noteSamples[i] = (float) Math.Round(noteSamples[i]);
                }           
            }

            //Pass on new Wav file Data
            List<short> newWavData = convertNewData(dataPerNote); //convert split arrays back to dump
            backend.newWavData(newWavData, rawWavData); //Send to backend
        }
        #endregion        
        
        #region Internal Functions
        //Convert the collection of sub arrays to a new dump of data
        private List<short> convertNewData(List<float[]> dataPerNote)
        {
            List<short> converted = new List<short>();
            bool first = true;

            foreach (float[] floatArray in dataPerNote)
            {
                if (first) //Get the first 3/4 of the first array
                {
                    for (int i = 0; i < ((floatArray.Length / 4) * 3); i++)
                    {
                        converted.Add((short)floatArray[i]);
                    }
                    first = false;
                }
                else //Get the MIDDLE 2/4 of the other arrays
                {
                    for (int i = (floatArray.Length / 4); i < ((floatArray.Length / 4) * 3); i++)
                    {
                        converted.Add((short)floatArray[i]);
                    }
                }

            }
            //get the last 1/4 of the last array
            for (int i = (dataPerNote[dataPerNote.Count - 1].Length / 4) * 3; i < dataPerNote[dataPerNote.Count - 1].Length; i++)
            {
                converted.Add((short)dataPerNote[dataPerNote.Count - 1][i]);
            }
            return converted;
        }

        //Converts the raw data dump into a series of split float arrays
        private List<float[]> convertRawData(List<short> rawWavData, int sampleRateWav)
        {
            //internal variables;
            List<float[]> returnable = new List<float[]>();

            //ask correct size of the sub arrays
            int size = correctSize(sampleRateWav);

            int pos = 0; //current position in the dump
            for (int x = 0; (pos < rawWavData.Count); x++)
            {
                float[] inserter = new float[size]; //make a sub array
                for (int i = 0; i < size; i++)
                {
                    inserter[i] = (float)rawWavData[pos];
                    pos++;
                    while ((pos == rawWavData.Count) && (i < size)) //when there no more data in the dump but space in sub array
                    {
                        inserter[i] = 0; //insert 0 in empty space
                        i++;
                    }
                }
                if (pos != rawWavData.Count) pos -= size / 2; //double read all values so the fourier transform edges don't influence the outcome
                returnable.Add(inserter);
            }

            return returnable;
        }

        //Gives a correct size for the wav file using the samplerate and resolution
        private int correctSize(int sampleRateWav)
        {
            int x = sampleRateWav / RESOLUTION;
            int y = 2;

            //search for a power of two greater than the current value
            while (x > y)
            {
                y *= 2;
            }
            return y;
        }
        #endregion
    }
}
