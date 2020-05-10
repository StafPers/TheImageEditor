using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEditor.ImageEffects
{
    class InverseEffect : IImageEffect
    {
        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            return new InverseEffect();
        }

        /// <summary>
        /// Applies the effect to an image
        /// </summary>
        /// <param name="img">The image to apply an effect to</param>
        /// <returns>A new image with the effect applied</returns>
        public Bitmap ApplyEffect( Bitmap img )
        {
            Bitmap inverseImg = (Bitmap)img.Clone();
            BitmapData data = inverseImg.LockBits(new Rectangle(0, 0, inverseImg.Width, inverseImg.Height), ImageLockMode.ReadWrite, inverseImg.PixelFormat);

            // 3 or 4 depending on if the image has alpha
            int colWidth = data.Stride / inverseImg.Width;

            //I'm using pointers in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                for( int y = 0; y < inverseImg.Height; ++y )
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for( int x = 0; x < inverseImg.Width; ++x )
                    {
                        row[columnOffset] = (byte)(255 - row[columnOffset]);
                        row[columnOffset + 1] = ( byte )( 255 - row[columnOffset + 1] );
                        row[columnOffset + 2] = ( byte )( 255 - row[columnOffset + 2] );

                        columnOffset += colWidth;
                    }
                }
            }

            inverseImg.UnlockBits( data );
            return inverseImg;
        }
    }
}
