namespace ImageEditor.Helper
{
    /// <summary>
    /// A helper class with math functions missing from Math
    /// </summary>
    public static class MathHelper
    {
        /// <summary>
        /// Linear interpolation
        /// </summary>
        /// <param name="start">start value of interpolation</param>
        /// <param name="end">end value of interpolation</param>
        /// <param name="fraction">fraction to interpolate 0.0f-1.0f</param>
        /// <returns></returns>
        public static float Lerp(float start, float end, float fraction)
        {
            return start + ( ( end - start ) * Clamp(0.0f, 1.0f, fraction) );
        }

        /// <summary>
        /// Clamps a value between min and max
        /// </summary>
        /// <param name="min">min value</param>
        /// <param name="max">max value</param>
        /// <param name="val">the value to clamp</param>
        /// <returns>The clamped value</returns>
        public static float Clamp(float min, float max, float val)
        {
            return val < min ? min : val > max ? max : val;
        }

        /// <summary>
        /// Clamps a value between min and max
        /// </summary>
        /// <param name="min">min value</param>
        /// <param name="max">max value</param>
        /// <param name="val">the value to clamp</param>
        /// <returns>The clamped value</returns>
        public static int Clamp( int min, int max, int val )
        {
            return val < min ? min : val > max ? max : val;
        }

        /// <summary>
        /// Clamps a value between min and max
        /// </summary>
        /// <param name="min">min value</param>
        /// <param name="max">max value</param>
        /// <param name="val">the value to clamp</param>
        /// <returns>The clamped value</returns>
        public static byte Clamp( byte min, byte max, byte val )
        {
            return val < min ? min : val > max ? max : val;
        }
    }
}
