using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Lokaverkefni
 * Vor 2017
 * Erla Óskarsdóttir
 * Hrafnkell Þorri Þrastarson */

namespace Lokaverkefni_Klasasafn
{
    public class TypingGame : FastThinking
    {
        //private inastance varible skilgreind
        private string title;
        private int words;

        //Smiðurinn tekur inn 
        public TypingGame(string t, int w, int score, int totalTime) 
            : base (score, totalTime)
        {
            title = t;
            words = w;
        } //End á smið

        //Public Property sem skilar frá sér instance breytu
        public string Title
        {
            get
            {
                return title;
            } //End á get
        } //End á Title

        //Public Property sem skilar frá sér instance breytu
        public int Words
        {
            get
            {
                return words;
            } //End á get
        } //End á Words
    }
}
