using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitale_muziekcollectie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<string> Albums = new List<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Albums.Add(textBox1.Text);
            foreach(var s in Albums)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(Albums.Contains(textBox1.Text))
            {
                MessageBox.Show("It does!");
            }
            else
            {
                MessageBox.Show("It doesn't!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                Albums.RemoveAt((Convert.ToInt32(numericUpDown1.Value - 1)));
                foreach (var s in Albums)
                {
                    listBox1.Items.Add(s);
                }
                MessageBox.Show("Album succesfully deleted!");
            }
            catch
            {
                MessageBox.Show("That album doesn't exist!");
            }
            }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Albums.Clear();
                listBox1.Items.Clear();
                MessageBox.Show("Deleteing all albums, Doomsday is here!");
            }
            else
            {
                MessageBox.Show("dan niet");
            }
        }
    }
}
