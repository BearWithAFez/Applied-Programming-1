using System;
using System.Collections.Generic;
using System.Linq;
using Data;
using Data_interface;
using Logica_Interface;

namespace Logic
{
    public class basicLogic : IbasicLogica
    {
        //comunicatie met DATA layer
        private IbasicData backend = new basicData();

        //Default Values.
        private const double roundPrecision = 0.1;
        private const int roundDecimals = 2;

        //public methodes
        public void changePath(string path, bool typeIsCsv)
        {
            //type indicates wich file is changed.
            if (typeIsCsv)
            {
                backend.changeCsv(path);
            }
            else
            {
                backend.changeWav(path);
            }
        }

        public string convert(int ms, bool roundIt, bool returnUnfound, bool seperatorIsComma)
        {
            //read csv file for tones Dictionary
            backend.setSeperator(seperatorIsComma);
            Dictionary<char, double> tonesDictionary = backend.csvDictionary;

            //Read the wav file for usefull values and comunicate with data layer
            List<short> rawWavData = backend.WAVdata;
            int sampleRateWav = backend.sampleRate;
            int notes = ((rawWavData.Count * 1000) / sampleRateWav) / ms; //aantal tonen in Wav

            //converteer de rawData naar floats per toon
            List<float[]> dataPerNote = convertRawData(rawWavData, sampleRateWav, notes);

            //RFFT toepassen en dominante frequencie zoeken
            List<double> frequencyList = new List<double>();
            foreach (float[] noteSamples in dataPerNote)
            {
                //fourier
                Fourier.RFFT(noteSamples, FourierDirection.Forward);

                //zoek freq
                double maxAmplitude = 0;
                int positie = 0;

                for (int i = 0; i < noteSamples.Length; i += 2)//max en pos bepalen
                {
                    double vermogen = Math.Sqrt((Math.Pow(noteSamples[i], 2)) + Math.Pow(noteSamples[i + 1], 2));
                    if (vermogen > maxAmplitude)
                    {
                        positie = i;
                        maxAmplitude = vermogen;
                    }
                }

                double frequency = ((positie * sampleRateWav) / (double)noteSamples.Length) / 2;//what is the frequency

                //(afronden) en toevoegen
                if (roundIt)
                {
                    frequencyList.Add((Math.Round(frequency * roundPrecision) / roundPrecision));
                }
                else
                {
                    frequencyList.Add(frequency);
                }
            }

            //create return String
            string returnable = "";
            foreach (double frequency in frequencyList)
            {
                //als nog niet afgerond
                double _frequency = frequency;
                if (!roundIt)
                {
                    _frequency = Math.Round(frequency, roundDecimals);
                }

                if (tonesDictionary.FirstOrDefault(x => x.Value == _frequency).Key == 0)//default waarde = ongevonden
                {
                    if (!returnUnfound)
                    {
                        returnable += "? ";
                    }
                    else
                    {
                        returnable += String.Format("?\"{0}Hz\" ", _frequency);
                    }
                }
                else
                {
                    returnable += tonesDictionary.FirstOrDefault(x => x.Value == _frequency).Key + " ";
                }

            }

            return returnable;
        }

        //inner Logica
        /// <summary>
        ///         gets a List of SHORT data and converts it to a List of FLOATS that are ready to use FOURIER on
        /// </summary>
        /// <param name="rawWavData">the Short Data</param>
        /// <param name="sampleRateWav">The sampleRate of said data</param>
        /// <param name="notes">Number of characters that are expected</param>
        /// <returns>the converted data in as floats</returns>
        private List<float[]> convertRawData(List<short> rawWavData, int sampleRateWav, int notes)
        {
            List<List<short>> perToneShort = new List<List<short>>();
            List<List<float>> perToneFloat = new List<List<float>>();
            List<float[]> returnable = new List<float[]>();

            //Short list to shorts per tone
            int position = 0;
            for (int i = 0; i < notes; i++)
            {
                List<short> sampleList = new List<short>();
                for (int j = 0; j < rawWavData.Count / notes; j++)
                {
                    sampleList.Add(rawWavData[position]);
                    position++;
                }
                perToneShort.Add(sampleList);
            }
            //to floats
            foreach (List<short> ShortList in perToneShort)
            {
                List<float> singleNoteSamples = new List<float>();
                foreach (short sample in ShortList)
                {
                    singleNoteSamples.Add(sample / ((2 ^ 16) / 2) - 1);
                }
                perToneFloat.Add(singleNoteSamples);
            }
            //make sure length is OK
            foreach (List<float> datasamplefloatlist in perToneFloat)
            {
                while (IsPowerOfTwo(datasamplefloatlist.Count) == false)
                {
                    datasamplefloatlist.Add(0);
                }
                float[] DataArrayFloat = datasamplefloatlist.ToArray();
                returnable.Add(DataArrayFloat);
            }
            return returnable;
        }

        /// <summary>
        ///         Checks if it is a power of 2
        /// </summary>
        /// <param name="x">Value to be checked</param>
        /// <returns>If it is a power of 2</returns>
        private bool IsPowerOfTwo(long x)
        {
            return ((x & (x - 1)) == 0);
        }
    }
}