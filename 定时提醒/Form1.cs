using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Timing
{
    public partial class Main_Form : Form
    {
        int hour, min, second;
        int totalSecond;
        int reseted = 0;
        bool btnChange = true ;//ture表示将按下
        
        System.Media.SoundPlayer soundp;//wav声音类
        
 
        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            soundp = new System.Media.SoundPlayer(global::Timing.Properties.Resources.shanshanai);//wav声音类                     
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            totalSecond--;
            int temp;
            if (totalSecond < 0)//定时时间到
            { 
                reseted = 0;
                //声音
                if (checkBox_music.Checked == true)
                {
                    soundp.Load();
                    soundp.PlayLooping();
                    //sp.PlayLooping(); //循环播放
                    //System.Media.SystemSounds.Asterisk.Play(); 
                    //System.Media.SystemSounds.Beep.Play(); 
                }
                
                //定时器
                timer.Stop();//停止计数
                timer.Enabled = false;
                //是否是最小化中
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Visible = true;
                    this.ShowInTaskbar = true;
                    this.WindowState = FormWindowState.Normal;
                }
                //按钮
                btn_start.BackColor = Color.Gray;
                btn_start.Text = "START";
                btn_start.Enabled = false;
                btnChange = true;

                //晃动窗口
                this.TopMost = true;
                this.BackColor = Color.Indigo;
                label_timeing.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                numericUpDown1.Visible = false;
                numericUpDown2.Visible = false;
                numericUpDown3.Visible = false;
                panel1.Visible = false;
                btn_reset.Text = "取消提醒";
            }
            else
            {
                temp = totalSecond / 3600;//整数个小时
                if (temp < 10)
                    label_H.Text = "0" + temp.ToString();
                else
                    label_H.Text = temp.ToString();

                temp = totalSecond / 60 - temp * 60;//分钟
                if (temp < 10)
                    label_M.Text = "0" + temp.ToString();
                else
                    label_M.Text = temp.ToString();

                temp = totalSecond % 60;
                if (temp < 10)
                    label_S.Text = "0" + temp.ToString();
                else
                    label_S.Text = temp.ToString();
            }

        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if (reseted == 0)//已经复位
            {
                hour = (int)numericUpDown1.Value;
                min = (int)numericUpDown2.Value;
                second = (int)numericUpDown3.Value;

                totalSecond = 3600 * hour + 60 * min + second;
            }

            if (btnChange)
            {
                //改变按钮颜色
                timer.Enabled = true;
                timer.Start();//开始计数
                btn_start.BackColor = Color.DarkGray;
                btn_start.Text = "PAUSE";
            }
            else 
            {
                timer.Stop();//停止计数
                btn_start.BackColor = Color.Gold;
                btn_start.Text = "START";
            }

            btnChange = !btnChange;
            
            reseted = 1;

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            
            reseted = 0;
            //声音
            soundp.Stop();
            //定时器恢复
            timer.Stop();//停止计数
            timer.Enabled = false;

            //按钮恢复
            btn_start.BackColor = Color.Gold;
            btn_start.Text = "START";
            btn_start.Enabled = true;
            btnChange = true;

            //撤销置顶状态
            this.TopMost = false ;
            this.BackColor = Color.LightGray;
            label_timeing.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            numericUpDown1.Visible = true;
            numericUpDown2.Visible = true;
            numericUpDown3.Visible = true;
            panel1.Visible = true;
            btn_reset.Text = "RESET";

            label_H.Text = "00";
            label_M.Text = "00";
            label_S.Text = "00";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value > 25)
                MessageBox.Show("最大定时25小时哦！！！亲请重新设定。。。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown2.Value >= 60)
            {
                numericUpDown1.Value = numericUpDown1.Value + 1;
                numericUpDown2.Value = 0;
            }
        } 
        
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown3.Value == 60)
            {
                numericUpDown2.Value = numericUpDown2.Value + 1;
                numericUpDown3.Value = 0;
            }
            if (numericUpDown2.Value >= 60)
            {
                numericUpDown1.Value = numericUpDown1.Value + 1;
                numericUpDown2.Value = 0;
            }
        }

        private void Main_Form_SizeChanged(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
               // this.notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;            
        }        
    }
}
