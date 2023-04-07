using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace AD_TakeHome_W6
{
    public partial class Form2 : Form
    {
        string answer="";
        string guess = "";
        int line;
        int transfer = 0;
        int location1 = 50;
        int location2 = 50;
        string[] listanswers = File.ReadAllText("Wordle Word List.txt").Split(',');
        List<string> hijau = new List<string>();
        int wincondition = 0;

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
                    tombol.Tag = j.ToString() + "," + i.ToString();
                    this.Controls.Add(tombol);

                }
            }
            createanswer();
        }

        private void createanswer()
        {
            Random random = new Random();
            answer = listanswers[random.Next(0, listanswers.Length - 1)].ToUpper();
        }

        private void Update(string keypress)
        {
            if (keypress == "ENTER")
            {
                solution();
                checkgreen();
                checkyellow();
                condition();
            }
            else if (keypress == "DELETE")
            {
                DeleteButton(guess.Length);
            }
            else
            {
                if(guess.Length == 5)
                {

                }
                else
                {
                    guess = guess + keypress.ToUpper(); ;
                }
                UpdateButtonPannel(guess.Length);
            }
        }

        private void UpdateButtonPannel(int keylength)
        {
            for(int i = 0; i < 5; i++)
            {
                foreach(Button button in this.Controls.OfType <Button> ())
                {
                    string tag = button.Tag.ToString();
                    if (tag == line.ToString() + "," + i.ToString() && i < keylength)
                    {
                        button.Text = guess[i].ToString();
                    }
                    else if(tag == line.ToString() + "," + i.ToString())
                    {
                        button.Text = "";
                    }
                }   
            } 
        }

        private void checkgreen() 
        {
            wincondition = 0;
            for( int i = 0; i < 5; i++)
            {
                foreach (Button button in this.Controls.OfType <Button> ())
                {
                    string tagurit = button.Tag.ToString();
                    if (tagurit == line.ToString() + "," + i.ToString())
                    {
                        if (guess[i] == answer[i]) 
                        {
                            button.BackColor = Color.LightGreen;
                            hijau[i] = "";
                            wincondition++;
                        }   
                    }
                }
            }
        }

        private void checkyellow()
        {
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0 ; j < 5 ; j++)
                {
                    foreach (Button button in this.Controls.OfType<Button>())
                    {
                        string tagurit = button.Tag.ToString();
                        if (tagurit == line.ToString() + "," + i.ToString())
                        {
                            if (guess[i].ToString() == hijau[j].ToString() && button.BackColor != Color.LightGreen && hijau[j] != "")
                            {
                                button.BackColor = Color.Yellow;
                                hijau[i] = "";
                            }
                        }
                    }
                }    
            }
        }

        private void solution()
        {
            for(int i = 0; i < 5; i++)
            {
                hijau.Add(answer[i].ToString());
            }
        }

        private void condition()
        {
            line++;
            guess = "";
            if(wincondition == 5)
            {
                MessageBox.Show("Congratulations, You Win!");
                this.Close();
            }
            else if(line == transfer && wincondition != 5)
            {
                MessageBox.Show("The answer was " + answer + " You Lose!");
                this.Close();
            }
            
        }

        
        private void DeleteButton(int keylength)
        {
            guess = guess.Substring(0, guess.Length - 1);
            UpdateButtonPannel(guess.Length);
        }


        private void BTN_Q_Click(object sender, EventArgs e)
        {
            Update("Q");
        }

        private void BTN_W_Click(object sender, EventArgs e)
        {
            Update("W");
        }

        private void BTN_E_Click(object sender, EventArgs e)
        {
            Update("E");
        }

        private void BTN_R_Click(object sender, EventArgs e)
        {
            Update("R");
        }

        private void BTN_T_Click(object sender, EventArgs e)
        {
            Update("T");
        }

        private void BTN_Y_Click(object sender, EventArgs e)
        {
            Update("Y");
        }

        private void BTN_U_Click(object sender, EventArgs e)
        {
            Update("U");
        }

        private void BTN_I_Click(object sender, EventArgs e)
        {
            Update("I");
        }

        private void BTN_O_Click(object sender, EventArgs e)
        {
            Update("O");
        }

        private void BTN_P_Click(object sender, EventArgs e)
        {
            Update("P");
        }

        private void BTN_A_Click(object sender, EventArgs e)
        {
            Update("A");
        }

        private void BTN_S_Click(object sender, EventArgs e)
        {
            Update("S");
        }

        private void BTN_D_Click(object sender, EventArgs e)
        {
            Update("D");
        }

        private void BTN_F_Click(object sender, EventArgs e)
        {
            Update("F");
        }

        private void BTN_G_Click(object sender, EventArgs e)
        {
            Update("G");
        }

        private void BTN_H_Click(object sender, EventArgs e)
        {
            Update("H");
        }

        private void BTN_J_Click(object sender, EventArgs e)
        {
            Update("J");
        }

        private void BTN_K_Click(object sender, EventArgs e)
        {
            Update("K");
        }

        private void BTN_L_Click(object sender, EventArgs e)
        {
            Update("L");
        }

        private void BTN_Z_Click(object sender, EventArgs e)
        {
            Update("Z");
        }

        private void BTN_X_Click(object sender, EventArgs e)
        {
            Update("X");
        }

        private void BTN_C_Click(object sender, EventArgs e)
        {
            Update("C");
        }

        private void BTN_V_Click(object sender, EventArgs e)
        {
            Update("V");
        }

        private void BTN_B_Click(object sender, EventArgs e)
        {
            Update("B");
        }

        private void BTN_N_Click(object sender, EventArgs e)
        {
            Update("N");
        }

        private void BTN_M_Click(object sender, EventArgs e)
        {
            Update("M");
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            Update("DELETE");
        }

        private void BTN_Enter_Click(object sender, EventArgs e)
        {
            Update("ENTER");
        }
    }
}
