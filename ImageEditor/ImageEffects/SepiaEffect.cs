﻿using ImageEditor.Helper;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;

namespace ImageEditor.ImageEffects
{
    class SepiaEffect : IImageEffect<float>
    {
        private float _amount = 1.0f;

        /// <summary>
        /// Creates a copy of the instance
        /// </summary>
        public object Clone()
        {
            SepiaEffect newInstance = new SepiaEffect();
            newInstance.SetValue(_amount);
            return newInstance;
        }

        public void SetValue( float amount )
        {
            _amount = MathHelper.Clamp( 0.0f, 1.0f, amount );
        }

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
                        byte oldB = row[x];
                        byte oldG = row[x + 1];
                        byte oldR = row[x + 2];

                        float remainder = 1.0f - _amount;
                        int r = Math.Min(255, (int)((((oldR * 0.393f) + (oldG * 0.769f) + (oldB * 0.189f)) *  _amount) + (oldR * remainder)));
                        int g = Math.Min(255, (int)((((oldR * 0.349f) + (oldG * 0.686f) + (oldB * 0.168f)) *  _amount) + (oldG * remainder)));
                        int b = Math.Min(255, (int)((((oldR * 0.272f) + (oldG * 0.534f) + (oldB * 0.131f)) *  _amount) + (oldB * remainder)));

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
