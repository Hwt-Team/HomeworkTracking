
namespace FormsUI.Forms.UserForms.ProjectObjects
{
    partial class Update
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.tbxClassName = new System.Windows.Forms.TextBox();
            this.tbxObjectName = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.lblObjectName = new System.Windows.Forms.Label();
            this.tbxNamespace = new System.Windows.Forms.TextBox();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.panelProjectObjectUpdate = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.panelProjectObjectUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(75)))), ((int)(((byte)(165)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(225, 177);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 35;
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
            this.btnOk.Location = new System.Drawing.Point(121, 177);
            this.btnOk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(81, 38);
            this.btnOk.TabIndex = 34;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // tbxClassName
            // 
            this.tbxClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxClassName.Location = new System.Drawing.Point(164, 89);
            this.tbxClassName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxClassName.Name = "tbxClassName";
            this.tbxClassName.Size = new System.Drawing.Size(124, 27);
            this.tbxClassName.TabIndex = 33;
            // 
            // tbxObjectName
            // 
            this.tbxObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxObjectName.Location = new System.Drawing.Point(164, 124);
            this.tbxObjectName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxObjectName.Name = "tbxObjectName";
            this.tbxObjectName.Size = new System.Drawing.Size(124, 27);
            this.tbxObjectName.TabIndex = 32;
            // 
            // lblClassName
            // 
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClassName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblClassName.Location = new System.Drawing.Point(35, 91);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(104, 22);
            this.lblClassName.TabIndex = 31;
            this.lblClassName.Text = "Class name";
            // 
            // lblObjectName
            // 
            this.lblObjectName.AutoSize = true;
            this.lblObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblObjectName.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblObjectName.Location = new System.Drawing.Point(35, 126);
            this.lblObjectName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblObjectName.Name = "lblObjectName";
            this.lblObjectName.Size = new System.Drawing.Size(111, 22);
            this.lblObjectName.TabIndex = 30;
            this.lblObjectName.Text = "Object name";
            // 
            // tbxNamespace
            // 
            this.tbxNamespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxNamespace.Location = new System.Drawing.Point(164, 54);
            this.tbxNamespace.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxNamespace.Name = "tbxNamespace";
            this.tbxNamespace.Size = new System.Drawing.Size(124, 27);
            this.tbxNamespace.TabIndex = 29;
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNamespace.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNamespace.Location = new System.Drawing.Point(35, 56);
            this.lblNamespace.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(105, 22);
            this.lblNamespace.TabIndex = 28;
            this.lblNamespace.Text = "Namespace";
            // 
            // panelProjectObjectUpdate
            // 
            this.panelProjectObjectUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelProjectObjectUpdate.Controls.Add(this.label);
            this.panelProjectObjectUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelProjectObjectUpdate.Location = new System.Drawing.Point(0, 0);
            this.panelProjectObjectUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelProjectObjectUpdate.Name = "panelProjectObjectUpdate";
            this.panelProjectObjectUpdate.Size = new System.Drawing.Size(341, 30);
            this.panelProjectObjectUpdate.TabIndex = 36;
            this.panelProjectObjectUpdate.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelProjectObjectUpdate_MouseDown);
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
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(341, 251);
            this.Controls.Add(this.panelProjectObjectUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.tbxClassName);
            this.Controls.Add(this.tbxObjectName);
            this.Controls.Add(this.lblClassName);
            this.Controls.Add(this.lblObjectName);
            this.Controls.Add(this.tbxNamespace);
            this.Controls.Add(this.lblNamespace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MinimumSize = new System.Drawing.Size(341, 251);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.panelProjectObjectUpdate.ResumeLayout(false);
            this.panelProjectObjectUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbxClassName;
        private System.Windows.Forms.TextBox tbxObjectName;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Label lblObjectName;
        private System.Windows.Forms.TextBox tbxNamespace;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.Panel panelProjectObjectUpdate;
        private System.Windows.Forms.Label label;
    }
}