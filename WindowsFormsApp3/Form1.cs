using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int r = 0;
        public void button1_Click(object sender, EventArgs e)
        {
            double sr = Convert.ToDouble(comboBox1.Text);
            double sr1 = Convert.ToDouble(comboBox2.Text);
            double sr2 = Convert.ToDouble(comboBox3.Text);
            double sr3 = Convert.ToDouble(comboBox4.Text);
            double sr4 = Convert.ToDouble(comboBox5.Text);
            double sr5 = Convert.ToDouble(comboBox6.Text);
            double sr6 = Convert.ToDouble(comboBox7.Text);
            double sr7 = Convert.ToDouble(comboBox8.Text);
            double sr8 = Convert.ToDouble(comboBox9.Text);
            int srz = Convert.ToInt32((sr + sr1 + sr2 + sr3 + sr4 + sr5 + sr6 + sr7 + sr8) / 9);
            if (srz > 3)
            {
                r++;
            }

            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Заполните данные");
            }
            else
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + " " + comboBox1.Text + " " + comboBox2.Text + " " + comboBox3.Text + " " +
                " " + comboBox4.Text + " " + " " + comboBox5.Text + " " + " " + comboBox6.Text + " " + " " + comboBox7.Text + " " + " " + comboBox8.Text + " " + " " + comboBox9.Text + " " + " Среднее значение оценок -->" + " " + srz);

            using (System.IO.StreamWriter Ocenki = new System.IO.StreamWriter("C:/Users/delke/Desktop/1.txt"))
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                    Ocenki.WriteLine(listBox1.Items[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (System.IO.StreamReader sr = new System.IO.StreamReader("C:/Users/delke/Desktop/1.txt"))
            {
                while (!sr.EndOfStream)
                {
                    listBox1.Items.Add(sr.ReadLine());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter wr = new StreamWriter("C:/Users/delke/Desktop/1.txt");
            wr.WriteLine("");
            wr.Close();

            listBox1.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            using (StreamReader read = new StreamReader("C:/Users/delke/Desktop/1.txt"))
                foreach (string str in read.ReadToEnd().Split(new Char[] { '\n' }))
                {
                    if (str.Contains(textBox3.Text))
                    {
                        listBox1.Items.Add(str);
                    }

                }
        }

        public void button6_Click(object sender, EventArgs e)
        { 
            listBox2.Items.Add("Кол-во оценок среднего балла = " + r);
        }
    }
}
