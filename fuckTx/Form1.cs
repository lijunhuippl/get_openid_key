using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fuckTx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String url = textBox1.Text;


            webBrowser1.Navigate(url, "_self", null, "User-Agent: Mozilla/5.0 (Linux; Android 7.0; SM-G892A Build/NRD90M; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/67.0.3396.87 Mobile Safari/537.36");
        }

     
           /************
            * 
            * 1. 让webbrowser 可以打开 pay.qq.com/h5 并正常执行,把小姐姐叫过来
            * 2. 点击获取按钮 可以获取 openid 和openkey
            * 
            *
            */

        private void button2_Click(object sender, EventArgs e)
        {
            // 获取账号的 openid openkey  获取zoneid 
            // 这样就不用每次 f12 获取 xx了


        }
    }
}
