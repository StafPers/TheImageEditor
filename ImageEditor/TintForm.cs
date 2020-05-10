using ImageEditor.ImageEffects;
using System;
using System.Collections.Generic;

namespace ImageEditor
{
    /// <summary>
    /// Form used for adjusting and applying Tint effect to an image
    /// </summary>
    public partial class TintForm : EffectFormBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public TintForm()
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
            TintEffect tintEffect = new TintEffect();
            Img = new HistoryImage( image.Image, tintEffect );

            // Go over the history up until current index to detect if this effect has already been applied
            // if so then I can use it to set the effect values 
            for( int i = currentIndex; i > 0; --i )
            {
                IImageEffect effect = history[i].Effect;
                if( effect != null && effect is TintEffect )
                {
                    tintEffect.Color = (effect as TintEffect).Color;
                    break;
                }
            }

            TintEffect oldTint = image.Effect as TintEffect;
            barRed.Value = tintEffect.Color.R;
            barGreen.Value = tintEffect.Color.G;
            barBlue.Value = tintEffect.Color.B;

            ApplyEffect();
        }

        /// <summary>
        /// Applies the effect to the image in the pictureBox
        /// Updates the labels
        /// </summary>
        private void ApplyEffect()
        {
            TintEffect effect = Img.Effect as TintEffect;

            lblRedVal.Text = effect.Color.R.ToString();
            lblGreenVal.Text = effect.Color.G.ToString();
            lblBlueVal.Text = effect.Color.B.ToString();

            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;
        }

        /// <summary>
        /// Sets effect Color based on the scroll bars
        /// Updates the label
        /// </summary>
        private void ColorChanged( object sender, EventArgs e )
        {
            TintEffect effect = Img.Effect as TintEffect;
            effect.Color = System.Drawing.Color.FromArgb( barRed.Value, barGreen.Value, barBlue.Value );

            ApplyEffect();
        }
    }
}
