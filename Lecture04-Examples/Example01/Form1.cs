using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example01
{
    public partial class Form1 : Form
    {
        private Scene currentScene;

        public Form1()
        {
            InitializeComponent();
            this.currentScene = new Scene(this.scenePictureBox);
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(1);                                      //按下按鈕後，將這個Form的scene的picturebox變為圖片1
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            this.MakeDecision(2);
        }

        private void MakeDecision(int decision)                        //case number對應scene number也對應到圖片number，
                                                                       //所以劇情的順序並不會按照case number的順序
        {
            switch (this.currentScene.Number)
            {
                case 1:
                    this.currentScene.ChangeTo(2);
                    break;

                case 2:
                    if (decision == 1)
                    {
                        this.currentScene.ChangeTo(10);
                        MessageBox.Show("GG惹");
                    }
                    else
                        this.currentScene.ChangeTo(8);
                    break;

                case 8:
                    if (decision == 1)

                        this.currentScene.ChangeTo(9);
                    else
                    {
                        this.currentScene.ChangeTo(10);
                        MessageBox.Show("GG惹");
                    }
                    break;

                case 9:

                    this.currentScene.ChangeTo(3);
                    break;

                case 3:
                    if (decision == 1)
                    {
                        this.currentScene.ChangeTo(4);
                        MessageBox.Show("GG惹");
                    }
                    else
                        this.currentScene.ChangeTo(5);
                    break;

                case 5:
                    if (decision == 1)
                    {
                        this.currentScene.ChangeTo(6);
                        MessageBox.Show("GG惹");
                    }
                    else
                    {
                        this.currentScene.ChangeTo(7);
                        MessageBox.Show("GG惹");
                    }
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}