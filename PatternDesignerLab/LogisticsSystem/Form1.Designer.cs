
namespace LogisticsSystem
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_PostMsg = new System.Windows.Forms.Button();
            this.txt_MesContent = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rab_SpecialMsg = new System.Windows.Forms.RadioButton();
            this.rabtn_NormalMsg = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.input_SMS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_SMS = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.input_WeChat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_WeChat = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.timer_SpecialMsg = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_PostMsg
            // 
            this.btn_PostMsg.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_PostMsg.Location = new System.Drawing.Point(148, 493);
            this.btn_PostMsg.Name = "btn_PostMsg";
            this.btn_PostMsg.Size = new System.Drawing.Size(290, 75);
            this.btn_PostMsg.TabIndex = 0;
            this.btn_PostMsg.Text = "发送";
            this.btn_PostMsg.UseVisualStyleBackColor = true;
            this.btn_PostMsg.Click += new System.EventHandler(this.btn_PostMsg_Click);
            // 
            // txt_MesContent
            // 
            this.txt_MesContent.Location = new System.Drawing.Point(24, 152);
            this.txt_MesContent.Multiline = true;
            this.txt_MesContent.Name = "txt_MesContent";
            this.txt_MesContent.Size = new System.Drawing.Size(528, 196);
            this.txt_MesContent.TabIndex = 1;
            this.txt_MesContent.TextChanged += new System.EventHandler(this.txt_MesContent_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 70);
            this.label1.TabIndex = 2;
            this.label1.Text = "物流管理系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(19, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "输入你要发送的消息：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rab_SpecialMsg);
            this.panel1.Controls.Add(this.rabtn_NormalMsg);
            this.panel1.Location = new System.Drawing.Point(24, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 100);
            this.panel1.TabIndex = 4;
            // 
            // rab_SpecialMsg
            // 
            this.rab_SpecialMsg.AutoSize = true;
            this.rab_SpecialMsg.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rab_SpecialMsg.Location = new System.Drawing.Point(319, 18);
            this.rab_SpecialMsg.Name = "rab_SpecialMsg";
            this.rab_SpecialMsg.Size = new System.Drawing.Size(145, 32);
            this.rab_SpecialMsg.TabIndex = 1;
            this.rab_SpecialMsg.Text = "特殊消息";
            this.rab_SpecialMsg.UseVisualStyleBackColor = true;
            // 
            // rabtn_NormalMsg
            // 
            this.rabtn_NormalMsg.AutoSize = true;
            this.rabtn_NormalMsg.Checked = true;
            this.rabtn_NormalMsg.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rabtn_NormalMsg.Location = new System.Drawing.Point(25, 18);
            this.rabtn_NormalMsg.Name = "rabtn_NormalMsg";
            this.rabtn_NormalMsg.Size = new System.Drawing.Size(145, 32);
            this.rabtn_NormalMsg.TabIndex = 0;
            this.rabtn_NormalMsg.TabStop = true;
            this.rabtn_NormalMsg.Text = "普通消息";
            this.rabtn_NormalMsg.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.input_SMS);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_SMS);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(667, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 539);
            this.panel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(156, 461);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 75);
            this.button1.TabIndex = 6;
            this.button1.Text = "发送";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // input_SMS
            // 
            this.input_SMS.Location = new System.Drawing.Point(32, 357);
            this.input_SMS.Multiline = true;
            this.input_SMS.Name = "input_SMS";
            this.input_SMS.Size = new System.Drawing.Size(522, 72);
            this.input_SMS.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(32, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 28);
            this.label5.TabIndex = 3;
            this.label5.Text = "输入你要发送的消息：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(27, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "物流消息";
            // 
            // txt_SMS
            // 
            this.txt_SMS.Location = new System.Drawing.Point(32, 92);
            this.txt_SMS.Multiline = true;
            this.txt_SMS.Name = "txt_SMS";
            this.txt_SMS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_SMS.Size = new System.Drawing.Size(522, 211);
            this.txt_SMS.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(195, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "手机短信";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.input_WeChat);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txt_WeChat);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(1287, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(576, 539);
            this.panel3.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(156, 461);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(290, 75);
            this.button2.TabIndex = 6;
            this.button2.Text = "发送";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // input_WeChat
            // 
            this.input_WeChat.Location = new System.Drawing.Point(32, 357);
            this.input_WeChat.Multiline = true;
            this.input_WeChat.Name = "input_WeChat";
            this.input_WeChat.Size = new System.Drawing.Size(522, 72);
            this.input_WeChat.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(32, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(292, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "输入你要发送的消息：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(27, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "物流消息";
            // 
            // txt_WeChat
            // 
            this.txt_WeChat.Location = new System.Drawing.Point(32, 92);
            this.txt_WeChat.Multiline = true;
            this.txt_WeChat.Name = "txt_WeChat";
            this.txt_WeChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_WeChat.Size = new System.Drawing.Size(522, 211);
            this.txt_WeChat.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(195, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 43);
            this.label8.TabIndex = 0;
            this.label8.Text = "微信";
            // 
            // timer_SpecialMsg
            // 
            this.timer_SpecialMsg.Interval = 4000;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1898, 602);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MesContent);
            this.Controls.Add(this.btn_PostMsg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_PostMsg;
        private System.Windows.Forms.TextBox txt_MesContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rab_SpecialMsg;
        private System.Windows.Forms.RadioButton rabtn_NormalMsg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_SMS;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox input_SMS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox input_WeChat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_WeChat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer_SpecialMsg;
    }
}

