using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace WindowsFormsHangMan
{
    class RandomWord
    {
        public string GetRandomWord()
        {
            WebClient wc = new WebClient();

            string wordlist = wc.DownloadString("http://www.puzzlers.org/pub/wordlists/pocket.txt");

            string[] words = wordlist.Split('\n'); //split when getting to this character 

            Random rand = new Random();
            
            return words[rand.Next(0, words.Length - 1)];
            
        }
    }
}
