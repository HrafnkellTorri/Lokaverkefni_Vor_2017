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
    public class SpaceBarKlasi : FastThinking
    {
        //private inastance varible skilgreind
        private string title;

        //Smiðurinn tekur inn 3 breytur
        public SpaceBarKlasi(string t, int score, int totalTime) 
            : base (score, totalTime)
        {
            title = t;
        } //End á smið

        //Public Property sem skilar frá sér instance breytu
        public string Title
        {
            get
            {
                return title;
            } //End á get
        } //End á Title

        //Aðferð sem skilar streng, tengist hinum klösunum sem bæta við strenginn
        public override string ToString()
        {
            return string.Format("Game: {0}", Title) + base.ToString();
        }//End á override string
    }
}
