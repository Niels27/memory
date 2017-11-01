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
    /// <summary>
    /// Het tussenmenu is bedoeld om informatie te verzamelen over het te maken scherm. 
    /// Opties zijn:
    ///  - Speleraantal kiezen
    ///  - Spelernamen invullen
    ///  - Gridgrootte.
    /// 
    /// Opmerkingen:
    /// De variabelen zijn public.
    /// </summary>
    public partial class tussenmenu : Form
    {
        
        /// <summary>
        /// De variabelen zijn public. Wanneer een spel geladen wordt, worden deze public variabelen ingevuld vanuit de safefile,
        /// daarna een scherm heropend. 
        /// 
        /// - speleraantal is.... het speleraantal.
        /// - spelernamen is een List waarin spelernamen geädd worden.
        /// - disableer is een boolean array. Iedere index staat voor een picturebox. Als die waarde op die index true is, moet die picturebox
        ///   bij het laden de "omgedraaide kaart" tonen.
        /// - volgordelijst bevat welke kaart op welke pictureboxindex staat. We hebben getallen 0-7 gehanteerd voor 4*4 memory, 0-11 voor 
        ///   6*4 memory. Het getal staat dus voor welke kaart omgedraaid zou moeten worden wanneer op de picturebox geklikt wordt.
        /// - spelerscores is een List waarin de scores van de speler komen te staan, die worden opgedate iedere keer dat er gescoord wordt.
        /// - disableer2 is een boolean arary en werkt hetzelfde als disableer. het is alleen een langere array, omdat deze is voor 6*4 memory.
        /// </summary>
        public static int speleraantal = 0;
        public static List<string> spelernamen = new List<string>();
        public static bool[] disableer = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };
        public static List<int> volgordelijst = new List<int>();
        public static List<int> spelerscores = new List<int>();
        public static bool[] disableer2 = { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, };


        /// <summary>
        /// Inhoud van tussenmenu().
        /// 
        /// - Wanneer je in het tussenmenu komt, wil je een nieuw spel spelen, dus het eerste wat gebeurt is dat de variabelen van het
        ///   tussenmenu worden gereset. 
        ///   
        /// </summary>
        public tussenmenu()
        {



            InitializeComponent();

            //reset de waarden bij het starten van het tussenmenu
            tussenmenu.spelernamen.Clear();
            tussenmenu.volgordelijst.Clear();
            tussenmenu.spelerscores.Clear();
            tussenmenu.disableer[0] = false;
            tussenmenu.disableer[1] = false;
            tussenmenu.disableer[2] = false;
            tussenmenu.disableer[3] = false;
            tussenmenu.disableer[4] = false;
            tussenmenu.disableer[5] = false;
            tussenmenu.disableer[6] = false;
            tussenmenu.disableer[7] = false;
            tussenmenu.disableer[8] = false;
            tussenmenu.disableer[9] = false;
            tussenmenu.disableer[10] = false;
            tussenmenu.disableer[11] = false;
            tussenmenu.disableer[12] = false;
            tussenmenu.disableer[13] = false;
            tussenmenu.disableer[14] = false;
            tussenmenu.disableer[15] = false;

            tussenmenu.disableer2[0] = false;
            tussenmenu.disableer2[1] = false;
            tussenmenu.disableer2[2] = false;
            tussenmenu.disableer2[3] = false;
            tussenmenu.disableer2[4] = false;
            tussenmenu.disableer2[5] = false;
            tussenmenu.disableer2[6] = false;
            tussenmenu.disableer2[7] = false;
            tussenmenu.disableer2[8] = false;
            tussenmenu.disableer2[9] = false;
            tussenmenu.disableer2[10] = false;
            tussenmenu.disableer2[11] = false;
            tussenmenu.disableer2[12] = false;
            tussenmenu.disableer2[13] = false;
            tussenmenu.disableer2[14] = false;
            tussenmenu.disableer2[15] = false;
            tussenmenu.disableer2[16] = false;
            tussenmenu.disableer2[17] = false;
            tussenmenu.disableer2[18] = false;
            tussenmenu.disableer2[19] = false;
            tussenmenu.disableer2[20] = false;
            tussenmenu.disableer2[21] = false;
            tussenmenu.disableer2[22] = false;
            tussenmenu.disableer2[23] = false;


         
        }


        /// <summary>
        /// button1_click checkt de ingevoerde informatie.
        /// </summary>
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

            char[] tsjek1 = (textBox2.Text).ToCharArray(); for (int i = 0; i < tsjek1.Length; i++) { if (tsjek1[i] == ';' || tsjek1[i] == '|' || tsjek1[i] == '/' || tsjek1[i] == '*') { label7.Text = "voer geen gekke tekens in"; } }
            char[] tsjek2 = (textBox3.Text).ToCharArray(); for (int i = 0; i < tsjek2.Length; i++) { if (tsjek2[i] == ';' || tsjek2[i] == '|' || tsjek2[i] == '/' || tsjek2[i] == '*') { label7.Text = "voer geen gekke tekens in"; } }
            char[] tsjek3 = (textBox4.Text).ToCharArray(); for (int i = 0; i < tsjek3.Length; i++) { if (tsjek3[i] == ';' || tsjek3[i] == '|' || tsjek3[i] == '/' || tsjek3[i] == '*') { label7.Text = "voer geen gekke tekens in"; } }
            char[] tsjek4 = (textBox5.Text).ToCharArray(); for (int i = 0; i < tsjek4.Length; i++) { if (tsjek4[i] == ';' || tsjek4[i] == '|' || tsjek4[i] == '/' || tsjek4[i] == '*') { label7.Text = "voer geen gekke tekens in"; } }





            //checkt de radiobuttons en of de namen goed zijn, dan opent het spelbord pas
            if (radioButton1.Checked&&label7.Text =="goed")
            {
                Spelbord4x4 frm = new Spelbord4x4();
                frm.Show();
                this.Close();
            }
            else if (radioButton2.Checked&&label7.Text == "goed")
            {
                Spelbord6x4 frm = new Spelbord6x4();
                frm.Show();
                this.Close();
            }


        }
        //terug naar hoofdmenu
            private void button2_Click(object sender, EventArgs e)
        {
            Hoofdmenu frm = new Hoofdmenu();
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
