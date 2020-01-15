using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math_Quiz_Game
{
    public partial class Form1 : Form
    {
        public Random randomizer = new Random();
        public int Plus_Number_Left, Plus_Number_Right;
        public int Subtract_Number_Left, Subtract_Number_Right;
        public int Divide_Number_Left, Divide_Number_Right;
        public int Multiply_Number_Left, Multiply_Number_Right;
        public int Time_Left;

        private void Start_Button_Click(object sender, EventArgs e)
        {
            //This will fill out the question for Addition.
            Plus_Number_Left = randomizer.Next(51);
            Plus_Number_Right = randomizer.Next(51);

            Plus_Left_Label.Text = Plus_Number_Left.ToString();
            Plus_Right_Label.Text = Plus_Number_Right.ToString();

            Sum.Value = 0;

            //This will fill out the question for Subrtraction.
            Subtract_Number_Left = randomizer.Next(1, 101);
            Subtract_Number_Right = randomizer.Next(1, Subtract_Number_Left);

            Subtract_Left_Label.Text = Subtract_Number_Left.ToString();
            Subtract_Right_Label.Text = Subtract_Number_Right.ToString();

            Subtract.Value = 0;

            //This will fill out the question for Division.
            Divide_Number_Right = randomizer.Next(1, 12);
            int temp = randomizer.Next(2, 11);
            Divide_Number_Left = Divide_Number_Right * temp;
            Divide_Left_Label.Text = Divide_Number_Left.ToString();
            Divide_Right_Label.Text = Divide_Number_Right.ToString();

            Divide.Value = 0;

            //This will fill out the question for Multiplication.
            Multiply_Number_Left = randomizer.Next(1, 12);
            Multiply_Number_Right = randomizer.Next(1, 12);

            Multiply_Left_Label.Text = Multiply_Number_Left.ToString();
            Multiply_Right_Label.Text = Multiply_Number_Right.ToString();

            Multiply.Value = 0;

            Time_Left = 30;
            Time_Label.Text = "30 seconds";
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //This will end the test once all of the answers are correct
                timer1.Stop();
                MessageBox.Show("Congratulations! You got all of the answers correct!");
            }
            //This will continue to countdown the timer until the answers are correct.
            else if (Time_Left >0)
            {
                Time_Left = Time_Left - 1;
                Time_Label.Text = Time_Left + " seconds";
            }
            else
            {
                //This will end the test once time runs up and display a message that the test was not completed in time as well as fill in the correct answers.
                timer1.Stop();
                Time_Label.Text = "Time's Up!";
                MessageBox.Show("You didn't finish in time. The correct answers have been filled in");
                Sum.Value = Plus_Number_Left + Plus_Number_Right;
                Subtract.Value = Subtract_Number_Left - Subtract_Number_Right;
                Divide.Value = Divide_Number_Left / Divide_Number_Right;
                Multiply.Value = Multiply_Number_Left * Multiply_Number_Right;
            }
        }
        private bool CheckTheAnswer()
        {
            //This will check if each of the answer is correct. Once they are all correct it will end the test.
            if ((Plus_Number_Left + Plus_Number_Right == Sum.Value) && (Subtract_Number_Left - Subtract_Number_Right == Subtract.Value) 
                && (Multiply_Number_Left * Multiply_Number_Right == Multiply.Value) 
                && (Divide_Number_Left / Divide_Number_Right == Divide.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }
    }
}
