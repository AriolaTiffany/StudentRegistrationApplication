namespace StudentRegistrationApplication
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
            this.label4 = new System.Windows.Forms.Label();
            this.LN = new System.Windows.Forms.Label();
            this.CBDay = new System.Windows.Forms.ComboBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.RBTNMale = new System.Windows.Forms.RadioButton();
            this.BTNRegister = new System.Windows.Forms.Button();
            this.FN = new System.Windows.Forms.Label();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.MN = new System.Windows.Forms.Label();
            this.TBMiddleName = new System.Windows.Forms.TextBox();
            this.GNDR = new System.Windows.Forms.Label();
            this.RBTNFemale = new System.Windows.Forms.RadioButton();
            this.DOB = new System.Windows.Forms.Label();
            this.CBMonth = new System.Windows.Forms.ComboBox();
            this.CBYear = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CBProgram = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bauhaus 93", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SteelBlue;
            this.label4.Location = new System.Drawing.Point(34, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(321, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Student Registration Form";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LN
            // 
            this.LN.AutoSize = true;
            this.LN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LN.ForeColor = System.Drawing.Color.DarkRed;
            this.LN.Location = new System.Drawing.Point(36, 74);
            this.LN.Name = "LN";
            this.LN.Size = new System.Drawing.Size(82, 15);
            this.LN.TabIndex = 1;
            this.LN.Text = "Last Name*";
            // 
            // CBDay
            // 
            this.CBDay.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBDay.FormattingEnabled = true;
            this.CBDay.Location = new System.Drawing.Point(39, 304);
            this.CBDay.Name = "CBDay";
            this.CBDay.Size = new System.Drawing.Size(58, 24);
            this.CBDay.TabIndex = 2;
            this.CBDay.Text = " Day ";
            // 
            // TBLastName
            // 
            this.TBLastName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLastName.Location = new System.Drawing.Point(39, 92);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(306, 22);
            this.TBLastName.TabIndex = 3;
            // 
            // RBTNMale
            // 
            this.RBTNMale.AutoSize = true;
            this.RBTNMale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNMale.Location = new System.Drawing.Point(39, 251);
            this.RBTNMale.Name = "RBTNMale";
            this.RBTNMale.Size = new System.Drawing.Size(53, 20);
            this.RBTNMale.TabIndex = 4;
            this.RBTNMale.TabStop = true;
            this.RBTNMale.Text = "Male";
            this.RBTNMale.UseVisualStyleBackColor = true;
            // 
            // BTNRegister
            // 
            this.BTNRegister.BackColor = System.Drawing.Color.Red;
            this.BTNRegister.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRegister.ForeColor = System.Drawing.Color.White;
            this.BTNRegister.Location = new System.Drawing.Point(39, 407);
            this.BTNRegister.Name = "BTNRegister";
            this.BTNRegister.Size = new System.Drawing.Size(150, 32);
            this.BTNRegister.TabIndex = 5;
            this.BTNRegister.Text = "Register Student";
            this.BTNRegister.UseVisualStyleBackColor = false;
            this.BTNRegister.Click += new System.EventHandler(this.BTNRegister_Click);
            // 
            // FN
            // 
            this.FN.AutoSize = true;
            this.FN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FN.ForeColor = System.Drawing.Color.DarkRed;
            this.FN.Location = new System.Drawing.Point(36, 126);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(84, 15);
            this.FN.TabIndex = 6;
            this.FN.Text = "First Name*";
            // 
            // TBFirstName
            // 
            this.TBFirstName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFirstName.Location = new System.Drawing.Point(39, 144);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(306, 22);
            this.TBFirstName.TabIndex = 7;
            // 
            // MN
            // 
            this.MN.AutoSize = true;
            this.MN.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MN.ForeColor = System.Drawing.Color.DarkRed;
            this.MN.Location = new System.Drawing.Point(36, 178);
            this.MN.Name = "MN";
            this.MN.Size = new System.Drawing.Size(97, 15);
            this.MN.TabIndex = 8;
            this.MN.Text = "Middle Name*";
            // 
            // TBMiddleName
            // 
            this.TBMiddleName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBMiddleName.Location = new System.Drawing.Point(39, 196);
            this.TBMiddleName.Name = "TBMiddleName";
            this.TBMiddleName.Size = new System.Drawing.Size(306, 22);
            this.TBMiddleName.TabIndex = 9;
            // 
            // GNDR
            // 
            this.GNDR.AutoSize = true;
            this.GNDR.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GNDR.ForeColor = System.Drawing.Color.DarkRed;
            this.GNDR.Location = new System.Drawing.Point(36, 233);
            this.GNDR.Name = "GNDR";
            this.GNDR.Size = new System.Drawing.Size(61, 15);
            this.GNDR.TabIndex = 10;
            this.GNDR.Text = "Gender*";
            // 
            // RBTNFemale
            // 
            this.RBTNFemale.AutoSize = true;
            this.RBTNFemale.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBTNFemale.Location = new System.Drawing.Point(109, 251);
            this.RBTNFemale.Name = "RBTNFemale";
            this.RBTNFemale.Size = new System.Drawing.Size(68, 20);
            this.RBTNFemale.TabIndex = 11;
            this.RBTNFemale.TabStop = true;
            this.RBTNFemale.Text = "Female";
            this.RBTNFemale.UseVisualStyleBackColor = true;
            // 
            // DOB
            // 
            this.DOB.AutoSize = true;
            this.DOB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DOB.ForeColor = System.Drawing.Color.DarkRed;
            this.DOB.Location = new System.Drawing.Point(36, 286);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(93, 15);
            this.DOB.TabIndex = 12;
            this.DOB.Text = "Date of birth*";
            // 
            // CBMonth
            // 
            this.CBMonth.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMonth.FormattingEnabled = true;
            this.CBMonth.Location = new System.Drawing.Point(103, 304);
            this.CBMonth.Name = "CBMonth";
            this.CBMonth.Size = new System.Drawing.Size(74, 24);
            this.CBMonth.TabIndex = 13;
            this.CBMonth.Text = " Month ";
            // 
            // CBYear
            // 
            this.CBYear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBYear.FormattingEnabled = true;
            this.CBYear.Location = new System.Drawing.Point(183, 304);
            this.CBYear.Name = "CBYear";
            this.CBYear.Size = new System.Drawing.Size(74, 24);
            this.CBYear.TabIndex = 14;
            this.CBYear.Text = " Year  ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(36, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Program to apply*";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CBProgram
            // 
            this.CBProgram.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBProgram.FormattingEnabled = true;
            this.CBProgram.Location = new System.Drawing.Point(39, 365);
            this.CBProgram.Name = "CBProgram";
            this.CBProgram.Size = new System.Drawing.Size(306, 24);
            this.CBProgram.TabIndex = 16;
            this.CBProgram.Text = " Select program";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.CBProgram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CBYear);
            this.Controls.Add(this.CBMonth);
            this.Controls.Add(this.DOB);
            this.Controls.Add(this.RBTNFemale);
            this.Controls.Add(this.GNDR);
            this.Controls.Add(this.TBMiddleName);
            this.Controls.Add(this.MN);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.BTNRegister);
            this.Controls.Add(this.RBTNMale);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.CBDay);
            this.Controls.Add(this.LN);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LastNameTB;
        private System.Windows.Forms.RadioButton MaleRBTN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.TextBox FirstNameTB;
        private System.Windows.Forms.Label middlename;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LN;
        private System.Windows.Forms.ComboBox CBDay;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.RadioButton RBTNMale;
        private System.Windows.Forms.Button BTNRegister;
        private System.Windows.Forms.Label FN;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.Label MN;
        private System.Windows.Forms.TextBox TBMiddleName;
        private System.Windows.Forms.Label GNDR;
        private System.Windows.Forms.RadioButton RBTNFemale;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.ComboBox CBMonth;
        private System.Windows.Forms.ComboBox CBYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBProgram;
    }
}

