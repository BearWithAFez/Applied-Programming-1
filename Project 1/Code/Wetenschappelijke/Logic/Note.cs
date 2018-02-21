using System;

namespace Logic
{
    public class Note
    {
        public float Frequency { get; set; }
        public TimeSpan Duration { get; set; }

        public Note(float _Frequency, int _Duration)
        {
            Frequency = _Frequency;
            Duration = new TimeSpan(0, 0, 0, 0, _Duration);
        }

    }
}