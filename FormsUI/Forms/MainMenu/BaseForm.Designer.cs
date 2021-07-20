﻿
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
            this.panelNavbar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelITaskSubMenu = new System.Windows.Forms.Panel();
            this.panelStudentSubMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new FontAwesome.Sharp.IconPictureBox();
            this.iconCurrentChildFormIcon = new FontAwesome.Sharp.IconPictureBox();
            this.btnCalendar = new FontAwesome.Sharp.IconButton();
            this.btnStates = new FontAwesome.Sharp.IconButton();
            this.btnITask = new FontAwesome.Sharp.IconButton();
            this.btnITaskSubmenu = new FontAwesome.Sharp.IconButton();
            this.btnGroups = new FontAwesome.Sharp.IconButton();
            this.btnStudies = new FontAwesome.Sharp.IconButton();
            this.btnGraduates = new FontAwesome.Sharp.IconButton();
            this.btnBaseStudents = new FontAwesome.Sharp.IconButton();
            this.btnStudents = new FontAwesome.Sharp.IconButton();
            this.btnStudentExercises = new FontAwesome.Sharp.IconButton();
            this.btnExercises = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelBase.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.panelNavbar.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelITaskSubMenu.SuspendLayout();
            this.panelStudentSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).BeginInit();
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
            this.panelBase.Size = new System.Drawing.Size(900, 633);
            this.panelBase.TabIndex = 0;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.panelContainer.Controls.Add(this.pbLogo);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(231, 64);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(669, 569);
            this.panelContainer.TabIndex = 2;
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
            this.panelNavbar.Size = new System.Drawing.Size(669, 64);
            this.panelNavbar.TabIndex = 0;
            this.panelNavbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelNavbar_MouseDown);
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
            // panelSidebar
            // 
            this.panelSidebar.AutoScroll = true;
            this.panelSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
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
            this.panelSidebar.Size = new System.Drawing.Size(231, 633);
            this.panelSidebar.TabIndex = 1;
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
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(231, 117);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(109, 81);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(473, 377);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
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
            this.btnMinimize.Location = new System.Drawing.Point(590, 5);
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
            this.btnMaximize.Location = new System.Drawing.Point(616, 5);
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
            this.btnClose.Location = new System.Drawing.Point(642, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 2;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.ClientSize = new System.Drawing.Size(900, 633);
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
            this.panelNavbar.ResumeLayout(false);
            this.panelNavbar.PerformLayout();
            this.panelSidebar.ResumeLayout(false);
            this.panelITaskSubMenu.ResumeLayout(false);
            this.panelStudentSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildFormIcon)).EndInit();
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
    }
}