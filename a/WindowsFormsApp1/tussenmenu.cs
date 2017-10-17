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
        public static int speleraantal = 0;
        public static List<string> spelernamen = new List<string>();
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
            spelernamen.Clear();
            speleraantal = Convert.ToInt32(numericUpDown1.Value);
            if (speleraantal==1) { spelernamen.Add(textBox2.Text); }
          else  if (speleraantal == 2) { spelernamen.Add(textBox2.Text); spelernamen.Add(textBox3.Text); }
           else if (speleraantal == 3) { spelernamen.Add(textBox2.Text); spelernamen.Add(textBox3.Text); spelernamen.Add(textBox4.Text); }
           else if (speleraantal == 4) { spelernamen.Add(textBox2.Text); spelernamen.Add(textBox3.Text); spelernamen.Add(textBox4.Text); spelernamen.Add(textBox5.Text);  }


            //checkt de radiobuttons
            if (radioButton1.Checked) {
                /*Form2 frm = new Form2();
                frm.Show();
                this.Close(); */
            }
            else if (radioButton2.Checked) {
                //link naar 6x6 grid
            }


            

            for (int j = 0; j < speleraantal; j++) {


                char[] tsjek = spelernamen[j].ToCharArray();

                if (spelernamen[j] == "") { label7.Text = "naam vergeten in te voeren"; }
                else { label7.Text = "goed"; }
                for (int i = 0; i < tsjek.Length; i++)
                {
                    if (tsjek[i] == ';' || tsjek[i] == '|' || tsjek[i] == '/' || tsjek[i] == '*')
                    {
                        label7.Text = "voer geen gekke tekens in";
                    }
                   
                }
            }
            



            }

            private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             speleraantal = Convert.ToInt32(numericUpDown1.Value);
            if (speleraantal==1) { textBox3.Visible = false; label4.Visible = false; textBox4.Visible = false; label5.Visible = false; textBox5.Visible = false; label6.Visible = false; }
            else if (speleraantal==2) { textBox3.Visible = true; label4.Visible = true; textBox4.Visible = false; label5.Visible = false; textBox5.Visible = false; label6.Visible = false; }
            else if (speleraantal == 3) { textBox4.Visible = true; label5.Visible = true; textBox5.Visible = false; label6.Visible = false; }
           else if (speleraantal == 4) {textBox5.Visible = true; label6.Visible = true; }

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e, int speleraantal)
        {
            
        }

        private void label4_Click(object sender, EventArgs e, int speleraantal)
        {
           
        }

        

       
        
               


          
    }
}
