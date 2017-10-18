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

        

        private void button1_Click(object sender, EventArgs e)
        {
            //hier moet code staan die spelernamen opvraagt
            spelernamen.Clear();
            speleraantal = Convert.ToInt32(numericUpDown1.Value);
            if (speleraantal==1) { spelernamen.Add(textBox2.Text); }
          else  if (speleraantal == 2) { spelernamen.Add(textBox2.Text); spelernamen.Add(textBox3.Text); }
           else if (speleraantal == 3) { spelernamen.Add(textBox2.Text); spelernamen.Add(textBox3.Text); spelernamen.Add(textBox4.Text); }
           else if (speleraantal == 4) { spelernamen.Add(textBox2.Text); spelernamen.Add(textBox3.Text); spelernamen.Add(textBox4.Text); spelernamen.Add(textBox5.Text);  }




            

            //geen gekke tekens of lege naam
             label7.Visible = true;
            label7.Text = "goed";
                
            if (speleraantal == 1 && (textBox2.Text == "")) { label7.Text = "naam vergeten in te voeren"; }
            else if (speleraantal == 2 && ( textBox3.Text == "" || textBox2.Text == "")) { label7.Text = "naam vergeten in te voeren"; }
            else if (speleraantal == 3 && ( textBox4.Text == "" || textBox3.Text == "" || textBox2.Text == "")) { label7.Text = "naam vergeten in te voeren"; }
            else if (speleraantal == 4 && ( textBox5.Text == "" || textBox4.Text == "" || textBox3.Text == "" || textBox2.Text == "")) { label7.Text = "naam vergeten in te voeren"; }
            
            if (speleraantal == 1 && (textBox2.Text == "|")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 2 && (textBox3.Text == "|" || textBox2.Text == "|")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 3 && (textBox4.Text == "|" || textBox3.Text == "|" || textBox2.Text == "|")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 4 && (textBox5.Text == "|" || textBox4.Text == "|" || textBox3.Text == "|" || textBox2.Text == "|")) { label7.Text = "verboden teken"; }
         
            if (speleraantal == 1 && (textBox2.Text == "/")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 2 && (textBox3.Text == "/" || textBox2.Text == "/")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 3 && (textBox4.Text == "/" || textBox3.Text == "/" || textBox2.Text == "/")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 4 && (textBox5.Text == "/" || textBox4.Text == "/" || textBox3.Text == "/" || textBox2.Text == "/")) { label7.Text = "verboden teken"; }
           
            if (speleraantal == 1 && (textBox2.Text == "*")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 2 && (textBox3.Text == "*" || textBox2.Text == "*")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 3 && (textBox4.Text == "*" || textBox3.Text == "*" || textBox2.Text == "*")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 4 && (textBox5.Text == "*" || textBox4.Text == "*" || textBox3.Text == "*" || textBox2.Text == "*")) { label7.Text = "verboden teken"; }
           
            if (speleraantal == 1 && (textBox2.Text == ";")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 2 && (textBox3.Text == ";" || textBox2.Text == ";")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 3 && (textBox4.Text == ";" || textBox3.Text == ";" || textBox2.Text == ";")) { label7.Text = "verboden teken"; }
            else if (speleraantal == 4 && (textBox5.Text == ";" || textBox4.Text == ";" || textBox3.Text == ";" || textBox2.Text == ";")) { label7.Text = "verboden teken"; }







            //checkt de radiobuttons en of de namen goed zijn, dan opent het spelbord pas
            if (radioButton1.Checked && label7.Text == "goed")
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Close();
            }
            else if (radioButton2.Checked)
            {
                //link naar 6x6 grid
            }


        }
        //terug naar hoofdmenu
            private void button2_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

      
        // geeft juiste aantal textboxjes voor invoer spelernamen afhankelijk van speleraantal
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
             speleraantal = Convert.ToInt32(numericUpDown1.Value);
            if (speleraantal==1) { textBox3.Visible = false; label4.Visible = false; textBox4.Visible = false; label5.Visible = false; textBox5.Visible = false; label6.Visible = false; }
            else if (speleraantal==2) { textBox3.Visible = true; label4.Visible = true; textBox4.Visible = false; label5.Visible = false; textBox5.Visible = false; label6.Visible = false; }
            else if (speleraantal == 3) { textBox4.Visible = true; label5.Visible = true; textBox5.Visible = false; label6.Visible = false; }
           else if (speleraantal == 4) {textBox5.Visible = true; label6.Visible = true; }

        }

     

       
        
               


          
    }
}
