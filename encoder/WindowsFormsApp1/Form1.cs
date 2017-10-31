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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static bool laden = false;

        List<string> naam = new List<string>();
        int tussengetal1 = 0;
        int totaalgetal = 0;

        char[] schrijf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ';', '/', '|', '*', ' ' };

        char[] tekenlijst = {'q','w','e','r','t','y','u','i','o','p','[',']','a','s','d','f','g','h','j','k','l',';','{','|','z','x','c','v','b','n','m',',','.','/',
                                    '1','2','3','4','5','6','7','8','9','0','!','@','#','$','%','^','&','*','(',')','_','-','=','+','Q','W','E','R','T','Y','U','I','O','P',
                                    'A','S','D','F','G','H','J','K','L','Z','X','C','V','B'};
        public Form1()
        {
            InitializeComponent();

            string path = @"c:\memorygroep24\highscores.sav";
            string path2 = @"c:\memorygroep24\memory.sav";
            string path3 = @"c:\memorygroep24/winverlies.sav";
            if (!File.Exists(path))
            {
                System.IO.Directory.CreateDirectory(@"c:\memorygroep24");
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(";naamloos;naamloos;naamloos;naamloos;naamloos;naamloos;naamloos;naamloos;naamloos;naamloos;/0/0/0/0/0/0/0/0/0/0/");
                    sw.Close();
                }
                using (StreamWriter ow = File.CreateText(path2)) 
                { ow.Write("aantal spelers: 1 spelernamen: ;Singleplayer; spelerscores: |0| disableerbool: /False/False/False/False/False/False/False/False/False/False/False/False/False/False/False/False/ volgordelijst: *7*1*6*5*4*7*2*3*6*0*4*0*3*1*2*5*");
                    ow.Close(); }

                using (StreamWriter ok = File.CreateText(path3))
                {
                    ok.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tussenmenu frm = new tussenmenu();
            frm.Show();
            this.Hide();
            
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1.laden = true;

            //blabla 



            string savefile = System.IO.File.ReadAllText(@"c:\memorygroep24\memory.sav"); // Het pad van de savefile. Let op! geen '/' maar '\'!

            /*
             code decoderen
             */
            string text2 = savefile;

            char[] arrey = text2.ToCharArray();
            int teller = 0;
            for (int i = 0; i < arrey.Length; i++)
            {
                if (teller > 41) { teller = 0; }

                for (int j = 0; j < tekenlijst.Length; j++)
                {
                    if (arrey[i] == tekenlijst[j]) { tussengetal1 = j + 1; totaalgetal = tussengetal1 - teller; }
                }

                teller++;

                for (int h = 0; h < schrijf.Length; h++)
                {
                    if (totaalgetal == h + 1) { naam.Add(Convert.ToString(schrijf[h])); }
                }
            }

            string dec = "";
            for (int i = 0; i < naam.Count; i++)
            {
                dec += "" + naam[i];
            }
            savefile = dec;
            naam.Clear();
            /*
             //einde code decoderen
             */

            // waarin de gegevens worden opgeslagen:



            List<int> detector = new List<int>();
            // // // // // //

            char[] ree = savefile.ToCharArray();
            
            //(deel 1)neemt de exacte plek over van de arree, bepaalt speleraantal
            for (int i = 0; i < ree.Length; i++) //lokaliseert namen door de ';'s te lokaliseren.
            {
                if (ree[i] == ';') { detector.Add(i); }
            }

            tussenmenu.spelernamen.Clear();

            for (int i = 0; i < (detector.Count - 1); i++) //(deel 2) zet de namen vervolgens in een string en voegt het toe aan de List
            {

                string plv = "";
                for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                {
                    plv += ree[j];
                }
                tussenmenu.spelernamen.Add(plv); //zet het in de list
            }
            detector.Clear();//maakt detector leeg

            tussenmenu.speleraantal = tussenmenu.spelernamen.Count();

            for (int i = 0; i < ree.Length; i++) //lokaliseert scores door de '|'s te lokaliseren.
            {
                if (ree[i] == '|') { detector.Add(i); }
            }

            tussenmenu.spelerscores.Clear(); //test om dit te clearen.
            for (int i = 0; i < (detector.Count - 1); i++) //(deel 2) zet de scores vervolgens in een string en voegt het toe aan de List
            {
                string plv = "";
                for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                {
                    plv += ree[j];
                }
                tussenmenu.spelerscores.Add(int.Parse(plv)); //zet het in de list
            }
            detector.Clear();//maakt detector leeg



            for (int i = 0; i < ree.Length; i++) //lokaliseert pictureposities door de '*'s te lokaliseren.
            {
                if (ree[i] == '*') { detector.Add(i); }
            }

            tussenmenu.volgordelijst.Clear();
            for (int i = 0; i < (detector.Count - 1); i++) //(deel 2) zet de posities vervolgens in een string en voegt het toe aan de List
            {
                string plv = "";
                for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                {
                    plv += ree[j];
                }
                tussenmenu.volgordelijst.Add(int.Parse(plv)); //zet het in de list
            }
            detector.Clear();//maakt detector leeg



            for (int i = 0; i < ree.Length; i++) //lokaliseert bools door de '/'s te lokaliseren.
            {
                if (ree[i] == '/') { detector.Add(i); }
            }
            int grid = detector.Count();

            if (detector.Count < 18)
            {

                for (int i = 0; i < (detector.Count - 1); i++) //(deel 2) zet de bools vervolgens in een string en voegt het toe aan de List
                {
                    string plv = "";
                    for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                    {
                        plv += ree[j];
                    }
                    tussenmenu.disableer[i] = bool.Parse(plv); //zet het in de bool[]

                }
                detector.Clear();
            }
            else
            {
                for (int i = 0; i < (detector.Count - 1); i++) //(deel 2) zet de bools vervolgens in een string en voegt het toe aan de List
                {
                    string plv = "";
                    for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                    {
                        plv += ree[j];
                    }
                    tussenmenu.disableer2[i] = bool.Parse(plv); //zet het in de bool[]

                }
                detector.Clear();
            }


            //checkt welk grid het is en opent bijbehorende form.
            if (grid < 18)
            {
                Form2 frm = new Form2();
                frm.Show();
                this.Hide();
            }
            else
            {
                Form3 frm = new Form3();
                frm.Show();
                this.Hide();
            }

        }
    }
}
