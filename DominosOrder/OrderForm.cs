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
    public partial class OrderForm : Form
    {
        public CustomerInfoForm customerForm;
        public int orderId;
        public OrderForm()
        {
            InitializeComponent();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {
            customerForm = new CustomerInfoForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            customerInfoPanel.Controls.Add(customerForm);
            customerForm.Show();
            customerForm.Set(orderId);

        }
        public void displayCustomerInfo()
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Green;
            button1.Hide();
        }
        public void SetOrder(string pizzatype, string toppings, string dough, string notes)
        {
            this.pizzaTypeBox.Text = pizzatype;
            this.extraToppingsBox.Text = toppings;
            this.specialDoughBox.Text = dough;
            this.extraNotesTextBox.Text = notes;

        }
        


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
