using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public class Scene
    {
        public int Number;

        public PictureBox TargetPictureBox;

        public Scene(PictureBox target)                             //建構場景時:
        {
            this.Number = 1;
            this.TargetPictureBox = target;
            this.TargetPictureBox.Image = this.GetImage();          //這個的目標picturebox的image=這個getimage()
        }

        public Image GetImage()
        {
            if (this.Number == 1)
                return global::Example01.Properties.Resources._1;   //C# Resource Image Array 簡化
            else if (this.Number == 2)
                return global::Example01.Properties.Resources._2;
            else if (this.Number == 3)
                return global::Example01.Properties.Resources._3;
            else if (this.Number == 4)
                return global::Example01.Properties.Resources._4;
            else if (this.Number == 5)
                return global::Example01.Properties.Resources._5;
            else if (this.Number == 6)
                return global::Example01.Properties.Resources._6;
            else if (this.Number == 7)
                return global::Example01.Properties.Resources._7;
            else if (this.Number == 8)
                return global::Example01.Properties.Resources._8;
            else if (this.Number == 9)
                return global::Example01.Properties.Resources._9;
            else
                return global::Example01.Properties.Resources._10;
        }

        public void ChangeTo(int target)
        {
            this.Number = target;
            this.TargetPictureBox.Image = this.GetImage();
        }
    }
}