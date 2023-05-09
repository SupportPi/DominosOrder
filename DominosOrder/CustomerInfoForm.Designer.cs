namespace DominosOrder
{
    partial class CustomerInfoForm
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
            this.components = new System.ComponentModel.Container();
            this.stateCombobox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.zipcodeBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.aptNumberBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.streetAddressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.isOtherRadio = new System.Windows.Forms.RadioButton();
            this.isFemaleRadio = new System.Windows.Forms.RadioButton();
            this.isMaleRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.customerCombobox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.customersDataSet1 = new DominosOrder.customersDataSet();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERSTableAdapter = new DominosOrder.customersDataSetTableAdapters.CUSTOMERSTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // stateCombobox
            // 
            this.stateCombobox.FormattingEnabled = true;
            this.stateCombobox.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.stateCombobox.Location = new System.Drawing.Point(127, 331);
            this.stateCombobox.Name = "stateCombobox";
            this.stateCombobox.Size = new System.Drawing.Size(121, 21);
            this.stateCombobox.TabIndex = 45;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "State:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(127, 302);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 20);
            this.cityBox.TabIndex = 43;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(49, 305);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 42;
            this.cityLabel.Text = "City:";
            // 
            // zipcodeBox
            // 
            this.zipcodeBox.Location = new System.Drawing.Point(127, 274);
            this.zipcodeBox.Name = "zipcodeBox";
            this.zipcodeBox.Size = new System.Drawing.Size(121, 20);
            this.zipcodeBox.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Zip Code:";
            // 
            // aptNumberBox
            // 
            this.aptNumberBox.Location = new System.Drawing.Point(127, 248);
            this.aptNumberBox.Name = "aptNumberBox";
            this.aptNumberBox.Size = new System.Drawing.Size(121, 20);
            this.aptNumberBox.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Suite/Apt #:";
            // 
            // streetAddressBox
            // 
            this.streetAddressBox.Location = new System.Drawing.Point(127, 219);
            this.streetAddressBox.Name = "streetAddressBox";
            this.streetAddressBox.Size = new System.Drawing.Size(121, 20);
            this.streetAddressBox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Street Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "First Name:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(115, 80);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 33;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(115, 51);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 32;
            // 
            // isOtherRadio
            // 
            this.isOtherRadio.AutoSize = true;
            this.isOtherRadio.Location = new System.Drawing.Point(109, 177);
            this.isOtherRadio.Name = "isOtherRadio";
            this.isOtherRadio.Size = new System.Drawing.Size(51, 17);
            this.isOtherRadio.TabIndex = 31;
            this.isOtherRadio.TabStop = true;
            this.isOtherRadio.Text = "Other";
            this.isOtherRadio.UseVisualStyleBackColor = true;
            // 
            // isFemaleRadio
            // 
            this.isFemaleRadio.AutoSize = true;
            this.isFemaleRadio.Location = new System.Drawing.Point(109, 154);
            this.isFemaleRadio.Name = "isFemaleRadio";
            this.isFemaleRadio.Size = new System.Drawing.Size(59, 17);
            this.isFemaleRadio.TabIndex = 30;
            this.isFemaleRadio.TabStop = true;
            this.isFemaleRadio.Text = "Female";
            this.isFemaleRadio.UseVisualStyleBackColor = true;
            // 
            // isMaleRadio
            // 
            this.isMaleRadio.AutoSize = true;
            this.isMaleRadio.Location = new System.Drawing.Point(109, 131);
            this.isMaleRadio.Name = "isMaleRadio";
            this.isMaleRadio.Size = new System.Drawing.Size(48, 17);
            this.isMaleRadio.TabIndex = 29;
            this.isMaleRadio.TabStop = true;
            this.isMaleRadio.Text = "Male";
            this.isMaleRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Gender:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Customer:";
            // 
            // customerCombobox
            // 
            this.customerCombobox.DataSource = this.cUSTOMERSBindingSource;
            this.customerCombobox.FormattingEnabled = true;
            this.customerCombobox.Location = new System.Drawing.Point(115, 18);
            this.customerCombobox.Name = "customerCombobox";
            this.customerCombobox.Size = new System.Drawing.Size(100, 21);
            this.customerCombobox.TabIndex = 26;
            this.customerCombobox.SelectedIndexChanged += new System.EventHandler(this.customerCombobox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stateCombobox);
            this.panel1.Controls.Add(this.isFemaleRadio);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.customerCombobox);
            this.panel1.Controls.Add(this.cityBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cityLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.zipcodeBox);
            this.panel1.Controls.Add(this.isMaleRadio);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.isOtherRadio);
            this.panel1.Controls.Add(this.aptNumberBox);
            this.panel1.Controls.Add(this.firstnameTextBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lastnameTextBox);
            this.panel1.Controls.Add(this.streetAddressBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 360);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customersDataSet1
            // 
            this.customersDataSet1.DataSetName = "customersDataSet";
            this.customersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.customersDataSet1;
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 360);
            this.Controls.Add(this.panel1);
            this.Name = "CustomerInfoForm";
            this.Text = "CustomerInfoForm";
            this.Load += new System.EventHandler(this.CustomerInfoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox stateCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox zipcodeBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox aptNumberBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox streetAddressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.RadioButton isOtherRadio;
        private System.Windows.Forms.RadioButton isFemaleRadio;
        private System.Windows.Forms.RadioButton isMaleRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox customerCombobox;
        private System.Windows.Forms.Panel panel1;
        private customersDataSet customersDataSet1;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private customersDataSetTableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
    }
}