namespace ImageEditor
{
    partial class GrayscaleForm
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
            this.icnBtnCancel = new FontAwesome.Sharp.IconButton();
            this.icnBtnApply = new FontAwesome.Sharp.IconButton();
            this.barAmount = new System.Windows.Forms.TrackBar();
            this.panelImg = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelBtns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barAmount)).BeginInit();
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
            this.panelBtns.Controls.Add(this.barAmount);
            this.panelBtns.Controls.Add(this.icnBtnCancel);
            this.panelBtns.Controls.Add(this.icnBtnApply);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtns.Location = new System.Drawing.Point(446, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(236, 395);
            this.panelBtns.TabIndex = 6;
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
            // barAmount
            // 
            this.barAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.barAmount.Location = new System.Drawing.Point(0, 120);
            this.barAmount.Maximum = 100;
            this.barAmount.Name = "barAmount";
            this.barAmount.Size = new System.Drawing.Size(236, 45);
            this.barAmount.TabIndex = 4;
            this.barAmount.TickFrequency = 10;
            this.barAmount.Value = 100;
            this.barAmount.Scroll += new System.EventHandler(this.barAmount_Scroll);
            // 
            // panelImg
            // 
            this.panelImg.Controls.Add(this.pictureBox);
            this.panelImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImg.Location = new System.Drawing.Point(0, 0);
            this.panelImg.Name = "panelImg";
            this.panelImg.Size = new System.Drawing.Size(446, 395);
            this.panelImg.TabIndex = 7;
            // 
            // GrayscaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(682, 395);
            this.Controls.Add(this.panelImg);
            this.Controls.Add(this.panelBtns);
            this.Icon = global::ImageEditor.Properties.Resources.AppIcon;
            this.Name = "GrayscaleForm";
            this.Text = "Grayscale";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelBtns.ResumeLayout(false);
            this.panelBtns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barAmount)).EndInit();
            this.panelImg.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Panel panelBtns;
        private FontAwesome.Sharp.IconButton icnBtnCancel;
        private FontAwesome.Sharp.IconButton icnBtnApply;
        private System.Windows.Forms.TrackBar barAmount;
        private System.Windows.Forms.Panel panelImg;
    }
}