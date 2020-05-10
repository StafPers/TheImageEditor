using ImageEditor.ImageEffects;
using System;
using System.Drawing;

namespace ImageEditor
{
    public class HistoryImage : ICloneable
    {
        public Bitmap Image { get; set; }
        public IImageEffect Effect { get; private set; }
        public bool IsSaved { get; set; }
        
        public HistoryImage(Bitmap image, IImageEffect effect = null, bool isSaved = false)
        {
            Image = image;
            Effect = effect;
            IsSaved = isSaved;
        }

        public object Clone()
        {
            return new HistoryImage((Bitmap)Image.Clone(), Effect != null ? (IImageEffect)Effect.Clone() : null, IsSaved);
        }
    }
}
