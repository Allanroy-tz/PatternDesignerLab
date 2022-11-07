using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogisticsSystem
{
    public partial class Form1 : Form
    {



        Tz20200440718_SMS _SMS = new Tz20200440718_SMS();
        Tz20200440718_WeChat _WeChat = new Tz20200440718_WeChat();
        public Form1()
        {
            InitializeComponent();
        }
        int num = 0;
        private void btn_PostMsg_Click(object sender, EventArgs e)
        {
            Tz20200440718_IMessage msg;
            if (rabtn_NormalMsg.Checked)
            {
                msg = new Tz20200440718_NormalMessage();
                _SMS.SetMessage(msg);
                _WeChat.SetMessage(msg);
                postNormalMsg();
            }
            else if (rab_SpecialMsg.Checked)
            {
                msg = new Tz20200440718_SpecialMessage();
                _SMS.SetMessage(msg);
                _WeChat.SetMessage(msg);
                postNormalMsg();
                timer_SpecialMsg.Start();
            }
        }
        private void postNormalMsg()
        {
            string msgContent = txt_MesContent.Text;
            txt_SMS.Text +=_SMS.Post(msgContent)+ "\r\n";
            txt_WeChat.Text += _WeChat.Post(msgContent) + "\r\n";
        }
        
        private void postSpecialMsg(object sender, EventArgs e)
        {
            if(num++>=5)
            {
                timer_SpecialMsg.Stop();
                return;
            }
            string msgContent = txt_MesContent.Text;
            txt_SMS.Text+=_SMS.Post(msgContent) + "\r\n";
            txt_WeChat.Text += _WeChat.Post(msgContent) + "\r\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(input_SMS.Text!="")
            {
                txt_SMS.Text += System.DateTime.Now.ToString() + ":"+ "我:" +input_SMS.Text + "\r\n";
                if(input_SMS.Text=="确认"&&timer_SpecialMsg.Enabled)
                {
                    timer_SpecialMsg.Stop();
                    string msg= "收到您的确认";
                    txt_SMS.Text += System.DateTime.Now.ToString()+":"+ msg + "\r\n";
                    txt_WeChat.Text += System.DateTime.Now.ToString() + ":"+msg + "\r\n";
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input_WeChat.Text != "")
            {
                txt_WeChat.Text += System.DateTime.Now.ToString() + ":"+"我:" + input_WeChat.Text;
                if (input_WeChat.Text == "确认" && timer_SpecialMsg.Enabled)
                {
                    timer_SpecialMsg.Stop();
                    string msg = "收到您的确认";
                    txt_SMS.Text += System.DateTime.Now.ToString() + ":"+msg + "\r\n";
                    txt_WeChat.Text += System.DateTime.Now.ToString() + ":"+msg + "\r\n";
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer_SpecialMsg.Tick += postSpecialMsg;
        }

        private void txt_MesContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
