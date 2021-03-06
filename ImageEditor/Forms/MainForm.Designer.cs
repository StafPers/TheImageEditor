﻿namespace ImageEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelEffects = new System.Windows.Forms.Panel();
            this.icnBtnCircle = new FontAwesome.Sharp.IconButton();
            this.icnBtnInvert = new FontAwesome.Sharp.IconButton();
            this.icnBtnContrast = new FontAwesome.Sharp.IconButton();
            this.icnBtnBrightness = new FontAwesome.Sharp.IconButton();
            this.icnBtnTint = new FontAwesome.Sharp.IconButton();
            this.icnBtnSepia = new FontAwesome.Sharp.IconButton();
            this.icnBtnGrayscale = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.icnBtnMaximize = new FontAwesome.Sharp.IconButton();
            this.icnBtnMinimize = new FontAwesome.Sharp.IconButton();
            this.icnBtnClose = new FontAwesome.Sharp.IconButton();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelFile = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelRightPad = new System.Windows.Forms.Panel();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.icnBtnClear = new FontAwesome.Sharp.IconButton();
            this.icnBtnSave = new FontAwesome.Sharp.IconButton();
            this.icnBtnLoad = new FontAwesome.Sharp.IconButton();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelEffects.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelFile.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.panelBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::ImageEditor.Properties.Resources.dragdrop;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(698, 445);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // panelEffects
            // 
            this.panelEffects.AutoScroll = true;
            this.panelEffects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelEffects.Controls.Add(this.icnBtnCircle);
            this.panelEffects.Controls.Add(this.icnBtnInvert);
            this.panelEffects.Controls.Add(this.icnBtnContrast);
            this.panelEffects.Controls.Add(this.icnBtnBrightness);
            this.panelEffects.Controls.Add(this.icnBtnTint);
            this.panelEffects.Controls.Add(this.icnBtnSepia);
            this.panelEffects.Controls.Add(this.icnBtnGrayscale);
            this.panelEffects.Controls.Add(this.panelLogo);
            this.panelEffects.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEffects.Location = new System.Drawing.Point(0, 0);
            this.panelEffects.Name = "panelEffects";
            this.panelEffects.Size = new System.Drawing.Size(200, 558);
            this.panelEffects.TabIndex = 8;
            // 
            // icnBtnCircle
            // 
            this.icnBtnCircle.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnCircle.FlatAppearance.BorderSize = 0;
            this.icnBtnCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnCircle.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnCircle.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnCircle.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnCircle.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.icnBtnCircle.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnCircle.IconSize = 32;
            this.icnBtnCircle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnCircle.Location = new System.Drawing.Point(0, 460);
            this.icnBtnCircle.Name = "icnBtnCircle";
            this.icnBtnCircle.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnCircle.Rotation = 0D;
            this.icnBtnCircle.Size = new System.Drawing.Size(200, 60);
            this.icnBtnCircle.TabIndex = 9;
            this.icnBtnCircle.Text = "Circle";
            this.icnBtnCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnCircle.UseVisualStyleBackColor = true;
            this.icnBtnCircle.Click += new System.EventHandler(this.icnBtnCircle_Click);
            // 
            // icnBtnInvert
            // 
            this.icnBtnInvert.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnInvert.FlatAppearance.BorderSize = 0;
            this.icnBtnInvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnInvert.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnInvert.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnInvert.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnInvert.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.icnBtnInvert.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnInvert.IconSize = 32;
            this.icnBtnInvert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnInvert.Location = new System.Drawing.Point(0, 400);
            this.icnBtnInvert.Name = "icnBtnInvert";
            this.icnBtnInvert.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnInvert.Rotation = 0D;
            this.icnBtnInvert.Size = new System.Drawing.Size(200, 60);
            this.icnBtnInvert.TabIndex = 8;
            this.icnBtnInvert.Text = "Invert";
            this.icnBtnInvert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnInvert.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnInvert.UseVisualStyleBackColor = true;
            this.icnBtnInvert.Click += new System.EventHandler(this.icnBtnInvert_Click);
            // 
            // icnBtnContrast
            // 
            this.icnBtnContrast.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnContrast.FlatAppearance.BorderSize = 0;
            this.icnBtnContrast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnContrast.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnContrast.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnContrast.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnContrast.IconChar = FontAwesome.Sharp.IconChar.Adjust;
            this.icnBtnContrast.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnContrast.IconSize = 32;
            this.icnBtnContrast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnContrast.Location = new System.Drawing.Point(0, 340);
            this.icnBtnContrast.Name = "icnBtnContrast";
            this.icnBtnContrast.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnContrast.Rotation = 0D;
            this.icnBtnContrast.Size = new System.Drawing.Size(200, 60);
            this.icnBtnContrast.TabIndex = 7;
            this.icnBtnContrast.Text = "Contrast";
            this.icnBtnContrast.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnContrast.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnContrast.UseVisualStyleBackColor = true;
            this.icnBtnContrast.Click += new System.EventHandler(this.icnBtnContrast_Click);
            // 
            // icnBtnBrightness
            // 
            this.icnBtnBrightness.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnBrightness.FlatAppearance.BorderSize = 0;
            this.icnBtnBrightness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnBrightness.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnBrightness.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnBrightness.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnBrightness.IconChar = FontAwesome.Sharp.IconChar.Sun;
            this.icnBtnBrightness.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnBrightness.IconSize = 32;
            this.icnBtnBrightness.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnBrightness.Location = new System.Drawing.Point(0, 280);
            this.icnBtnBrightness.Name = "icnBtnBrightness";
            this.icnBtnBrightness.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnBrightness.Rotation = 0D;
            this.icnBtnBrightness.Size = new System.Drawing.Size(200, 60);
            this.icnBtnBrightness.TabIndex = 6;
            this.icnBtnBrightness.Text = "Brightness";
            this.icnBtnBrightness.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnBrightness.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnBrightness.UseVisualStyleBackColor = true;
            this.icnBtnBrightness.Click += new System.EventHandler(this.icnBtnBrightness_Click);
            // 
            // icnBtnTint
            // 
            this.icnBtnTint.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnTint.FlatAppearance.BorderSize = 0;
            this.icnBtnTint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnTint.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnTint.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnTint.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnTint.IconChar = FontAwesome.Sharp.IconChar.Tint;
            this.icnBtnTint.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnTint.IconSize = 32;
            this.icnBtnTint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnTint.Location = new System.Drawing.Point(0, 220);
            this.icnBtnTint.Name = "icnBtnTint";
            this.icnBtnTint.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnTint.Rotation = 0D;
            this.icnBtnTint.Size = new System.Drawing.Size(200, 60);
            this.icnBtnTint.TabIndex = 5;
            this.icnBtnTint.Text = "Tint";
            this.icnBtnTint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnTint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnTint.UseVisualStyleBackColor = true;
            this.icnBtnTint.Click += new System.EventHandler(this.icnBtnTint_Click);
            // 
            // icnBtnSepia
            // 
            this.icnBtnSepia.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnSepia.FlatAppearance.BorderSize = 0;
            this.icnBtnSepia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnSepia.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnSepia.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnSepia.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnSepia.IconChar = FontAwesome.Sharp.IconChar.Filter;
            this.icnBtnSepia.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnSepia.IconSize = 32;
            this.icnBtnSepia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnSepia.Location = new System.Drawing.Point(0, 160);
            this.icnBtnSepia.Name = "icnBtnSepia";
            this.icnBtnSepia.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnSepia.Rotation = 0D;
            this.icnBtnSepia.Size = new System.Drawing.Size(200, 60);
            this.icnBtnSepia.TabIndex = 2;
            this.icnBtnSepia.Text = "Sepia";
            this.icnBtnSepia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnSepia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnSepia.UseVisualStyleBackColor = true;
            this.icnBtnSepia.Click += new System.EventHandler(this.icnBtnSepia_Click);
            // 
            // icnBtnGrayscale
            // 
            this.icnBtnGrayscale.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnGrayscale.FlatAppearance.BorderSize = 0;
            this.icnBtnGrayscale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnGrayscale.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnGrayscale.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnGrayscale.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnGrayscale.IconChar = FontAwesome.Sharp.IconChar.TintSlash;
            this.icnBtnGrayscale.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnGrayscale.IconSize = 32;
            this.icnBtnGrayscale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnGrayscale.Location = new System.Drawing.Point(0, 100);
            this.icnBtnGrayscale.Name = "icnBtnGrayscale";
            this.icnBtnGrayscale.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnGrayscale.Rotation = 0D;
            this.icnBtnGrayscale.Size = new System.Drawing.Size(200, 60);
            this.icnBtnGrayscale.TabIndex = 1;
            this.icnBtnGrayscale.Text = "Grayscale";
            this.icnBtnGrayscale.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnGrayscale.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnGrayscale.UseVisualStyleBackColor = true;
            this.icnBtnGrayscale.Click += new System.EventHandler(this.icnBtnGrayscale_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::ImageEditor.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 17);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(194, 68);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelTitlebar.Controls.Add(this.icnBtnMaximize);
            this.panelTitlebar.Controls.Add(this.icnBtnMinimize);
            this.panelTitlebar.Controls.Add(this.icnBtnClose);
            this.panelTitlebar.Controls.Add(this.panelMenu);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(200, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(728, 53);
            this.panelTitlebar.TabIndex = 10;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // icnBtnMaximize
            // 
            this.icnBtnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icnBtnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.icnBtnMaximize.FlatAppearance.BorderSize = 0;
            this.icnBtnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnMaximize.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.icnBtnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnMaximize.IconSize = 16;
            this.icnBtnMaximize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnMaximize.Location = new System.Drawing.Point(667, 12);
            this.icnBtnMaximize.Name = "icnBtnMaximize";
            this.icnBtnMaximize.Rotation = 0D;
            this.icnBtnMaximize.Size = new System.Drawing.Size(25, 25);
            this.icnBtnMaximize.TabIndex = 13;
            this.icnBtnMaximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnMaximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnMaximize.UseVisualStyleBackColor = false;
            this.icnBtnMaximize.Click += new System.EventHandler(this.icnBtnMaximize_Click);
            // 
            // icnBtnMinimize
            // 
            this.icnBtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icnBtnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.icnBtnMinimize.FlatAppearance.BorderSize = 0;
            this.icnBtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnMinimize.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.icnBtnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnMinimize.IconSize = 16;
            this.icnBtnMinimize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnMinimize.Location = new System.Drawing.Point(636, 12);
            this.icnBtnMinimize.Name = "icnBtnMinimize";
            this.icnBtnMinimize.Rotation = 0D;
            this.icnBtnMinimize.Size = new System.Drawing.Size(25, 25);
            this.icnBtnMinimize.TabIndex = 12;
            this.icnBtnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnMinimize.UseVisualStyleBackColor = false;
            this.icnBtnMinimize.Click += new System.EventHandler(this.icnBtnMinimize_Click);
            // 
            // icnBtnClose
            // 
            this.icnBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.icnBtnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.icnBtnClose.FlatAppearance.BorderSize = 0;
            this.icnBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnClose.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnClose.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.icnBtnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnClose.IconSize = 16;
            this.icnBtnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnClose.Location = new System.Drawing.Point(698, 12);
            this.icnBtnClose.Name = "icnBtnClose";
            this.icnBtnClose.Rotation = 0D;
            this.icnBtnClose.Size = new System.Drawing.Size(25, 25);
            this.icnBtnClose.TabIndex = 11;
            this.icnBtnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnClose.UseVisualStyleBackColor = false;
            this.icnBtnClose.Click += new System.EventHandler(this.icnBtnClose_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.panelFile);
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(129, 53);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // panelFile
            // 
            this.panelFile.Controls.Add(this.menuStrip);
            this.panelFile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFile.Location = new System.Drawing.Point(0, 31);
            this.panelFile.Name = "panelFile";
            this.panelFile.Size = new System.Drawing.Size(129, 22);
            this.panelFile.TabIndex = 8;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.menuStrip.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(129, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "Menu";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.revertMenuItem,
            this.redoMenuItem,
            this.exitMenuItem});
            this.fileMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(41, 20);
            this.fileMenuItem.Text = "File";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadMenuItem.Size = new System.Drawing.Size(155, 22);
            this.loadMenuItem.Text = "Load";
            this.loadMenuItem.Click += new System.EventHandler(this.loadMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveMenuItem.Text = "Save";
            this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(155, 22);
            this.saveAsMenuItem.Text = "Save as...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
            // 
            // revertMenuItem
            // 
            this.revertMenuItem.Name = "revertMenuItem";
            this.revertMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.revertMenuItem.Size = new System.Drawing.Size(155, 22);
            this.revertMenuItem.Text = "Revert";
            this.revertMenuItem.Click += new System.EventHandler(this.revertMenuItem_Click);
            // 
            // redoMenuItem
            // 
            this.redoMenuItem.Name = "redoMenuItem";
            this.redoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoMenuItem.Size = new System.Drawing.Size(155, 22);
            this.redoMenuItem.Text = "Redo";
            this.redoMenuItem.Click += new System.EventHandler(this.redoMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitMenuItem.Size = new System.Drawing.Size(155, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(94)))), ((int)(((byte)(105)))));
            this.lblTitle.Location = new System.Drawing.Point(11, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(106, 16);
            this.lblTitle.TabIndex = 7;
            this.lblTitle.Text = "The Image Editor";
            // 
            // panelForm
            // 
            this.panelForm.Controls.Add(this.panelDesktop);
            this.panelForm.Controls.Add(this.panelRightPad);
            this.panelForm.Controls.Add(this.panelBtns);
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Location = new System.Drawing.Point(200, 53);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(728, 505);
            this.panelForm.TabIndex = 11;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.panelDesktop.Controls.Add(this.pictureBox);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Margin = new System.Windows.Forms.Padding(0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(698, 445);
            this.panelDesktop.TabIndex = 12;
            // 
            // panelRightPad
            // 
            this.panelRightPad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelRightPad.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRightPad.Location = new System.Drawing.Point(698, 0);
            this.panelRightPad.Name = "panelRightPad";
            this.panelRightPad.Size = new System.Drawing.Size(30, 445);
            this.panelRightPad.TabIndex = 11;
            // 
            // panelBtns
            // 
            this.panelBtns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.panelBtns.Controls.Add(this.icnBtnClear);
            this.panelBtns.Controls.Add(this.icnBtnSave);
            this.panelBtns.Controls.Add(this.icnBtnLoad);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBtns.Location = new System.Drawing.Point(0, 445);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(728, 60);
            this.panelBtns.TabIndex = 10;
            // 
            // icnBtnClear
            // 
            this.icnBtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.icnBtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.icnBtnClear.FlatAppearance.BorderSize = 0;
            this.icnBtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnClear.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnClear.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnClear.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.icnBtnClear.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnClear.IconSize = 32;
            this.icnBtnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnClear.Location = new System.Drawing.Point(552, 0);
            this.icnBtnClear.Margin = new System.Windows.Forms.Padding(0);
            this.icnBtnClear.Name = "icnBtnClear";
            this.icnBtnClear.Rotation = 0D;
            this.icnBtnClear.Size = new System.Drawing.Size(146, 60);
            this.icnBtnClear.TabIndex = 12;
            this.icnBtnClear.Text = "Clear effects";
            this.icnBtnClear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnClear.UseVisualStyleBackColor = false;
            this.icnBtnClear.Click += new System.EventHandler(this.icnBtnClear_Click);
            // 
            // icnBtnSave
            // 
            this.icnBtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.icnBtnSave.FlatAppearance.BorderSize = 0;
            this.icnBtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnSave.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.icnBtnSave.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnSave.IconSize = 32;
            this.icnBtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnSave.Location = new System.Drawing.Point(146, 0);
            this.icnBtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.icnBtnSave.Name = "icnBtnSave";
            this.icnBtnSave.Rotation = 0D;
            this.icnBtnSave.Size = new System.Drawing.Size(146, 60);
            this.icnBtnSave.TabIndex = 11;
            this.icnBtnSave.Text = "Save";
            this.icnBtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnSave.UseVisualStyleBackColor = false;
            this.icnBtnSave.Click += new System.EventHandler(this.icnBtnSave_Click);
            // 
            // icnBtnLoad
            // 
            this.icnBtnLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.icnBtnLoad.FlatAppearance.BorderSize = 0;
            this.icnBtnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnLoad.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnLoad.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnLoad.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnLoad.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.icnBtnLoad.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnLoad.IconSize = 32;
            this.icnBtnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnLoad.Location = new System.Drawing.Point(0, 0);
            this.icnBtnLoad.Margin = new System.Windows.Forms.Padding(0);
            this.icnBtnLoad.Name = "icnBtnLoad";
            this.icnBtnLoad.Rotation = 0D;
            this.icnBtnLoad.Size = new System.Drawing.Size(146, 60);
            this.icnBtnLoad.TabIndex = 10;
            this.icnBtnLoad.Text = "Load";
            this.icnBtnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnLoad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnLoad.UseVisualStyleBackColor = false;
            this.icnBtnLoad.Click += new System.EventHandler(this.icnBtnLoad_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(255)))), ((int)(((byte)(62)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(200, 53);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(728, 9);
            this.panelShadow.TabIndex = 12;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(928, 558);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelEffects);
            this.MinimumSize = new System.Drawing.Size(680, 175);
            this.Name = "MainForm";
            this.Text = "The Image Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelEffects.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelFile.ResumeLayout(false);
            this.panelFile.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelForm.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.panelBtns.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelEffects;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton icnBtnGrayscale;
        private FontAwesome.Sharp.IconButton icnBtnContrast;
        private FontAwesome.Sharp.IconButton icnBtnBrightness;
        private FontAwesome.Sharp.IconButton icnBtnTint;
        private FontAwesome.Sharp.IconButton icnBtnSepia;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Panel panelTitlebar;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelBtns;
        private FontAwesome.Sharp.IconButton icnBtnLoad;
        private FontAwesome.Sharp.IconButton icnBtnSave;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelRightPad;
        private FontAwesome.Sharp.IconButton icnBtnMaximize;
        private FontAwesome.Sharp.IconButton icnBtnMinimize;
        private FontAwesome.Sharp.IconButton icnBtnClose;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton icnBtnCircle;
        private FontAwesome.Sharp.IconButton icnBtnInvert;
        private System.Windows.Forms.Panel panelFile;
        private FontAwesome.Sharp.IconButton icnBtnClear;
    }
}

