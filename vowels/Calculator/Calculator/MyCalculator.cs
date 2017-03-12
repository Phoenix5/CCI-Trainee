using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MyCalculator : Form
    {

        private double accumulator = 0;
        private char lastOperation;

        public MyCalculator()
        {
            InitializeComponent();
        }


     //   private void btnOpDivide_Click(object sender, EventArgs e)
     //   {
      //      txtDisplay.Text += '/';
     //   }

        private void btnbackSpace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length !=0 && text.Text.Length != 0)
            {
                txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1, 1);//using remove
                text.Text = text.Text.Substring(0, text.Text.Length - 1);//using substring

                if (txtDisplay.Text.Length == 0)
                    text.Clear();

           }
           
                

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            text.Clear();
        }

        private void btnBlank_Click(object sender, EventArgs e)
       {

        }

     //   private void btnNum1_Click(object sender, EventArgs e)
     //   {
     //       txtDisplay.Text += '1';
     //   }
     //
     //   private void btnNum2_Click(object sender, EventArgs e)
       // {
        //    txtDisplay.Text += '2';
       // }

     //   private void btnNum3_Click(object sender, EventArgs e)
     //   {
     //       txtDisplay.Text += '3';
     //   }

    //    private void btnOpMultiply_Click(object sender, EventArgs e)
    //    {
    //        txtDisplay.Text += '*';
    //    }

   //     private void btnOpSubtract_Click(object sender, EventArgs e)
   //     {
   //         txtDisplay.Text += '-';
   //     }

  //      private void btnNum6_Click(object sender, EventArgs e)
  //      {
  //          txtDisplay.Text += '6';
  //      }

  //      private void btnNum5_Click(object sender, EventArgs e)
  //      {
  //          txtDisplay.Text += '5';
  //      }

  //      private void btnNum4_Click(object sender, EventArgs e)
  //      {
  //          txtDisplay.Text += '4';
  //      }

  //      private void btnNum7_Click(object sender, EventArgs e)
  //      {
  //          txtDisplay.Text += '7';
  //      }

  //      private void btnNum8_Click(object sender, EventArgs e)
  //      {
  //          txtDisplay.Text += '8';
  //      }

 //       private void btnNum9_Click(object sender, EventArgs e)
  //      {
  //          txtDisplay.Text += '9';
   //     }

    //    private void btnOpAdd_Click(object sender, EventArgs e)
      //  {
     //       txtDisplay.Text += '+';
     //   }

     //  private void button3_Click(object sender, EventArgs e)
     //  {
     //      
     //  }

    //    private void btnNum0_Click(object sender, EventArgs e)
     //   {
       //     txtDisplay.Text += '0';
     //   }

       private void btnOpDot_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += '.';
        }

        private void MyCalculator_Load(object sender, EventArgs e)
        {

        }

        private void Operator_Pressed(object sender, EventArgs e)
        {
            // An operator was pressed; perform the last operation and store the new operator.
            char operation = (sender as Button).Text[0];
            if (operation == 'C')
            {
                accumulator = 0;
            }
            else
            {
                double currentValue = double.Parse(txtDisplay.Text);
                switch (lastOperation)
                {
                    case '+': accumulator += currentValue; break;
                    case '-': accumulator -= currentValue; break;
                    case '*': accumulator *= currentValue; break;
                    case '/': accumulator /= currentValue; break;
                    default: accumulator = currentValue; break;
                }
            }

            lastOperation = operation;
            txtDisplay.Text = operation == '=' ? accumulator.ToString() : "0";
            text.Text = operation == '=' ? accumulator.ToString() :text.Text+Convert.ToString(operation);
        }

        private void Operand_Pressed(object sender, EventArgs e)
        {
            // Add it to the display.
            string number = (sender as Button).Text;
            txtDisplay.Text = txtDisplay.Text == "0" ? number : txtDisplay.Text + number;
            text.Text = text.Text == "0" ? number : text.Text + number;
        }

        private void text_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonblk2_Click(object sender, EventArgs e)
        {

        }
    }
}
