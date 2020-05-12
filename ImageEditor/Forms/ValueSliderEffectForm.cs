using ImageEditor.ImageEffects;
using System;

// I had many forms with the same design and almost exactly the same functionality
// so I decided to take a template approach in order to reduce repetition
namespace ImageEditor
{
    /// <summary>
    /// Form used for adjusting and applying effects with a float value parameter to an image
    /// </summary>
    public partial class ValueSliderEffectForm<EffectType> : EffectFormBase where EffectType : class, IImageEffect<float>, new()
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ValueSliderEffectForm()
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

            _startImage = history.PreviewRemovedEffect<EffectType>();
            Img = new HistoryImage(_startImage.Id, _startImage.Image, new EffectType());

            // Use old values if it has already been applied 
            EffectType effect = (EffectType)history.HasEffect<EffectType>()?.Effect;
            if( effect != null)
                ( Img.Effect as EffectType ).SetValue(effect.GetValue());

            barAmount.Value = Math.Min((int)( ( Img.Effect as EffectType ).GetValue() * 100.0f), 100);

            Img.Image = Img.Effect.ApplyEffect(_startImage.Image);

            pictureBox.Image = Img.Image;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /// <summary>
        /// Sets effect Amount based on the scrollbar
        /// Updates the label
        /// </summary>
        private void barAmount_Scroll( object sender, EventArgs e )
        {
            float amount = barAmount.Value / 100.0f;

            (Img.Effect as EffectType).SetValue(amount);
            Img.Image = Img.Effect.ApplyEffect(_startImage.Image);
            pictureBox.Image = Img.Image;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
