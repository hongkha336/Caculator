using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caculator_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int light = 1;
        string PhepTinh = "";
        string KQ = "0";
        string temp = "";
        string temp2 = "";
        char nearTT = '\0';
        
      
        private void button1_Click(object sender, EventArgs e)
        {
            PhepTinh = PhepTinh + "1";
            temp2 = temp2 + "1";
            txtPhepTinh.Text = PhepTinh;
            light = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "2";
            PhepTinh = PhepTinh + "2";
            txtPhepTinh.Text = PhepTinh;
            light = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "3";
            PhepTinh = PhepTinh + "3";
            txtPhepTinh.Text = PhepTinh;
            light = 1;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "4";
            PhepTinh = PhepTinh + "4";
            txtPhepTinh.Text = PhepTinh;
            light = 1;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "5";
            PhepTinh = PhepTinh + "5";
            txtPhepTinh.Text = PhepTinh;
            light = 1;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "6";
            PhepTinh = PhepTinh + "6";
            txtPhepTinh.Text = PhepTinh;
            light = 1;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "7";
            PhepTinh = PhepTinh + "7";
            light = 1;
            txtPhepTinh.Text = PhepTinh;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "8";
            PhepTinh = PhepTinh + "8";
            light = 1;
            txtPhepTinh.Text = PhepTinh;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "9";
            light = 1;
            PhepTinh = PhepTinh + "9";
            txtPhepTinh.Text = PhepTinh;
        }

        private void btnCham_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + ".";
            PhepTinh = PhepTinh + ".";
            txtPhepTinh.Text = PhepTinh;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            temp2 = temp2 + "0";
            light = 1;
            PhepTinh = PhepTinh + "0";
            txtPhepTinh.Text = PhepTinh;
        }

        private void btnBang_Click(object sender, EventArgs e)
        {

            if (PhepTinh[PhepTinh.Length - 1] == ' ')
                MessageBox.Show("Math Error!!!");
            else
                tinh();
            
           

        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            if (nearTT == '\0')
                btnBang_Click(null, null);
            PhepTinh = PhepTinh + " + ";
         //   if(light==0)
            tinh();
            light = 1;
            nearTT = '+';
            txtPhepTinh.Text = PhepTinh;
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (nearTT == '\0')
                btnBang_Click(null, null);
            PhepTinh = PhepTinh + " - ";
   
                tinh();
            light = 1;
            nearTT = '-';
            txtPhepTinh.Text = PhepTinh;
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            if (nearTT == '\0')
                btnBang_Click(null, null);
            PhepTinh = PhepTinh + " x ";
     
                tinh();
            light = 1;
            nearTT = 'x';
            txtPhepTinh.Text = PhepTinh;
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            if (nearTT == '\0')
                btnBang_Click(null, null);
            PhepTinh = PhepTinh + " : ";
         
                tinh();
            light = 1;
            nearTT = ':';
            txtPhepTinh.Text = PhepTinh;
        }

        private void btnOFF_Click(object sender, EventArgs e)
        {
                this.Close();
        }

        private void btnPhantram_Click(object sender, EventArgs e)
        {
            if (lable1.Visible != true)
            {
                if (PhepTinh[PhepTinh.Length - 1] != ' ')
                {
                    nearTT = ':';
                    temp2 = "100";
                    tinh();
                    lable1.Visible = true;
                    light = 0;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
           
            int n = PhepTinh.Length;
            if(PhepTinh[n-1]!=' ')
            if (light == 1)
            {
                if (n == 1)
                {
                    PhepTinh = "0";
                    txtPhepTinh.Text = PhepTinh;
                }
                else
                {
                    if (PhepTinh[n - 2] != '+' && PhepTinh[n - 2] != '-' && PhepTinh[n - 2] != 'x' && PhepTinh[n - 2] != ':')
                    {
                        if (temp == "")
                        {
                            PhepTinh = PhepTinh.Substring(0, n - 1);
                            txtPhepTinh.Text
                                = PhepTinh;
                        }
                        else
                        {
                            if (temp.Length == 1)
                            {
                                PhepTinh = PhepTinh.Substring(0, n - 1);
                                PhepTinh = temp + PhepTinh;
                                txtPhepTinh.Text = PhepTinh;
                                temp = "";
                            }
                            else
                            {
                                PhepTinh = PhepTinh.Substring(0, n - 1);
                                PhepTinh = temp.Substring(temp.Length - 1, 1) + PhepTinh;
                                temp = temp.Substring(0, temp.Length - 1);
                                txtPhepTinh.Text = PhepTinh;
                            }
                        }
                    }
                }

                if (temp.Length != 1)
                {
                    temp2 = temp2.Substring(0, temp2.Length - 1);
                }
                else
                {
                    temp2 = "0";
                }
                if (nearTT == '\0')
                {
                    if (KQ.Length == 1)
                    {
                        btnAC_Click(null, null);
                    }
                    else
                    {
                        KQ = KQ.Substring(0, KQ.Length - 1);
                        txtKQ.Text = KQ;
                    }
                }
            }

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {
            if(PhepTinh.Length>26)
            {
                temp = temp+ PhepTinh.Substring(0, 1);
                PhepTinh = PhepTinh.Substring(1, PhepTinh.Length - 1);
                txtPhepTinh.Text = PhepTinh;
            }
       if(nearTT == '\0')
            {
                txtKQ.Text = temp2;
                KQ = temp2;
            }
            if (lable1.Visible == true)
            {
                lable1.Visible = false;
                string temp3 = temp2;
                btnAC_Click(null, null);
                temp2 = temp3;
                KQ = temp2;
                PhepTinh = temp2;
                txtPhepTinh.Text = temp2;
                txtKQ.Text = temp2;
            }

            //----------------------------------------------------------------------- TEXXT
       
            
            
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            PhepTinh = "";
            temp = "";
            KQ = "0";
            txtPhepTinh.ResetText();
            txtKQ.Text = "0";
            temp2 = "";
            nearTT = '\0';
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtKQ.Text = KQ;
            lable1.Visible = false;

        }
        bool laToanTu(char t)
        {
            if (t != '+' || t != '-' || t != 'x' || t != ':')
                return true;
            return false;
        }

  
        private void tinh()
        {
            
            if (light==1)
            {
                if (nearTT == '\0')
                {
                    nearTT = '+';
                    KQ = temp2;
                    temp2 = "0";
                    txtKQ.Text = KQ;
                }
                else
                {
                    double kq = 0;
                    if (nearTT == '+')
                        kq = Double.Parse(temp2) + Double.Parse(KQ);
                    if (nearTT == '-')
                        kq = Double.Parse(KQ) - Double.Parse(temp2);
                    if (nearTT == 'x')
                        kq = Double.Parse(KQ) * Double.Parse(temp2);
                    if (nearTT == ':')
                        kq = Double.Parse(KQ) / Double.Parse(temp2);
                    temp2 = "";
                //    nearTT = '\0';
                    KQ = kq.ToString();
                    txtKQ.Text = KQ;
                    light = 0;
                }
               
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
         
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.D1)
                button1_Click(null, null);
            if (keyData == Keys.D2)
                button2_Click(null, null);
            if (keyData == Keys.D3)
                button3_Click(null, null);
            if (keyData == Keys.D4)
                btn4_Click(null, null);
            if (keyData == Keys.D5)
                btn5_Click(null, null);
            if (keyData == Keys.D6)
                btn6_Click(null, null);
            if (keyData == Keys.D7)
                btn7_Click(null, null);
            if (keyData == Keys.D8)
                btn8_Click(null, null);
            if (keyData == Keys.D9)
                btn9_Click(null, null);
            if (keyData == Keys.D0)
                btn0_Click(null, null);
            if (keyData == Keys.Escape)
                btnAC_Click(null, null);
            if (keyData == Keys.Back)
                btnDel_Click(null, null);
            if (keyData == Keys.Delete)
                btnDel_Click(null, null);
            if (keyData == Keys.Enter)
                btnBang_Click(null, null);
            if (keyData == Keys.Oemplus)
                btnCong_Click(null, null);
            if (keyData == Keys.OemMinus)
                btnTru_Click(null, null);
     
            return base.ProcessDialogKey(keyData);
        }
    }
}
