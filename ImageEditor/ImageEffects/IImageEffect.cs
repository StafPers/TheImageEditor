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

    /// <summary>
    /// Interface used for effects which has some sort of parameter like Amount or Color
    /// </summary>
    /// <typeparam name="T">The datatype of the parameter</typeparam>
    public interface IImageEffect<T> : IImageEffect
    {
        void SetValue( T val );
        T GetValue();
    }
}
