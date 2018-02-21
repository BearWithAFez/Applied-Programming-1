using System.Collections.Generic;

namespace Logic
{
    public class translate
    {
        public Dictionary<char, float> guide{ get; set; }

        public List<Note> stringToNoteList(string s, int d)
        {
            s = s.ToLower();
            List<Note> ln = new List<Note>();

            foreach (char c in s)
            {
                // space = empty noise
                // () double tempo
                // [] halve tempo
                // Letters IN dict get transalted; letters NOT in dict are ignored.
                switch (c)
                {
                    case ' ':
                        ln.Add(new Note(0f,d));
                        break;
                    case '(':
                    case ']':
                        d /= 2;
                        break;
                    case ')':
                    case '[':
                        d *= 2;
                        break;
                    default:
                        if (guide.ContainsKey(c))
                        {
                            ln.Add(new Note(guide[c],d));
                        }                  
                        break;
                }
            }
            return ln;
        }
    }
}
