
namespace EtsGitTools
{
    partial class InitializeConnectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitializeConnectionForm));
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.TokenLabel = new System.Windows.Forms.Label();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.TokenTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.CodigaTokenLabel = new System.Windows.Forms.Label();
            this.CodigaTokenTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(8, 7);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(77, 17);
            this.UsernameLabel.TabIndex = 0;
            this.UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(8, 63);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(73, 17);
            this.PasswordLabel.TabIndex = 0;
            this.PasswordLabel.Text = "Password:";
            // 
            // TokenLabel
            // 
            this.TokenLabel.AutoSize = true;
            this.TokenLabel.Location = new System.Drawing.Point(8, 118);
            this.TokenLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TokenLabel.Name = "TokenLabel";
            this.TokenLabel.Size = new System.Drawing.Size(52, 17);
            this.TokenLabel.TabIndex = 0;
            this.TokenLabel.Text = "Token:";
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(8, 31);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(369, 22);
            this.UsernameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(8, 86);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(369, 22);
            this.PasswordTextBox.TabIndex = 2;
            // 
            // TokenTextBox
            // 
            this.TokenTextBox.Location = new System.Drawing.Point(8, 139);
            this.TokenTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TokenTextBox.Name = "TokenTextBox";
            this.TokenTextBox.PasswordChar = '*';
            this.TokenTextBox.Size = new System.Drawing.Size(369, 22);
            this.TokenTextBox.TabIndex = 3;
            // 
            // LoginButton
            // 
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.LoginButton.Location = new System.Drawing.Point(49, 241);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(140, 28);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Location = new System.Drawing.Point(197, 241);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 28);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CodigaTokenLabel
            // 
            this.CodigaTokenLabel.Location = new System.Drawing.Point(8, 177);
            this.CodigaTokenLabel.Name = "CodigaTokenLabel";
            this.CodigaTokenLabel.Size = new System.Drawing.Size(97, 26);
            this.CodigaTokenLabel.TabIndex = 7;
            this.CodigaTokenLabel.Text = "Codiga Token\r\n";
            // 
            // CodigaTokenTextBox
            // 
            this.CodigaTokenTextBox.Location = new System.Drawing.Point(8, 203);
            this.CodigaTokenTextBox.Name = "CodigaTokenTextBox";
            this.CodigaTokenTextBox.PasswordChar = '*';
            this.CodigaTokenTextBox.Size = new System.Drawing.Size(368, 22);
            this.CodigaTokenTextBox.TabIndex = 8;
            // 
            // InitializeConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 292);
            this.Controls.Add(this.CodigaTokenTextBox);
            this.Controls.Add(this.CodigaTokenLabel);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.TokenTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.TokenLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InitializeConnectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connect to Github";
            this.Load += new System.EventHandler(this.InitializeConnectionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox CodigaTokenTextBox;

        private System.Windows.Forms.Label CodigaTokenLabel;

        #endregion

        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label TokenLabel;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox TokenTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Button ExitButton;
    }
}