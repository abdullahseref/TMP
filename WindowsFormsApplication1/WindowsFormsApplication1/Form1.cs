using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string proc = Process.GetCurrentProcess().ProcessName;
            Process[] processes = Process.GetProcessesByName("WindowsFormsApplication1.vshost");
            if (processes.Length > 1)
            {
                MessageBox.Show("The application is already running");
                int currentProcess = Process.GetCurrentProcess().Id;
                foreach (Process item in processes)
                {
                    if (item.Id != currentProcess)
                    {
                        item.Kill();
                        item.WaitForExit();
                    }
                }
            }


        }
    }
}
