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
            this.Icon = ImageEditor.Properties.Resources.AppIcon;
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).BeginInit();
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
            this.barRed.Location = new System.Drawing.Point(343, 23);
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
            this.btnApply.Location = new System.Drawing.Point(318, 182);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(127, 35);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(465, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblRedVal
            // 
            this.lblRedVal.AutoSize = true;
            this.lblRedVal.Location = new System.Drawing.Point(582, 27);
            this.lblRedVal.Name = "lblRedVal";
            this.lblRedVal.Size = new System.Drawing.Size(13, 13);
            this.lblRedVal.TabIndex = 4;
            this.lblRedVal.Text = "0";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(307, 27);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(30, 13);
            this.lblRed.TabIndex = 6;
            this.lblRed.Text = "Red:";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(307, 78);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(39, 13);
            this.lblGreen.TabIndex = 9;
            this.lblGreen.Text = "Green:";
            // 
            // lblGreenVal
            // 
            this.lblGreenVal.AutoSize = true;
            this.lblGreenVal.Location = new System.Drawing.Point(582, 78);
            this.lblGreenVal.Name = "lblGreenVal";
            this.lblGreenVal.Size = new System.Drawing.Size(13, 13);
            this.lblGreenVal.TabIndex = 8;
            this.lblGreenVal.Text = "0";
            // 
            // barGreen
            // 
            this.barGreen.Location = new System.Drawing.Point(343, 74);
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
            this.lblBlue.Location = new System.Drawing.Point(307, 129);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(31, 13);
            this.lblBlue.TabIndex = 12;
            this.lblBlue.Text = "Blue:";
            // 
            // lblBlueVal
            // 
            this.lblBlueVal.AutoSize = true;
            this.lblBlueVal.Location = new System.Drawing.Point(582, 129);
            this.lblBlueVal.Name = "lblBlueVal";
            this.lblBlueVal.Size = new System.Drawing.Size(13, 13);
            this.lblBlueVal.TabIndex = 11;
            this.lblBlueVal.Text = "0";
            // 
            // barBlue
            // 
            this.barBlue.Location = new System.Drawing.Point(343, 125);
            this.barBlue.Maximum = 255;
            this.barBlue.Name = "barBlue";
            this.barBlue.Size = new System.Drawing.Size(233, 45);
            this.barBlue.TabIndex = 10;
            this.barBlue.TickFrequency = 20;
            this.barBlue.Scroll += new System.EventHandler(this.ColorChanged);
            // 
            // TintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 237);
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
            this.Name = "TintForm";
            this.Text = "Tint";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barBlue)).EndInit();
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
    }
}