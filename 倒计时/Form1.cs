using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 倒计时
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int hh = 1;
        int mm = 10;
        int ss = 59;

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer t = new Timer();
            label3.Text = hh + "时";
            label1.Text = mm + "分";
            label2.Text = ss + "秒";
            t.Interval = 10; //设置间隔时间t为1000毫秒；
            t.Tick += new EventHandler(timer1_Tick);//设置每间隔3000毫秒（3秒）执行一次函数timer_Tick
            t.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (mm >= 0)
            {
                ss--;
                if (ss == 0)
                {
                    mm--;
                    label1.Text = mm.ToString() + "分";
                    ss = 59;
                }
                label2.Text = ss.ToString() + "秒";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (hh >= 0)
            {
                if (mm >= 0)
                {
                    ss--;
                    if (ss == 0)
                    {
                        mm--;
                        if (mm == 0)
                        {
                            hh --;
                            label3.Text = hh.ToString() + "时";
                            mm = 59;
                        }
                        label1.Text = mm.ToString() + "分";
                        ss = 59;
                    }
                    label2.Text = ss.ToString() + "秒";
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
