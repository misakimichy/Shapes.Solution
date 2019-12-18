namespace Shapes.Models
{
    public class Pyramid
    {
        public int BaseLength { get; set; }
        public int BaseWidth { get; set; }
        public int PyaramidHeight { get; set; }
        public Pyramid(int baseLength, int baseWidth, int pyaramidHeight)
        {
            BaseLength = baseLength;
            BaseWidth = baseWidth;
            PyaramidHeight = pyaramidHeight;
        }

        public int GetVolume()
        {
            return (BaseLength * BaseWidth * PyaramidHeight) / 3;
        }
    }
}