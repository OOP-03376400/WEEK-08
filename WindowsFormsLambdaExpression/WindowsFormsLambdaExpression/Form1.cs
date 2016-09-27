using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsLambdaExpression
{
    delegate double MyDel(int par);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDel del = delegate (int x) { return x + 1; }; // Anonymous method

            MyDel le1 = (int x) => { return x + 1; }; // Lambda expression
            MyDel le2 = (x) => { return x + 1; };
            MyDel le3 = x => { return x + 1; };
            MyDel le4 = x => x + 1;

            textBox1.Text =  del(12).ToString();
            textBox2.Text = le1(12).ToString();
            textBox3.Text = le2(12).ToString();
            textBox4.Text = le3(12).ToString();
            textBox5.Text = le4(12).ToString();

        }
 
    }
}
