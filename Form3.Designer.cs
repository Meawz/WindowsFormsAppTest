namespace WindowsFormsAppTest
{
    partial class Form3
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
            this.ButtonExitCreate = new System.Windows.Forms.Button();
            this.ButtonBackCreate = new System.Windows.Forms.Button();
            this.LabelTitluContract = new System.Windows.Forms.Label();
            this.LabelBeneficiaryContract = new System.Windows.Forms.Label();
            this.LabelAdressContract = new System.Windows.Forms.Label();
            this.LabelCNPContract = new System.Windows.Forms.Label();
            this.TextBoxBeneficiary = new System.Windows.Forms.TextBox();
            this.TextBoxCNP = new System.Windows.Forms.TextBox();
            this.LabelRegisteredContract = new System.Windows.Forms.Label();
            this.dateTimePickerContract = new System.Windows.Forms.DateTimePicker();
            this.d = new System.Windows.Forms.TextBox();
            this.LabelNoContract = new System.Windows.Forms.Label();
            this.richTextBoxAdressContract = new System.Windows.Forms.RichTextBox();
            this.LabelIDCardContract = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelSeriesContract = new System.Windows.Forms.Label();
            this.TextBoxSeriesContract = new System.Windows.Forms.TextBox();
            this.TextBoxNoIDContract = new System.Windows.Forms.TextBox();
            this.LabelNoIDContract = new System.Windows.Forms.Label();
            this.LabelIssuedByContract = new System.Windows.Forms.Label();
            this.TextBoxIssuedContract = new System.Windows.Forms.TextBox();
            this.LabelIssuedOnContract = new System.Windows.Forms.Label();
            this.dateTimePickerIssuedOnContract = new System.Windows.Forms.DateTimePicker();
            this.ButtonRegisterContract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonExitCreate
            // 
            this.ButtonExitCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonExitCreate.Location = new System.Drawing.Point(858, 501);
            this.ButtonExitCreate.Name = "ButtonExitCreate";
            this.ButtonExitCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonExitCreate.TabIndex = 0;
            this.ButtonExitCreate.Text = "Exit";
            this.ButtonExitCreate.UseVisualStyleBackColor = true;
            this.ButtonExitCreate.Click += new System.EventHandler(this.ButtonExitCreeaza_Click);
            // 
            // ButtonBackCreate
            // 
            this.ButtonBackCreate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBackCreate.Location = new System.Drawing.Point(12, 501);
            this.ButtonBackCreate.Name = "ButtonBackCreate";
            this.ButtonBackCreate.Size = new System.Drawing.Size(75, 23);
            this.ButtonBackCreate.TabIndex = 1;
            this.ButtonBackCreate.Text = "Back";
            this.ButtonBackCreate.UseVisualStyleBackColor = true;
            this.ButtonBackCreate.Click += new System.EventHandler(this.ButtonBackCreate_Click);
            // 
            // LabelTitluContract
            // 
            this.LabelTitluContract.AutoSize = true;
            this.LabelTitluContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitluContract.Location = new System.Drawing.Point(265, 9);
            this.LabelTitluContract.Name = "LabelTitluContract";
            this.LabelTitluContract.Size = new System.Drawing.Size(376, 17);
            this.LabelTitluContract.TabIndex = 2;
            this.LabelTitluContract.Text = "CONTRACT DE PRESTĂRI SERVICII PSIHOLOGICE";
            this.LabelTitluContract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelBeneficiaryContract
            // 
            this.LabelBeneficiaryContract.AutoSize = true;
            this.LabelBeneficiaryContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBeneficiaryContract.Location = new System.Drawing.Point(41, 81);
            this.LabelBeneficiaryContract.Name = "LabelBeneficiaryContract";
            this.LabelBeneficiaryContract.Size = new System.Drawing.Size(74, 13);
            this.LabelBeneficiaryContract.TabIndex = 3;
            this.LabelBeneficiaryContract.Text = "Beneficiary:";
            // 
            // LabelAdressContract
            // 
            this.LabelAdressContract.AutoSize = true;
            this.LabelAdressContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAdressContract.Location = new System.Drawing.Point(66, 107);
            this.LabelAdressContract.Name = "LabelAdressContract";
            this.LabelAdressContract.Size = new System.Drawing.Size(49, 13);
            this.LabelAdressContract.TabIndex = 4;
            this.LabelAdressContract.Text = "Adress:";
            // 
            // LabelCNPContract
            // 
            this.LabelCNPContract.AutoSize = true;
            this.LabelCNPContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCNPContract.Location = new System.Drawing.Point(79, 184);
            this.LabelCNPContract.Name = "LabelCNPContract";
            this.LabelCNPContract.Size = new System.Drawing.Size(36, 13);
            this.LabelCNPContract.TabIndex = 5;
            this.LabelCNPContract.Text = "CNP:";
            // 
            // TextBoxBeneficiary
            // 
            this.TextBoxBeneficiary.Location = new System.Drawing.Point(127, 78);
            this.TextBoxBeneficiary.MaxLength = 255;
            this.TextBoxBeneficiary.Name = "TextBoxBeneficiary";
            this.TextBoxBeneficiary.Size = new System.Drawing.Size(157, 20);
            this.TextBoxBeneficiary.TabIndex = 6;
            // 
            // TextBoxCNP
            // 
            this.TextBoxCNP.Location = new System.Drawing.Point(127, 181);
            this.TextBoxCNP.MaxLength = 13;
            this.TextBoxCNP.Name = "TextBoxCNP";
            this.TextBoxCNP.Size = new System.Drawing.Size(157, 20);
            this.TextBoxCNP.TabIndex = 8;
            this.TextBoxCNP.TextChanged += new System.EventHandler(this.TextBoxCNP_TextChanged);
            this.TextBoxCNP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxCNP_KeyPress);
            // 
            // LabelRegisteredContract
            // 
            this.LabelRegisteredContract.AutoSize = true;
            this.LabelRegisteredContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRegisteredContract.Location = new System.Drawing.Point(28, 212);
            this.LabelRegisteredContract.Name = "LabelRegisteredContract";
            this.LabelRegisteredContract.Size = new System.Drawing.Size(87, 13);
            this.LabelRegisteredContract.TabIndex = 9;
            this.LabelRegisteredContract.Text = "Registered In:";
            // 
            // dateTimePickerContract
            // 
            this.dateTimePickerContract.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerContract.Location = new System.Drawing.Point(127, 206);
            this.dateTimePickerContract.MaxDate = new System.DateTime(2023, 9, 4, 0, 0, 0, 0);
            this.dateTimePickerContract.Name = "dateTimePickerContract";
            this.dateTimePickerContract.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerContract.TabIndex = 10;
            this.dateTimePickerContract.Value = new System.DateTime(2023, 9, 4, 0, 0, 0, 0);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(127, 232);
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(157, 20);
            this.d.TabIndex = 11;
            // 
            // LabelNoContract
            // 
            this.LabelNoContract.AutoSize = true;
            this.LabelNoContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNoContract.Location = new System.Drawing.Point(88, 235);
            this.LabelNoContract.Name = "LabelNoContract";
            this.LabelNoContract.Size = new System.Drawing.Size(27, 13);
            this.LabelNoContract.TabIndex = 12;
            this.LabelNoContract.Text = "No.";
            // 
            // richTextBoxAdressContract
            // 
            this.richTextBoxAdressContract.Location = new System.Drawing.Point(127, 104);
            this.richTextBoxAdressContract.Name = "richTextBoxAdressContract";
            this.richTextBoxAdressContract.Size = new System.Drawing.Size(157, 71);
            this.richTextBoxAdressContract.TabIndex = 13;
            this.richTextBoxAdressContract.Text = "";
            // 
            // LabelIDCardContract
            // 
            this.LabelIDCardContract.AutoSize = true;
            this.LabelIDCardContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIDCardContract.Location = new System.Drawing.Point(61, 261);
            this.LabelIDCardContract.Name = "LabelIDCardContract";
            this.LabelIDCardContract.Size = new System.Drawing.Size(54, 13);
            this.LabelIDCardContract.TabIndex = 14;
            this.LabelIDCardContract.Text = "ID Card:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(127, 258);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(157, 20);
            this.textBox1.TabIndex = 15;
            // 
            // LabelSeriesContract
            // 
            this.LabelSeriesContract.AutoSize = true;
            this.LabelSeriesContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSeriesContract.Location = new System.Drawing.Point(69, 287);
            this.LabelSeriesContract.Name = "LabelSeriesContract";
            this.LabelSeriesContract.Size = new System.Drawing.Size(46, 13);
            this.LabelSeriesContract.TabIndex = 16;
            this.LabelSeriesContract.Text = "Series:";
            // 
            // TextBoxSeriesContract
            // 
            this.TextBoxSeriesContract.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TextBoxSeriesContract.Location = new System.Drawing.Point(127, 284);
            this.TextBoxSeriesContract.MaxLength = 2;
            this.TextBoxSeriesContract.Name = "TextBoxSeriesContract";
            this.TextBoxSeriesContract.Size = new System.Drawing.Size(157, 20);
            this.TextBoxSeriesContract.TabIndex = 17;
            // 
            // TextBoxNoIDContract
            // 
            this.TextBoxNoIDContract.Location = new System.Drawing.Point(127, 310);
            this.TextBoxNoIDContract.MaxLength = 6;
            this.TextBoxNoIDContract.Name = "TextBoxNoIDContract";
            this.TextBoxNoIDContract.Size = new System.Drawing.Size(157, 20);
            this.TextBoxNoIDContract.TabIndex = 18;
            this.TextBoxNoIDContract.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNoIDContract_KeyPress);
            // 
            // LabelNoIDContract
            // 
            this.LabelNoIDContract.AutoSize = true;
            this.LabelNoIDContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNoIDContract.Location = new System.Drawing.Point(67, 313);
            this.LabelNoIDContract.Name = "LabelNoIDContract";
            this.LabelNoIDContract.Size = new System.Drawing.Size(48, 13);
            this.LabelNoIDContract.TabIndex = 19;
            this.LabelNoIDContract.Text = "No. ID:";
            // 
            // LabelIssuedByContract
            // 
            this.LabelIssuedByContract.AutoSize = true;
            this.LabelIssuedByContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIssuedByContract.Location = new System.Drawing.Point(50, 339);
            this.LabelIssuedByContract.Name = "LabelIssuedByContract";
            this.LabelIssuedByContract.Size = new System.Drawing.Size(65, 13);
            this.LabelIssuedByContract.TabIndex = 20;
            this.LabelIssuedByContract.Text = "Issued by:";
            // 
            // TextBoxIssuedContract
            // 
            this.TextBoxIssuedContract.Location = new System.Drawing.Point(127, 336);
            this.TextBoxIssuedContract.Name = "TextBoxIssuedContract";
            this.TextBoxIssuedContract.Size = new System.Drawing.Size(157, 20);
            this.TextBoxIssuedContract.TabIndex = 21;
            // 
            // LabelIssuedOnContract
            // 
            this.LabelIssuedOnContract.AutoSize = true;
            this.LabelIssuedOnContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelIssuedOnContract.Location = new System.Drawing.Point(49, 368);
            this.LabelIssuedOnContract.Name = "LabelIssuedOnContract";
            this.LabelIssuedOnContract.Size = new System.Drawing.Size(66, 13);
            this.LabelIssuedOnContract.TabIndex = 22;
            this.LabelIssuedOnContract.Text = "Issued on:";
            // 
            // dateTimePickerIssuedOnContract
            // 
            this.dateTimePickerIssuedOnContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerIssuedOnContract.Location = new System.Drawing.Point(127, 362);
            this.dateTimePickerIssuedOnContract.Name = "dateTimePickerIssuedOnContract";
            this.dateTimePickerIssuedOnContract.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerIssuedOnContract.TabIndex = 23;
            // 
            // ButtonRegisterContract
            // 
            this.ButtonRegisterContract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonRegisterContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonRegisterContract.Location = new System.Drawing.Point(440, 501);
            this.ButtonRegisterContract.Name = "ButtonRegisterContract";
            this.ButtonRegisterContract.Size = new System.Drawing.Size(75, 23);
            this.ButtonRegisterContract.TabIndex = 24;
            this.ButtonRegisterContract.Text = "Register";
            this.ButtonRegisterContract.UseVisualStyleBackColor = true;
            this.ButtonRegisterContract.Click += new System.EventHandler(this.ButtonRegisterContract_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 536);
            this.Controls.Add(this.ButtonRegisterContract);
            this.Controls.Add(this.dateTimePickerIssuedOnContract);
            this.Controls.Add(this.LabelIssuedOnContract);
            this.Controls.Add(this.TextBoxIssuedContract);
            this.Controls.Add(this.LabelIssuedByContract);
            this.Controls.Add(this.LabelNoIDContract);
            this.Controls.Add(this.TextBoxNoIDContract);
            this.Controls.Add(this.TextBoxSeriesContract);
            this.Controls.Add(this.LabelSeriesContract);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelIDCardContract);
            this.Controls.Add(this.richTextBoxAdressContract);
            this.Controls.Add(this.LabelNoContract);
            this.Controls.Add(this.d);
            this.Controls.Add(this.dateTimePickerContract);
            this.Controls.Add(this.LabelRegisteredContract);
            this.Controls.Add(this.TextBoxCNP);
            this.Controls.Add(this.TextBoxBeneficiary);
            this.Controls.Add(this.LabelCNPContract);
            this.Controls.Add(this.LabelAdressContract);
            this.Controls.Add(this.LabelBeneficiaryContract);
            this.Controls.Add(this.LabelTitluContract);
            this.Controls.Add(this.ButtonBackCreate);
            this.Controls.Add(this.ButtonExitCreate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form3";
            this.Text = "Creeaza Contract";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonExitCreate;
        private System.Windows.Forms.Button ButtonBackCreate;
        private System.Windows.Forms.Label LabelTitluContract;
        private System.Windows.Forms.Label LabelBeneficiaryContract;
        private System.Windows.Forms.Label LabelAdressContract;
        private System.Windows.Forms.Label LabelCNPContract;
        private System.Windows.Forms.TextBox TextBoxBeneficiary;
        private System.Windows.Forms.TextBox TextBoxCNP;
        private System.Windows.Forms.Label LabelRegisteredContract;
        private System.Windows.Forms.DateTimePicker dateTimePickerContract;
        private System.Windows.Forms.TextBox d;
        private System.Windows.Forms.Label LabelNoContract;
        private System.Windows.Forms.RichTextBox richTextBoxAdressContract;
        private System.Windows.Forms.Label LabelIDCardContract;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelSeriesContract;
        private System.Windows.Forms.TextBox TextBoxSeriesContract;
        private System.Windows.Forms.TextBox TextBoxNoIDContract;
        private System.Windows.Forms.Label LabelNoIDContract;
        private System.Windows.Forms.Label LabelIssuedByContract;
        private System.Windows.Forms.TextBox TextBoxIssuedContract;
        private System.Windows.Forms.Label LabelIssuedOnContract;
        private System.Windows.Forms.DateTimePicker dateTimePickerIssuedOnContract;
        private System.Windows.Forms.Button ButtonRegisterContract;
    }
}