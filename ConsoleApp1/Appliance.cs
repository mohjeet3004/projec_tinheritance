using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Appliance
    {
        private string brand;
        private string color;
        private string isAvaialble;
        private double itemNumber;
        private double price;
        private double quantity;
        private string Type;
        private double wattage;

        

        public Appliance()
        {
            
        }

        public Appliance(string brand, string color, string isAvaialble, double itemNumber, double price, double quantity, string type, double wattage)
        {
            this.brand = brand;
            this.color = color;
            this.isAvaialble = isAvaialble;
            this.itemNumber = itemNumber;
            this.price = price;
            this.quantity = quantity;
            Type = type;
            this.wattage = wattage;
        }

        public string Brand { get => brand; set => brand = value; }
        public string Color { get => color; set => color = value; }
        public string IsAvaialble { get => isAvaialble; set => isAvaialble = value; }
        public double ItemNumber { get => itemNumber; set => itemNumber = value; }
        public double Price { get => price; set => price = value; }
        public double Quantity { get => quantity; set => quantity = value; }
        public string Type1 { get => Type; set => Type = value; }
        public double Wattage { get => wattage; set => wattage = value; }

        public void Checkout()
        {
            
        }
        public void DetemineApplicance()
        {
            
        }
        public void FormatForFile()
        {

        }
    }
}
