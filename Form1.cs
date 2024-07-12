using System;
using System.Windows.Forms;

namespace GuessingGame
{
    public partial class Form1 : Form
    {
        private int number;
        bool isOdd;
        bool isEven;
        bool isPrime;
        int userNumber;
        int count = 0;


        public Form1()
        {
            InitializeComponent();
            input.Focus();
            Random random = new Random();
            number = random.Next(1,100);
            Hint(number);
            attemptCount.Text = Convert.ToString(count);
        }

        private bool isValid()
        {
            return int.TryParse(input.Text, out _);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input.Text != "" && isValid())
            {
                userNumber = Convert.ToInt32(input.Text);
                if (userNumber == number)
                {
                    count++;
                    attemptCount.Text = Convert.ToString(count);
                    MessageBox.Show($"Welldone! You guessed the number correctly at Attempt {count}");
                    input.Text = "";
                    input.Focus();
                }
                else if (userNumber > number)
                {
                    count++;
                    attemptCount.Text = Convert.ToString(count);
                    MessageBox.Show("Incorrect! Try any small number");
                    input.Text = "";
                    input.Focus();
                }
                else
                {
                    count++;
                    attemptCount.Text = Convert.ToString(count);
                    MessageBox.Show("Incorrect! Try any greater number");
                    input.Text = "";
                    input.Focus();
                }
            }
            
        }

        private void hintbtn_Click(object sender, EventArgs e)
        {
            if (isOdd)
            {
                hintlabel.Text = "Guess some Odd number";
            }
            if (isEven)
            {
                hintlabel.Text = "Guess some Even Number";
            }

            if (isPrime)
            {
                hintlabel.Text += " Your Number is Prime";
            }
        }

        private void Hint(int number)
        {
            if (number % 2 == 0)
            {
                isEven = true;
            }
            else
            {
                isOdd = true;
            }

            if (IsPrime(number))
            {
                isPrime = true;
            }
        }
        private bool IsPrime(int number)
        {
            if (this.number <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(this.number); i++)
            {
                if (this.number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
