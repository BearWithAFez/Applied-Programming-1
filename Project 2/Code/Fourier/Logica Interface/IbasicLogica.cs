namespace Logica_Interface
{
    public interface IbasicLogica
    {
        /// <summary>
        ///         Sets the Paths of used files.
        /// </summary>
        /// <param name="path">The new Path</param>
        /// <param name="typeIsCsv">The type of file to change, True= CSV, False = WAV</param>
        void changePath(string path, bool typeIsCsv);

        /// <summary>
        ///         Converts the used WAV file.
        /// </summary>
        /// <param name="ms">Duration per letter in returned string</param>
        /// <param name="roundIt">If frequency can be rounded</param>
        /// <param name="returnUnfound">If not found that it returns calculated frequency</param>
        /// <param name="seperatorIsComma">Wich seperatorType is used in CSV file (true: comma, false: semiColon)</param>
        /// <returns>the message in the wav file</returns>
        string convert(int ms, bool roundIt, bool returnUnfound, bool seperatorIsComma);
    }
}
