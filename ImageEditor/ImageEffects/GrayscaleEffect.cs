using ImageEditor.Helper;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEditor.ImageEffects
{
    class GrayscaleEffect : IImageEffect
    {
        private float _amount = 1.0f;
        public float Amount
        {
            get
            {
                return _amount;
            }

            set
            {
                _amount = MathHelper.Clamp( 0.0f, 1.0f, value );
            }
        }

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            GrayscaleEffect newInstance = new GrayscaleEffect();
            newInstance.Amount = Amount;
            return newInstance;
        }

        /// <summary>
        /// Applies the effect to an image
        /// </summary>
        /// <param name="img">The image to apply an effect to</param>
        /// <returns>A new image with the effect applied</returns>
        public Bitmap ApplyEffect( Bitmap img )
        {
            Bitmap grayImg = (Bitmap)img.Clone();
            BitmapData data = grayImg.LockBits(new Rectangle(0, 0, grayImg.Width, grayImg.Height), ImageLockMode.ReadWrite, grayImg.PixelFormat);

            // 3 or 4 depending on if the image has alpha
            int colWidth = data.Stride / grayImg.Width;

            //I'm using pointers in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                for( int y = 0; y < grayImg.Height; ++y )
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for( int x = 0; x < grayImg.Width; ++x )
                    {
                        byte b = row[columnOffset];
                        byte g = row[columnOffset + 1];
                        byte r = row[columnOffset + 2];

                        int avg = (int)(r * 0.3 + g * 0.59 + b * 0.11);
                        avg = Math.Min( 255, avg );

                        row[columnOffset] = ( byte )Math.Min( ( avg * Amount ) + ( b * ( 1.0f - Amount ) ), 255 );
                        row[columnOffset + 1] = ( byte )Math.Min( ( avg * Amount ) + ( g * ( 1.0f - Amount ) ), 255 );
                        row[columnOffset + 2] = ( byte )Math.Min( ( avg * Amount ) + ( r * ( 1.0f - Amount ) ), 255 );

                        columnOffset += colWidth;
                    }
                }
            }

            grayImg.UnlockBits( data );
            return grayImg;
        }
    }
}
