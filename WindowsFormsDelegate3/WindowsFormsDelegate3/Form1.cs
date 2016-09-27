using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDelegate3
{
    public partial class Form1 : Form
    {
        delegate int MyDel(); // Declare delegate with return value.

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyClass mc = new MyClass();

            MyDel mDel = mc.Add2;         // Create and initialize the delegate.
            mDel += mc.Add3;              // Add a method.
            mDel += mc.Add2;              // Add a method.
            string str = "Value: " + mDel();
            MessageBox.Show(str);
        }
    }

    class MyClass
    {
        int IntValue = 5;

        public int Add2()
        {
            IntValue += 2; return IntValue;
        }

        public int Add3()
        {
            IntValue += 3; return IntValue;
        }
    }
}
