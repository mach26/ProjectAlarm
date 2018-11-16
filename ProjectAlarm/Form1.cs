using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAlarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string alarmHour, alarmMinute;
        int hour, minute, second;

        private void button1_Click(object sender, EventArgs e)
        {
            alarmHour = comboBox1.Text;
            alarmMinute = comboBox2.Text;
        }
        void Ring_Alarm()
        {
            if(alarmHour==hour.ToString()&&alarmMinute==minute.ToString()&&second.ToString()=="0")
            axWindowsMediaPlayer1.URL = @"C:\\Windows\\media\\Alarm01.wav";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second = DateTime.Now.Second;
            minute = DateTime.Now.Minute;
            hour = DateTime.Now.Hour;
            label4.Text = hour.ToString();
            label3.Text = minute.ToString();
            label2.Text = second.ToString();
            Ring_Alarm();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            for (int i = 0; i < 24; i++)
                comboBox1.Items.Add(i);
            for (int i = 0; i < 60; i++)
                comboBox2.Items.Add(i);
        }
    }
}
