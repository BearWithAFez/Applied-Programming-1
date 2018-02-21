using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace Data
{
    public class csvReader
    {
        private Dictionary<char, float> data { get; set; }

        public Dictionary<char, float> readCsvFile(string path)
        {
            StreamReader _streamReader = new StreamReader(path);
            data = new Dictionary<char, float>();
            string[] _streamDataValues;

            while (!_streamReader.EndOfStream)
            {
                //Clean every line up, check if it isn't a comment, split them in the values.
                String _streamLineData = _streamReader.ReadLine().Trim();
                if (_streamLineData.Length > 0 && _streamLineData.Substring(0, 2) != @"//")
                {
                    _streamDataValues = _streamLineData.Split(',');
                    data.Add(_streamDataValues[0][0], float.Parse(_streamDataValues[1], CultureInfo.InvariantCulture));
                }
            }

            _streamReader.Close();
            _streamReader.Dispose();

            return data;
        }
    }
}
