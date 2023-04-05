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
    public partial class Form2 : Form
    {
        int transfer = 0;
        int location1 = 50;
        int location2 = 50;
        public Form2(int random)
        {
            InitializeComponent();
            transfer = random;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < transfer; j++)
                {
                    Button tombol = new Button();
                    tombol.Size = new Size(50, 50);
                    tombol.Location = new Point(location1 + 50 * i, location2 + 50 * j) ;
                    tombol.Tag = i.ToString() + "," + j.ToString() + "," + 0.ToString();
                    this.Controls.Add(tombol);
                }
            }
        }

        private void BTN_Q_Click(object sender, EventArgs e)
        {
           
        }
    }
}
