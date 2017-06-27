using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Formats;
using AForge.Imaging.Filters;
using AForge.Imaging;
using System.Drawing;

namespace WindowGram
{
    public class GrayFilter : ImageFilter
    {
        public Bitmap processedImage;

        public Bitmap GFilter()
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);
            processedImage = filter.Apply(image);
            return processedImage;
        }
    }
}