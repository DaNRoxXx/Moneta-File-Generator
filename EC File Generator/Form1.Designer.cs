namespace EC_File_Generator
{
    partial class Form1
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
            this.Generate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.crn = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.bName = new System.Windows.Forms.TextBox();
            this.bAddress = new System.Windows.Forms.TextBox();
            this.cnic = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.tType = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.bank = new System.Windows.Forms.TextBox();
            this.rName = new System.Windows.Forms.TextBox();
            this.rAddress = new System.Windows.Forms.TextBox();
            this.rCity = new System.Windows.Forms.TextBox();
            this.ec = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.tNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.fNum = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.random = new System.Windows.Forms.CheckBox();
            this.error = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Generate.Location = new System.Drawing.Point(249, 463);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(109, 32);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "CRN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Transaction Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Transfer Amount:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Beneficairy Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Beneficairy Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Beneficariy CNIC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Beneficariy Mobile No.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Beneficairy City:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(352, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Transaction Type:";
            // 
            // crn
            // 
            this.crn.Location = new System.Drawing.Point(167, 128);
            this.crn.Name = "crn";
            this.crn.Size = new System.Drawing.Size(100, 20);
            this.crn.TabIndex = 11;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(167, 155);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(100, 20);
            this.date.TabIndex = 12;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(167, 182);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 13;
            // 
            // bName
            // 
            this.bName.Location = new System.Drawing.Point(167, 209);
            this.bName.Name = "bName";
            this.bName.Size = new System.Drawing.Size(100, 20);
            this.bName.TabIndex = 14;
            // 
            // bAddress
            // 
            this.bAddress.Location = new System.Drawing.Point(167, 236);
            this.bAddress.Name = "bAddress";
            this.bAddress.Size = new System.Drawing.Size(100, 20);
            this.bAddress.TabIndex = 15;
            // 
            // cnic
            // 
            this.cnic.Location = new System.Drawing.Point(167, 263);
            this.cnic.Name = "cnic";
            this.cnic.Size = new System.Drawing.Size(100, 20);
            this.cnic.TabIndex = 16;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(167, 290);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 20);
            this.number.TabIndex = 17;
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(463, 128);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(100, 20);
            this.city.TabIndex = 18;
            // 
            // tType
            // 
            this.tType.Location = new System.Drawing.Point(463, 155);
            this.tType.Name = "tType";
            this.tType.Size = new System.Drawing.Size(100, 20);
            this.tType.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Bank Name:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(352, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Remitter Name:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(352, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Remitter Address:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(352, 263);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Remitter City:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(352, 290);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 24;
            this.label14.Text = "EC Short Code:";
            // 
            // bank
            // 
            this.bank.Location = new System.Drawing.Point(463, 182);
            this.bank.Name = "bank";
            this.bank.Size = new System.Drawing.Size(100, 20);
            this.bank.TabIndex = 25;
            // 
            // rName
            // 
            this.rName.Location = new System.Drawing.Point(463, 209);
            this.rName.Name = "rName";
            this.rName.Size = new System.Drawing.Size(100, 20);
            this.rName.TabIndex = 26;
            // 
            // rAddress
            // 
            this.rAddress.Location = new System.Drawing.Point(463, 236);
            this.rAddress.Name = "rAddress";
            this.rAddress.Size = new System.Drawing.Size(100, 20);
            this.rAddress.TabIndex = 27;
            // 
            // rCity
            // 
            this.rCity.Location = new System.Drawing.Point(463, 263);
            this.rCity.Name = "rCity";
            this.rCity.Size = new System.Drawing.Size(100, 20);
            this.rCity.TabIndex = 28;
            // 
            // ec
            // 
            this.ec.Location = new System.Drawing.Point(463, 290);
            this.ec.Name = "ec";
            this.ec.Size = new System.Drawing.Size(100, 20);
            this.ec.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(158, 376);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(193, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "Number of Transactions Per File:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(158, 402);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "Number of Files:";
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(349, 347);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(100, 20);
            this.fName.TabIndex = 32;
            // 
            // tNum
            // 
            this.tNum.Location = new System.Drawing.Point(349, 373);
            this.tNum.Name = "tNum";
            this.tNum.Size = new System.Drawing.Size(100, 20);
            this.tNum.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(158, 350);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "File Name:";
            // 
            // fNum
            // 
            this.fNum.Location = new System.Drawing.Point(349, 399);
            this.fNum.Name = "fNum";
            this.fNum.Size = new System.Drawing.Size(100, 20);
            this.fNum.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::EC_File_Generator.Properties.Resources.TPS_Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(149, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // random
            // 
            this.random.AutoSize = true;
            this.random.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random.ForeColor = System.Drawing.Color.Red;
            this.random.Location = new System.Drawing.Point(259, 321);
            this.random.Name = "random";
            this.random.Size = new System.Drawing.Size(88, 17);
            this.random.TabIndex = 39;
            this.random.Text = "Randomize";
            this.random.UseVisualStyleBackColor = true;
            this.random.CheckedChanged += new System.EventHandler(this.Random_CheckedChanged);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(204, 437);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 13);
            this.error.TabIndex = 40;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 513);
            this.Controls.Add(this.error);
            this.Controls.Add(this.random);
            this.Controls.Add(this.fNum);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tNum);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.ec);
            this.Controls.Add(this.rCity);
            this.Controls.Add(this.rAddress);
            this.Controls.Add(this.rName);
            this.Controls.Add(this.bank);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tType);
            this.Controls.Add(this.city);
            this.Controls.Add(this.number);
            this.Controls.Add(this.cnic);
            this.Controls.Add(this.bAddress);
            this.Controls.Add(this.bName);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.date);
            this.Controls.Add(this.crn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Generate);
            this.Name = "Form1";
            this.Text = "EC File Generator - TPS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox crn;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.TextBox bName;
        private System.Windows.Forms.TextBox bAddress;
        private System.Windows.Forms.TextBox cnic;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox tType;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox bank;
        private System.Windows.Forms.TextBox rName;
        private System.Windows.Forms.TextBox rAddress;
        private System.Windows.Forms.TextBox rCity;
        private System.Windows.Forms.TextBox ec;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox tNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox fNum;
        private System.Windows.Forms.CheckBox random;
        private System.Windows.Forms.Label error;
    }
}

