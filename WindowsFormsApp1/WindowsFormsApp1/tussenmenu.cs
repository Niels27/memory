using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class tussenmenu : Form
    {
        //variabelen
        public tussenmenu()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hier moet code staan die spelernamen opvraagt
            int speleraantal = int.Parse(textBox1.Text);

            //checkt de radiobuttons
            if (radioButton1.Checked) {
                Form2 frm = new Form2();
                frm.Show();
                this.Close();
            }
            else if (radioButton2.Checked) {
                //link naar 6x6 grid
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }
    }
}
