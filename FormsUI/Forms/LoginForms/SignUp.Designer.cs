
namespace FormsUI.Forms.LoginForms
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.lblSignIn = new System.Windows.Forms.Label();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxPasswordRepeat = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblErrorMessage = new System.Windows.Forms.Label();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Controls.Add(this.btnMinimize);
            this.panelLogo.Controls.Add(this.btnClose);
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLogo.Location = new System.Drawing.Point(541, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(325, 536);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelLogo_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 24;
            this.btnMinimize.Location = new System.Drawing.Point(265, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 24;
            this.btnClose.Location = new System.Drawing.Point(293, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelTitle.Controls.Add(this.btnBack);
            this.panelTitle.Controls.Add(this.lblSignIn);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(541, 124);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnBack
            // 
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ChevronCircleLeft;
            this.btnBack.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 35;
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 35);
            this.btnBack.TabIndex = 2;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // lblSignIn
            // 
            this.lblSignIn.BackColor = System.Drawing.Color.Transparent;
            this.lblSignIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSignIn.Font = new System.Drawing.Font("Monotype Corsiva", 40F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSignIn.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSignIn.Location = new System.Drawing.Point(0, 0);
            this.lblSignIn.Name = "lblSignIn";
            this.lblSignIn.Size = new System.Drawing.Size(541, 124);
            this.lblSignIn.TabIndex = 1;
            this.lblSignIn.Text = "Sign up";
            this.lblSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSignIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSignIn_MouseDown);
            // 
            // tbxUserName
            // 
            this.tbxUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbxUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxUserName.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUserName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxUserName.Location = new System.Drawing.Point(51, 149);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(431, 36);
            this.tbxUserName.TabIndex = 3;
            this.tbxUserName.Text = "Username";
            this.tbxUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxUserName.Enter += new System.EventHandler(this.tbxUserName_Enter);
            this.tbxUserName.Leave += new System.EventHandler(this.tbxUserName_Leave);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPassword.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxPassword.Location = new System.Drawing.Point(51, 192);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(431, 36);
            this.tbxPassword.TabIndex = 4;
            this.tbxPassword.Text = "Password";
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.Enter += new System.EventHandler(this.tbxPassword_Enter);
            this.tbxPassword.Leave += new System.EventHandler(this.tbxPassword_Leave);
            // 
            // tbxPasswordRepeat
            // 
            this.tbxPasswordRepeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbxPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPasswordRepeat.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxPasswordRepeat.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxPasswordRepeat.Location = new System.Drawing.Point(51, 235);
            this.tbxPasswordRepeat.Name = "tbxPasswordRepeat";
            this.tbxPasswordRepeat.Size = new System.Drawing.Size(431, 36);
            this.tbxPasswordRepeat.TabIndex = 5;
            this.tbxPasswordRepeat.Text = "Password Repeat";
            this.tbxPasswordRepeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPasswordRepeat.Enter += new System.EventHandler(this.tbxPasswordRepeat_Enter);
            this.tbxPasswordRepeat.Leave += new System.EventHandler(this.tbxPasswordRepeat_Leave);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxFirstName.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxFirstName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxFirstName.Location = new System.Drawing.Point(51, 321);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(431, 36);
            this.tbxFirstName.TabIndex = 6;
            this.tbxFirstName.Text = "Firstname";
            this.tbxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxFirstName.Enter += new System.EventHandler(this.tbxFirstName_Enter);
            this.tbxFirstName.Leave += new System.EventHandler(this.tbxFirstName_Leave);
            // 
            // tbxLastName
            // 
            this.tbxLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxLastName.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxLastName.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxLastName.Location = new System.Drawing.Point(51, 364);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(431, 36);
            this.tbxLastName.TabIndex = 7;
            this.tbxLastName.Text = "Lastname";
            this.tbxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxLastName.Enter += new System.EventHandler(this.tbxLastName_Enter);
            this.tbxLastName.Leave += new System.EventHandler(this.tbxLastName_Leave);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEmail.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.tbxEmail.Location = new System.Drawing.Point(51, 278);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(431, 36);
            this.tbxEmail.TabIndex = 8;
            this.tbxEmail.Text = "Email";
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxEmail.Enter += new System.EventHandler(this.tbxEmail_Enter);
            this.tbxEmail.Leave += new System.EventHandler(this.tbxEmail_Leave);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSignUp.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSignUp.Location = new System.Drawing.Point(51, 463);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(431, 60);
            this.btnSignUp.TabIndex = 9;
            this.btnSignUp.Text = "Sign up";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblErrorMessage
            // 
            this.lblErrorMessage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblErrorMessage.Font = new System.Drawing.Font("Monotype Corsiva", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblErrorMessage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblErrorMessage.Image = ((System.Drawing.Image)(resources.GetObject("lblErrorMessage.Image")));
            this.lblErrorMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErrorMessage.Location = new System.Drawing.Point(120, 420);
            this.lblErrorMessage.Name = "lblErrorMessage";
            this.lblErrorMessage.Size = new System.Drawing.Size(310, 35);
            this.lblErrorMessage.TabIndex = 10;
            this.lblErrorMessage.Text = "Error Message";
            this.lblErrorMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblErrorMessage.Visible = false;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(866, 536);
            this.Controls.Add(this.lblErrorMessage);
            this.Controls.Add(this.btnSignUp);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxPasswordRepeat);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUserName);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(866, 536);
            this.Name = "SignUp";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignUp_FormClosed);
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblSignIn;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxPasswordRepeat;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblErrorMessage;
        private FontAwesome.Sharp.IconButton btnBack;
    }
}