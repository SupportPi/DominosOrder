namespace DominosOrder
{
    partial class DominosApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DominosApp));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.submitButton = new System.Windows.Forms.Button();
            this.jokeLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.baseCostBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.extraNotesTextBox = new System.Windows.Forms.TextBox();
            this.specialDoughBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pizzaTypeBox = new System.Windows.Forms.ComboBox();
            this.extraToppingsBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerInfoPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 41);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 534);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Saved Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.submitButton);
            this.tabPage2.Controls.Add(this.jokeLabel);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.totalCostLabel);
            this.tabPage2.Controls.Add(this.totalBox);
            this.tabPage2.Controls.Add(this.discountBox);
            this.tabPage2.Controls.Add(this.baseCostBox);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.extraNotesTextBox);
            this.tabPage2.Controls.Add(this.specialDoughBox);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.pizzaTypeBox);
            this.tabPage2.Controls.Add(this.extraToppingsBox);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.customerInfoPanel);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.Transparent;
            this.submitButton.Location = new System.Drawing.Point(621, 482);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(163, 23);
            this.submitButton.TabIndex = 22;
            this.submitButton.Text = "Submit Order!";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // jokeLabel
            // 
            this.jokeLabel.AutoSize = true;
            this.jokeLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.jokeLabel.Location = new System.Drawing.Point(3, 492);
            this.jokeLabel.Name = "jokeLabel";
            this.jokeLabel.Size = new System.Drawing.Size(169, 13);
            this.jokeLabel.TabIndex = 21;
            this.jokeLabel.Text = "Please remember to request a Tip*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(384, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Discount (%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 418);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Base Cost:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(384, 477);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostLabel.TabIndex = 18;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // totalBox
            // 
            this.totalBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.totalBox.Location = new System.Drawing.Point(459, 475);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(104, 20);
            this.totalBox.TabIndex = 17;
            this.totalBox.TextChanged += new System.EventHandler(this.totalBox_TextChanged);
            // 
            // discountBox
            // 
            this.discountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.discountBox.Location = new System.Drawing.Point(459, 441);
            this.discountBox.Name = "discountBox";
            this.discountBox.Size = new System.Drawing.Size(104, 20);
            this.discountBox.TabIndex = 16;
            // 
            // baseCostBox
            // 
            this.baseCostBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.baseCostBox.Location = new System.Drawing.Point(459, 415);
            this.baseCostBox.Name = "baseCostBox";
            this.baseCostBox.Size = new System.Drawing.Size(104, 20);
            this.baseCostBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(375, 392);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estimated Cost ($) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(375, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Extra Notes:";
            // 
            // extraNotesTextBox
            // 
            this.extraNotesTextBox.Location = new System.Drawing.Point(458, 214);
            this.extraNotesTextBox.Multiline = true;
            this.extraNotesTextBox.Name = "extraNotesTextBox";
            this.extraNotesTextBox.Size = new System.Drawing.Size(185, 164);
            this.extraNotesTextBox.TabIndex = 12;
            // 
            // specialDoughBox
            // 
            this.specialDoughBox.FormattingEnabled = true;
            this.specialDoughBox.Items.AddRange(new object[] {
            "Plain",
            "Garlic Infused",
            "Xtra Cheesy"});
            this.specialDoughBox.Location = new System.Drawing.Point(458, 156);
            this.specialDoughBox.Name = "specialDoughBox";
            this.specialDoughBox.Size = new System.Drawing.Size(162, 21);
            this.specialDoughBox.TabIndex = 11;
            this.specialDoughBox.Text = "Plain";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Special Dough:";
            // 
            // pizzaTypeBox
            // 
            this.pizzaTypeBox.FormattingEnabled = true;
            this.pizzaTypeBox.Items.AddRange(new object[] {
            "Cheese",
            "Pepperoni",
            "Margarita",
            ""});
            this.pizzaTypeBox.Location = new System.Drawing.Point(459, 86);
            this.pizzaTypeBox.Name = "pizzaTypeBox";
            this.pizzaTypeBox.Size = new System.Drawing.Size(161, 21);
            this.pizzaTypeBox.TabIndex = 9;
            this.pizzaTypeBox.Text = "Cheese";
            // 
            // extraToppingsBox
            // 
            this.extraToppingsBox.FormattingEnabled = true;
            this.extraToppingsBox.Items.AddRange(new object[] {
            "None",
            "Pepperoni",
            "Extra Cheese",
            "Italian Sausage",
            "Meatball",
            "Olives"});
            this.extraToppingsBox.Location = new System.Drawing.Point(459, 121);
            this.extraToppingsBox.Name = "extraToppingsBox";
            this.extraToppingsBox.Size = new System.Drawing.Size(161, 21);
            this.extraToppingsBox.TabIndex = 8;
            this.extraToppingsBox.Text = "Plain";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(375, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pizza Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(375, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Extra Toppings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Order Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Information:";
            // 
            // customerInfoPanel
            // 
            this.customerInfoPanel.BackColor = System.Drawing.Color.Silver;
            this.customerInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfoPanel.Location = new System.Drawing.Point(13, 80);
            this.customerInfoPanel.Name = "customerInfoPanel";
            this.customerInfoPanel.Size = new System.Drawing.Size(279, 363);
            this.customerInfoPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create a new Order:";
            // 
            // DominosApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "DominosApp";
            this.Text = "Dominos Order";
            this.Load += new System.EventHandler(this.DominosApp_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel customerInfoPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox extraNotesTextBox;
        private System.Windows.Forms.ComboBox specialDoughBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox pizzaTypeBox;
        private System.Windows.Forms.ComboBox extraToppingsBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.TextBox baseCostBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label jokeLabel;
        private System.Windows.Forms.Label label10;
    }
}

