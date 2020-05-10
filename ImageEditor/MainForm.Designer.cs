namespace ImageEditor
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelEffects = new System.Windows.Forms.Panel();
            this.icnBtnContrast = new FontAwesome.Sharp.IconButton();
            this.icnBtnBrightness = new FontAwesome.Sharp.IconButton();
            this.icnBtnTint = new FontAwesome.Sharp.IconButton();
            this.icnBtnCircle = new FontAwesome.Sharp.IconButton();
            this.icnBtnInverse = new FontAwesome.Sharp.IconButton();
            this.icnBtnSepia = new FontAwesome.Sharp.IconButton();
            this.icnBtnGrayscale = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelEffects.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(945, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.revertToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // revertToolStripMenuItem
            // 
            this.revertToolStripMenuItem.Name = "revertToolStripMenuItem";
            this.revertToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.revertToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.revertToolStripMenuItem.Text = "Revert";
            this.revertToolStripMenuItem.Click += new System.EventHandler(this.revertToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.Location = new System.Drawing.Point(15, 576);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 38);
            this.btnLoad.TabIndex = 8;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Location = new System.Drawing.Point(158, 576);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(137, 38);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Image = global::ImageEditor.Properties.Resources.DragDropIcon;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(12, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(727, 402);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragDrop);
            this.pictureBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.pictureBox_DragEnter);
            // 
            // panelEffects
            // 
            this.panelEffects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelEffects.Controls.Add(this.icnBtnContrast);
            this.panelEffects.Controls.Add(this.icnBtnBrightness);
            this.panelEffects.Controls.Add(this.icnBtnTint);
            this.panelEffects.Controls.Add(this.icnBtnCircle);
            this.panelEffects.Controls.Add(this.icnBtnInverse);
            this.panelEffects.Controls.Add(this.icnBtnSepia);
            this.panelEffects.Controls.Add(this.icnBtnGrayscale);
            this.panelEffects.Controls.Add(this.panelLogo);
            this.panelEffects.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelEffects.Location = new System.Drawing.Point(745, 24);
            this.panelEffects.Name = "panelEffects";
            this.panelEffects.Size = new System.Drawing.Size(200, 602);
            this.panelEffects.TabIndex = 8;
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
            this.icnBtnContrast.Location = new System.Drawing.Point(0, 460);
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
            this.icnBtnBrightness.Location = new System.Drawing.Point(0, 400);
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
            this.icnBtnTint.Location = new System.Drawing.Point(0, 340);
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
            this.icnBtnCircle.Location = new System.Drawing.Point(0, 280);
            this.icnBtnCircle.Name = "icnBtnCircle";
            this.icnBtnCircle.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnCircle.Rotation = 0D;
            this.icnBtnCircle.Size = new System.Drawing.Size(200, 60);
            this.icnBtnCircle.TabIndex = 4;
            this.icnBtnCircle.Text = "Circle";
            this.icnBtnCircle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnCircle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnCircle.UseVisualStyleBackColor = true;
            this.icnBtnCircle.Click += new System.EventHandler(this.icnBtnCircle_Click);
            // 
            // icnBtnInverse
            // 
            this.icnBtnInverse.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnInverse.FlatAppearance.BorderSize = 0;
            this.icnBtnInverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnInverse.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnInverse.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnInverse.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnInverse.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.icnBtnInverse.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnInverse.IconSize = 32;
            this.icnBtnInverse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnInverse.Location = new System.Drawing.Point(0, 220);
            this.icnBtnInverse.Name = "icnBtnInverse";
            this.icnBtnInverse.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnInverse.Rotation = 0D;
            this.icnBtnInverse.Size = new System.Drawing.Size(200, 60);
            this.icnBtnInverse.TabIndex = 3;
            this.icnBtnInverse.Text = "Inverse";
            this.icnBtnInverse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnInverse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnInverse.UseVisualStyleBackColor = true;
            this.icnBtnInverse.Click += new System.EventHandler(this.icnBtnInverse_Click);
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
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 626);
            this.Controls.Add(this.panelEffects);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.Icon = global::ImageEditor.Properties.Resources.AppIcon;
            this.Name = "MainForm";
            this.Text = "The Image Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelEffects.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.Panel panelEffects;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton icnBtnGrayscale;
        private FontAwesome.Sharp.IconButton icnBtnContrast;
        private FontAwesome.Sharp.IconButton icnBtnBrightness;
        private FontAwesome.Sharp.IconButton icnBtnTint;
        private FontAwesome.Sharp.IconButton icnBtnCircle;
        private FontAwesome.Sharp.IconButton icnBtnInverse;
        private FontAwesome.Sharp.IconButton icnBtnSepia;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
    }
}

