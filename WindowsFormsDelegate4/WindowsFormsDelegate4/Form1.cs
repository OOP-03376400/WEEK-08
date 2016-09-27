using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDelegate4
{
    delegate void MyDel(ref int X);

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyDel mDel = this.Add2;
            mDel += this.Add3;
            mDel += this.Add2;

            int x = 8;
            mDel(ref x);

            string str = "Value: " + x;
            MessageBox.Show(str);


        }
        public void Add2(ref int x)
        {
            x += 2;
        }
        public void Add3(ref int x)
        {
            x += 3;
        }



    }
}
