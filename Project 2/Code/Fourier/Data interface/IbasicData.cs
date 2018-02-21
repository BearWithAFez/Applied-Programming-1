using System.Collections.Generic;

namespace Data_interface
{
    public interface IbasicData
    {
        /// <summary>
        ///     The sample rate of current WAV file
        /// </summary>
        int sampleRate { get; }

        /// <summary>
        ///     The samples in the WAVfile
        /// </summary>
        List<short> WAVdata { get; }

        /// <summary>
        ///     The translate guide of the CSV file
        /// </summary>
        Dictionary<char, double> csvDictionary { get; }

        /// <summary>
        ///     Sets current CSV file
        /// </summary>
        /// <param name="path">New path</param>
        void changeCsv(string path);

        /// <summary>
        ///     sets current WAV file
        /// </summary>
        /// <param name="path">New path</param>
        void changeWav(string path);

        /// <summary>
        ///     Sets if the CSV file should be splitted on Comma or on Semicolon
        /// </summary>
        /// <param name="seperatorIsComma">If it should be split on comma</param>
        void setSeperator(bool seperatorIsComma);
    }
}
