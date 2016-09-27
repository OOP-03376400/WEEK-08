using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDelegate1
{
    delegate void MyDel(int value); // Declare delegate TYPE.
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDel del; // Declare delegate variable.

            // Create random-integer-generator object and get a random number between 0 and 99.
            Random rand = new Random();
            int randomValue = rand.Next(99);

            // Create a delegate object that contains either PrintLow or PrintHigh, and assign
            // the object to the del variable.
            del = randomValue < 50
                        ? new MyDel(this.PrintLow)
                        : new MyDel(this.PrintHigh);

            del(randomValue); // Execute the delegate.
        }

        void PrintLow(int value)
        {
            string str = value + " is Low Value ";
            MessageBox.Show(str);
        }

        void PrintHigh(int value)
        {
            string str = value + " is High Value ";
            MessageBox.Show(str);
        }

    }
}
