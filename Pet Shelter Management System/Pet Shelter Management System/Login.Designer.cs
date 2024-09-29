namespace Pet_Shelter_Management_System
{
    partial class Login
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.txtLoginID = new MetroFramework.Controls.MetroTextBox();
            this.txtLoginPassword = new MetroFramework.Controls.MetroTextBox();
            this.lblPassword = new MetroFramework.Controls.MetroLabel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSignIn = new MetroFramework.Controls.MetroButton();
            this.lblID = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.txtLoginID);
            this.metroPanel1.Controls.Add(this.txtLoginPassword);
            this.metroPanel1.Controls.Add(this.lblPassword);
            this.metroPanel1.Controls.Add(this.btnClear);
            this.metroPanel1.Controls.Add(this.btnSignIn);
            this.metroPanel1.Controls.Add(this.lblID);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 12;
            this.metroPanel1.Location = new System.Drawing.Point(31, 28);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(404, 444);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 13;
            this.metroPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel1_Paint);
            // 
            // txtLoginID
            // 
            // 
            // 
            // 
            this.txtLoginID.CustomButton.Image = null;
            this.txtLoginID.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtLoginID.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginID.CustomButton.Name = "";
            this.txtLoginID.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLoginID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginID.CustomButton.TabIndex = 1;
            this.txtLoginID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginID.CustomButton.UseSelectable = true;
            this.txtLoginID.CustomButton.Visible = false;
            this.txtLoginID.Lines = new string[0];
            this.txtLoginID.Location = new System.Drawing.Point(167, 145);
            this.txtLoginID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginID.MaxLength = 32767;
            this.txtLoginID.Name = "txtLoginID";
            this.txtLoginID.PasswordChar = '\0';
            this.txtLoginID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginID.SelectedText = "";
            this.txtLoginID.SelectionLength = 0;
            this.txtLoginID.SelectionStart = 0;
            this.txtLoginID.ShortcutsEnabled = true;
            this.txtLoginID.Size = new System.Drawing.Size(197, 28);
            this.txtLoginID.TabIndex = 9;
            this.txtLoginID.UseSelectable = true;
            this.txtLoginID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoginID.Click += new System.EventHandler(this.txtLoginID_Leave);
            // 
            // txtLoginPassword
            // 
            // 
            // 
            // 
            this.txtLoginPassword.CustomButton.Image = null;
            this.txtLoginPassword.CustomButton.Location = new System.Drawing.Point(171, 2);
            this.txtLoginPassword.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPassword.CustomButton.Name = "";
            this.txtLoginPassword.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txtLoginPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLoginPassword.CustomButton.TabIndex = 1;
            this.txtLoginPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLoginPassword.CustomButton.UseSelectable = true;
            this.txtLoginPassword.CustomButton.Visible = false;
            this.txtLoginPassword.Lines = new string[0];
            this.txtLoginPassword.Location = new System.Drawing.Point(167, 181);
            this.txtLoginPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoginPassword.MaxLength = 32767;
            this.txtLoginPassword.Name = "txtLoginPassword";
            this.txtLoginPassword.PasswordChar = '●';
            this.txtLoginPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLoginPassword.SelectedText = "";
            this.txtLoginPassword.SelectionLength = 0;
            this.txtLoginPassword.SelectionStart = 0;
            this.txtLoginPassword.ShortcutsEnabled = true;
            this.txtLoginPassword.Size = new System.Drawing.Size(197, 28);
            this.txtLoginPassword.TabIndex = 8;
            this.txtLoginPassword.UseSelectable = true;
            this.txtLoginPassword.UseSystemPasswordChar = true;
            this.txtLoginPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLoginPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLoginPassword.Click += new System.EventHandler(this.txtLoginPassword_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(48, 186);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(307, 404);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(167, 240);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(71, 28);
            this.btnSignIn.TabIndex = 7;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseSelectable = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 145);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 20);
            this.lblID.TabIndex = 3;
            this.lblID.Text = " ID";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(167, 14);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "LOGIN";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 501);
            this.Controls.Add(this.metroPanel1);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(27, 37, 27, 25);
            this.Text = "Login";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox txtLoginID;
        private MetroFramework.Controls.MetroTextBox txtLoginPassword;
        private MetroFramework.Controls.MetroLabel lblPassword;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSignIn;
        private MetroFramework.Controls.MetroLabel lblID;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}