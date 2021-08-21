
namespace FormsUI.Forms.UserForms.Claims.Both
{
    partial class ClaimForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClaimForm));
            this.btnBothDgw = new System.Windows.Forms.Button();
            this.btnSubsidiariesDgw = new System.Windows.Forms.Button();
            this.btnMainDgw = new System.Windows.Forms.Button();
            this.dgwClaims = new System.Windows.Forms.DataGridView();
            this.btnReload = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgwClaims)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBothDgw
            // 
            this.btnBothDgw.FlatAppearance.BorderSize = 0;
            this.btnBothDgw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnBothDgw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnBothDgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBothDgw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBothDgw.Location = new System.Drawing.Point(270, 12);
            this.btnBothDgw.MinimumSize = new System.Drawing.Size(50, 40);
            this.btnBothDgw.Name = "btnBothDgw";
            this.btnBothDgw.Size = new System.Drawing.Size(100, 40);
            this.btnBothDgw.TabIndex = 25;
            this.btnBothDgw.Text = "Both";
            this.btnBothDgw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBothDgw.UseVisualStyleBackColor = true;
            this.btnBothDgw.Click += new System.EventHandler(this.btnBothDgw_Click);
            // 
            // btnSubsidiariesDgw
            // 
            this.btnSubsidiariesDgw.FlatAppearance.BorderSize = 0;
            this.btnSubsidiariesDgw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnSubsidiariesDgw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnSubsidiariesDgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubsidiariesDgw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSubsidiariesDgw.Location = new System.Drawing.Point(144, 12);
            this.btnSubsidiariesDgw.MinimumSize = new System.Drawing.Size(50, 40);
            this.btnSubsidiariesDgw.Name = "btnSubsidiariesDgw";
            this.btnSubsidiariesDgw.Size = new System.Drawing.Size(120, 40);
            this.btnSubsidiariesDgw.TabIndex = 24;
            this.btnSubsidiariesDgw.Text = "Subsidiaries";
            this.btnSubsidiariesDgw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubsidiariesDgw.UseVisualStyleBackColor = true;
            this.btnSubsidiariesDgw.Click += new System.EventHandler(this.btnSubsidiariesDgw_Click);
            // 
            // btnMainDgw
            // 
            this.btnMainDgw.FlatAppearance.BorderSize = 0;
            this.btnMainDgw.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnMainDgw.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnMainDgw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMainDgw.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMainDgw.Location = new System.Drawing.Point(38, 12);
            this.btnMainDgw.MinimumSize = new System.Drawing.Size(50, 40);
            this.btnMainDgw.Name = "btnMainDgw";
            this.btnMainDgw.Size = new System.Drawing.Size(100, 40);
            this.btnMainDgw.TabIndex = 23;
            this.btnMainDgw.Text = "Main";
            this.btnMainDgw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMainDgw.UseVisualStyleBackColor = true;
            this.btnMainDgw.Click += new System.EventHandler(this.btnMainDgw_Click);
            // 
            // dgwClaims
            // 
            this.dgwClaims.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwClaims.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwClaims.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwClaims.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwClaims.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwClaims.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgwClaims.Location = new System.Drawing.Point(29, 58);
            this.dgwClaims.Name = "dgwClaims";
            this.dgwClaims.ReadOnly = true;
            this.dgwClaims.RowHeadersWidth = 51;
            this.dgwClaims.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgwClaims.RowTemplate.Height = 40;
            this.dgwClaims.Size = new System.Drawing.Size(470, 466);
            this.dgwClaims.TabIndex = 21;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnReload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReload.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            this.btnReload.IconColor = System.Drawing.Color.Gainsboro;
            this.btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReload.IconSize = 32;
            this.btnReload.Location = new System.Drawing.Point(506, 476);
            this.btnReload.MinimumSize = new System.Drawing.Size(97, 48);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(133, 48);
            this.btnReload.TabIndex = 22;
            this.btnReload.Text = "Reload";
            this.btnReload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // ClaimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(669, 536);
            this.Controls.Add(this.btnBothDgw);
            this.Controls.Add(this.btnSubsidiariesDgw);
            this.Controls.Add(this.btnMainDgw);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgwClaims);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(669, 536);
            this.Name = "ClaimForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClaimForm";
            this.Load += new System.EventHandler(this.ClaimForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwClaims)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBothDgw;
        private System.Windows.Forms.Button btnSubsidiariesDgw;
        private System.Windows.Forms.Button btnMainDgw;
        private FontAwesome.Sharp.IconButton btnReload;
        private System.Windows.Forms.DataGridView dgwClaims;
    }
}