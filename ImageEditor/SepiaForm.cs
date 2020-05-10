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
        /// <param name="image">The image which the effect may be applied to</param>
        /// <param name="history">The history of changes</param>
        /// <param name="currentIndex">The index of the image within the history</param>
        public SepiaForm(HistoryImage image, List<HistoryImage> history, int currentIndex )
        {
            InitializeComponent();
            InitializeImage( image, history, currentIndex );
        }

        /// <summary>
        /// Sets the image in the picture box
        /// </summary>
        /// <param name="image">The image which the effect may be applied to</param>
        /// <param name="history">The history of changes</param>
        /// <param name="currentIndex">The index of the image within the history</param>
        private void InitializeImage( HistoryImage image, List<HistoryImage> history, int currentIndex )
        {
            if( image.Image == null )
                return;

            _originalImg = image;
            Img = new HistoryImage( image.Image, new SepiaEffect() );

            // Go over the history up until current index to detect if this effect has already been applied
            // if so then I can use it to set the effect values 
            for( int i = currentIndex; i > 0; --i )
            {
                IImageEffect effect = history[i].Effect;
                if( effect != null && effect is SepiaEffect )
                {
                    ( Img.Effect as SepiaEffect ).Amount = ( effect as SepiaEffect ).Amount;
                    break;
                }
            }

            barAmount.Value = Math.Min((int)( ( Img.Effect as SepiaEffect ).Amount * 100.0f), 100);
            lblAmount.Text = ( Img.Effect as SepiaEffect ).Amount.ToString();
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

            (Img.Effect as SepiaEffect).Amount = amount;
            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;
        }
    }
}
