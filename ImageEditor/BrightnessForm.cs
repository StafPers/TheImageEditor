using ImageEditor.ImageEffects;
using System;

namespace ImageEditor
{
    /// <summary>
    /// Form used for adjusting and applying Brightness effect to an image
    /// </summary>
    public partial class BrightnessForm : EffectFormBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public BrightnessForm()
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
            Img = new HistoryImage( image.Image, new BrightnessEffect() );

            // Use old values if it has already been applied 
            IImageEffect effect = history.HasEffect<BrightnessEffect>()?.Effect;
            if( effect != null)
                ( Img.Effect as BrightnessEffect ).Amount = ( effect as BrightnessEffect ).Amount;

            barAmount.Value = Math.Min((int)( ( Img.Effect as BrightnessEffect ).Amount * 100.0f), 100);
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

            (Img.Effect as BrightnessEffect).Amount = amount;
            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;
        }
    }
}
