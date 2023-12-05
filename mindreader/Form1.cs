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
    public partial class Form1 : Form
    {
        PictureBox[] x=new PictureBox[101];
        int q;
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            //this.pictureBox1.BackgroundImage = global::mindreader.Properties.Resources.s1;
            //pictureBox1.BackgroundImage = Image.FromFile("D:\\mindreader project\\mindreader\\s1.png");
            x[1] = pictureBox1;
            x[2] = pictureBox2;
            x[3] = pictureBox3;
            x[4] = pictureBox4;
            x[5] = pictureBox5;
            x[6] = pictureBox6;
            x[7] = pictureBox7;
            x[8] = pictureBox8;
            x[9] = pictureBox9;
            x[10] = pictureBox10;
            x[11] = pictureBox11;
            x[12] = pictureBox12;
            x[13] = pictureBox13;
            x[14] = pictureBox14;
            x[15] = pictureBox15;
            x[16] = pictureBox16;
            x[17] = pictureBox17;
            x[18] = pictureBox18;
            x[19] = pictureBox19;
            x[20] = pictureBox20;
            x[21] = pictureBox21;
            x[22] = pictureBox22;
            x[23] = pictureBox23;
            x[24] = pictureBox24;
            x[25] = pictureBox25;
            x[26] = pictureBox26;
            x[27] = pictureBox27;
            x[28] = pictureBox28;
            x[29] = pictureBox29;
            x[30] = pictureBox30;
            x[31] = pictureBox31;
            x[32] = pictureBox32;
            x[33] = pictureBox33;
            x[34] = pictureBox34;
            x[35] = pictureBox35;
            x[36] = pictureBox36;
            x[37] = pictureBox37;
            x[38] = pictureBox38;
            x[39] = pictureBox39;
            x[40] = pictureBox40;
            x[41] = pictureBox41;
            x[42] = pictureBox42;
            x[43] = pictureBox43;
            x[44] = pictureBox44;
            x[45] = pictureBox45;
            x[46] = pictureBox46;
            x[47] = pictureBox47;
            x[48] = pictureBox48;
            x[49] = pictureBox49;
            x[50] = pictureBox50;
            x[51] = pictureBox51;
            x[52] = pictureBox52;
            x[53] = pictureBox53;
            x[54] = pictureBox54;
            x[55] = pictureBox55;
            x[56] = pictureBox56;
            x[57] = pictureBox57;
            x[58] = pictureBox58;
            x[59] = pictureBox59;
            x[60] = pictureBox60;
            x[61] = pictureBox61;
            x[62] = pictureBox62;
            x[63] = pictureBox63;
            x[64] = pictureBox64;
            x[65] = pictureBox65;
            x[66] = pictureBox66;
            x[67] = pictureBox67;
            x[68] = pictureBox68;
            x[69] = pictureBox69;
            x[70] = pictureBox70;
            x[71] = pictureBox71;
            x[72] = pictureBox72;
            x[73] = pictureBox73;
            x[74] = pictureBox74;
            x[75] = pictureBox75;
            x[76] = pictureBox76;
            x[77] = pictureBox77;
            x[78] = pictureBox78;
            x[79] = pictureBox79;
            x[80] = pictureBox80;
            x[81] = pictureBox81;
            x[82] = pictureBox82;
            x[83] = pictureBox83;
            x[84] = pictureBox84;
            x[85] = pictureBox85;
            x[86] = pictureBox86;
            x[87] = pictureBox87;
            x[88] = pictureBox88;
            x[89] = pictureBox89;
            x[90] = pictureBox90;
            x[91] = pictureBox91;
            x[92] = pictureBox92;
            x[93] = pictureBox93;
            x[94] = pictureBox94;
            x[95] = pictureBox95;
            x[96] = pictureBox96;
            x[97] = pictureBox97;
            x[98] = pictureBox98;
            x[99] = pictureBox99;
            x[100] = pictureBox100;
            Random r = new Random();
            int y = r.Next(1,16);
            q = y;
            for(int i=1;i<=100;i++)
            {
                if(i%9==0)
                {
                    x[i].BackgroundImage = Image.FromFile("F:\\mindreader project-20191215T071809Z-001\\mindreader project\\mindreader\\s" + y+".png");
                }
                else
                {
                    x[i].BackgroundImage = Image.FromFile("F:\\mindreader project-20191215T071809Z-001\\mindreader project\\mindreader\\s" + r.Next(1,16) + ".png");
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label91_Click(object sender, EventArgs e)
        {

        }

        private void label81_Click(object sender, EventArgs e)
        {

        }

        private void label71_Click(object sender, EventArgs e)
        {

        }

        private void label61_Click(object sender, EventArgs e)
        {

        }

        private void label51_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label40_Click(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }

        private void label100_Click(object sender, EventArgs e)
        {

        }

        private void label90_Click(object sender, EventArgs e)
        {

        }

        private void label80_Click(object sender, EventArgs e)
        {

        }

        private void label70_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 x = new Form2(q);
            this.Hide();
            x.Show();
            
        }

    }
}
