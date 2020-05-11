namespace ImageEditor
{
    partial class TintForm
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.barBlue = new System.Windows.Forms.TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.barGreen = new System.Windows.Forms.TrackBar();
            this.lblGreen = new System.Windows.Forms.Label();
            this.barRed = new System.Windows.Forms.TrackBar();
            this.lblRed = new System.Windows.Forms.Label();
            this.icnBtnCancel = new FontAwesome.Sharp.IconButton();
            this.icnBtnApply = new FontAwesome.Sharp.IconButton();
            this.panelImg = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).BeginInit();
            this.panelImg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(446, 395);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // panelBtns
            // 
            this.panelBtns.Controls.Add(this.barBlue);
            this.panelBtns.Controls.Add(this.lblBlue);
            this.panelBtns.Controls.Add(this.barGreen);
            this.panelBtns.Controls.Add(this.lblGreen);
            this.panelBtns.Controls.Add(this.barRed);
            this.panelBtns.Controls.Add(this.lblRed);
            this.panelBtns.Controls.Add(this.icnBtnCancel);
            this.panelBtns.Controls.Add(this.icnBtnApply);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtns.Location = new System.Drawing.Point(446, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(236, 395);
            this.panelBtns.TabIndex = 13;
            // 
            // barBlue
            // 
            this.barBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.barBlue.Location = new System.Drawing.Point(0, 258);
            this.barBlue.Maximum = 255;
            this.barBlue.Name = "barBlue";
            this.barBlue.Size = new System.Drawing.Size(236, 45);
            this.barBlue.TabIndex = 17;
            this.barBlue.TickFrequency = 20;
            this.barBlue.Scroll += new System.EventHandler(this.ColorChanged);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBlue.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlue.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblBlue.Location = new System.Drawing.Point(0, 242);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lblBlue.Size = new System.Drawing.Size(45, 16);
            this.lblBlue.TabIndex = 16;
            this.lblBlue.Text = "Blue:";
            // 
            // barGreen
            // 
            this.barGreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.barGreen.Location = new System.Drawing.Point(0, 197);
            this.barGreen.Maximum = 255;
            this.barGreen.Name = "barGreen";
            this.barGreen.Size = new System.Drawing.Size(236, 45);
            this.barGreen.TabIndex = 15;
            this.barGreen.TickFrequency = 20;
            this.barGreen.Scroll += new System.EventHandler(this.ColorChanged);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGreen.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreen.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblGreen.Location = new System.Drawing.Point(0, 181);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lblGreen.Size = new System.Drawing.Size(54, 16);
            this.lblGreen.TabIndex = 14;
            this.lblGreen.Text = "Green:";
            // 
            // barRed
            // 
            this.barRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.barRed.Location = new System.Drawing.Point(0, 136);
            this.barRed.Maximum = 255;
            this.barRed.Name = "barRed";
            this.barRed.Size = new System.Drawing.Size(236, 45);
            this.barRed.TabIndex = 13;
            this.barRed.TickFrequency = 20;
            this.barRed.Scroll += new System.EventHandler(this.ColorChanged);
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblRed.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRed.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRed.Location = new System.Drawing.Point(0, 120);
            this.lblRed.Name = "lblRed";
            this.lblRed.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.lblRed.Size = new System.Drawing.Size(42, 16);
            this.lblRed.TabIndex = 12;
            this.lblRed.Text = "Red:";
            // 
            // icnBtnCancel
            // 
            this.icnBtnCancel.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnCancel.FlatAppearance.BorderSize = 0;
            this.icnBtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnCancel.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnCancel.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnCancel.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.icnBtnCancel.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnCancel.IconSize = 32;
            this.icnBtnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnCancel.Location = new System.Drawing.Point(0, 60);
            this.icnBtnCancel.Name = "icnBtnCancel";
            this.icnBtnCancel.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnCancel.Rotation = 0D;
            this.icnBtnCancel.Size = new System.Drawing.Size(236, 60);
            this.icnBtnCancel.TabIndex = 3;
            this.icnBtnCancel.Text = "Cancel";
            this.icnBtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnCancel.UseVisualStyleBackColor = true;
            // 
            // icnBtnApply
            // 
            this.icnBtnApply.Dock = System.Windows.Forms.DockStyle.Top;
            this.icnBtnApply.FlatAppearance.BorderSize = 0;
            this.icnBtnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icnBtnApply.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.icnBtnApply.Font = new System.Drawing.Font("Arimo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icnBtnApply.ForeColor = System.Drawing.Color.Gainsboro;
            this.icnBtnApply.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.icnBtnApply.IconColor = System.Drawing.Color.Gainsboro;
            this.icnBtnApply.IconSize = 32;
            this.icnBtnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnApply.Location = new System.Drawing.Point(0, 0);
            this.icnBtnApply.Name = "icnBtnApply";
            this.icnBtnApply.Padding = new System.Windows.Forms.Padding(15, 0, 20, 0);
            this.icnBtnApply.Rotation = 0D;
            this.icnBtnApply.Size = new System.Drawing.Size(236, 60);
            this.icnBtnApply.TabIndex = 2;
            this.icnBtnApply.Text = "Apply";
            this.icnBtnApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnApply.UseVisualStyleBackColor = true;
            // 
            // panelImg
            // 
            this.panelImg.Controls.Add(this.pictureBox);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(446, 395);
            this.panelImg.TabIndex = 14;
            // 
            // TintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(682, 395);
            this.Controls.Add(this.panelImg);
            this.Controls.Add(this.panelBtns);
            this.Icon = global::ImageEditor.Properties.Resources.AppIcon;
            this.Name = "TintForm";
            this.Text = "Tint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelBtns.ResumeLayout(false);
            this.panelBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).EndInit();
            this.panelImg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelBtns;
        private FontAwesome.Sharp.IconButton icnBtnCancel;
        private FontAwesome.Sharp.IconButton icnBtnApply;
        private System.Windows.Forms.TrackBar barBlue;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar barGreen;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.TrackBar barRed;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Panel panelImg;
    }
}