using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class MainForm : Form
    {
        Dictionary<string, double> menu = new Dictionary<string, double>()
        {
            {"Coffee", 2.50},
            {"Tea", 2.00},
            {"Sandwich", 5.00},
            {"Cake", 3.50}
        };

        List<string> orderItems = new List<string>();
        List<int> orderQuantities = new List<int>();

        public MainForm()
        {
            InitializeComponent();
            PopulateMenu();
        }

        private void PopulateMenu()
        {
            foreach (var item in menu.Keys)
            {
                comboBoxItems.Items.Add(item);
            }
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBoxItems.SelectedItem.ToString();
            int quantity = (int)numericUpDownQuantity.Value;

            orderItems.Add(selectedItem);
            orderQuantities.Add(quantity);

            MessageBox.Show($"Added {quantity} {selectedItem}(s) to your order.");
        }

        private void btnDisplayReceipt_Click(object sender, EventArgs e)
        {
            double total = 0;
            string receipt = "Receipt:\n";

            for (int i = 0; i < orderItems.Count; i++)
            {
                string item = orderItems[i];
                int quantity = orderQuantities[i];
                double price = menu[item];
                double itemTotal = price * quantity;

                receipt += $"{item} x{quantity}: ${price} each, Total: ${itemTotal}\n";
                total += itemTotal;
            }

            receipt += $"\nTotal: ${total}";

            MessageBox.Show(receipt, "Receipt");
        }
    }
}

