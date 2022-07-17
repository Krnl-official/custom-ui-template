/*
 * 
 *      <- Krnl custom ui template (.NET Framework) ->
 *               Unrestricted use permitted
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KrnlAPI;

namespace custom_ui_template_framework
{
    public partial class Form1 : Form
    {
        KrnlApi krnlAPI = new KrnlApi();

        public Form1()
        {
            InitializeComponent();
            krnlAPI.Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (krnlAPI.IsInjected())
            {
                krnlAPI.Execute(richTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Please inject before executing a script");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(!krnlAPI.IsInjected())
            {
                krnlAPI.Inject();
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
