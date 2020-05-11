using ImageEditor.ImageEffects;
using System;
using System.Collections.Generic;

namespace ImageEditor
{
    /// <summary>
    /// Form used for adjusting and applying Sepia effect to an image
    /// </summary>
    public partial class SepiaForm : EffectFormBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SepiaForm( )
        {
            InitializeComponent();
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
            Img = new HistoryImage( image.Image, new SepiaEffect() );

            // Use old values if it has already been applied 
            IImageEffect effect = history.HasEffect<SepiaEffect>()?.Effect;
            if( effect != null )
                ( Img.Effect as SepiaEffect ).Amount = ( effect as SepiaEffect ).Amount;

            barAmount.Value = Math.Min((int)( ( Img.Effect as SepiaEffect ).Amount * 100.0f), 100);
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

            (Img.Effect as SepiaEffect).Amount = amount;
            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;
        }

        private void icnBtnApply_Click( object sender, EventArgs e )
        {
            OnEffectApplied();
        }

        private void icnBtnCancel_Click( object sender, EventArgs e )
        {
            onEffectCanceled();
        }
    }
}
