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
    public class TypingGameKlasi : FastThinking
    {
        //private inastance varible skilgreind
        private string title;
        private int words;

        //Smiðurinn tekur inn 4 breytur
        public TypingGameKlasi(string t, int wordCount, int score, int totalTime) 
            : base (score, totalTime)
        {
            title = t;
            words = wordCount;
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

        //Aðferð sem skilar streng, tengist hinum klösunum sem bæta við strenginn
        public override string ToString()
        {
            return string.Format("Game: {0} \n\nWords: {1}", Title, Words) + base.ToString();
        }//End á override string
    }
}
