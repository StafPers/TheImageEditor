using ImageEditor.Helper;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

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
        public Bitmap ApplyEffect( Bitmap inImg )
        {
            Bitmap outImg = (Bitmap)inImg.Clone();
            BitmapData outData = outImg.LockBits(new Rectangle(0, 0, outImg.Width, outImg.Height), ImageLockMode.ReadWrite, outImg.PixelFormat);
            int bytesPerPixel = Bitmap.GetPixelFormatSize(outImg.PixelFormat) / 8;
            int height = outData.Height;
            int width = outData.Width * bytesPerPixel;
            int contrast = (int)MathHelper.Lerp(-255.0f, 255.0f, Amount);
            float correctionFactor = (259.0f * (255.0f + contrast)) / (255.0f * (259.0f - contrast));

            //I'm using pointers in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                byte* ptr0 = (byte*)outData.Scan0;
                Parallel.For( 0, height, y =>
                {
                    byte* row = ptr0 + (y * outData.Stride);
                    for( int x = 0; x < width; x += bytesPerPixel )
                    {
                        byte oldB = row[x];
                        byte oldG = row[x + 1];
                        byte oldR = row[x + 2];

                        int r = Math.Min(255, (int)((((oldR * 0.393f) + (oldG * 0.769f) + (oldB * 0.189f)) *  Amount) + (oldR * (1.0f - Amount))));
                        int g = Math.Min(255, (int)((((oldR * 0.349f) + (oldG * 0.686f) + (oldB * 0.168f)) *  Amount) + (oldG * (1.0f - Amount))));
                        int b = Math.Min(255, (int)((((oldR * 0.272f) + (oldG * 0.534f) + (oldB * 0.131f)) *  Amount) + (oldB * (1.0f - Amount))));

                        row[x] = ( byte )b;
                        row[x + 1] = ( byte )g;
                        row[x + 2] = ( byte )r;
                    }
                } );
            }

            outImg.UnlockBits( outData );
            return outImg;
        }
    }
}
