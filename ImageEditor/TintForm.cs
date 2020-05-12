using ImageEditor.ImageEffects;
using System;
using System.Drawing;

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
            TintEffect tintEffect = new TintEffect();
            Img = new HistoryImage( _originalImg.Id, image.Image, tintEffect );

            // Use old values if it has already been applied 
            IImageEffect effect = history.HasEffect<TintEffect>()?.Effect;
            if( effect != null )
                ( Img.Effect as TintEffect ).SetValue(( effect as TintEffect ).GetValue());

            TintEffect oldTint = image.Effect as TintEffect;
            Color color = tintEffect.GetValue();
            barRed.Value = color.R;
            barGreen.Value = color.G;
            barBlue.Value = color.B;

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
            effect.SetValue(Color.FromArgb( barRed.Value, barGreen.Value, barBlue.Value ));

            ApplyEffect();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
