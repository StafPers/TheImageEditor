﻿using ImageEditor.ImageEffects;
using System;

namespace ImageEditor
{
    /// <summary>
    /// Form used for adjusting and applying grayscale effect to an image
    /// </summary>
    public partial class GrayscaleForm : EffectFormBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GrayscaleForm()
        {
            InitializeComponent();
            icnBtnApply.Click += Apply_Click;
            icnBtnCancel.Click += Cancel_Click;
        }

        /// <summary>
        /// Sets the image in the picture box
        /// </summary>
        /// <param name="image">The image which the effect may be applied to</param>
        /// <param name="history">The history of changes</param>
        /// <param name="currentIndex">The index of the image within the history</param>
        protected override void InitializeImage( HistoryImage image, HistoryManager history )
        {
            if( image.Image == null )
                return;

            _originalImg = image;
            Img = new HistoryImage( _originalImg.Id, image.Image, new GrayscaleEffect() );

            // Use old values if it has already been applied 
            IImageEffect effect = history.HasEffect<GrayscaleEffect>()?.Effect;
            if( effect != null )
                ( Img.Effect as GrayscaleEffect ).Amount = ( effect as GrayscaleEffect ).Amount;

            barAmount.Value = Math.Min((int)( ( Img.Effect as GrayscaleEffect ).Amount * 100.0f), 100);
            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;
        }

        /// <summary>
        /// Sets effect Amount based on the scrollbar
        /// Updates the label
        /// </summary>
        private void barAmount_Scroll( object sender, EventArgs e )
        {
            float amount = barAmount.Value / 100.0f;

            (Img.Effect as GrayscaleEffect).Amount = amount;
            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
