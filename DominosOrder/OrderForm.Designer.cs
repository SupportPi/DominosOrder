namespace DominosOrder
{
    partial class OrderForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.customerInfoPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.totalCostLabel = new System.Windows.Forms.Label();
            this.totalBox = new System.Windows.Forms.TextBox();
            this.discountBox = new System.Windows.Forms.TextBox();
            this.baseCostBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.extraNotesTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.specialDoughBox = new System.Windows.Forms.TextBox();
            this.extraToppingsBox = new System.Windows.Forms.TextBox();
            this.pizzaTypeBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(640, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Mark as Fulfilled";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Order Status:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Firebrick;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(101, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 28);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(654, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 38);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Information:";
            // 
            // customerInfoPanel
            // 
            this.customerInfoPanel.BackColor = System.Drawing.Color.Silver;
            this.customerInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.customerInfoPanel.Location = new System.Drawing.Point(12, 87);
            this.customerInfoPanel.Name = "customerInfoPanel";
            this.customerInfoPanel.Size = new System.Drawing.Size(293, 360);
            this.customerInfoPanel.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Discount (%):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(403, 394);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Base Cost:";
            // 
            // totalCostLabel
            // 
            this.totalCostLabel.AutoSize = true;
            this.totalCostLabel.Location = new System.Drawing.Point(403, 453);
            this.totalCostLabel.Name = "totalCostLabel";
            this.totalCostLabel.Size = new System.Drawing.Size(58, 13);
            this.totalCostLabel.TabIndex = 34;
            this.totalCostLabel.Text = "Total Cost:";
            // 
            // totalBox
            // 
            this.totalBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.totalBox.Location = new System.Drawing.Point(478, 451);
            this.totalBox.Name = "totalBox";
            this.totalBox.Size = new System.Drawing.Size(104, 20);
            this.totalBox.TabIndex = 33;
            // 
            // discountBox
            // 
            this.discountBox.Location = new System.Drawing.Point(478, 417);
            this.discountBox.Name = "discountBox";
            this.discountBox.ReadOnly = true;
            this.discountBox.Size = new System.Drawing.Size(104, 20);
            this.discountBox.TabIndex = 32;
            // 
            // baseCostBox
            // 
            this.baseCostBox.Location = new System.Drawing.Point(478, 391);
            this.baseCostBox.Name = "baseCostBox";
            this.baseCostBox.ReadOnly = true;
            this.baseCostBox.Size = new System.Drawing.Size(104, 20);
            this.baseCostBox.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(394, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Estimated Cost ($) :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Extra Notes:";
            // 
            // extraNotesTextBox
            // 
            this.extraNotesTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.extraNotesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraNotesTextBox.Location = new System.Drawing.Point(483, 182);
            this.extraNotesTextBox.Multiline = true;
            this.extraNotesTextBox.Name = "extraNotesTextBox";
            this.extraNotesTextBox.ReadOnly = true;
            this.extraNotesTextBox.Size = new System.Drawing.Size(185, 164);
            this.extraNotesTextBox.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(396, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Special Dough:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Pizza Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(394, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Extra Toppings:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Order Information:";
            // 
            // specialDoughBox
            // 
            this.specialDoughBox.Location = new System.Drawing.Point(483, 151);
            this.specialDoughBox.Name = "specialDoughBox";
            this.specialDoughBox.ReadOnly = true;
            this.specialDoughBox.Size = new System.Drawing.Size(100, 20);
            this.specialDoughBox.TabIndex = 37;
            // 
            // extraToppingsBox
            // 
            this.extraToppingsBox.Location = new System.Drawing.Point(483, 122);
            this.extraToppingsBox.Name = "extraToppingsBox";
            this.extraToppingsBox.ReadOnly = true;
            this.extraToppingsBox.Size = new System.Drawing.Size(100, 20);
            this.extraToppingsBox.TabIndex = 38;
            // 
            // pizzaTypeBox
            // 
            this.pizzaTypeBox.Location = new System.Drawing.Point(483, 90);
            this.pizzaTypeBox.Name = "pizzaTypeBox";
            this.pizzaTypeBox.ReadOnly = true;
            this.pizzaTypeBox.Size = new System.Drawing.Size(100, 20);
            this.pizzaTypeBox.TabIndex = 39;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pizzaTypeBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.extraToppingsBox);
            this.Controls.Add(this.specialDoughBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.totalCostLabel);
            this.Controls.Add(this.totalBox);
            this.Controls.Add(this.discountBox);
            this.Controls.Add(this.baseCostBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.extraNotesTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerInfoPanel);
            this.Name = "OrderForm";
            this.Text = "Order Form";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel customerInfoPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label totalCostLabel;
        private System.Windows.Forms.TextBox totalBox;
        private System.Windows.Forms.TextBox discountBox;
        private System.Windows.Forms.TextBox baseCostBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox extraNotesTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox specialDoughBox;
        private System.Windows.Forms.TextBox extraToppingsBox;
        private System.Windows.Forms.TextBox pizzaTypeBox;
    }
}