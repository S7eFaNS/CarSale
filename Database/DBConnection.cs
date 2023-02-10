using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using CarSale.Model;

namespace CarSale.Database
{
    public class DBConnetion
    {
        private string connectionString;

        public DBConnetion(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void SaveCar(Car car, Customer customer)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Guid carId = Guid.NewGuid();
                using (SqlCommand command = new SqlCommand("INSERT INTO SoldCars (CarBrand, CarModel, CarYear, CarPrice, CarID) values(@CarBrand, @CarModel, @CarYear, @CarPrice, @CarID);", connection))
                {
                    command.Parameters.AddWithValue("@CarBrand", car.GetBrand);
                    command.Parameters.AddWithValue("@CarModel", car.GetModel);
                    command.Parameters.AddWithValue("@CarYear", car.GetYear);
                    command.Parameters.AddWithValue("@CarPrice", car.GetPrice);
                    command.Parameters.AddWithValue("@CarID", carId);
                    command.ExecuteNonQuery();
                }
                using (SqlCommand command = new SqlCommand("INSERT INTO Customer (CarID, CustomerName, CustomerPhone, CustomerAddress, CustomerZipCity) values(@CarID, @CustomerName, @CustomerPhone, @CustomerAddress, @CustomerZipCity)", connection))
                {
                    command.Parameters.AddWithValue("@CarID", carId);
                    command.Parameters.AddWithValue("@CustomerName", customer.GetName);
                    command.Parameters.AddWithValue("@CustomerPhone", customer.GetPhone);
                    command.Parameters.AddWithValue("@CustomerAddress", customer.GetAddress);
                    command.Parameters.AddWithValue("@CustomerZipCity", customer.GetZip_City);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public void LoadCar(ListBox listbox)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT SoldCars.CarID, SoldCars.CarBrand, SoldCars.CarModel, SoldCars.CarYear, SoldCars.CarPrice,\r\n       Customer.CustomerName, Customer.CustomerPhone, Customer.CustomerAddress, Customer.CustomerZipCity\r\nFROM SoldCars\r\nINNER JOIN Customer ON Customer.CarID = SoldCars.CarID", connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string carData = reader["CarBrand"].ToString() + " " + reader["CarModel"].ToString() + " " + reader["CarYear"].ToString() + " Price: " + reader["CarPrice"].ToString();
                        string customerData = " Name: " + reader["CustomerName"].ToString() + " Phone: " + reader["CustomerPhone"].ToString() + " Address: " + reader["CustomerAddress"].ToString() + " " + reader["CustomerZipCity"].ToString();
                        string combinedData = carData + ", " + customerData;
                        listbox.Items.Add(combinedData);
                    }
                }
                connection.Close();
            }
        }
    }
}
