using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Text;
using CarSale.Database;
using CarSale.Model;

namespace CarSale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dealership dealership = new Dealership();

        List<string> listcollection = new List<string>();

        private void button10_Click(object sender, EventArgs e)
        {
            listBoxCars.Items.Clear();

            loadingFile(listBoxCars);
            
            btnEditACarInfo.Enabled = false;
            btnRemoveFromTheCatalogue.Enabled = false;
            listBoxCars.SelectionMode = SelectionMode.MultiExtended;
        }

        List<int> theselected = new List<int>();
        
        int donTclear = 0;

        private void btnAddToTheCatalogue_Click(object sender, EventArgs e)
        {
            try
            {
                string make = tbTheBrand.Text;
                string model = tbTheModel.Text;
                int year = Convert.ToInt32(tbTheYear.Text);
                string price = tbThePrice.Text;

                Car newCar = new Car(make, model, year, price);

                dealership.TheCar.Add(newCar);

                listBoxCars.Items.Add(newCar);

                string newLine = make + "," + model + "," + year + "," + price;

                File.AppendAllText("../../MOCK_CAR_DATA1.csv", newLine + Environment.NewLine);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid input for year, please enter a number");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnEditACarInfo_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxCars.SelectedIndex >= 0)
                {
                    List<string> linesList = File.ReadAllLines("../../MOCK_CAR_DATA1.csv").ToList();

                    dealership.TheCar[listBoxCars.SelectedIndex] = new Car(tbTheBrand.Text, tbTheModel.Text, Convert.ToInt32(tbTheYear.Text), tbThePrice.Text);

                    int sell = listBoxCars.SelectedIndex + 1;

                    listBoxCars.Items[listBoxCars.SelectedIndex] = dealership.TheCar[listBoxCars.SelectedIndex];

                    linesList[sell] = dealership.TheCar[sell - 1].TheCSVFormat();

                    File.WriteAllLines("../../MOCK_CAR_DATA1.csv", linesList.ToArray());

                    List<string> linesListt = File.ReadAllLines("../../MOCK_CAR_DATA1.csv").ToList();
                }
                else
                {
                    throw new Exception("No car selected to edit");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRemoveFromTheCatalogue_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxCars.SelectedIndex >= 0)
                {
                    List<string> linesList = File.ReadAllLines("../../MOCK_CAR_DATA1.csv").ToList();

                    linesList.RemoveAt(listBoxCars.SelectedIndex + 1);

                    dealership.TheCar.RemoveAt(listBoxCars.SelectedIndex);

                    listBoxCars.Items.RemoveAt(listBoxCars.SelectedIndex);

                    File.WriteAllLines("../../MOCK_CAR_DATA1.csv", linesList.ToArray());
                }
                else
                {
                    throw new Exception("No car selected to remove from the catalogue");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void listBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (donTclear == 0)
            {
                theselected.Clear();

                if (listBoxCars.SelectedIndices.Count > 0)
                {
                    for (int cmon = 0; cmon < listBoxCars.Items.Count; cmon++)
                    {
                        for (int cmmonn = 0; cmmonn < listBoxCars.SelectedItems.Count; cmmonn++)
                        {
                            if (cmon + 1 + ") " + dealership.TheCar[cmon].ToString() == listBoxCars.SelectedItems[cmmonn].ToString())
                            {
                                theselected.Add(cmon);
                            }
                        }
                    }
                    if (listBoxCars.SelectedIndices.Count > 1)
                    {
                        btnEditACarInfo.Enabled = false;
                        foreach (TextBox textBox in Controls.OfType<TextBox>())
                            textBox.Text = "";
                    }
                }

                if (listBoxCars.SelectedIndices.Count == 1 && listBoxCars.SelectedIndex >= 0)
                {
                    for (int i = 0; i < dealership.TheCar.Count; i++)
                    {
                        if (i + 1 + ") " + dealership.TheCar[i].ToString() == listBoxCars.SelectedItem.ToString())
                        {
                            tbTheBrand.Text = dealership.TheCar[i].GetBrand;
                            tbTheModel.Text = dealership.TheCar[i].GetModel;
                            tbTheYear.Text = dealership.TheCar[i].GetYear.ToString();
                            tbThePrice.Text = dealership.TheCar[i].GetPrice.ToString();
                        }
                    }
                    btnEditACarInfo.Enabled = true;
                    btnRemoveFromTheCatalogue.Enabled = true;
                    return;
                }

                else if (listBoxCars.SelectedIndices.Count == 1 && listBoxCars.SelectedIndex >= 0)
                {
                    if (listBoxCars.SelectedIndex >= 0)
                    {
                        listBoxCars.ClearSelected();
                        foreach (TextBox textBox in Controls.OfType<TextBox>())
                            textBox.Text = "";
                    }
                    btnEditACarInfo.Enabled = true;
                    btnRemoveFromTheCatalogue.Enabled = true;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBoxAvailableCars.Items.Clear();

            loadingFile(listBoxAvailableCars);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox5.Text) == false)
            {
                listBoxAvailableCars.Items.Clear();

                foreach (Car car in dealership.TheCar)
                {
                    if (car.GetBrand.Contains(textBox5.Text) || car.GetYear.ToString().Contains(textBox5.Text))
                    {
                        listBoxAvailableCars.Items.Add(car);
                    }
                }
            }
            else if (textBox5.Text == "")
            {
                listBoxAvailableCars.Items.Clear();

                dealership.TheCar.Clear();

                loadingFile(listBoxAvailableCars);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                {
                    if (control is TextBox)
                    {
                        (control as TextBox).Clear();
                    }

                    else if (control is ListBox)
                    {
                        (control as ListBox).Items.Clear();
                    }

                    else
                    {
                        func(control.Controls);
                    }
                }
            };
            func(Controls);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                string accessory = Microsoft.VisualBasic.Interaction.InputBox("Thank you for purchasing the car.\nPlease enter which accessory would you want as a gift:\n\nChair Cushion\nCar Hooks\nAdditional Tires", "Item Input", "", 100, 100);
                MessageBox.Show($"You'll receive\n{accessory}\nThank you for your purchase");

                Car currentCar = dealership.TheCar[listBoxAvailableCars.SelectedIndex];

                string filePath = @"C:\Users\Stefan\source\repos\Car Sale\CarSale\CarSale\SoldCars.md";

                List<string> linesList = File.ReadAllLines("../../MOCK_CAR_DATA1.csv").ToList();

                linesList.RemoveAt(listBoxAvailableCars.SelectedIndex + 1);

                dealership.TheCar.RemoveAt(listBoxAvailableCars.SelectedIndex);

                listBoxAvailableCars.Items.RemoveAt(listBoxAvailableCars.SelectedIndex);

                File.WriteAllLines("../../MOCK_CAR_DATA1.csv", linesList.ToArray());

                Customer customer = new Customer(textBoxName.Text, textBoxPhone.Text, textBoxAddress.Text, textBoxZip_City.Text);

                contentBuild(ref currentCar, ref customer, ref filePath);

                DBConnetion db = new DBConnetion("Data Source = DESKTOP-7TELIFV\\SQLEXPRESS;Initial Catalog = CarSales;Integrated Security = True");

                db.SaveCar(currentCar, customer);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("No car selected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxSoldCars.Items.Clear();
            foreach (var line in File.ReadLines("C:\\Users\\Stefan\\source\\repos\\Car Sale\\CarSale\\CarSale\\SoldCars.md"))
            {
                var items = line.Split("---");
                var item = String.Join("---", items);
                listBoxSoldCars.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBoxSoldCars.Items.Clear();

            DBConnetion db = new DBConnetion("Data Source = DESKTOP-7TELIFV\\SQLEXPRESS;Initial Catalog = CarSales;Integrated Security = True");
            
            db.LoadCar(listBoxSoldCars);
        }

        private void contentBuild(ref Car car, ref Customer customer, ref string filePath)
        {
            StringBuilder content = new StringBuilder();

            content.Append("# " + DateTime.Now + " | ");
            content.Append(car.GetBrand + " " + car.GetModel + " " + car.GetYear + "\n");
            content.Append("\n");
            content.Append("- *Price*: " + car.GetPrice + "\n");
            content.Append("- *Customer*: " + customer.GetName + "\n");
            content.Append("- *Phone no.*: " + customer.GetPhone + "\n");
            content.Append("- *Address*: " + customer.GetAddress + "\n");
            content.Append("- *Zip code & city*: " + customer.GetZip_City + "\n");
            content.Append("\n");
            content.Append("---\n");

            File.AppendAllText(filePath, content.ToString());
        }

        private void loadingFile(ListBox listBox)
        {
            foreach (var line in File.ReadAllLines("../../MOCK_CAR_DATA1.csv").Skip(1))
            {   
                string[] items = line.Split(',');
                dealership.TheCar.Add(new Car(items[0], items[1], Convert.ToInt32(items[2]), items[3]));
                listBox.Items.Add(dealership.TheCar[dealership.TheCar.Count - 1].ToString());
            }
        }
    }
}