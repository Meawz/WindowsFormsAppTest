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
            this.TextBoxAdress = new System.Windows.Forms.TextBox();
            this.TextBoxCNP = new System.Windows.Forms.TextBox();
            this.LabelRegisteredContract = new System.Windows.Forms.Label();
            this.dateTimePickerContract = new System.Windows.Forms.DateTimePicker();
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
            this.LabelBeneficiaryContract.Location = new System.Drawing.Point(22, 88);
            this.LabelBeneficiaryContract.Name = "LabelBeneficiaryContract";
            this.LabelBeneficiaryContract.Size = new System.Drawing.Size(74, 13);
            this.LabelBeneficiaryContract.TabIndex = 3;
            this.LabelBeneficiaryContract.Text = "Beneficiary:";
            // 
            // LabelAdressContract
            // 
            this.LabelAdressContract.AutoSize = true;
            this.LabelAdressContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelAdressContract.Location = new System.Drawing.Point(47, 119);
            this.LabelAdressContract.Name = "LabelAdressContract";
            this.LabelAdressContract.Size = new System.Drawing.Size(49, 13);
            this.LabelAdressContract.TabIndex = 4;
            this.LabelAdressContract.Text = "Adress:";
            // 
            // LabelCNPContract
            // 
            this.LabelCNPContract.AutoSize = true;
            this.LabelCNPContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCNPContract.Location = new System.Drawing.Point(60, 145);
            this.LabelCNPContract.Name = "LabelCNPContract";
            this.LabelCNPContract.Size = new System.Drawing.Size(36, 13);
            this.LabelCNPContract.TabIndex = 5;
            this.LabelCNPContract.Text = "CNP:";
            // 
            // TextBoxBeneficiary
            // 
            this.TextBoxBeneficiary.Location = new System.Drawing.Point(106, 85);
            this.TextBoxBeneficiary.Name = "TextBoxBeneficiary";
            this.TextBoxBeneficiary.Size = new System.Drawing.Size(157, 20);
            this.TextBoxBeneficiary.TabIndex = 6;
            // 
            // TextBoxAdress
            // 
            this.TextBoxAdress.Location = new System.Drawing.Point(106, 116);
            this.TextBoxAdress.Name = "TextBoxAdress";
            this.TextBoxAdress.Size = new System.Drawing.Size(157, 20);
            this.TextBoxAdress.TabIndex = 7;
            // 
            // TextBoxCNP
            // 
            this.TextBoxCNP.Location = new System.Drawing.Point(106, 142);
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
            this.LabelRegisteredContract.Location = new System.Drawing.Point(9, 177);
            this.LabelRegisteredContract.Name = "LabelRegisteredContract";
            this.LabelRegisteredContract.Size = new System.Drawing.Size(87, 13);
            this.LabelRegisteredContract.TabIndex = 9;
            this.LabelRegisteredContract.Text = "Registered In:";
            // 
            // dateTimePickerContract
            // 
            this.dateTimePickerContract.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerContract.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerContract.Location = new System.Drawing.Point(106, 171);
            this.dateTimePickerContract.Name = "dateTimePickerContract";
            this.dateTimePickerContract.Size = new System.Drawing.Size(98, 20);
            this.dateTimePickerContract.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 536);
            this.Controls.Add(this.dateTimePickerContract);
            this.Controls.Add(this.LabelRegisteredContract);
            this.Controls.Add(this.TextBoxCNP);
            this.Controls.Add(this.TextBoxAdress);
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
        private System.Windows.Forms.TextBox TextBoxAdress;
        private System.Windows.Forms.TextBox TextBoxCNP;
        private System.Windows.Forms.Label LabelRegisteredContract;
        private System.Windows.Forms.DateTimePicker dateTimePickerContract;
    }
}