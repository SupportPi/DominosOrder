using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DominosOrder
{
    public partial class CustomerInfoForm : Form
    {
        public string firstname;
        public string lastname;
        public string streetaddress;
        public string aptnum;
        public string zipcode;
        public string city;
        public string state;
        public string gender;
        public int order;

        private void BindCombobox()
        {
            customerCombobox.DataSource = customersDataSet1.Tables["customers"];
            customerCombobox.DisplayMember = "Id";
        }
        public CustomerInfoForm()
        {
            InitializeComponent();
            BindCombobox();
        }
        private string GetSelectedGender()
        {
            if (isMaleRadio.Checked)
                return "Male";
            if (isFemaleRadio.Checked)
                return "Female";
            if (isOtherRadio.Checked)
                return "Other";
            return "Male"; // Default to Male
        }
        private void LoadGenderIntoRadio(string gender)
        {
            switch (gender)
            {
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
        public int hasSelectedId()
        {
            if (int.TryParse(customerCombobox.Text, out int index))
                return index;
            return -1;
        }
        // Saves the Customer Information to the Database (If not using preselected :o)
        public int Save()
        {
            var table = customersDataSet1.Tables["customers"];
            loadData();
            var row = table.NewRow();
            row["FIRST_NAME"] = firstname;
            row["LAST_NAME"] = lastname;
            row["STREET_ADDRESS"] = streetaddress;
            row["APT_SUITE"] = aptnum;
            row["ZIP_CODE"] = zipcode;
            row["CITY"] = city;
            row["US_STATE"] = state;
            row["GENDER"] = gender;
            table.Rows.Add(row);
            this.cUSTOMERSTableAdapter.Update(customersDataSet1);

            if (int.TryParse(row["Id"].ToString(), out int id))
                return id;
            else // Negative Number Indicates that it failed; >= 0
                return -1;
        }
        public void loadData()
        {
            try
            {
                firstname = firstnameTextBox.Text;
                lastname = lastnameTextBox.Text;
                gender = GetSelectedGender();
                streetaddress = streetAddressBox.Text;
                aptnum = aptNumberBox.Text;
                zipcode = zipcodeBox.Text;
                city = cityBox.Text;
                state = stateCombobox.Text;
            }
            catch (Exception err)
            {
                MessageBox.Show("Failed to Validate Customer Data - Please Re-enter your Data!", "Error!");
            }
        }
        public void Set(int id)
        {
            customerCombobox.Text = id.ToString();
            updateSelectedData();
        }
        private void updateSelectedData()
        {
            var table = customersDataSet1.Tables["customers"];

            if (int.TryParse(customerCombobox.Text, out int index))
            {
                try
                {
                    DataRow[] rows = table.Select("Id=" + customerCombobox.Text);
                    var row = rows[0];
                    firstname = row["FIRST_NAME"].ToString();
                    lastname = row["LAST_NAME"].ToString();
                    streetaddress = row["STREET_ADDRESS"].ToString();
                    aptnum = row["APT_SUITE"].ToString();
                    zipcode = row["ZIP_CODE"].ToString();
                    city = row["CITY"].ToString();
                    state = row["US_STATE"].ToString();
                    gender = row["GENDER"].ToString();
                    
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
        private void CustomerInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet1.CUSTOMERS' table. You can move, or remove it, as needed.
            this.cUSTOMERSTableAdapter.Fill(this.customersDataSet1.CUSTOMERS);
            customerCombobox.Text = "N/A";

        }

        private void customerCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateSelectedData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
