using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lokaverkefni
{
    //Þessi klasi geymir aðferðir fyrir allt forritið
    class Adferdir
    {
        //Þessi aðferð finnur dagsetningu, hún tekur inn 3 breytur og skilar síðan string breytu (dagsetningunni)
        public string FindDate (int day, string month, int year)
        {
            //Breytur skilgreindar
            string date = "";
            int monthnumber = 0;

            //Margar if setningar, hver if setning fyrir mánuð
            //Hver mánuður er með númer, númerið er sett í breytuna monthnumber
            if (month == "January")
            {
                monthnumber = 1;
            }
            else if (month == "February")
            {
                monthnumber = 2;
            }
            else if (month == "March")
            {
                monthnumber = 3;
            }
            else if (month == "April")
            {
                monthnumber = 4;
            }
            else if (month == "May")
            {
                monthnumber = 5;
            }
            else if (month == "June")
            {
                monthnumber = 6;
            }
            else if (month == "July")
            {
                monthnumber = 7;
            }
            else if (month == "August")
            {
                monthnumber = 8;
            }
            else if (month == "September")
            {
                monthnumber = 9;
            }
            else if (month == "October")
            {
                monthnumber = 10;
            }
            else if (month == "November")
            {
                monthnumber = 11;
            }
            else if (month == "December")
            {
                monthnumber = 12;
            }

            //Hérna er dagsetningin fundin út, árið, númer á mánuðinum og dagurinn settur saman í string breytu
            date = year + "-" + monthnumber + "-" + day;

            //SKilað dagsetningu
            return date;
        }

        //Aðferð sem skilar leiðbeiningum fyrir TypingGame
        public string instructionsTyping ()
        {
            return "Type as many words as you can and try to be fast! When you get 5 words in a row you get 2x combo wich gives you extra points, "
            + "keep getting many words right in a row and you could get 5x combo! Get a word wrong and you will lose your combo and 5 points! Stay safe!";
        }

        //Aðferð sem skilar leiðbeiningum fyrir Village
        public string instructionsVillage()
        {
            return "Village";
        }

        //Aðferð sem skilar leiðbeiningum fyrir SpaceBar
        public string instructionsSpaceBar()
        {
            return "Press space as many times as you can in 10 seconds! Good Luck!";
        }
    }
}
