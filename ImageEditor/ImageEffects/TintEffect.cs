using ImageEditor.Helper;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace ImageEditor.ImageEffects
{
    class TintEffect : IImageEffect<Color>
    {
        private Color _color;

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            TintEffect newInstance = new TintEffect();
            newInstance.SetValue(_color);
            return newInstance;
        }

        public void SetValue( Color color )
        {
            _color = color;
        }

        public Color GetValue() => _color;

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

                        row[x + 2] = Math.Min( ( byte )255, ( byte )( r + ( ( 255 - r ) * ( _color.R / 255.0f ) ) ) );
                        row[x + 1] = Math.Min( ( byte )255, ( byte )( g + ( ( 255 - g ) * ( _color.G / 255.0f ) ) ) );
                        row[x] = Math.Min( ( byte )255, ( byte )( b + ( ( 255 - b ) * ( _color.B / 255.0f ) ) ) );
                    }
                } );
            }

            outImg.UnlockBits( outData );
            return outImg;
        }
    }
}
