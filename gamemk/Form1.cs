using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gamemk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int i = 0;
        public char k = ' ';
       

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Visible = false;
            timer1.Enabled = true;
            
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            i++;
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            k = (char)e.KeyChar;
            
            this.Text = i.ToString();
            this.Text += ":" + k.ToString();
        }
    }
}
