using ImageEditor.Helper;
using System.Drawing;
using System.Drawing.Imaging;

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
        public Bitmap ApplyEffect( Bitmap img )
        {
            Bitmap contrastImg = (Bitmap)img.Clone();
            BitmapData data = contrastImg.LockBits(new Rectangle(0, 0, contrastImg.Width, contrastImg.Height), ImageLockMode.ReadWrite, contrastImg.PixelFormat);

            // 3 or 4 depending on if the image has alpha
            int colWidth = data.Stride / contrastImg.Width;
            int contrast = (int)MathHelper.Lerp(-255.0f, 255.0f, Amount);
            float correctionFactor = (259.0f * (255.0f + contrast)) / (255.0f * (259.0f - contrast));

            //I'm using pointers in these functions because GetPixel and SetPixel are way to slow
            //to be useable since I'm using sliders which causes this function to be called frequently
            unsafe
            {
                for( int y = 0; y < contrastImg.Height; ++y )
                {
                    byte* row = (byte*)data.Scan0 + (y * data.Stride);
                    int columnOffset = 0;
                    for( int x = 0; x < contrastImg.Width; ++x )
                    {
                        byte b = row[columnOffset];
                        byte g = row[columnOffset + 1];
                        byte r = row[columnOffset + 2];

                        row[columnOffset + 2] = (byte)MathHelper.Clamp(0, 255, (int)(correctionFactor * ( r - 128.0f ) + 128.0f));
                        row[columnOffset + 1] = ( byte )MathHelper.Clamp( 0, 255, ( int )( correctionFactor * ( g - 128.0f ) + 128.0f ) );
                        row[columnOffset] = ( byte )MathHelper.Clamp( 0, 255, ( int )( correctionFactor * ( b - 128.0f ) + 128.0f ) );

                        columnOffset += colWidth;
                    }
                }
            }

            contrastImg.UnlockBits( data );
            return contrastImg;
        }
    }
}
