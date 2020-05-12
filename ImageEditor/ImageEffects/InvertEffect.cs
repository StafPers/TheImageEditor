using ImageEditor.Helper;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace ImageEditor.ImageEffects
{
    class InvertEffect : IImageEffect<float>
    {
        private float _amount = 1.0f;

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            InvertEffect newInstance = new InvertEffect();
            newInstance.SetValue( _amount );
            return newInstance;
        }

        /// <summary>
        /// Setter for _amount
        /// </summary>
        public void SetValue( float amount )
        {
            _amount = MathHelper.Clamp( 0.0f, 1.0f, amount );
        }

        /// <summary>
        /// Getter for _amount
        /// </summary>
        public float GetValue() => _amount;

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

            //I'm using pointers and parallel in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                byte* ptr0 = (byte*)outData.Scan0;
                Parallel.For( 0, height, y =>
                {
                    byte* row = ptr0 + (y * outData.Stride);
                    for( int x = 0; x < width; x += bytesPerPixel )
                    {
                        int invB = 255 - row[x];
                        int invG = 255 - row[x + 1];
                        int invR = 255 - row[x + 2];

                        row[x] = ( byte )(MathHelper.Lerp(row[x], invB, _amount));
                        row[x + 1] = ( byte )( MathHelper.Lerp( row[x + 1], invG, _amount ) );
                        row[x + 2] = ( byte )( MathHelper.Lerp( row[x + 2], invR, _amount ) );
                    }
                } );
            }

            outImg.UnlockBits( outData );
            return outImg;
        }
    }
}
