using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomRadioButtons
{
    class CustomRadioButtonGroup
    {
        private static List<CustomRadioButton> customRadioButtons;

        private static List<CustomRadioButton> CustomRadioButtons
        {
            get
            {
                return customRadioButtons;
            }

            set
            {
                customRadioButtons = value;
            }
        }

        public CustomRadioButtonGroup()
        {
            customRadioButtons = new List<CustomRadioButton>();
        }

        public void Add(CustomRadioButton customRadioButton)
        {
            
            CustomRadioButtons.Add(customRadioButton);
        }

        public void UseIt(Form parent)
        {
            int count = 0;

            for(int i = 0; i < CustomRadioButtons.Count; i++)
            {
                if (i == 0)
                {
                    CustomRadioButtons[i].Check = true;
                }
                else
                {
                    CustomRadioButtons[i].Check = false;
                }
                

                parent.Controls.Add(CustomRadioButtons[i].RadioButton);
            }
        }

        public static void check(CustomRadioButton customRadioButton)
        {
            for (int i = 0; i < CustomRadioButtons.Count; i++)
            {
                if(CustomRadioButtons[i].RadioButton == customRadioButton)
                {
                    CustomRadioButtons[i].Check = true;
                }else
                {
                    CustomRadioButtons[i].Check = false;
                }
            }
        }
    }
}
