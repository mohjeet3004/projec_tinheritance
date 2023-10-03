using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Microwave : Appliance
    {
        private double capacity;
        private double roomType;
        public Microwave()
        {
            
        }
        public Microwave(double capacity, double roomType)
        {
            this.capacity = capacity;
            this.roomType = roomType;
        }

        public double Capacity { get => capacity; set => capacity = value; }
        public double RoomType { get => roomType; set => roomType = value; }

        public void FormatForFile()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
    
}
