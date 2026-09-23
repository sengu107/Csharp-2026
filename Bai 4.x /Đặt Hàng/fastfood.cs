using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dangkyhocvien
{
    public partial class fastfood : Form
    {
        Dictionary<string, int> menu = new Dictionary<string, int>()
        {
            { "Hamburger", 50000 },
            { "Pizza", 120000 },
            { "Gà Rán", 35000 },
            { "Pepsi", 15000 }
        };

        public fastfood()
        {
            InitializeComponent();

            foreach (var item in menu)
            {
                lstMenu.Items.Add(item.Key + " - " + item.Value.ToString("N0") + " VNĐ");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (lstMenu.SelectedItem != null)
            {
                string item = lstMenu.SelectedItem.ToString();

                lstSelected.Items.Add(item);
                lstMenu.Items.Remove(item);

                UpdateTotal();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstSelected.SelectedItem != null)
            {
                string item = lstSelected.SelectedItem.ToString();

                lstSelected.Items.Remove(item);
                lstMenu.Items.Add(item);

                UpdateTotal();
            }
        }

        private void UpdateTotal()
        {
            int total = 0;

            foreach (string item in lstSelected.Items)
            {
                string name = item.Substring(0, item.LastIndexOf(" - "));
                total += menu[name];
            }

            lblTotal.Text = "Total: " + total.ToString("N0") + " VNĐ";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}