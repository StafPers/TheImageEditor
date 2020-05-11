using ImageEditor.Helper;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace ImageEditor.ImageEffects
{
    class ContrastEffect : IImageEffect
    {
        private float _amount = 0.5f;
        public float Amount { get { return _amount; } set { _amount = MathHelper.Clamp( 0.0f, 1.0f, value ); } }

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            ContrastEffect newInstance = new ContrastEffect();
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
                        byte b = row[x];
                        byte g = row[x + 1];
                        byte r = row[x + 2];

                        row[x + 2] = ( byte )MathHelper.Clamp( 0, 255, ( int )( correctionFactor * ( r - 128.0f ) + 128.0f ) );
                        row[x + 1] = ( byte )MathHelper.Clamp( 0, 255, ( int )( correctionFactor * ( g - 128.0f ) + 128.0f ) );
                        row[x] = ( byte )MathHelper.Clamp( 0, 255, ( int )( correctionFactor * ( b - 128.0f ) + 128.0f ) );
                    }
                } );
            }

            outImg.UnlockBits( outData );
            return outImg;
        }
    }
}
