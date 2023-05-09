namespace DominosOrder
{
    partial class SavedCustomersForm
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
            this.customerCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.isMaleRadio = new System.Windows.Forms.RadioButton();
            this.isFemaleRadio = new System.Windows.Forms.RadioButton();
            this.isOtherRadio = new System.Windows.Forms.RadioButton();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.streetAddressBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.aptNumberBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zipcodeBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.stateCombobox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.removeCustomerButton = new System.Windows.Forms.Button();
            this.cUSTOMERSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataSet = new DominosOrder.customersDataSet();
            this.cUSTOMERSTableAdapter = new DominosOrder.customersDataSetTableAdapters.CUSTOMERSTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iNTERNALIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIRSTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lASTNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gENDERDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sTREETADDRESSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aPTSUITEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zIPCODEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSSTATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerCombobox
            // 
            this.customerCombobox.FormattingEnabled = true;
            this.customerCombobox.Location = new System.Drawing.Point(84, 62);
            this.customerCombobox.Name = "customerCombobox";
            this.customerCombobox.Size = new System.Drawing.Size(100, 21);
            this.customerCombobox.TabIndex = 0;
            this.customerCombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gender:";
            // 
            // isMaleRadio
            // 
            this.isMaleRadio.AutoSize = true;
            this.isMaleRadio.Location = new System.Drawing.Point(78, 175);
            this.isMaleRadio.Name = "isMaleRadio";
            this.isMaleRadio.Size = new System.Drawing.Size(48, 17);
            this.isMaleRadio.TabIndex = 4;
            this.isMaleRadio.TabStop = true;
            this.isMaleRadio.Text = "Male";
            this.isMaleRadio.UseVisualStyleBackColor = true;
            this.isMaleRadio.CheckedChanged += new System.EventHandler(this.isMaleRadio_CheckedChanged);
            // 
            // isFemaleRadio
            // 
            this.isFemaleRadio.AutoSize = true;
            this.isFemaleRadio.Location = new System.Drawing.Point(78, 198);
            this.isFemaleRadio.Name = "isFemaleRadio";
            this.isFemaleRadio.Size = new System.Drawing.Size(59, 17);
            this.isFemaleRadio.TabIndex = 5;
            this.isFemaleRadio.TabStop = true;
            this.isFemaleRadio.Text = "Female";
            this.isFemaleRadio.UseVisualStyleBackColor = true;
            // 
            // isOtherRadio
            // 
            this.isOtherRadio.AutoSize = true;
            this.isOtherRadio.Location = new System.Drawing.Point(78, 221);
            this.isOtherRadio.Name = "isOtherRadio";
            this.isOtherRadio.Size = new System.Drawing.Size(51, 17);
            this.isOtherRadio.TabIndex = 6;
            this.isOtherRadio.TabStop = true;
            this.isOtherRadio.Text = "Other";
            this.isOtherRadio.UseVisualStyleBackColor = true;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(84, 95);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnameTextBox.TabIndex = 8;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(84, 124);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastnameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "First Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Street Address:";
            // 
            // streetAddressBox
            // 
            this.streetAddressBox.Location = new System.Drawing.Point(96, 263);
            this.streetAddressBox.Name = "streetAddressBox";
            this.streetAddressBox.Size = new System.Drawing.Size(121, 20);
            this.streetAddressBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Suite/Apt #:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // aptNumberBox
            // 
            this.aptNumberBox.Location = new System.Drawing.Point(96, 292);
            this.aptNumberBox.Name = "aptNumberBox";
            this.aptNumberBox.Size = new System.Drawing.Size(121, 20);
            this.aptNumberBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 321);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Zip Code:";
            // 
            // zipcodeBox
            // 
            this.zipcodeBox.Location = new System.Drawing.Point(96, 318);
            this.zipcodeBox.Name = "zipcodeBox";
            this.zipcodeBox.Size = new System.Drawing.Size(121, 20);
            this.zipcodeBox.TabIndex = 17;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(18, 349);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 18;
            this.cityLabel.Text = "City:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(96, 346);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(121, 20);
            this.cityBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 378);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "State:";
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
            this.stateCombobox.Location = new System.Drawing.Point(96, 375);
            this.stateCombobox.Name = "stateCombobox";
            this.stateCombobox.Size = new System.Drawing.Size(121, 21);
            this.stateCombobox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Saved Customer Information";
            // 
            // removeCustomerButton
            // 
            this.removeCustomerButton.Location = new System.Drawing.Point(20, 415);
            this.removeCustomerButton.Name = "removeCustomerButton";
            this.removeCustomerButton.Size = new System.Drawing.Size(197, 23);
            this.removeCustomerButton.TabIndex = 25;
            this.removeCustomerButton.Text = "Delete";
            this.removeCustomerButton.UseVisualStyleBackColor = true;
            this.removeCustomerButton.Click += new System.EventHandler(this.removeCustomerButton_Click);
            // 
            // cUSTOMERSBindingSource
            // 
            this.cUSTOMERSBindingSource.DataMember = "CUSTOMERS";
            this.cUSTOMERSBindingSource.DataSource = this.customersDataSet;
            // 
            // customersDataSet
            // 
            this.customersDataSet.DataSetName = "customersDataSet";
            this.customersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERSTableAdapter
            // 
            this.cUSTOMERSTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.iNTERNALIDDataGridViewTextBoxColumn,
            this.fIRSTNAMEDataGridViewTextBoxColumn,
            this.lASTNAMEDataGridViewTextBoxColumn,
            this.gENDERDataGridViewTextBoxColumn,
            this.sTREETADDRESSDataGridViewTextBoxColumn,
            this.aPTSUITEDataGridViewTextBoxColumn,
            this.zIPCODEDataGridViewTextBoxColumn,
            this.cITYDataGridViewTextBoxColumn,
            this.uSSTATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cUSTOMERSBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(333, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(372, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iNTERNALIDDataGridViewTextBoxColumn
            // 
            this.iNTERNALIDDataGridViewTextBoxColumn.DataPropertyName = "INTERNAL_ID";
            this.iNTERNALIDDataGridViewTextBoxColumn.HeaderText = "INTERNAL_ID";
            this.iNTERNALIDDataGridViewTextBoxColumn.Name = "iNTERNALIDDataGridViewTextBoxColumn";
            this.iNTERNALIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fIRSTNAMEDataGridViewTextBoxColumn
            // 
            this.fIRSTNAMEDataGridViewTextBoxColumn.DataPropertyName = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.HeaderText = "FIRST_NAME";
            this.fIRSTNAMEDataGridViewTextBoxColumn.Name = "fIRSTNAMEDataGridViewTextBoxColumn";
            this.fIRSTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lASTNAMEDataGridViewTextBoxColumn
            // 
            this.lASTNAMEDataGridViewTextBoxColumn.DataPropertyName = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.HeaderText = "LAST_NAME";
            this.lASTNAMEDataGridViewTextBoxColumn.Name = "lASTNAMEDataGridViewTextBoxColumn";
            this.lASTNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gENDERDataGridViewTextBoxColumn
            // 
            this.gENDERDataGridViewTextBoxColumn.DataPropertyName = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.HeaderText = "GENDER";
            this.gENDERDataGridViewTextBoxColumn.Name = "gENDERDataGridViewTextBoxColumn";
            this.gENDERDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sTREETADDRESSDataGridViewTextBoxColumn
            // 
            this.sTREETADDRESSDataGridViewTextBoxColumn.DataPropertyName = "STREET_ADDRESS";
            this.sTREETADDRESSDataGridViewTextBoxColumn.HeaderText = "STREET_ADDRESS";
            this.sTREETADDRESSDataGridViewTextBoxColumn.Name = "sTREETADDRESSDataGridViewTextBoxColumn";
            this.sTREETADDRESSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aPTSUITEDataGridViewTextBoxColumn
            // 
            this.aPTSUITEDataGridViewTextBoxColumn.DataPropertyName = "APT_SUITE";
            this.aPTSUITEDataGridViewTextBoxColumn.HeaderText = "APT_SUITE";
            this.aPTSUITEDataGridViewTextBoxColumn.Name = "aPTSUITEDataGridViewTextBoxColumn";
            this.aPTSUITEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // zIPCODEDataGridViewTextBoxColumn
            // 
            this.zIPCODEDataGridViewTextBoxColumn.DataPropertyName = "ZIP_CODE";
            this.zIPCODEDataGridViewTextBoxColumn.HeaderText = "ZIP_CODE";
            this.zIPCODEDataGridViewTextBoxColumn.Name = "zIPCODEDataGridViewTextBoxColumn";
            this.zIPCODEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cITYDataGridViewTextBoxColumn
            // 
            this.cITYDataGridViewTextBoxColumn.DataPropertyName = "CITY";
            this.cITYDataGridViewTextBoxColumn.HeaderText = "CITY";
            this.cITYDataGridViewTextBoxColumn.Name = "cITYDataGridViewTextBoxColumn";
            this.cITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // uSSTATEDataGridViewTextBoxColumn
            // 
            this.uSSTATEDataGridViewTextBoxColumn.DataPropertyName = "US_STATE";
            this.uSSTATEDataGridViewTextBoxColumn.HeaderText = "US_STATE";
            this.uSSTATEDataGridViewTextBoxColumn.Name = "uSSTATEDataGridViewTextBoxColumn";
            this.uSSTATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SavedCustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.removeCustomerButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.stateCombobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.zipcodeBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.aptNumberBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.streetAddressBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.isOtherRadio);
            this.Controls.Add(this.isFemaleRadio);
            this.Controls.Add(this.isMaleRadio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerCombobox);
            this.Name = "SavedCustomersForm";
            this.Text = "SavedCustomersForm";
            this.Load += new System.EventHandler(this.SavedCustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton isMaleRadio;
        private System.Windows.Forms.RadioButton isFemaleRadio;
        private System.Windows.Forms.RadioButton isOtherRadio;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox streetAddressBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox aptNumberBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zipcodeBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox stateCombobox;
        private System.Windows.Forms.Label label9;
        private customersDataSet customersDataSet;
        private customersDataSetTableAdapters.CUSTOMERSTableAdapter cUSTOMERSTableAdapter;
        private System.Windows.Forms.BindingSource cUSTOMERSBindingSource;
        private System.Windows.Forms.Button removeCustomerButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iNTERNALIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIRSTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lASTNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gENDERDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTREETADDRESSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aPTSUITEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn zIPCODEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSSTATEDataGridViewTextBoxColumn;
    }
}