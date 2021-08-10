using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public enum Operators { Add, Sub, Multi, Div }
    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;
        public Calculator()
        {
            InitializeComponent();
        }

        private void NumButton1_Click(object sender, EventArgs e)
        {
            Button numButton = (Button) sender;
            SetNum(numButton.Text);
        }

       
        public void SetNum(string num)
        {

            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;

            }
            else if (NumScreen.Text == "0")
                NumScreen.Text = num;
            else
                NumScreen.Text = NumScreen.Text + num;

        }

        private void NumPlus_Click(object sender, EventArgs e)
        {
            int num = int.Parse(NumScreen.Text);
            if (!isNewNum)
            {
                if (Opt == Operators.Add)
                    Result = Result + num;
                else if (Opt == Operators.Sub)
                    Result = Result - num;
                else if (Opt == Operators.Multi)
                    Result = Result * num;
                else if (Opt == Operators.Div)
                    Result = Result / num;
            }

            NumScreen.Text = Result.ToString();
            isNewNum = true;

            Button optButton = (Button)sender;

            if (optButton.Text == "+")
                Opt = Operators.Add;
            else if (optButton.Text == "-")
                Opt = Operators.Sub;
            else if(optButton.Text == "*")
                Opt = Operators.Multi;
            else if(optButton.Text == "/")
                Opt = Operators.Div;

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
    }
}
