using ImageEditor.ImageEffects;
using System;
using System.Collections.Generic;

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
        }

        /// <summary>
        /// Sets the image in the picture box
        /// </summary>
        /// <param name="image">The image which the effect may be applied to</param>
        /// <param name="history">The history of changes</param>
        /// <param name="currentIndex">The index of the image within the history</param>
        protected override void InitializeImage( HistoryImage image, List<HistoryImage> history, int currentIndex )
        {
            if( image.Image == null )
                return;

            _originalImg = image;
            Img = new HistoryImage( image.Image, new BrightnessEffect() );

            // Go over the history up until current index to detect if this effect has already been applied
            // if so then I can use it to set the effect values 
            for( int i = currentIndex; i > 0; --i )
            {
                IImageEffect effect = history[i].Effect;
                if( effect != null && effect is BrightnessEffect )
                {
                    ( Img.Effect as BrightnessEffect ).Amount = ( effect as BrightnessEffect ).Amount;
                    break;
                }
            }

            barAmount.Value = Math.Min((int)( ( Img.Effect as BrightnessEffect ).Amount * 100.0f), 100);
            lblAmount.Text = ( Img.Effect as BrightnessEffect ).Amount.ToString();
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

            lblAmount.Text = amount.ToString();

            (Img.Effect as BrightnessEffect).Amount = amount;
            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;
        }
    }
}
