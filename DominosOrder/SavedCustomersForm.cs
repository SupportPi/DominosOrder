using DominosOrder.customersDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace DominosOrder
{
    public partial class SavedCustomersForm : Form
    {

        public SavedCustomersForm()
        {
            InitializeComponent();
            BindCombobox();

        }
        
        private string GetSelectedGender()
        {
            if(isMaleRadio.Checked)
                return "Male";
            if (isFemaleRadio.Checked)
                return "Female";
            if (isOtherRadio.Checked)
                return "Other";
            return "Male"; // Default to Male
        }
        public int save()
        {


            return 0;
        }

        private void BindCombobox()
        {
            customerCombobox.DataSource = customersDataSet.Tables["customers"];
            customerCombobox.DisplayMember = "Id";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void SavedCustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.customersDataSet.CUSTOMERS);
            customerCombobox.Text = "N/A";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadGenderIntoRadio(string gender)
        {
            switch (gender) {
                case "Male":
                    isMaleRadio.Checked = true;
                break;
                case "Female":
                    isFemaleRadio.Checked = true;
                break;
                case "Other":
                    isOtherRadio.Checked = true;
                break;
            }
            
        }
        private void removeSelectedCustomer() {
            var table = customersDataSet.Tables["customers"];
           
            if (customerCombobox.Text != "N/A")
            {
                DataRow[] rows = table.Select("Id=" + customerCombobox.Text);
                rows[0].Delete();
                var count = customerCombobox.Items.Count;
                if(count > 0)
                    customerCombobox.SelectedIndex = 0;
                customerCombobox.Text = "N/A";

            }
            //TableAdapterManager.UpdateAll(customersDataSet);
            this.cUSTOMERSTableAdapter.Update(customersDataSet) ;
        }
        private void updateDatasetFromData()
        {
            var table = customersDataSet.Tables["customers"];

            if (int.TryParse(customerCombobox.Text, out int index))
            {
                try
                {
                    DataRow[] rows = table.Select("Id=" + customerCombobox.Text);
                    var row = rows[0];
                    string firstname = row["FIRST_NAME"].ToString();
                    string lastname = row["LAST_NAME"].ToString();
                    string streetaddress = row["STREET_ADDRESS"].ToString();
                    string aptnum = row["APT_SUITE"].ToString();
                    string zipcode = row["ZIP_CODE"].ToString();
                    string city = row["CITY"].ToString();
                    string state = row["US_STATE"].ToString();
                    string gender = row["GENDER"].ToString();
                    LoadGenderIntoRadio(gender);
                    firstnameTextBox.Text = firstname;
                    lastnameTextBox.Text = lastname;
                    streetAddressBox.Text = streetaddress;
                    aptNumberBox.Text = aptnum;
                    zipcodeBox.Text = zipcode;
                    cityBox.Text = city;
                    stateCombobox.Text = state;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Failed to Save Selected Customer Data!", "Error!");
                    int selectedIndex = customerCombobox.SelectedIndex;
                }

            }
            else
            {
                MessageBox.Show("Failed to Parse Customer Selection", "Error!");
            }
        }
        private void updateSelectedData()
        {
            var table = customersDataSet.Tables["customers"];

            if (int.TryParse(customerCombobox.Text, out int index))
            {
                try
                {
                    DataRow[] rows = table.Select("Id=" + customerCombobox.Text);
                    var row = rows[0];
                    string firstname = row["FIRST_NAME"].ToString();
                    string lastname = row["LAST_NAME"].ToString();
                    string streetaddress = row["STREET_ADDRESS"].ToString();
                    string aptnum = row["APT_SUITE"].ToString();
                    string zipcode = row["ZIP_CODE"].ToString();
                    string city = row["CITY"].ToString();
                    string state = row["US_STATE"].ToString();
                    string gender = row["GENDER"].ToString();
                    LoadGenderIntoRadio(gender);
                    firstnameTextBox.Text = firstname;
                    lastnameTextBox.Text = lastname;
                    streetAddressBox.Text = streetaddress;
                    aptNumberBox.Text = aptnum;
                    zipcodeBox.Text = zipcode;
                    cityBox.Text = city;
                    stateCombobox.Text = state;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Failed to Load Selected Customer!", "Error!");
                    int selectedIndex = customerCombobox.SelectedIndex;
                }

            }
            else
            {
                MessageBox.Show("Failed to Parse Customer Selection", "Error!");
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSelectedData();
        }

        private void isMaleRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void removeCustomerButton_Click(object sender, EventArgs e)
        {
            removeSelectedCustomer();
        }

        private void saveCustomerButton_Click(object sender, EventArgs e)
        {

        }
    }
}
