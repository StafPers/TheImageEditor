using ImageEditor.Helper;
using System.Drawing;
using System.Drawing.Imaging;

/// <summary>
/// An effect to adjust the brightness of an image
/// </summary>
namespace ImageEditor.ImageEffects
{
    class BrightnessEffect : IImageEffect
    {
        private float _amount = 0.5f;
        public float Amount { get { return _amount; } set { _amount = MathHelper.Clamp( 0.0f, 1.0f, value ); } }

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            BrightnessEffect newInstance = new BrightnessEffect();
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
            Bitmap brightnessImg = (Bitmap)img.Clone();
            BitmapData data = brightnessImg.LockBits(new Rectangle(0, 0, brightnessImg.Width, brightnessImg.Height), ImageLockMode.ReadWrite, brightnessImg.PixelFormat);

            // 3 or 4 depending on if the image has alpha
            int colWidth = data.Stride / brightnessImg.Width;
            int brightness = (int)MathHelper.Lerp(-255.0f, 255.0f, Amount);

            //I'm using pointers in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                for( int y = 0; y < brightnessImg.Height; ++y )
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for( int x = 0; x < brightnessImg.Width; ++x )
                    {
                        byte b = row[columnOffset];
                        byte g = row[columnOffset + 1];
                        byte r = row[columnOffset + 2];

                        row[columnOffset + 2] = (byte)MathHelper.Clamp( 0, 255, r + brightness );
                        row[columnOffset + 1] = ( byte )MathHelper.Clamp( 0, 255, g + brightness );
                        row[columnOffset] = ( byte )MathHelper.Clamp( 0, 255, b + brightness );

                        columnOffset += colWidth;
                    }
                }
            }

            brightnessImg.UnlockBits( data );
            return brightnessImg;
        }
    }
}
