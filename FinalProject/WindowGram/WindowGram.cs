using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Imaging.Formats;
using AForge.Imaging.Filters;
using AForge.Imaging;

namespace WindowGram
{
    public partial class WindowGram : Form
    {
        public WindowGram()
        {
            InitializeComponent();
        }

        public Bitmap processedImage;

        private void loadImageButton_Click(object sender, EventArgs e)
        {
            ImageFilter originImage = new ImageFilter();
            originPictureBox.Image = originImage.GetImage();
        }

        private void applyFilterButtom_Click(object sender, EventArgs e)
        {
            string selectedFilter = filterSelector.Items[filterSelector.SelectedIndex].ToString();
        }

        private void saveImageButton_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "NewImage.bmp";
            saveFileDialog.Filter = "Bitmap file(*.bmp)|*.bmp";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                processedImage.Save(saveFileDialog.FileName);
            }
        }
    }
}