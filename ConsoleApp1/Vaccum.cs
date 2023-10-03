using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Vaccum : Appliance
    {
        private double batteryVoltage;
        private double grade;

        public double BatteryVoltage { get => batteryVoltage; set => batteryVoltage = value; }
        public double Grade { get => grade; set => grade = value; }
        public Vaccum()
        {
            
        }

        public Vaccum(double batteryVoltage, double grade)
        {
            this.batteryVoltage = batteryVoltage;
            this.grade = grade;
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
