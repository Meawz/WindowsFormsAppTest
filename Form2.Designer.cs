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
            this.buttonExitMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonExitMenu
            // 
            this.buttonExitMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonExitMenu.Location = new System.Drawing.Point(713, 415);
            this.buttonExitMenu.Name = "buttonExitMenu";
            this.buttonExitMenu.Size = new System.Drawing.Size(75, 23);
            this.buttonExitMenu.TabIndex = 0;
            this.buttonExitMenu.Text = "Exit";
            this.buttonExitMenu.UseVisualStyleBackColor = true;
            this.buttonExitMenu.Click += new System.EventHandler(this.ButtonExitMenu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExitMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonExitMenu;
    }
}