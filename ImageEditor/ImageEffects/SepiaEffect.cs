using ImageEditor.Helper;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEditor.ImageEffects
{
    class SepiaEffect : IImageEffect
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
                _amount = MathHelper.Clamp(0.0f, 1.0f, value);
            }
        }

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            SepiaEffect newInstance = new SepiaEffect();
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
            Bitmap sepiaImg = (Bitmap)img.Clone();
            BitmapData data = sepiaImg.LockBits(new Rectangle(0, 0, sepiaImg.Width, sepiaImg.Height), ImageLockMode.ReadWrite, sepiaImg.PixelFormat);

            // 3 or 4 depending on if the image has alpha
            int colWidth = data.Stride / sepiaImg.Width;

            //I'm using pointers in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                for( int y = 0; y < sepiaImg.Height; ++y )
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for( int x = 0; x < sepiaImg.Width; ++x )
                    {
                        byte oldB = row[columnOffset];
                        byte oldG = row[columnOffset + 1];
                        byte oldR = row[columnOffset + 2];

                        int r = Math.Min(255, (int)((((oldR * 0.393f) + (oldG * 0.769f) + (oldB * 0.189f)) *  Amount) + (oldR * (1.0f - Amount))));
                        int g = Math.Min(255, (int)((((oldR * 0.349f) + (oldG * 0.686f) + (oldB * 0.168f)) *  Amount) + (oldG * (1.0f - Amount))));
                        int b = Math.Min(255, (int)((((oldR * 0.272f) + (oldG * 0.534f) + (oldB * 0.131f)) *  Amount) + (oldB * (1.0f - Amount))));

                        row[columnOffset] = ( byte )b;
                        row[columnOffset + 1] = ( byte )g;
                        row[columnOffset + 2] = ( byte )r;

                        columnOffset += colWidth;
                    }
                }
            }

            sepiaImg.UnlockBits( data );
            return sepiaImg;
        }
    }
}
