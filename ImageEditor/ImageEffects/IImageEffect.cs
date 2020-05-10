using System;
using System.Drawing;

namespace ImageEditor.ImageEffects
{
    /// <summary>
    /// Interface used for creating ImageEffects
    /// </summary>
    public interface IImageEffect : ICloneable
    {
        Bitmap ApplyEffect( Bitmap image );
    }
}
