using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsNamedMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int Add20(int x)
        {
            return x + 20;
        }

        delegate int OtherDel(int InParam);

        private void button1_Click(object sender, EventArgs e)
        {
            OtherDel del = Add20;

            textBox1.Text = del(5).ToString();
            textBox2.Text = del(6).ToString();
        }
    }
}
