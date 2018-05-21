using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tools
{
    public class ToolsStr
    {
        public string Str { get; set; }
        public ToolsStr(string str)
        {
            Str = str;
        }
        public string FixByWords(string[] words)
        {
            string FixedString = Str;
            for (int i = 0; i < words.Length; i++)
            {
                FixByWord(words[i], ref FixedString);
            }
            return FixedString;
        }
        private void FixByWord(string word, ref string tofix)
        {
            char[] Str = tofix.ToCharArray();
            for (int i = 0; i < Str.Length -word.Length+1; i++)
            {
                bool t = true;
                for (int j = 0; j < word.Length; j++)
                {
                    if(char.ToLower(Str[i+j])!= char.ToLower(word[j]))
                    {
                        t = false;
                        break;
                    }
                }
                if(t && !(i>0 && (Str[i-1] <= 'я' && Str[i - 1] >= 'а'|| Str[i - 1] <= 'Я' && Str[i - 1] >= 'А')) && !(i < Str.Length - word.Length && (Str[i+word.Length] <= 'я' && Str[i + word.Length] >= 'а' || Str[i + word.Length] <= 'Я' && Str[i + word.Length] >= 'А')))
                {
                    Str[i] = Char.ToUpper(Str[i]);
                    i += word.Length;
                }
            }
            tofix = new string(Str);
        }
    }
}
