using System;
using System.Collections.Generic;
using System.Text;

namespace CountLetters
{
    public class Count
    {       
        public Count()
        {

        }

        public static int Counter(string wordToSplit, char key)
        {
            var list = new Dictionary<char, int>();

            for (int i = 0; i < wordToSplit.Length; i++)
            {
                if (list.ContainsKey(wordToSplit[i]))
                {
                    list[wordToSplit[i]]++;
                }
                else
                {
                    list.Add(wordToSplit[i], 1);
                }
            }

            if (list.ContainsKey(key))
            {
                return list[key];
            }
            else
            {
                return 0;
            }
        }

            
    }
}
