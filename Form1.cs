using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShoeOrderingSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeListBox();
            InitializeCityListBox();
        }

        private void InitializeListBox()
        {
            listBoxBrandModel.Items.Add("Nike - Air Force 1");
            listBoxBrandModel.Items.Add("Adidas - Stan Smith");
            listBoxBrandModel.Items.Add("Puma - RS-X");
            // Add more shoe models as needed
        }

        private void InitializeCityListBox()
        {
            listBoxCity.Items.Add("Eskişehir");
            listBoxCity.Items.Add("Ankara");
            // Add more cities as needed
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
           

            if (!string.IsNullOrEmpty(textBoxName.Text) &&
               !string.IsNullOrEmpty(textBoxSurname.Text) &&
               !string.IsNullOrEmpty(textBoxPhoneNumber.Text) &&
               listBoxBrandModel.SelectedItem != null &&
               GetSelectedSizes().Count != 0 &&
               listBoxCity.SelectedItem != null &&
               listBoxDistrict.SelectedItem != null
               )
            {
                string fullName = textBoxName.Text + " " + textBoxSurname.Text;
                string phoneNumber = textBoxPhoneNumber.Text;
                string selectedModel = listBoxBrandModel.SelectedItem.ToString();
                List<string> selectedSizes = GetSelectedSizes();
                string city = listBoxCity.SelectedItem.ToString();
                string district = listBoxDistrict.SelectedItem.ToString();
                string orderInfo = $"{fullName} - {phoneNumber} - {selectedModel} - Sizes: {string.Join(", ", selectedSizes)} - {city}/{district} - {DateTime.Now}";
                listBoxOrders.Items.Add(orderInfo);

            }
            else
                MessageBox.Show("Please fill all the informations!");


        }

        private List<string> GetSelectedSizes()
        {
            List<string> selectedSizes = new List<string>();
            foreach (CheckBox checkBox in flowLayoutPanelSizes.Controls)
            {
                if (checkBox.Checked)
                {
                    selectedSizes.Add(checkBox.Text);
                }

            }
            return selectedSizes;
        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDistrict.Items.Clear();
            if (listBoxCity.SelectedItem.ToString() == "Eskişehir")
            {
                listBoxDistrict.Items.Add("Tepebaşı");
                listBoxDistrict.Items.Add("Odunpazarı");
                // Add more districts of Eskişehir as needed
            }
            else if (listBoxCity.SelectedItem.ToString() == "Ankara")
            {
                listBoxDistrict.Items.Add("Çankaya");
                listBoxDistrict.Items.Add("Kızılay");
                // Add more districts of Ankara as needed
            }
        }

        private void listBoxBrandModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanelSizes.Controls.Clear();
            // Assuming sizes are model-dependent
            string selectedModel = listBoxBrandModel.SelectedItem.ToString();
            switch (selectedModel)
            {
                case "Nike - Air Force 1":
                    AddSizesToFlowLayoutPanel(new string[] { "7", "8", "9", "10", "11" });
                    break;
                case "Adidas - Stan Smith":
                    AddSizesToFlowLayoutPanel(new string[] { "6", "7", "8", "9", "10" });
                    break;
                case "Puma - RS-X":
                    AddSizesToFlowLayoutPanel(new string[] { "7", "8", "9", "10" });
                    break;
                default:
                    break;
            }
        }
        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedIndex != -1)
            {
                string selectedOrder = listBoxOrders.SelectedItem.ToString();
                labelSelectedOrder.Text = "Selected Order: " + selectedOrder;
                labelSelectedOrder.Visible = true;
            }
            else
            {
                labelSelectedOrder.Visible = false;
            }

            {
                // Seçilen öğe varsa ve ListBox'ın SelectedItem özelliği null değilse
                if (listBoxOrders.SelectedItem != null)
                {
                    // Seçilen öğenin bilgilerini Label'da göster
                    string selectedOrderInfo = listBoxOrders.SelectedItem.ToString();
                    label2.Text = selectedOrderInfo;
                }
                else
                {
                    // Eğer bir öğe seçilmemişse, Label'ı temizle
                    label2.Text = "";
                }
            }
        }

        private void AddSizesToFlowLayoutPanel(string[] sizes)
        {
            foreach (var size in sizes)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Text = size;
                flowLayoutPanelSizes.Controls.Add(checkBox);
            }
        }

    }

}