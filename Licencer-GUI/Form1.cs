using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Licencer_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] office32setup = { "setup.exe /download Configuration-32.xml" , "setup.exe /configure configuration.xml" };
            string[] office64setup = { "setup.exe /download Configuration.xml", "setup.exe /configure configuration.xml" };
            string[] win10licence = { "slmgr /upk & slmgr /skms lisans.tk & slmgr /ipk NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J & slmgr /ato" };
            //string
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Process officeinstaller = new Process();
            textBox1.Text = "Wait for installation\nThis may take while downloading office. Depends on Your internet speed, 2GB data dowloading take a while ";
            Process officeinstaller = new Process();
            officeinstaller.StartInfo.UseShellExecute = false;
            officeinstaller.StartInfo.RedirectStandardOutput = true;
            MessageBox.Show("calisiyor");
            //if()
            //officeinstaller.StartInfo.FileName=

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void whichos(string ostype)
        {
           
            //bool isChecked = OSx86.Checked;
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            
            bool is32bit = !string.IsNullOrEmpty(
                Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432"));
                //OSx64.Checked = true;
            if(is32bit)
            {
                OSx86.Checked = true;
            }
            //if(!is32bit)
            {
                OSx64.Checked = true;
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "BLA";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //linkLabel1.Links.Add("test.com");
        }

        private void OSx64_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
