using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestioneOrdini
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "risultato della divisione";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                comboBox1.Items.Add(i);
            }

            for (int i = 0; i < 50; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ((int)comboBox1.SelectedItem / (int)comboBox2.SelectedItem).ToString();
        }
    }
}
