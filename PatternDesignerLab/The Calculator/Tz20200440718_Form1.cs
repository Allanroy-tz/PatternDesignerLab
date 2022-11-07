using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Calculator
{
    public partial class Tz20200440718_Form1 : Form
    {
        /// <summary>
        /// 第一个操作数
        /// </summary>
        double a;
        /// <summary>
        /// 第二个操作数
        /// </summary>
        double b;
        /// <summary>
        /// 面板上的数字
        /// </summary>
        string inputNum="";
        /// <summary>
        /// 当前操作数
        /// </summary>
        double t;
        /// <summary>
        /// 一元运算
        /// </summary>
        Tz20200440718_IUnaryOp unaryOp;
        /// <summary>
        /// 二元运算
        /// </summary>
        Tz20200440718_IBinaryOp binaryOp;
        /// <summary>
        /// 运算工厂
        /// </summary>
        Tz20200440718_OpFactory opFactory;

        Tz20200440718_AbstractThemeFactory themeFactory;
        Tz20200440718_LogFactory logFactory=new Tz20200440718_LogFactory();
        Tz20200440718_LogOp logOp;
        List<string> logList = new List<string>();
        string logWrite = "";
        public Tz20200440718_Form1()
        {
            InitializeComponent();
            opFactory = new Tz20200440718_OpFactory();
        }
        double StringToDouble(string s)
        {
            int i = 0;
            if (s.Length == 0) return 0;
            while (i < s.Length && s[i] != '.')
            {
                i++;
            }
            double c = 0;
            int q = 1;
            for (int l = i - 1; l >0; l--, q *= 10)
            {
                c += ((s[l] - '0') * q);
            }
            double qq = 0.1;
            for (int l = i + 1; l < s.Length; l++, qq *= 0.1)
            {
                c += ((s[l] - '0') * qq);
            }
            if (s[0] == '-')
                c *= -1;
            else if (s[0] >= '0' && s[0] <= '9')
                c += ((s[0] - '0') * q);
            return c;
        }
        void FirstNum()
        {
            a = StringToDouble(inputNum);
            inputNum = "";
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            inputNum += '1';
            txtInput.Text += '1';
        }
        private void btnZero_Click(object sender, EventArgs e)
        {
            inputNum += '0';
            txtInput.Text += '0';
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            inputNum += '2';
            txtInput.Text += '2';
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            inputNum += '3';
            txtInput.Text += '3';
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            inputNum += '4';
            txtInput.Text += '4';
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            inputNum += '5';
            txtInput.Text += '5';
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            inputNum += '6';
            txtInput.Text += '6';
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            inputNum += '7';
            txtInput.Text += '7';
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            inputNum += '8';
            txtInput.Text += '8';
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            inputNum += '9';
            txtInput.Text += '9';
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtInput.Text += '.';
        }
        int logNum=1;
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string result = "无效";
            if (unaryOp != null)
            {
                a = StringToDouble(inputNum);
                result = unaryOp.Calculate(a).ToString();
                unaryOp = null;
            }
            else if (binaryOp != null)
            {
                b = StringToDouble(inputNum);
                result = binaryOp.Calculate(a, b).ToString();
                binaryOp = null;
            }
            txtResult.Text = txtInput.Text+"="+result;
            string log = DateTime.Now.ToString() + ":" + txtResult.Text;
            logWrite += (log + "\n");
            txtLog.Text += (logNum++.ToString() + "," + log + "\n");
            logList.Add(log);
           
        }
        private void btnOpSub_Click(object sender, EventArgs e)
        {
            if (unaryOp == null)
            {
                binaryOp = opFactory.GetBinaryOp(EBinaryOp.Sub);
                FirstNum();
            }
            else
            {
                inputNum = "-";
            }
            txtInput.Text += "-";
        }
        private void btnOpAdd_Click(object sender, EventArgs e)
        {
            binaryOp = opFactory.GetBinaryOp(EBinaryOp.Add);
            FirstNum();
            txtInput.Text += "+";
        }
        private void btnOpDiv_Click(object sender, EventArgs e)
        {
            binaryOp = opFactory.GetBinaryOp(EBinaryOp.Div);
            FirstNum();
            txtInput.Text += "/";
        }

        private void btnOpMul_Click(object sender, EventArgs e)
        {
            binaryOp = opFactory.GetBinaryOp(EBinaryOp.Mul);
            txtInput.Text += "*";
            FirstNum();
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            binaryOp = opFactory.GetBinaryOp(EBinaryOp.Log);
            txtInput.Text += "log";
            FirstNum();
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            binaryOp = opFactory.GetBinaryOp(EBinaryOp.Pow);
            txtInput.Text += "^";
            FirstNum();
        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            unaryOp = opFactory.GetUnaryOp(EUnaryOp.Abs);
            txtInput.Text = "abs";
        }

        private void btnReciprocal_Click_1(object sender, EventArgs e)
        {
            unaryOp = opFactory.GetUnaryOp(EUnaryOp.Opp);
            txtInput.Text = "~";
        }
        private void btnRec_Click(object sender, EventArgs e)
        {
            unaryOp = opFactory.GetUnaryOp(EUnaryOp.Reciprocal);
            txtInput.Text = "1/";
        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            unaryOp = opFactory.GetUnaryOp(EUnaryOp.Sqrt);
            txtInput.Text = "√";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            inputNum = "";
        }
        private void theme01Btn_Click(object sender, EventArgs e)
        {
            themeFactory = new Tz20200440718_theme01Factory();
            this.BackColor = themeFactory.GetColor();
            txtInput.Font = themeFactory.GetFont();
            txtResult.Font= themeFactory.GetFont();
            txtLog.Font= themeFactory.GetFont();
        }

        private void theme02btn_Click(object sender, EventArgs e)
        {
            themeFactory = new Tz20200440718_theme02Factory();
            this.BackColor = themeFactory.GetColor();
            txtInput.Font = themeFactory.GetFont();
            txtResult.Font = themeFactory.GetFont();
            txtLog.Font = themeFactory.GetFont();
        }

        private void 读日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /*  logOp = logFactory.GetOp("DB");
            txtLog.Text = logOp.ReadLog();*/
            logOp = logFactory.GetOp("Doc");
            txtLog.Text = logOp.ReadLog();
        }

        private void 写日志ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logOp = logFactory.GetOp("DB");
            for (int i = 0; i < logList.Count; i++)
                logOp.WriteLog(i+1, logList[i]);
            txtLog.Text = "数据库读入成功\n";
            logOp = logFactory.GetOp("Doc");
            logOp.WriteLog(0, logOp.ReadLog()+logWrite);
            txtLog.Text += "文本读入成功";
        }
    }
}
