using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1
{
    public class DishWasher : Appliance
    {
        private string feature;
        private string soundRating;

        public string Feature { get => feature; set => feature = value; }
        public string SoundRating { get => soundRating; set => soundRating = value; }

        public DishWasher(string feature, string soundRating)
        {
            this.feature = feature;
            this.soundRating = soundRating;
        }
        public DishWasher()
        {
            
        }

        public void FormatForFile()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
    

}
