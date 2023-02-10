using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Model
{
    public class Car
    {
        private string brand;
        private string model;
        private int year;
        private string price;

        public Car(string brand, string model, int year, string price)
        {
            GetBrand = brand;
            GetModel = model;
            GetYear = year;
            GetPrice = price;
        }

        public string GetBrand
        {
            get { return brand; }
            set { brand = value; }
        }

        public string GetModel
        {
            get { return model; }
            set { model = value; }
        }

        public int GetYear
        {
            get { return year; }
            set { year = value; }
        }

        public string GetPrice
        {
            get { return price; }
            set { price = value; }
        }

        public override string ToString()
        {
            return brand + " " + model + " " + year + " " + price;
        }

        public string TheCSVFormat()
        {
            return GetBrand + "," + GetModel + "," + GetYear + "," + GetPrice;
        }
    }
}
