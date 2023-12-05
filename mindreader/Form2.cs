using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mindreader
{
    public partial class Form2 : Form
    {
        int t;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(int y)
        {
            InitializeComponent();
            t = y;
            pictureBox1.BackgroundImage = Image.FromFile("F:\\mindreader project-20191215T071809Z-001\\mindreader project\\mindreader\\s" + t+".png");
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            this.Hide();
            x.Show();
        }
    }
}
