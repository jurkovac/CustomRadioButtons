using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomRadioButtons
{
    class CustomRadioButton : PictureBox
    {
        private bool check = false;
        private Bitmap checkedImage = null;
        private Bitmap uncheckedImage = null;
        private PictureBox radioButton = null;

        public CustomRadioButton() { }

        public CustomRadioButton(Image checkedImage, Image uncheckedImage, int width, int height, int x, int y)
        {
            CheckedImage = new Bitmap(checkedImage);
            UncheckedImage = new Bitmap(uncheckedImage);
            RadioButton = new PictureBox();
            RadioButton.Image = UncheckedImage;
            RadioButton.Width = width;
            RadioButton.Height = height;
            RadioButton.Location = new Point(x, y);
            RadioButton.SizeMode = PictureBoxSizeMode.Zoom;
            RadioButton.Click += RadioButton_Click;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            CustomRadioButtonGroup.check(this);

            if (Check)
            {
                Check = false;
            }else
            {
                Check = true;
            }
        }

        public bool Check
        {
            get
            {
                return check;
            }

            set
            {
                check = value;

                if(check)
                {
                    RadioButton.Image = CheckedImage;
                }else
                {
                    RadioButton.Image = UncheckedImage;
                }
            }
        }

        public Bitmap CheckedImage
        {
            get
            {
                return checkedImage;
            }

            set
            {
                checkedImage = value;
            }
        }

        public Bitmap UncheckedImage
        {
            get
            {
                return uncheckedImage;
            }

            set
            {
                uncheckedImage = value;
            }
        }

        public PictureBox RadioButton
        {
            get
            {
                return radioButton;
            }

            set
            {
                radioButton = value;
            }
        }
    }
}
