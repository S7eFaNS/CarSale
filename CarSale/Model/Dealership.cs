using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarSale.Model
{
    public class Dealership
    {
        private List<Car> cars = new List<Car>();

        private List<Customer> customers = new List<Customer>();

        public Dealership()
        {

        }

        public List<Car> TheCar { get { return cars; } }
    }
}
