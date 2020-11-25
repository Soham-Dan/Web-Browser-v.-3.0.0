using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Brower
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.GoHome();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                webBrowser1.GoBack();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                webBrowser1.GoForward();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string WebPage = textBox1.Text.Trim();
            webBrowser1.Navigate(WebPage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Following webpages are not supported:\n1. Google Sites\n2.All high Graphics and CSS Styling Web Pages\n\nPages Supported:\n1.All Microsoft Web Pages.",
                            "Web Pages Supported and Not Supported",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation,
                             MessageBoxDefaultButton.Button1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            MessageBox.Show(current.ToString());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a OpenSource Project By Soham Dandekar\nVersion: 3.0.0\n\nContact Details:\nEmail: sohamdanprog2008@gmail.com\n\nFor Other Versions Please Go to https://drive.google.com/drive/folders/1ewMj5J_wIk7mhi5oFs2KS3-tn86KtLmp?usp=sharing \n\nThank You...\n",
                            "About",
                            MessageBoxButtons.OK);
        }
    }
}
