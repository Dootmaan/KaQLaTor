using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaQLaTor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AllClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.result = 0;
            this.pre = "";
            this.result_label.Text = result.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            
            pre += "1";
            this.result_label.Text = pre;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            pre += "2";
            this.result_label.Text = pre;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            pre += "3";
            this.result_label.Text = pre;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            pre += "4";
            this.result_label.Text = pre;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            pre += "5";
            this.result_label.Text = pre;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            pre += "6";
            this.result_label.Text = pre;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            pre += "7";
            this.result_label.Text = pre;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            pre += "8";
            this.result_label.Text = pre;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            pre += "9";
            this.result_label.Text = pre;
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            if (!this.use_dot)
            {
                pre += ".";
                this.use_dot = true;
                this.result_label.Text = pre;
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (this.use_equal)
            {
                use_equal = false;
                this.pre = "";
            }
            if (pre != "")
            {
                pre += "0";
                this.result_label.Text = pre;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            //=
            this.use_equal = true;
            this.use_dot = false;
            if (preOp != "") //否则不改变输出
            {
                double previous = Double.Parse(this.pre);
                if (preOp == "+")
                {
                    result = result + previous;
                }
                if (preOp == "-")
                {
                    result = result - previous;
                }
                if (preOp == "*")
                {
                    result = result * previous;
                }
                if (preOp == "/")
                {
                    result = result / previous;
                }
                this.result_label.Text = result.ToString();
                this.preOp = "";
                this.pre = result.ToString();
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //+
            this.use_dot = false;
            double previous = Double.Parse(this.pre);
            if (preOp == "")
            {
                this.result = previous;
            }
            else
            {
                if (preOp == "+")
                {
                    result = result + previous;
                }
                if (preOp == "-")
                {
                    result = result - previous;
                }
                if (preOp == "*")
                {
                    result = result * previous;
                }
                if (preOp == "/")
                {
                    result = result / previous;
                }
            }
            preOp = "+";
            this.pre = "";
            this.result_label.Text = result.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            //-
            this.use_dot = false;
            double previous = Double.Parse(this.pre);
            if (preOp == "")
            {
                this.result = previous;
            }
            else
            {
                if (preOp == "+")
                {
                    result = result + previous;
                }
                if (preOp == "-")
                {
                    result = result - previous;
                }
                if (preOp == "*")
                {
                    result = result * previous;
                }
                if (preOp == "/")
                {
                    result = result / previous;
                }
            }
            preOp = "-";
            this.pre = "";
            this.result_label.Text = result.ToString();
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            //*
            this.use_dot = false;
            double previous = Double.Parse(this.pre);
            if (preOp == "")
            {
                this.result = previous;
            }
            else
            {
                if (preOp == "+")
                {
                    result = result + previous;
                }
                if (preOp == "-")
                {
                    result = result - previous;
                }
                if (preOp == "*")
                {
                    result = result * previous;
                }
                if (preOp == "/")
                {
                    result = result / previous;
                }
            }
            preOp = "*";
            this.pre = "";
            this.result_label.Text = result.ToString();
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            // /
            this.use_dot = false;
            double previous = Double.Parse(this.pre);
            if (preOp == "")
            {
                this.result = previous;
            }
            else
            {
                if (preOp == "+")
                {
                    result = result + previous;
                }
                if (preOp == "-")
                {
                    result = result - previous;
                }
                if (preOp == "*")
                {
                    result = result * previous;
                }
                if (preOp == "/")
                {
                    result = result / previous;
                }
            }
            preOp = "/";
            this.pre = "";
            this.result_label.Text = result.ToString();
        }
    }
}
