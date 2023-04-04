using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AD_TakeHome_W6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Play_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TB_Input.Text) || Convert.ToInt32(TB_Input.Text) < 3) 
            {
                MessageBox.Show("Input more than 3");
            }
            else
            {
                int x = Convert.ToInt32(TB_Input.Text);
                BTN_P form2 = new BTN_P(x);
                form2.ShowDialog();
            }
            
            
        }
    }
}
