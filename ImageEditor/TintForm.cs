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
        protected override void InitializeImage( HistoryImage image, HistoryManager history )
        {
            if( image.Image == null )
                return;

            _originalImg = image;
            TintEffect tintEffect = new TintEffect();
            Img = new HistoryImage( image.Image, tintEffect );

            // Use old values if it has already been applied 
            IImageEffect effect = history.HasEffect<TintEffect>()?.Effect;
            if( effect != null )
                ( Img.Effect as TintEffect ).Color = ( effect as TintEffect ).Color;

            TintEffect oldTint = image.Effect as TintEffect;
            barRed.Value = tintEffect.Color.R;
            barGreen.Value = tintEffect.Color.G;
            barBlue.Value = tintEffect.Color.B;

            ApplyEffect();
        }

        /// <summary>
        /// Applies the effect to the image in the pictureBox
        /// </summary>
        private void ApplyEffect()
        {
            TintEffect effect = Img.Effect as TintEffect;

            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;
        }

        /// <summary>
        /// Sets effect Color based on the scroll bars
        /// </summary>
        private void ColorChanged( object sender, EventArgs e )
        {
            TintEffect effect = Img.Effect as TintEffect;
            effect.Color = System.Drawing.Color.FromArgb( barRed.Value, barGreen.Value, barBlue.Value );

            ApplyEffect();
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
