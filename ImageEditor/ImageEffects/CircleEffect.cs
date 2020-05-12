using ImageEditor.Helper;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace ImageEditor.ImageEffects
{
    class CircleEffect : IImageEffect<float>
    {
        private float _radiusFactor = 1.0f;
        private const int _minRadius = 10;

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            CircleEffect newInstance = new CircleEffect();
            newInstance.SetValue( _radiusFactor );
            return newInstance;
        }

        /// <summary>
        /// Setter for _amount
        /// </summary>
        public void SetValue( float amount )
        {
            _radiusFactor = MathHelper.Clamp( 0.0f, 1.0f, amount );
        }

        /// <summary>
        /// Getter for _amount
        /// </summary>
        public float GetValue() => _radiusFactor;

        /// <summary>
        /// Applies the effect to an image
        /// </summary>
        /// <param name="img">The image to apply an effect to</param>
        /// <returns>A new image with the effect applied</returns>
        public Bitmap ApplyEffect( Bitmap img )
        {
            Bitmap circleImg = (Bitmap)img.Clone();
            BitmapData outData = circleImg.LockBits(new Rectangle(0, 0, circleImg.Width, circleImg.Height), ImageLockMode.ReadWrite, circleImg.PixelFormat);

            int bytesPerPixel = Bitmap.GetPixelFormatSize(circleImg.PixelFormat) / 8;

            int height = circleImg.Height;
            int width = outData.Width * bytesPerPixel;

            // I've tried to optimize effects since they can be pretty slow
            // That's why I'm bitshifting instead of dividing since it's a few less instructions
            int centerX = circleImg.Width >> 1;
            int centerY = height >> 1;

            int radius = (int)MathHelper.Lerp(_minRadius, Math.Min(circleImg.Width, height) >> 1, _radiusFactor);
            int radiusSq = radius * radius;

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
                        int deltaX = centerX - x / bytesPerPixel;
                        int deltaY = centerY - y;

                        if( ( deltaX * deltaX ) + ( deltaY * deltaY ) > radiusSq )
                        {
                            row[x] = 255;
                            row[x + 1] = 255;
                            row[x + 2] = 255;
                        }
                    }
                } );
            }

            circleImg.UnlockBits( outData );
            return circleImg;
        }
    }
}
