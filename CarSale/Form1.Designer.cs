namespace CarSale
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxZip_City = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listBoxAvailableCars = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveFromTheCatalogue = new System.Windows.Forms.Button();
            this.btnEditACarInfo = new System.Windows.Forms.Button();
            this.btnAddToTheCatalogue = new System.Windows.Forms.Button();
            this.tbThePrice = new System.Windows.Forms.TextBox();
            this.tbTheYear = new System.Windows.Forms.TextBox();
            this.tbTheModel = new System.Windows.Forms.TextBox();
            this.tbTheBrand = new System.Windows.Forms.TextBox();
            this.listBoxCars = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSoldCars = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(803, 451);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::CarSale.Properties.Resources.car;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.textBoxZip_City);
            this.tabPage1.Controls.Add(this.textBoxAddress);
            this.tabPage1.Controls.Add(this.textBoxPhone);
            this.tabPage1.Controls.Add(this.textBoxName);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox5);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.listBoxAvailableCars);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cars for sale";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 278);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Zip/City:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Address:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(7, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name:";
            // 
            // textBoxZip_City
            // 
            this.textBoxZip_City.Location = new System.Drawing.Point(77, 275);
            this.textBoxZip_City.Name = "textBoxZip_City";
            this.textBoxZip_City.Size = new System.Drawing.Size(205, 27);
            this.textBoxZip_City.TabIndex = 10;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(77, 229);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(205, 27);
            this.textBoxAddress.TabIndex = 9;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(77, 184);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(205, 27);
            this.textBoxPhone.TabIndex = 8;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(77, 137);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(205, 27);
            this.textBoxName.TabIndex = 7;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(683, 339);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 54);
            this.button9.TabIndex = 6;
            this.button9.Text = "Clear Data";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(22, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fillter:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(77, 35);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(195, 27);
            this.textBox5.TabIndex = 3;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(435, 339);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(117, 54);
            this.button7.TabIndex = 2;
            this.button7.Text = "Show available cars";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(558, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 54);
            this.button6.TabIndex = 1;
            this.button6.Text = "Sell Car";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // listBoxAvailableCars
            // 
            this.listBoxAvailableCars.FormattingEnabled = true;
            this.listBoxAvailableCars.ItemHeight = 20;
            this.listBoxAvailableCars.Location = new System.Drawing.Point(435, 18);
            this.listBoxAvailableCars.Name = "listBoxAvailableCars";
            this.listBoxAvailableCars.Size = new System.Drawing.Size(348, 304);
            this.listBoxAvailableCars.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::CarSale.Properties.Resources.car;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnRemoveFromTheCatalogue);
            this.tabPage2.Controls.Add(this.btnEditACarInfo);
            this.tabPage2.Controls.Add(this.btnAddToTheCatalogue);
            this.tabPage2.Controls.Add(this.tbThePrice);
            this.tabPage2.Controls.Add(this.tbTheYear);
            this.tabPage2.Controls.Add(this.tbTheModel);
            this.tabPage2.Controls.Add(this.tbTheBrand);
            this.tabPage2.Controls.Add(this.listBoxCars);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit available cars";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(505, 333);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(172, 46);
            this.button10.TabIndex = 12;
            this.button10.Text = "Show Cars";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(23, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(23, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Brand:";
            // 
            // btnRemoveFromTheCatalogue
            // 
            this.btnRemoveFromTheCatalogue.Location = new System.Drawing.Point(271, 306);
            this.btnRemoveFromTheCatalogue.Name = "btnRemoveFromTheCatalogue";
            this.btnRemoveFromTheCatalogue.Size = new System.Drawing.Size(93, 56);
            this.btnRemoveFromTheCatalogue.TabIndex = 7;
            this.btnRemoveFromTheCatalogue.Text = "Remove";
            this.btnRemoveFromTheCatalogue.UseVisualStyleBackColor = true;
            this.btnRemoveFromTheCatalogue.Click += new System.EventHandler(this.btnRemoveFromTheCatalogue_Click);
            // 
            // btnEditACarInfo
            // 
            this.btnEditACarInfo.Location = new System.Drawing.Point(148, 306);
            this.btnEditACarInfo.Name = "btnEditACarInfo";
            this.btnEditACarInfo.Size = new System.Drawing.Size(93, 56);
            this.btnEditACarInfo.TabIndex = 6;
            this.btnEditACarInfo.Text = "Edit";
            this.btnEditACarInfo.UseVisualStyleBackColor = true;
            this.btnEditACarInfo.Click += new System.EventHandler(this.btnEditACarInfo_Click);
            // 
            // btnAddToTheCatalogue
            // 
            this.btnAddToTheCatalogue.Location = new System.Drawing.Point(23, 306);
            this.btnAddToTheCatalogue.Name = "btnAddToTheCatalogue";
            this.btnAddToTheCatalogue.Size = new System.Drawing.Size(93, 56);
            this.btnAddToTheCatalogue.TabIndex = 5;
            this.btnAddToTheCatalogue.Text = "Add";
            this.btnAddToTheCatalogue.UseVisualStyleBackColor = true;
            this.btnAddToTheCatalogue.Click += new System.EventHandler(this.btnAddToTheCatalogue_Click);
            // 
            // tbThePrice
            // 
            this.tbThePrice.Location = new System.Drawing.Point(96, 244);
            this.tbThePrice.Name = "tbThePrice";
            this.tbThePrice.Size = new System.Drawing.Size(199, 27);
            this.tbThePrice.TabIndex = 4;
            // 
            // tbTheYear
            // 
            this.tbTheYear.Location = new System.Drawing.Point(96, 202);
            this.tbTheYear.Name = "tbTheYear";
            this.tbTheYear.Size = new System.Drawing.Size(199, 27);
            this.tbTheYear.TabIndex = 3;
            // 
            // tbTheModel
            // 
            this.tbTheModel.Location = new System.Drawing.Point(96, 159);
            this.tbTheModel.Name = "tbTheModel";
            this.tbTheModel.Size = new System.Drawing.Size(199, 27);
            this.tbTheModel.TabIndex = 2;
            // 
            // tbTheBrand
            // 
            this.tbTheBrand.Location = new System.Drawing.Point(96, 113);
            this.tbTheBrand.Name = "tbTheBrand";
            this.tbTheBrand.Size = new System.Drawing.Size(199, 27);
            this.tbTheBrand.TabIndex = 1;
            // 
            // listBoxCars
            // 
            this.listBoxCars.FormattingEnabled = true;
            this.listBoxCars.ItemHeight = 20;
            this.listBoxCars.Location = new System.Drawing.Point(421, 87);
            this.listBoxCars.Name = "listBoxCars";
            this.listBoxCars.Size = new System.Drawing.Size(362, 224);
            this.listBoxCars.TabIndex = 0;
            this.listBoxCars.SelectedIndexChanged += new System.EventHandler(this.listBoxCars_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::CarSale.Properties.Resources.car;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.listBoxSoldCars);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Show sold cars";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Sold Cars \r\n(Data Base)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSoldCars
            // 
            this.listBoxSoldCars.FormattingEnabled = true;
            this.listBoxSoldCars.ItemHeight = 20;
            this.listBoxSoldCars.Location = new System.Drawing.Point(150, 50);
            this.listBoxSoldCars.Name = "listBoxSoldCars";
            this.listBoxSoldCars.Size = new System.Drawing.Size(528, 244);
            this.listBoxSoldCars.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 323);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(196, 63);
            this.button4.TabIndex = 0;
            this.button4.Text = "Show Sold cars";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnRemoveFromTheCatalogue;
        private Button btnEditACarInfo;
        private Button btnAddToTheCatalogue;
        private TextBox tbThePrice;
        private TextBox tbTheYear;
        private TextBox tbTheModel;
        private TextBox tbTheBrand;
        private ListBox listBoxCars;
        private ListBox listBoxSoldCars;
        private Button button4;
        private TextBox textBoxZip_City;
        private TextBox textBoxAddress;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private Button button9;
        private Label label5;
        private TextBox textBox5;
        private Button button7;
        private Button button6;
        private ListBox listBoxAvailableCars;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button button10;
        private Button button1;
    }
}