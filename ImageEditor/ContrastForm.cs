using ImageEditor.ImageEffects;
using System;

namespace ImageEditor
{
    /// <summary>
    /// Form used for adjusting and applying contrast effect to an image
    /// </summary>
    public partial class ContrastForm : EffectFormBase
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ContrastForm( )
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
            Img = new HistoryImage( image.Image, new ContrastEffect() );

            // Use old values if it has already been applied 
            IImageEffect effect = history.HasEffect<ContrastEffect>()?.Effect;
            if( effect != null )
                ( Img.Effect as ContrastEffect ).Amount = ( effect as ContrastEffect ).Amount;

            barAmount.Value = Math.Min((int)( ( Img.Effect as ContrastEffect ).Amount * 100.0f), 100);
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

            (Img.Effect as ContrastEffect).Amount = amount;
            Img.Image = Img.Effect.ApplyEffect( _originalImg.Image );
            pictureBox.Image = Img.Image;

            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
