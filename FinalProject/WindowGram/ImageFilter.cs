using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AForge.Imaging.Formats;
using AForge.Imaging.Filters;
using AForge.Imaging;
using System.Windows.Forms;

namespace WindowGram
{
    public class ImageFilter
    {
        public OpenFileDialog openFileDialog = new OpenFileDialog();

        public Bitmap image;

        public Bitmap GetImage()
        {
            openFileDialog.Filter = "所有檔案(*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = ImageDecoder.DecodeFromFile(openFileDialog.FileName);
            }
            return image;
        }
    }
}