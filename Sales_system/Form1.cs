using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sales_system
{
    public partial class Form1 : Form
    {
        private ListBox bagTypeListBox;
        private NumericUpDown quantityNumericUpDown;
        private RadioButton overnightRadioButton;
        private RadioButton threeDayRadioButton;
        private RadioButton standardRadioButton;
        private Button calculateButton;
        private Button clearButton;
        public Form1()
        {

            InitializeComponent();
        }
        private void InitializeComponents()
        {
            bagTypeListBox = new ListBox
            {
                Name = "bagTypeListBox",
                Location = new Point(10, 10),
                Size = new Size(200, 100)

            };
            bagTypeListBox.Items.AddRange(new string[] { "Full Decorative", "Beaded", "Needlepoint Design", "Fringed Beaded", "Plain" });
            this.Controls.Add(bagTypeListBox);

            quantityNumericUpDown = new NumericUpDown
            {
                Name = "quantityNumericUpDown",
                Location = new Point(10, 120),
                Size = new Size(100, 20),
                Minimum = 1,
                Value = 1
            };
            this.Controls.Add(quantityNumericUpDown);
            overnightRadioButton = new RadioButton
            {
                Name = "overnightRadioButton",
                Text = "Overnight",
                Location = new Point(10, 150)
            };
            threeDayRadioButton = new RadioButton
            {
                Name = "threeDayRadioButton",
                Text = "Three Day",
                Location = new Point(10, 180)
            };
            Standardbtn = new RadioButton
            {
                Name = "standardRadioButton",
                Text = "Standard",
                Location = new Point(10, 210)
            };
            this.Controls.Add(Overnightbtn);
            this.Controls.Add(Three_Daybtn);
            this.Controls.Add(Standardbtn);

            calculateButton = new Button
            {
                Name = "clearButton",
                Text = "Clear Selection",
                Location = new Point(120, 240),
                Size = new Size(100, 30)
            };
            clearButton = new Button
            {
                Name = "clearButton",
                Text = "Clear Selection",
                Location = new Point(120, 240),
                Size = new Size(100, 30)
            };
            clearButton.Click += new EventHandler(ClearButton_Click_Click);
            this.Controls.Add(clearButton);

            this.Text = "Handbag Sales System";
            this.Size = new Size(250, 320);

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click_Click(object sender, EventArgs e)
        {
            string selectedBag = bagType.SelectedItem?.ToString();
            if (selectedBag == null)
            {
                MessageBox.Show("Please select a bag type.");
                return;
            }
            int quantity = (int)Numericquantity.Value;

            // Determine price based on bag type
            int price = 0;
            if (selectedBag == "Full Decorative")
            {
                price = 450;
            }
            else if (selectedBag == "Beaded")
            {
                price = 560;
            }
            else if (selectedBag == "Needlepoint Design")
            {
                price = 240;
            }
            else if (selectedBag == "Fringed Beaded")
            {
                price = 630;
            }
            else if (selectedBag == "Plain")
            {
                price = 120;
            }
            double shippingRate = 0;
            if (Overnightbtn.Checked) shippingRate = 0.10;
            else if (Three_Daybtn.Checked) shippingRate = 0.07;
            else if (Standardbtn.Checked) shippingRate = 0.05;
            else
            {
                MessageBox.Show("Please select a shipping option.");
                return;
            }
            double totalCost = quantity * price * (1 + shippingRate);

            MessageBox.Show($"Selection: {selectedBag}\nQuantity: {quantity}\nShipping: {shippingRate * 100}%\nTotal Cost: R{totalCost:F2}");

        }

        private void ClearButton_Click_Click(object sender, EventArgs e)
        {
            bagType.ClearSelected();
            Numericquantity.Value = 1;
            Overnightbtn.Checked = false;
            Three_Daybtn.Checked = false;
            Standardbtn.Checked = false;
            MessageBox.Show("Selections cleared.");
        }
        


    }
}
