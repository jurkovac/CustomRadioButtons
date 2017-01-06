using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomRadioButtons
{
    public partial class Form1 : Form
    {
        CustomRadioButton crb, crb2, crb3;

        public Form1()
        {
            InitializeComponent();
            var b1 = Properties.Resources.radio_checked;
            var b2 = Properties.Resources.radio_unchecked;
            crb = new CustomRadioButton(b1, b2, 12, 12, 10, 10);
            crb2 = new CustomRadioButton(b1, b2, 12, 12, 35, 10);
            crb3 = new CustomRadioButton(b1, b2, 12, 12, 60, 10);
            CustomRadioButtonGroup crbg = new CustomRadioButtonGroup();
            crbg.Add(crb);
            crbg.Add(crb2);
            crbg.Add(crb3);
            crbg.UseIt(this);
        }       
    }
}
