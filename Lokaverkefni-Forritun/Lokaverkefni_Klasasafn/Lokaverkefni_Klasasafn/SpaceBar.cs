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
    public class SpaceBar : FastThinking
    {
        //private inastance varible skilgreind
        private string title;
        private int clicks;

        //Smiðurinn tekur inn 
        public SpaceBar(string t, int c, int score, int totalTime) 
            : base (score, totalTime)
        {
            title = t;
            clicks = c;
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
        public int Clicks
        {
            get
            {
                return clicks;
            } //End á get
        } //End á Clicks
    }
}
