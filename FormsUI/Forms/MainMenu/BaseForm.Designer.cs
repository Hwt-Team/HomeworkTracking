
namespace FormsUI.Forms.MainMenu
{
    partial class BaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseForm));
            this.panelBase = new System.Windows.Forms.Panel();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelUserManagement = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnUserManagement = new FontAwesome.Sharp.IconButton();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.panelITaskSubMenu = new System.Windows.Forms.Panel();
            this.btnStates = new FontAwesome.Sharp.IconButton();
            this.btnITask = new FontAwesome.Sharp.IconButton();
            this.btnITaskSubmenu = new FontAwesome.Sharp.IconButton();
            this.panelStudentSubMenu = new System.Windows.Forms.Panel();
            this.btnGroups = new FontAwesome.Sharp.IconButton();
            this.btnStudies = new FontAwesome.Sharp.IconButton();
            this.btnGraduates = new FontAwesome.Sharp.IconButton();
            this.btnBaseStudents = new FontAwesome.Sharp.IconButton();
            this.btnStudents = new FontAwesome.Sharp.IconButton();
            this.btnStudentExercises = new FontAwesome.Sharp.IconButton();
            this.btnExercises = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelBase.SuspendLayout();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).BeginInit();
            this.panelSidebar.SuspendLayout();
            this.panelUserManagement.SuspendLayout();
            this.panelITaskSubMenu.SuspendLayout();
            this.panelStudentSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBase
            // 
            this.panelBase.Controls.Add(this.panelContainer);
            this.panelBase.Controls.Add(this.panelNavbar);
            this.panelBase.Controls.Add(this.panelSidebar);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBase.Location = new System.Drawing.Point(0, 0);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(949, 839);
            this.panelBase.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelContainer.Controls.Add(this.pbLogo);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(231, 64);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(718, 775);
            this.panelContainer.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(133, 184);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(473, 377);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelNavbar
            // 
            this.panelNavbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelNavbar.Controls.Add(this.btnMinimize);
            this.panelNavbar.Controls.Add(this.btnMaximize);
            this.panelNavbar.Controls.Add(this.btnClose);
            this.panelNavbar.Controls.Add(this.lblTitleChildForm);
            this.panelNavbar.Controls.Add(this.iconCurrentChildFormIcon);
            this.panelNavbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelNavbar.Location = new System.Drawing.Point(231, 0);
            this.panelNavbar.Name = "panelNavbar";
            this.panelNavbar.Size = new System.Drawing.Size(718, 64);
            this.panelNavbar.TabIndex = 0;
            this.panelNavbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNavbar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnMinimize.ForeColor = System.Drawing.Color.DimGray;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.DimGray;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(639, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(20, 20);
            this.btnMinimize.TabIndex = 4;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnMaximize.ForeColor = System.Drawing.Color.DimGray;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.btnMaximize.IconColor = System.Drawing.Color.DimGray;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(665, 5);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(20, 20);
            this.btnMaximize.TabIndex = 3;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.DimGray;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 20;
            this.btnClose.Location = new System.Drawing.Point(691, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(60, 27);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(54, 20);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildFormIcon
            // 
            this.iconCurrentChildFormIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconCurrentChildFormIcon.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildFormIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildFormIcon.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildFormIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildFormIcon.Location = new System.Drawing.Point(23, 20);
            this.iconCurrentChildFormIcon.Name = "iconCurrentChildFormIcon";
            this.iconCurrentChildFormIcon.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildFormIcon.TabIndex = 0;
            this.iconCurrentChildFormIcon.TabStop = false;
            // 
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelSidebar.Controls.Add(this.panelUserManagement);
            this.panelSidebar.Controls.Add(this.btnUserManagement);
            this.panelSidebar.Controls.Add(this.btnCalendar);
            this.panelSidebar.Controls.Add(this.panelITaskSubMenu);
            this.panelSidebar.Controls.Add(this.btnITaskSubmenu);
            this.panelSidebar.Controls.Add(this.panelStudentSubMenu);
            this.panelSidebar.Controls.Add(this.btnStudents);
            this.panelSidebar.Controls.Add(this.btnStudentExercises);
            this.panelSidebar.Controls.Add(this.btnExercises);
            this.panelSidebar.Controls.Add(this.panelLogo);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(231, 839);
            this.panelSidebar.TabIndex = 1;
            // 
            // panelUserManagement
            // 
            this.panelUserManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelUserManagement.Controls.Add(this.iconButton1);
            this.panelUserManagement.Controls.Add(this.iconButton2);
            this.panelUserManagement.Controls.Add(this.iconButton3);
            this.panelUserManagement.Controls.Add(this.btnUsers);
            this.panelUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserManagement.Location = new System.Drawing.Point(0, 628);
            this.panelUserManagement.Name = "panelUserManagement";
            this.panelUserManagement.Size = new System.Drawing.Size(231, 160);
            this.panelUserManagement.TabIndex = 9;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 120);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(231, 40);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Groups";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // iconButton2
            // 
            this.iconButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.iconButton2.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(0, 80);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(231, 40);
            this.iconButton2.TabIndex = 7;
            this.iconButton2.Text = "Studies";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton3
            // 
            this.iconButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.iconButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.iconButton3.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 40);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(231, 40);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.Text = "Graduates";
            this.iconButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // btnUsers
            // 
            this.btnUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUsers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsers.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 32;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 0);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(231, 40);
            this.btnUsers.TabIndex = 5;
            this.btnUsers.Text = "Users";
            this.btnUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserManagement.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManagement.FlatAppearance.BorderSize = 0;
            this.btnUserManagement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnUserManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUserManagement.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserManagement.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnUserManagement.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUserManagement.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserManagement.IconSize = 32;
            this.btnUserManagement.Location = new System.Drawing.Point(0, 582);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUserManagement.Size = new System.Drawing.Size(231, 46);
            this.btnUserManagement.TabIndex = 8;
            this.btnUserManagement.Text = "User management";
            this.btnUserManagement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnCalendar
            // 
            this.btnCalendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalendar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCalendar.FlatAppearance.BorderSize = 0;
            this.btnCalendar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnCalendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalendar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCalendar.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnCalendar.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCalendar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalendar.IconSize = 32;
            this.btnCalendar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.Location = new System.Drawing.Point(0, 537);
            this.btnCalendar.Name = "btnCalendar";
            this.btnCalendar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalendar.Size = new System.Drawing.Size(231, 45);
            this.btnCalendar.TabIndex = 7;
            this.btnCalendar.Text = "Calendar";
            this.btnCalendar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalendar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalendar.UseVisualStyleBackColor = true;
            this.btnCalendar.Click += new System.EventHandler(this.btnCalendar_Click);
            // 
            // panelITaskSubMenu
            // 
            this.panelITaskSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelITaskSubMenu.Controls.Add(this.btnStates);
            this.panelITaskSubMenu.Controls.Add(this.btnITask);
            this.panelITaskSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelITaskSubMenu.Location = new System.Drawing.Point(0, 457);
            this.panelITaskSubMenu.Name = "panelITaskSubMenu";
            this.panelITaskSubMenu.Size = new System.Drawing.Size(231, 80);
            this.panelITaskSubMenu.TabIndex = 7;
            // 
            // btnStates
            // 
            this.btnStates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStates.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStates.FlatAppearance.BorderSize = 0;
            this.btnStates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnStates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStates.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStates.IconChar = FontAwesome.Sharp.IconChar.AngleRight;
            this.btnStates.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStates.IconSize = 32;
            this.btnStates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStates.Location = new System.Drawing.Point(0, 40);
            this.btnStates.Name = "btnStates";
            this.btnStates.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnStates.Size = new System.Drawing.Size(231, 40);
            this.btnStates.TabIndex = 7;
            this.btnStates.Text = "States";
            this.btnStates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStates.UseVisualStyleBackColor = true;
            this.btnStates.Click += new System.EventHandler(this.btnStates_Click);
            // 
            // btnITask
            // 
            this.btnITask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnITask.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnITask.FlatAppearance.BorderSize = 0;
            this.btnITask.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnITask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnITask.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnITask.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnITask.IconChar = FontAwesome.Sharp.IconChar.CheckDouble;
            this.btnITask.IconColor = System.Drawing.Color.Gainsboro;
            this.btnITask.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnITask.IconSize = 32;
            this.btnITask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnITask.Location = new System.Drawing.Point(0, 0);
            this.btnITask.Name = "btnITask";
            this.btnITask.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnITask.Size = new System.Drawing.Size(231, 40);
            this.btnITask.TabIndex = 6;
            this.btnITask.Text = "ITask management";
            this.btnITask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnITask.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnITask.UseVisualStyleBackColor = true;
            this.btnITask.Click += new System.EventHandler(this.btnITask_Click);
            // 
            // btnITaskSubmenu
            // 
            this.btnITaskSubmenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnITaskSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnITaskSubmenu.FlatAppearance.BorderSize = 0;
            this.btnITaskSubmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnITaskSubmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnITaskSubmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnITaskSubmenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnITaskSubmenu.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnITaskSubmenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnITaskSubmenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnITaskSubmenu.IconSize = 32;
            this.btnITaskSubmenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnITaskSubmenu.Location = new System.Drawing.Point(0, 412);
            this.btnITaskSubmenu.Name = "btnITaskSubmenu";
            this.btnITaskSubmenu.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnITaskSubmenu.Size = new System.Drawing.Size(231, 45);
            this.btnITaskSubmenu.TabIndex = 6;
            this.btnITaskSubmenu.Text = "ITask";
            this.btnITaskSubmenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnITaskSubmenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnITaskSubmenu.UseVisualStyleBackColor = true;
            this.btnITaskSubmenu.Click += new System.EventHandler(this.btnITaskSubmenu_Click);
            // 
            // panelStudentSubMenu
            // 
            this.panelStudentSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panelStudentSubMenu.Controls.Add(this.btnGroups);
            this.panelStudentSubMenu.Controls.Add(this.btnStudies);
            this.panelStudentSubMenu.Controls.Add(this.btnGraduates);
            this.panelStudentSubMenu.Controls.Add(this.btnBaseStudents);
            this.panelStudentSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStudentSubMenu.Location = new System.Drawing.Point(0, 252);
            this.panelStudentSubMenu.Name = "panelStudentSubMenu";
            this.panelStudentSubMenu.Size = new System.Drawing.Size(231, 160);
            this.panelStudentSubMenu.TabIndex = 5;
            // 
            // btnGroups
            // 
            this.btnGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGroups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGroups.FlatAppearance.BorderSize = 0;
            this.btnGroups.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGroups.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGroups.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.btnGroups.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGroups.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGroups.IconSize = 32;
            this.btnGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.Location = new System.Drawing.Point(0, 120);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnGroups.Size = new System.Drawing.Size(231, 40);
            this.btnGroups.TabIndex = 8;
            this.btnGroups.Text = "Groups";
            this.btnGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGroups.UseVisualStyleBackColor = true;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // btnStudies
            // 
            this.btnStudies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudies.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudies.FlatAppearance.BorderSize = 0;
            this.btnStudies.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnStudies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudies.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudies.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnStudies.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStudies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudies.IconSize = 32;
            this.btnStudies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudies.Location = new System.Drawing.Point(0, 80);
            this.btnStudies.Name = "btnStudies";
            this.btnStudies.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnStudies.Size = new System.Drawing.Size(231, 40);
            this.btnStudies.TabIndex = 7;
            this.btnStudies.Text = "Studies";
            this.btnStudies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudies.UseVisualStyleBackColor = true;
            this.btnStudies.Click += new System.EventHandler(this.btnStudies_Click);
            // 
            // btnGraduates
            // 
            this.btnGraduates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGraduates.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGraduates.FlatAppearance.BorderSize = 0;
            this.btnGraduates.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnGraduates.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGraduates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGraduates.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGraduates.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            this.btnGraduates.IconColor = System.Drawing.Color.Gainsboro;
            this.btnGraduates.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGraduates.IconSize = 32;
            this.btnGraduates.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraduates.Location = new System.Drawing.Point(0, 40);
            this.btnGraduates.Name = "btnGraduates";
            this.btnGraduates.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnGraduates.Size = new System.Drawing.Size(231, 40);
            this.btnGraduates.TabIndex = 6;
            this.btnGraduates.Text = "Graduates";
            this.btnGraduates.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGraduates.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGraduates.UseVisualStyleBackColor = true;
            this.btnGraduates.Click += new System.EventHandler(this.btnGraduates_Click);
            // 
            // btnBaseStudents
            // 
            this.btnBaseStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaseStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBaseStudents.FlatAppearance.BorderSize = 0;
            this.btnBaseStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnBaseStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaseStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBaseStudents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBaseStudents.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.btnBaseStudents.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBaseStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBaseStudents.IconSize = 32;
            this.btnBaseStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaseStudents.Location = new System.Drawing.Point(0, 0);
            this.btnBaseStudents.Name = "btnBaseStudents";
            this.btnBaseStudents.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBaseStudents.Size = new System.Drawing.Size(231, 40);
            this.btnBaseStudents.TabIndex = 5;
            this.btnBaseStudents.Text = "Base students";
            this.btnBaseStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaseStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBaseStudents.UseVisualStyleBackColor = true;
            this.btnBaseStudents.Click += new System.EventHandler(this.btnBaseStudents_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudents.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudents.FlatAppearance.BorderSize = 0;
            this.btnStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudents.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconChar = FontAwesome.Sharp.IconChar.UserGraduate;
            this.btnStudents.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStudents.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudents.IconSize = 32;
            this.btnStudents.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.Location = new System.Drawing.Point(0, 207);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStudents.Size = new System.Drawing.Size(231, 45);
            this.btnStudents.TabIndex = 4;
            this.btnStudents.Text = "Students";
            this.btnStudents.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnStudentExercises
            // 
            this.btnStudentExercises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentExercises.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStudentExercises.FlatAppearance.BorderSize = 0;
            this.btnStudentExercises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnStudentExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStudentExercises.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStudentExercises.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.btnStudentExercises.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStudentExercises.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStudentExercises.IconSize = 32;
            this.btnStudentExercises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentExercises.Location = new System.Drawing.Point(0, 162);
            this.btnStudentExercises.Name = "btnStudentExercises";
            this.btnStudentExercises.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnStudentExercises.Size = new System.Drawing.Size(231, 45);
            this.btnStudentExercises.TabIndex = 3;
            this.btnStudentExercises.Text = "Student exercises";
            this.btnStudentExercises.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentExercises.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStudentExercises.UseVisualStyleBackColor = true;
            this.btnStudentExercises.Click += new System.EventHandler(this.btnStudentExercises_Click);
            // 
            // btnExercises
            // 
            this.btnExercises.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExercises.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExercises.FlatAppearance.BorderSize = 0;
            this.btnExercises.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.btnExercises.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExercises.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExercises.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExercises.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnExercises.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExercises.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExercises.IconSize = 32;
            this.btnExercises.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercises.Location = new System.Drawing.Point(0, 117);
            this.btnExercises.Name = "btnExercises";
            this.btnExercises.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExercises.Size = new System.Drawing.Size(231, 45);
            this.btnExercises.TabIndex = 1;
            this.btnExercises.Text = "Exercises";
            this.btnExercises.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExercises.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExercises.UseVisualStyleBackColor = true;
            this.btnExercises.Click += new System.EventHandler(this.btnExercises_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(231, 117);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(39, 18);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(146, 81);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 1;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 839);
            this.Controls.Add(this.panelBase);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "BaseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseForm";
            this.panelBase.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).EndInit();
            this.panelSidebar.ResumeLayout(false);
            this.panelUserManagement.ResumeLayout(false);
            this.panelITaskSubMenu.ResumeLayout(false);
            this.panelStudentSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelNavbar;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnExercises;
        private FontAwesome.Sharp.IconButton btnStudentExercises;
        private FontAwesome.Sharp.IconButton btnStudents;
        private System.Windows.Forms.Panel panelStudentSubMenu;
        private FontAwesome.Sharp.IconButton btnStudies;
        private FontAwesome.Sharp.IconButton btnGraduates;
        private FontAwesome.Sharp.IconButton btnBaseStudents;
        private FontAwesome.Sharp.IconButton btnCalendar;
        private FontAwesome.Sharp.IconButton btnITaskSubmenu;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildFormIcon;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private FontAwesome.Sharp.IconPictureBox btnClose;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelITaskSubMenu;
        private FontAwesome.Sharp.IconButton btnStates;
        private FontAwesome.Sharp.IconButton btnITask;
        private FontAwesome.Sharp.IconButton btnGroups;
        private System.Windows.Forms.Panel panelUserManagement;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnUserManagement;
    }
}