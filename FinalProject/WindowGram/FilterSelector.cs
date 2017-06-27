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
    public class FilterSelector : ImageFilter
    {
        public static FilterBox Select(string name)
        {
            switch (name)
            {
                case "GrayFilter":
                    return new GrayFilter();

                default:
                    return new GrayFilter();
            }
        }
    }
}