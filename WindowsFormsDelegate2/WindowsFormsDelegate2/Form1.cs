using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDelegate2
{
    public partial class Form1 : Form
    {
        // Define a delegate type with no return value and no parameters.
        delegate void PrintFunction();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Test t = new Test();                      // Create a test class instance.
            PrintFunction pf;                         // Create a null delegate.

            pf = t.Print1;                            // Instantiate and initialize the delegate.

            // Add three more methods to the delegate.
            pf += Test.Print2;
            pf += t.Print1;
            pf += Test.Print2;
            // The delegate now contains four methods.

            if (null != pf)                         // Make sure the delegate isn't null.
                pf();                                  // Invoke the delegate.
            else
                MessageBox.Show("Delegate is empty");

        }
    }


    class Test
    {
        public void Print1()
        {
            MessageBox.Show("Show1 -- instance (Object)");
        }

        public static void Print2()
        {
            MessageBox.Show("Show2 -- static");
        }
    }


}
