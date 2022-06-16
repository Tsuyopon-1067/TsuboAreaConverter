using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 坪面積変換
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double value;//入力された数値を受け取る
        int value_try;//trueならテキストボックスは数字
        int radio;//四捨五入オプション(0-4)
        double a;
        private void Btn_act_Click(object sender, EventArgs e)
        {
            if (radio_0.Checked) radio = 0;
            if (radio_1.Checked) radio = 1;
            if (radio_2.Checked) radio = 2;
            if (radio_3.Checked) radio = 3;
            if (radio_4.Checked) radio = 4;
            //入力された文字列が数値なら以下実行
            if(int.TryParse(input.Text, out value_try) || input.Text == "")
            {
                if (input.Text == "") input.Text = "0";//空白なら0
                value = double.Parse(input.Text);
                value = value * 400 / 121;//坪数*400/121 = ㎡ 
                value = value * Math.Pow(10, radio);
                value = (Math.Round(value, MidpointRounding.AwayFromZero));
                value = value / Math.Pow(10, radio);
                
                label_answer.Text = input.Text+"坪は" +value.ToString()+"㎡です。";
            }


        }

        private void Btn_d_Click(object sender, EventArgs e)
        {
            //入力された文字列が数値なら以下実行
            if (int.TryParse(input.Text, out value_try))
            {
                a = double.Parse(input.Text);
                if (a > 0) a--;
                input.Text = a.ToString();
            }
            else if (input.Text == "") input.Text = "0";
        }
        private void Btn_i_Click(object sender, EventArgs e)
        {
            //空白なら1に
            //入力された文字列が数値なら以下実行
            if (int.TryParse(input.Text, out value_try))
            {
                a = double.Parse(input.Text);
                a++;
                input.Text = a.ToString();
            }
            else if (input.Text == "") input.Text = "1";
        }
    }
}
