using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Refrigerator : Appliance
    {
        private int doors;
        private double height;
        private double width;

        public Refrigerator(int doors, double height, double width)
        {
            this.doors = doors;
            this.height = height;
            this.width = width;
        }

        public int Doors { get => doors; set => doors = value; }
        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }

        public void FormatForFile()
        {

        }
        public  Refrigerator()
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
