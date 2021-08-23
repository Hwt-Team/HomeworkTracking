
namespace FormsUI.Forms.UserForms.UserClaims
{
    partial class Add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.tbxClaimId = new System.Windows.Forms.TextBox();
            this.tbxUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblClaimId = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.panelUserClaimAdd = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panelUserClaimAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxClaimId
            // 
            this.tbxClaimId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxClaimId.Location = new System.Drawing.Point(174, 110);
            this.tbxClaimId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxClaimId.Name = "tbxClaimId";
            this.tbxClaimId.Size = new System.Drawing.Size(114, 27);
            this.tbxClaimId.TabIndex = 15;
            // 
            // tbxUserId
            // 
            this.tbxUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxUserId.Location = new System.Drawing.Point(174, 55);
            this.tbxUserId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxUserId.Name = "tbxUserId";
            this.tbxUserId.Size = new System.Drawing.Size(114, 27);
            this.tbxUserId.TabIndex = 14;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUserId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblUserId.Location = new System.Drawing.Point(41, 58);
            this.lblUserId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(67, 22);
            this.lblUserId.TabIndex = 13;
            this.lblUserId.Text = "User id";
            // 
            // lblClaimId
            // 
            this.lblClaimId.AutoSize = true;
            this.lblClaimId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClaimId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblClaimId.Location = new System.Drawing.Point(41, 112);
            this.lblClaimId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaimId.Name = "lblClaimId";
            this.lblClaimId.Size = new System.Drawing.Size(74, 22);
            this.lblClaimId.TabIndex = 12;
            this.lblClaimId.Text = "Claim id";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(242, 171);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 38);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnOk.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOk.Location = new System.Drawing.Point(135, 171);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(80, 38);
            this.btnOk.TabIndex = 10;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // panelUserClaimAdd
            // 
            this.panelUserClaimAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelUserClaimAdd.Controls.Add(this.label);
            this.panelUserClaimAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserClaimAdd.Location = new System.Drawing.Point(0, 0);
            this.panelUserClaimAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelUserClaimAdd.Name = "panelUserClaimAdd";
            this.panelUserClaimAdd.Size = new System.Drawing.Size(356, 34);
            this.panelUserClaimAdd.TabIndex = 37;
            this.panelUserClaimAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelUserClaimAdd_MouseDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.ForeColor = System.Drawing.Color.Gainsboro;
            this.label.Location = new System.Drawing.Point(11, 9);
            this.label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(38, 18);
            this.label.TabIndex = 25;
            this.label.Text = "label";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(356, 237);
            this.Controls.Add(this.panelUserClaimAdd);
            this.Controls.Add(this.tbxClaimId);
            this.Controls.Add(this.tbxUserId);
            this.Controls.Add(this.lblUserId);
            this.Controls.Add(this.lblClaimId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(356, 237);
            this.Name = "Add";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Add_Load);
            this.panelUserClaimAdd.ResumeLayout(false);
            this.panelUserClaimAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxClaimId;
        private System.Windows.Forms.TextBox tbxUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblClaimId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Panel panelUserClaimAdd;
        private System.Windows.Forms.Label label;
    }
}