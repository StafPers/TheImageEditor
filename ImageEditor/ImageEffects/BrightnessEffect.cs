using ImageEditor.Helper;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

/// <summary>
/// An effect to adjust the brightness of an image
/// </summary>
namespace ImageEditor.ImageEffects
{
    class BrightnessEffect : IImageEffect<float>
    {
        private float _amount = 0.5f;

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            BrightnessEffect newInstance = new BrightnessEffect();
            newInstance.SetValue(_amount);
            return newInstance;
        }

        public void SetValue(float amount)
        {
            _amount = MathHelper.Clamp( 0.0f, 1.0f, amount );
        }

        public float GetValue() => _amount;

        /// <summary>
        /// Applies the effect to an image
        /// </summary>
        /// <param name="inImg">The image to apply an effect to</param>
        /// <returns>A new image with the effect applied</returns>
        public Bitmap ApplyEffect( Bitmap inImg )
        {
            Bitmap outImg = (Bitmap)inImg.Clone();
            BitmapData outData = outImg.LockBits(new Rectangle(0, 0, outImg.Width, outImg.Height), ImageLockMode.ReadWrite, outImg.PixelFormat);
            int bytesPerPixel = Bitmap.GetPixelFormatSize(outImg.PixelFormat) / 8;
            int height = outData.Height;
            int width = outData.Width * bytesPerPixel;
            int brightness = (int)MathHelper.Lerp(-255.0f, 255.0f, _amount);

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

                        row[x] = ( byte )MathHelper.Clamp( 0, 255, b + brightness );
                        row[x + 1] = ( byte )MathHelper.Clamp( 0, 255, g + brightness );
                        row[x + 2] = ( byte )MathHelper.Clamp( 0, 255, r + brightness );
                    }
                } );
            }

            outImg.UnlockBits( outData );
            return outImg;
        }
    }
}
