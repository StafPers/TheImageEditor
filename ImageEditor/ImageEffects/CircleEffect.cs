using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageEditor.ImageEffects
{
    class CircleEffect : IImageEffect
    {
        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            return new CircleEffect();
        }

        /// <summary>
        /// Applies the effect to an image
        /// </summary>
        /// <param name="img">The image to apply an effect to</param>
        /// <returns>A new image with the effect applied</returns>
        public Bitmap ApplyEffect( Bitmap img )
        {
            Bitmap circleImg = (Bitmap)img.Clone();
            BitmapData data = circleImg.LockBits(new Rectangle(0, 0, circleImg.Width, circleImg.Height), ImageLockMode.ReadWrite, circleImg.PixelFormat);

            int radius = Math.Min(circleImg.Width, circleImg.Height) / 2;
            int radiusSq = radius * radius;
            int centerX = circleImg.Width / 2;
            int centerY = circleImg.Height / 2;

            // 3 or 4 depending on if the image has alpha
            int colWidth = data.Stride / circleImg.Width;

            //I'm using pointers in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                for( int y = 0; y < circleImg.Height; ++y )
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for( int x = 0; x < circleImg.Width; ++x )
                    {
                        int deltaX = centerX - x;
                        int deltaY = centerY - y;

                        if((deltaX * deltaX) + (deltaY * deltaY) > radiusSq)
                        {
                            row[columnOffset] = 255;
                            row[columnOffset + 1] = 255;
                            row[columnOffset + 2] = 255;
                        }

                        columnOffset += colWidth;
                    }
                }
            }

            circleImg.UnlockBits( data );
            return circleImg;
        }
    }
}
