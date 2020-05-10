using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEditor.ImageEffects
{
    class TintEffect : IImageEffect
    {
        public Color Color { get; set; }

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            TintEffect newInstance = new TintEffect();
            newInstance.Color = Color;
            return newInstance;
        }

        /// <summary>
        /// Applies the effect to an image
        /// </summary>
        /// <param name="img">The image to apply an effect to</param>
        /// <returns>A new image with the effect applied</returns>
        public Bitmap ApplyEffect( Bitmap img )
        {
            Bitmap tintedImg = (Bitmap)img.Clone();
            BitmapData data = tintedImg.LockBits(new Rectangle(0, 0, tintedImg.Width, tintedImg.Height), ImageLockMode.ReadWrite, tintedImg.PixelFormat);

            // 3 or 4 depending on if the image has alpha
            int colWidth = data.Stride / tintedImg.Width;

            //I'm using pointers in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                for( int y = 0; y < tintedImg.Height; ++y )
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for( int x = 0; x < tintedImg.Width; ++x )
                    {
                        byte b = row[columnOffset];
                        byte g = row[columnOffset + 1];
                        byte r = row[columnOffset + 2];

                        row[columnOffset + 2] = Math.Min((byte)255, ( byte )( r + ( ( 255 - r ) * ( Color.R / 255.0f ))));
                        row[columnOffset + 1] = Math.Min((byte)255, ( byte )( g + ( ( 255 - g ) * ( Color.G / 255.0f ))));
                        row[columnOffset] = Math.Min((byte)255, ( byte )( b + (( 255 - b ) * (Color.B / 255.0f ))));

                        columnOffset += colWidth;
                    }
                }
            }

            tintedImg.UnlockBits( data );
            return tintedImg;
        }
    }
}
