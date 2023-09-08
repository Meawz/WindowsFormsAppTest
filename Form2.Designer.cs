namespace WindowsFormsAppTest
{
    partial class Form2
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
            this.ButtonExitMenu = new System.Windows.Forms.Button();
            this.ButtonMenuCreeaza = new System.Windows.Forms.Button();
            this.ButtonBackMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonExitMenu
            // 
            this.ButtonExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonExitMenu.Location = new System.Drawing.Point(713, 415);
            this.ButtonExitMenu.Name = "ButtonExitMenu";
            this.ButtonExitMenu.Size = new System.Drawing.Size(75, 23);
            this.ButtonExitMenu.TabIndex = 0;
            this.ButtonExitMenu.Text = "Exit";
            this.ButtonExitMenu.UseVisualStyleBackColor = true;
            this.ButtonExitMenu.Click += new System.EventHandler(this.ButtonExitMenu_Click);
            // 
            // ButtonMenuCreeaza
            // 
            this.ButtonMenuCreeaza.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonMenuCreeaza.Location = new System.Drawing.Point(12, 12);
            this.ButtonMenuCreeaza.Name = "ButtonMenuCreeaza";
            this.ButtonMenuCreeaza.Size = new System.Drawing.Size(165, 53);
            this.ButtonMenuCreeaza.TabIndex = 1;
            this.ButtonMenuCreeaza.Text = "Creeaza un nou \r\ncontract\r\n";
            this.ButtonMenuCreeaza.UseVisualStyleBackColor = true;
            this.ButtonMenuCreeaza.Click += new System.EventHandler(this.ButtonMenuCreeaza_Click);
            // 
            // ButtonBackMenu
            // 
            this.ButtonBackMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtonBackMenu.Location = new System.Drawing.Point(12, 415);
            this.ButtonBackMenu.Name = "ButtonBackMenu";
            this.ButtonBackMenu.Size = new System.Drawing.Size(75, 23);
            this.ButtonBackMenu.TabIndex = 2;
            this.ButtonBackMenu.Text = "Back";
            this.ButtonBackMenu.UseVisualStyleBackColor = true;
            this.ButtonBackMenu.Click += new System.EventHandler(this.ButtonBackMenu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButtonBackMenu);
            this.Controls.Add(this.ButtonMenuCreeaza);
            this.Controls.Add(this.ButtonExitMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonExitMenu;
        private System.Windows.Forms.Button ButtonMenuCreeaza;
        private System.Windows.Forms.Button ButtonBackMenu;
    }
}