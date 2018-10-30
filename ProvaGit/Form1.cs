using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProvaGit
{
    public partial class Form1 : Form
    {
        List<int> vettore = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            vettore.Add(Convert.ToInt32(numericUpDown1.Value));
            vettore.Add(Convert.ToInt32(numericUpDown2.Value));
            vettore.Add(Convert.ToInt32(numericUpDown3.Value));
            vettore.Add(Convert.ToInt32(numericUpDown4.Value));
            vettore.Add(Convert.ToInt32(numericUpDown5.Value));
            MessageBox.Show("Max: " + vettore.Max().ToString() + " Min: " + vettore.Min().ToString());
            
        }

        
    }
}
