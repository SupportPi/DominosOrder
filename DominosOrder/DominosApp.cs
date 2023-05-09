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
    public partial class DominosApp : Form
    {
        private int num_orders = 0;
        private CustomerInfoForm customerForm;
        private SavedCustomersForm savedCustomersForm;
        public DominosApp()
        {
            InitializeComponent();
        }

        private void DominosApp_Load(object sender, EventArgs e)
        {
            savedCustomersForm = new SavedCustomersForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            tabPage1.Controls.Add(savedCustomersForm);
            savedCustomersForm.Show();

            /*orderForm = new OrderForm();
            orderForm.TopLevel = false;
            orderForm.FormBorderStyle = FormBorderStyle.None;
            orderForm.Dock = DockStyle.Fill;
            tabPage2.Controls.Add(orderForm);
            orderForm.Show();*/
            customerForm = new CustomerInfoForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            customerInfoPanel.Controls.Add(customerForm);
            customerForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void submitButton_Click(object sender, EventArgs e)
        {

            customerForm.loadData();

            // Creates a New Tab containing Order Data - Uneditable due to Time Constraints ;-;
            TabPage orderPage = new TabPage();

            // Creates a new OrderForm to Describe the Created Order - Along with a Button to Submit or Delete (Both Remove the Order bc real functionality (while possible with a webdriver - would be stupid)) the Order;
            OrderForm pizzaOrder = new OrderForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            orderPage.Controls.Add(pizzaOrder);
            int num_orders = ++this.num_orders;
            orderPage.Text = "Order #" + num_orders;
            tabControl.Controls.Add(orderPage);
            int data_saved_id;

            data_saved_id = customerForm.hasSelectedId();
            // Saves Data 
            if (data_saved_id == -1) 
                data_saved_id = customerForm.Save();
            pizzaOrder.orderId = data_saved_id;
            // stupid
            string toppings = extraToppingsBox.Text;
            string dough = specialDoughBox.Text;
            string pizzatype = pizzaTypeBox.Text;
            string notes = extraNotesTextBox.Text;
            pizzaOrder.SetOrder(pizzatype, toppings, dough, notes);
            pizzaOrder.Show();


        }
    }
}
