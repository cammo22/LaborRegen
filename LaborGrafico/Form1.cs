using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaborGrafico
{
    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variabile
            int labor, laborpieni = 5000, labormancanti,calcolo,tempo;
            labor = Convert.ToInt32(textBox1.Text);
            labormancanti = laborpieni - labor;
            textBox2.Text = labormancanti.ToString();
            calcolo = labormancanti / 10;
            tempo = calcolo * 5;
            DateTime today = DateTime.Now;
            DateTime newDate2 = today.AddMinutes(tempo);
            textBox3.Text = newDate2.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToLongTimeString();

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Text = DateTime.Now.ToLongTimeString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_Click(object sender, EventArgs e)
        {


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox3.Text);
        }

    }
}
