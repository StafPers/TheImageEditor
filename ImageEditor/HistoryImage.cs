using ImageEditor.ImageEffects;
using System;
using System.Drawing;

namespace ImageEditor
{
    /// <summary>
    /// Used to represent an image with effects
    /// Has the image, the effect applied on it and a flag to check if the image has been saved
    /// </summary>
    public class HistoryImage : ICloneable
    {
        public Bitmap Image { get; set; }
        public IImageEffect Effect { get; private set; }
        public bool IsSaved { get; set; }
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="image">The image</param>
        /// <param name="effect">The effect</param>
        /// <param name="isSaved">Flag if it's been saved</param>
        public HistoryImage(Bitmap image, IImageEffect effect = null, bool isSaved = false)
        {
            Image = image;
            Effect = effect;
            IsSaved = isSaved;
        }

        /// <summary>
        /// Returns a copy of the instance
        /// </summary>
        public object Clone()
        {
            return new HistoryImage((Bitmap)Image.Clone(), Effect != null ? (IImageEffect)Effect.Clone() : null, IsSaved);
        }
    }
}
