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
            this.barRed = new System.Windows.Forms.TrackBar();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblRedVal = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblGreenVal = new System.Windows.Forms.Label();
            this.barGreen = new System.Windows.Forms.TrackBar();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblBlueVal = new System.Windows.Forms.Label();
            this.barBlue = new System.Windows.Forms.TrackBar();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.icnBtnCancel = new FontAwesome.Sharp.IconButton();
            this.icnBtnApply = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).BeginInit();
            this.panelBtns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(21, 23);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(274, 194);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // barRed
            // 
            this.barRed.Location = new System.Drawing.Point(62, 173);
            this.barRed.Maximum = 255;
            this.barRed.Name = "barRed";
            this.barRed.Size = new System.Drawing.Size(233, 45);
            this.barRed.TabIndex = 1;
            this.barRed.TickFrequency = 20;
            this.barRed.Scroll += new System.EventHandler(this.ColorChanged);
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(37, 332);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(127, 35);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(184, 332);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblRedVal
            // 
            this.lblRedVal.AutoSize = true;
            this.lblRedVal.Location = new System.Drawing.Point(301, 177);
            this.lblRedVal.Name = "lblRedVal";
            this.lblRedVal.Size = new System.Drawing.Size(13, 13);
            this.lblRedVal.TabIndex = 4;
            this.lblRedVal.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(26, 177);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(30, 13);
            this.lblRed.TabIndex = 6;
            this.lblRed.Text = "Red:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(26, 228);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 13);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "Green:";
            // 
            // lblGreenVal
            // 
            this.lblGreenVal.AutoSize = true;
            this.lblGreenVal.Location = new System.Drawing.Point(301, 228);
            this.lblGreenVal.Name = "lblGreenVal";
            this.lblGreenVal.Size = new System.Drawing.Size(13, 13);
            this.lblGreenVal.TabIndex = 8;
            this.lblGreenVal.Text = "0";
            // 
            // barGreen
            // 
            this.barGreen.Location = new System.Drawing.Point(62, 224);
            this.barGreen.Maximum = 255;
            this.barGreen.Name = "barGreen";
            this.barGreen.Size = new System.Drawing.Size(233, 45);
            this.barGreen.TabIndex = 7;
            this.barGreen.TickFrequency = 20;
            this.barGreen.Scroll += new System.EventHandler(this.ColorChanged);
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(26, 279);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(31, 13);
            this.lblBlue.TabIndex = 12;
            this.lblBlue.Text = "Blue:";
            // 
            // lblBlueVal
            // 
            this.lblBlueVal.AutoSize = true;
            this.lblBlueVal.Location = new System.Drawing.Point(301, 279);
            this.lblBlueVal.Name = "lblBlueVal";
            this.lblBlueVal.Size = new System.Drawing.Size(13, 13);
            this.lblBlueVal.TabIndex = 11;
            this.lblBlueVal.Text = "0";
            // 
            // barBlue
            // 
            this.barBlue.Location = new System.Drawing.Point(62, 275);
            this.barBlue.Maximum = 255;
            this.barBlue.Name = "barBlue";
            this.barBlue.Size = new System.Drawing.Size(233, 45);
            this.barBlue.TabIndex = 10;
            this.barBlue.TickFrequency = 20;
            this.barBlue.Scroll += new System.EventHandler(this.ColorChanged);
            // 
            // panelBtns
            // 
            this.panelBtns.Controls.Add(this.icnBtnCancel);
            this.panelBtns.Controls.Add(this.icnBtnApply);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtns.Location = new System.Drawing.Point(482, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(200, 395);
            this.panelBtns.TabIndex = 13;
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
            this.icnBtnCancel.Size = new System.Drawing.Size(200, 60);
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
            this.icnBtnApply.Size = new System.Drawing.Size(200, 60);
            this.icnBtnApply.TabIndex = 2;
            this.icnBtnApply.Text = "Apply";
            this.icnBtnApply.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.icnBtnApply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.icnBtnApply.UseVisualStyleBackColor = true;
            // 
            // TintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(682, 395);
            this.Controls.Add(this.panelBtns);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblBlueVal);
            this.Controls.Add(this.barBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblGreenVal);
            this.Controls.Add(this.barGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblRedVal);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.barRed);
            this.Controls.Add(this.pictureBox);
            this.Icon = global::ImageEditor.Properties.Resources.AppIcon;
            this.Name = "TintForm";
            this.Text = "Tint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).EndInit();
            this.panelBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar barRed;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblRedVal;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblGreenVal;
        private System.Windows.Forms.TrackBar barGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblBlueVal;
        private System.Windows.Forms.TrackBar barBlue;
        private System.Windows.Forms.Panel panelBtns;
        private FontAwesome.Sharp.IconButton icnBtnCancel;
        private FontAwesome.Sharp.IconButton icnBtnApply;
    }
}