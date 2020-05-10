﻿namespace ImageEditor
{
    partial class SepiaForm
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
            this.barAmount = new System.Windows.Forms.TrackBar();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblAmount = new System.Windows.Forms.Label();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.icnBtnCancel = new FontAwesome.Sharp.IconButton();
            this.icnBtnApply = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAmount)).BeginInit();
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
            // barAmount
            // 
            this.barAmount.Location = new System.Drawing.Point(21, 233);
            this.barAmount.Maximum = 100;
            this.barAmount.Name = "barAmount";
            this.barAmount.Size = new System.Drawing.Size(233, 45);
            this.barAmount.TabIndex = 1;
            this.barAmount.TickFrequency = 10;
            this.barAmount.Value = 100;
            this.barAmount.Scroll += new System.EventHandler(this.barAmount_Scroll);
            // 
            // btnApply
            // 
            this.btnApply.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnApply.Location = new System.Drawing.Point(21, 274);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(127, 35);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(168, 274);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 35);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(260, 237);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(22, 13);
            this.lblAmount.TabIndex = 4;
            this.lblAmount.Text = "1.0";
            // 
            // panelBtns
            // 
            this.panelBtns.Controls.Add(this.icnBtnCancel);
            this.panelBtns.Controls.Add(this.icnBtnApply);
            this.panelBtns.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBtns.Location = new System.Drawing.Point(482, 0);
            this.panelBtns.Name = "panelBtns";
            this.panelBtns.Size = new System.Drawing.Size(200, 395);
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
            // SepiaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(682, 395);
            this.Controls.Add(this.panelBtns);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.barAmount);
            this.Controls.Add(this.pictureBox);
            this.Icon = global::ImageEditor.Properties.Resources.AppIcon;
            this.Name = "SepiaForm";
            this.Text = "Sepia";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAmount)).EndInit();
            this.panelBtns.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TrackBar barAmount;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel panelBtns;
        private FontAwesome.Sharp.IconButton icnBtnCancel;
        private FontAwesome.Sharp.IconButton icnBtnApply;
    }
}