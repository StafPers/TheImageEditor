using System;
using System.Windows.Forms;

namespace ImageEditor
{
    /// <summary>
    /// Base form for effectforms. Contains some common functionality
    /// </summary>
    public class EffectFormBase : Form
    {
        // All effects has apply and cancel button so events for them are stored here
        public event EventHandler<EffectAppliedEventArgs> EffectApplied;
        public event EventHandler EffectCanceled;

        protected HistoryImage _originalImg;
        public HistoryImage Img { get; protected set; }

        /// <summary>
        /// Event handler for Apply button
        /// </summary>
        protected virtual void OnEffectApplied()
        {
            EffectApplied?.Invoke( this, new EffectAppliedEventArgs() { Image = Img } );
        }

        /// <summary>
        /// Event handler for cancel button
        /// </summary>
        protected virtual void onEffectCanceled()
        {
            EffectCanceled?.Invoke( this, EventArgs.Empty );
        }

        /// <summary>
        /// Sets up form and shows it
        /// <param name="image">The image which the effect may be applied to</param>
        /// <param name="history">The history of changes</param>
        /// <param name="currentIndex">The index of the image within the history</param>
        /// </summary>
        public void ShowForm( HistoryImage image, HistoryManager history )
        {
            InitializeImage( image, history );
            Show();
        }

        /// <summary>
        /// Used to initialize an image with the forms effect
        /// </summary>
        protected virtual void InitializeImage( HistoryImage image, HistoryManager history ) { }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // EffectFormBase
            // 
            ClientSize = new System.Drawing.Size(284, 261);
            Name = "EffectFormBase";
            ResumeLayout(false);
        }


        protected void Apply_Click( object sender, EventArgs e )
        {
            OnEffectApplied();
        }

        protected void Cancel_Click( object sender, EventArgs e )
        {
            onEffectCanceled();
        }
    }

    /// <summary>
    /// Event args for when an effect is applied
    /// </summary>
    public class EffectAppliedEventArgs : EventArgs
    {
        public HistoryImage Image { get; set; }
    }
}
