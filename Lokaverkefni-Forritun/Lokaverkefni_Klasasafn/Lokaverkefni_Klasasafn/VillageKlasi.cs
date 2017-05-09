using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni_Klasasafn
{
    public class VillageKlasi : FastThinking
    {
        //private inastance varible skilgreind
        private string title;
        private string age;

        //Smiðurinn tekur inn 4 breytur
        public VillageKlasi(string t, string a, int score, int totalTime) 
            : base (score, totalTime)
        {
            title = t;
            age = a;
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
        public string Age
        {
            get
            {
                return age;
            } //End á get
        } //End á Age

        //Aðferð sem skilar streng, tengist hinum klösunum sem bæta við strenginn
        public override string ToString()
        {
            return string.Format("Game: {0} \n\n{1}", Title, Age) + base.ToString();
        }//End á override string
    }
}
