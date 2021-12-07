using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheNumbers
{
    public partial class Form1 : Form
    {
        Random rand;
        List<int> list;      
        int[] array;
        int[] tmp;
        int number;
        int timerLeft;
        int count;
        int meter;
        
        public Form1()
        {
            InitializeComponent();
            rand = new Random();
            list = new List<int>();
            number = 0;
            array = new int[16];
            tmp = new int[16];
            count = 0;
            meter = 0;
           
        }

        public void UniqueRandom()
        {
            do
            {
                number = rand.Next(0, 101);
                if (!list.Contains(number))
                    list.Add(number);
            } while (list.Count!=16);
            array = list.ToArray();
            
            number = 0;
            btn1.Text = array[0].ToString();
            btn2.Text = array[1].ToString();
            btn3.Text = array[2].ToString();
            btn4.Text = array[3].ToString();
            btn5.Text = array[4].ToString();
            btn6.Text = array[5].ToString();
            btn7.Text = array[6].ToString();
            btn8.Text = array[7].ToString();
            btn9.Text = array[8].ToString();
            btn10.Text = array[9].ToString();
            btn11.Text = array[10].ToString();
            btn12.Text = array[11].ToString();
            btn13.Text = array[12].ToString();
            btn14.Text = array[13].ToString();
            btn15.Text = array[14].ToString();
            btn16.Text = array[15].ToString();
            list.Sort();
            tmp = list.ToArray();
            list.Clear();

        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (nud.Value == 0)
                MessageBox.Show("Значение поля \"Время игры\" не может быть равно 0.");
            else
            {
                UniqueRandom();
                EnableOrDisableOfButton(true);
                count = 0;
                lb.Items.Clear();
                if(meter!=0)
                    NullTextOfButton();
                timer.Start();
                timerLeft = (int)nud.Value;
                pb.Maximum = timerLeft;
                pb.Value = timerLeft;
                
            }
        }

        public void EnableOrDisableOfButton(bool boo)
        {

            btn1.Enabled = boo;
            btn2.Enabled = boo;
            btn3.Enabled = boo;
            btn4.Enabled = boo;
            btn5.Enabled = boo;
            btn6.Enabled = boo;
            btn7.Enabled = boo;
            btn8.Enabled = boo;
            btn9.Enabled = boo;
            btn10.Enabled =boo;
            btn11.Enabled =boo;
            btn12.Enabled =boo;
            btn13.Enabled =boo;
            btn14.Enabled =boo;
            btn15.Enabled =boo;
            btn16.Enabled =boo;
        }

        public void NullTextOfButton()
        {
            btn1.Text = null;
            btn2.Text = null;
            btn3.Text = null;
            btn4.Text = null;
            btn5.Text = null;
            btn6.Text = null;
            btn7.Text = null;
            btn8.Text = null;
            btn9.Text = null;
            btn10.Text = null;
            btn11.Text = null;
            btn12.Text = null;
            btn13.Text = null;
            btn14.Text = null;
            btn15.Text = null;
            btn16.Text = null;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(timerLeft>0)
            {
                timerLeft--;
                pb.Value--;
                Text = timerLeft + " seconds";
            }
            else
            {
                timer.Stop();
                DialogResult dialogResult = MessageBox.Show("Начать новую игру?", "Время вышло. Вы проиграли!", MessageBoxButtons.YesNo);
                Restart(dialogResult);

            }
        }

        public void AddNumber(Button b)
        {           
            int numeric = int.Parse(b.Text);
            
            if (tmp[count]==numeric)
            {
                lb.Items.Add(numeric);
                lb.SelectedIndex = count;
                b.Enabled = false;
                count++;
            }
            if(count==16)
            {
                timer.Stop();
                DialogResult dialogResult = MessageBox.Show("Начать новую игру?","Вы выиграли!", MessageBoxButtons.YesNo);
                Restart(dialogResult);
            }


        }

        public void Restart(DialogResult result)
        {
            if (result == DialogResult.Yes)
            {
               
                count = 0;
                lb.Items.Clear();
                NullTextOfButton();
                EnableOrDisableOfButton(true);
            }
            else if (result == DialogResult.No)
            {
                Close();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            AddNumber(btn1);
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            AddNumber(btn2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            AddNumber(btn3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            AddNumber(btn4);
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            AddNumber(btn5);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            AddNumber(btn6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            AddNumber(btn7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            AddNumber(btn8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            AddNumber(btn9);
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            AddNumber(btn10);
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            AddNumber(btn11);
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            AddNumber(btn12);
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            AddNumber(btn13);
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            AddNumber(btn14);
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            AddNumber(btn15);
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            AddNumber(btn16);
        }
    }
}
