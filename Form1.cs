using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are u sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes) { 
         
                this.Close();


            } else
            {
                MessageBox.Show("I love you!!!!", "To Whom It May Concern");
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Text = "Close Form";
        }
    }
}
