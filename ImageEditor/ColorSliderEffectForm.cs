using ImageEditor.ImageEffects;
using System;
using System.Drawing;

namespace ImageEditor
{
    /// <summary>
    /// Form used for adjusting and applying Tint effect to an image
    /// </summary>
    public partial class ColorSliderEffectForm<EffectType> : EffectFormBase where EffectType : class, IImageEffect<Color>, new()
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ColorSliderEffectForm()
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

            Img = new HistoryImage( _originalImg.Id, image.Image, new EffectType() );

            // Use old values if it has already been applied 
            EffectType effect = (EffectType)history.HasEffect<TintEffect>()?.Effect;
            if( effect != null )
                ( Img.Effect as EffectType ).SetValue(effect.GetValue());

            effect = Img.Effect as EffectType;

            Color color = effect.GetValue();
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
            EffectType effect = Img.Effect as EffectType;

            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;
        }

        /// <summary>
        /// Sets effect Color based on the scroll bars
        /// </summary>
        private void ColorChanged( object sender, EventArgs e )
        {
            EffectType effect = Img.Effect as EffectType;
            effect.SetValue(Color.FromArgb( barRed.Value, barGreen.Value, barBlue.Value ));

            ApplyEffect();

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
