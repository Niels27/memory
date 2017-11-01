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
    public partial class eindespel : Form
    {
        List<string> naam = new List<string>();

        int tussengetal1 = 0;
        int totaalgetal = 0;

        char[] schrijf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ';', '/', '|', '*', ' ' };

        char[] tekenlijst = {'q','w','e','r','t','y','u','i','o','p','[',']','a','s','d','f','g','h','j','k','l',';','{','|','z','x','c','v','b','n','m',',','.','/',
                                    '1','2','3','4','5','6','7','8','9','0','!','@','#','$','%','^','&','*','(',')','_','-','=','+','Q','W','E','R','T','Y','U','I','O','P',
                                    'A','S','D','F','G','H','J','K','L','Z','X','C','V','B'};

        public eindespel()
        {
            InitializeComponent();

            

            //waarden die vanuit het memorybord moeten worden gehaald:
            List<string> spelernamen = tussenmenu.spelernamen;
            List<int> spelerscores = tussenmenu.spelerscores;
            //voor de labels:
            if (tussenmenu.speleraantal == 1) {
                label2.Text = spelernamen[0]; label6.Text = Convert.ToString(spelerscores[0]);
                //maakt deze labels onzichtbaar:
                label3.Visible = false; label4.Visible = false; label5.Visible = false; label7.Visible = false;
                label8.Visible = false; label9.Visible = false;
            }
            else if (tussenmenu.speleraantal == 2) {
                label2.Text = spelernamen[0]; label6.Text = Convert.ToString(spelerscores[0]);
                label3.Text = spelernamen[1]; label7.Text = Convert.ToString(spelerscores[1]); ;
                //maakt deze labels onzichtbaar:
                 label4.Visible = false; label5.Visible = false; 
                label8.Visible = false; label9.Visible = false;
            }
            else if (tussenmenu.speleraantal == 3) {
                label2.Text = spelernamen[0]; label6.Text = Convert.ToString(spelerscores[0]);
                label3.Text = spelernamen[1]; label7.Text = Convert.ToString(spelerscores[1]);
                label4.Text = spelernamen[2]; label8.Text = Convert.ToString(spelerscores[2]);
                //maakt deze labels onzichtbaar:
                 label5.Visible = false;
                 label9.Visible = false;
            }
            else if (tussenmenu.speleraantal == 4) {
                label2.Text = spelernamen[0]; label6.Text = Convert.ToString(spelerscores[0]);
                label3.Text = spelernamen[1]; label7.Text = Convert.ToString(spelerscores[1]);
                label4.Text = spelernamen[2]; label8.Text = Convert.ToString(spelerscores[2]);
                label5.Text = spelernamen[3]; label9.Text = Convert.ToString(spelerscores[3]);

            }

            //
           


            //vars voor deze form:
            string highscores = System.IO.File.ReadAllText(@"c:\memorygroep24\highscores.sav");
            List<string> scnamen = new List<string>();
            List<int> scscores = new List<int>();
            List<int> detector = new List<int>();

            char[] arrey = highscores.ToCharArray();

            for (int i = 0; i < arrey.Length; i++) //lokaliseert namen door de ';'s te lokaliseren.
            {
                if (arrey[i] == ';') { detector.Add(i); }
            }

            for (int i = 0; i < (detector.Count - 1); i++) //(deel 2) zet de namen vervolgens in een string en voegt het toe aan de List
            {
                string plv = "";
                for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                {
                    plv += arrey[j];
                }
                scnamen.Add(plv); //zet het in de list
            }
            detector.Clear();//maakt detector leeg

            for (int i = 0; i < arrey.Length; i++) //lokaliseert scores door de '/'s te lokaliseren.
            {
                if (arrey[i] == '/') { detector.Add(i); }
            }

            for (int i = 0; i < (detector.Count - 1); i++) //(deel 2) zet de scores vervolgens in een string en voegt het toe aan de List
            {
                string plv = "";
                for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                {
                    plv += arrey[j];
                }
                scscores.Add(int.Parse(plv)); //zet het in de list
            }
            detector.Clear();//maakt detector leeg

            //update de highscorelijst op basis van punten, op de juiste plek in de list.
            for (int i = 0; i < spelernamen.Count; i++)
            {

                if (spelerscores[i] >= scscores[0]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = scscores[7];
                    scscores[7] = scscores[6];
                    scscores[6] = scscores[5];
                    scscores[5] = scscores[4];
                    scscores[4] = scscores[3];
                    scscores[3] = scscores[2];
                    scscores[2] = scscores[1];
                    scscores[1] = scscores[0];
                    scscores[0] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = scnamen[7];
                    scnamen[7] = scnamen[6];
                    scnamen[6] = scnamen[5];
                    scnamen[5] = scnamen[4];
                    scnamen[4] = scnamen[3];
                    scnamen[3] = scnamen[2];
                    scnamen[2] = scnamen[1];
                    scnamen[1] = scnamen[0];
                    scnamen[0] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[1]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = scscores[7];
                    scscores[7] = scscores[6];
                    scscores[6] = scscores[5];
                    scscores[5] = scscores[4];
                    scscores[4] = scscores[3];
                    scscores[3] = scscores[2];
                    scscores[2] = scscores[1];
                    scscores[1] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = scnamen[7];
                    scnamen[7] = scnamen[6];
                    scnamen[6] = scnamen[5];
                    scnamen[5] = scnamen[4];
                    scnamen[4] = scnamen[3];
                    scnamen[3] = scnamen[2];
                    scnamen[2] = scnamen[1];
                    scnamen[1] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[2]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = scscores[7];
                    scscores[7] = scscores[6];
                    scscores[6] = scscores[5];
                    scscores[5] = scscores[4];
                    scscores[4] = scscores[3];
                    scscores[3] = scscores[2];
                    scscores[2] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = scnamen[7];
                    scnamen[7] = scnamen[6];
                    scnamen[6] = scnamen[5];
                    scnamen[5] = scnamen[4];
                    scnamen[4] = scnamen[3];
                    scnamen[3] = scnamen[2];
                    scnamen[2] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[3]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = scscores[7];
                    scscores[7] = scscores[6];
                    scscores[6] = scscores[5];
                    scscores[5] = scscores[4];
                    scscores[4] = scscores[3];
                    scscores[3] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = scnamen[7];
                    scnamen[7] = scnamen[6];
                    scnamen[6] = scnamen[5];
                    scnamen[5] = scnamen[4];
                    scnamen[4] = scnamen[3];
                    scnamen[3] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[4]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = scscores[7];
                    scscores[7] = scscores[6];
                    scscores[6] = scscores[5];
                    scscores[5] = scscores[4];
                    scscores[4] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = scnamen[7];
                    scnamen[7] = scnamen[6];
                    scnamen[6] = scnamen[5];
                    scnamen[5] = scnamen[4];
                    scnamen[4] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[5]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = scscores[7];
                    scscores[7] = scscores[6];
                    scscores[6] = scscores[5];
                    scscores[5] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = scnamen[7];
                    scnamen[7] = scnamen[6];
                    scnamen[6] = scnamen[5];
                    scnamen[5] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[6]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = scscores[7];
                    scscores[7] = scscores[6];
                    scscores[6] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = scnamen[7];
                    scnamen[7] = scnamen[6];
                    scnamen[6] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[7]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = scscores[7];
                    scscores[7] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = scnamen[7];
                    scnamen[7] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[8]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = scscores[8];
                    scscores[8] = spelerscores[i];

                    scnamen[9] = scnamen[8];
                    scnamen[8] = spelernamen[i];
                }
                else if (spelerscores[i] >= scscores[9]) //schuift alle scores een stukje op en vergeet de elfde score in deze lijst van tien.
                {
                    scscores[9] = spelerscores[i];

                    scnamen[9] = spelernamen[i];
                }


            }
            
            // voor het zetten in de sav file
            string a = ";";//voor de topspelers
            string b = "/";//voor de topscores
            for (int i = 0; i < scnamen.Count; i++) { a += scnamen[i] + ";"; b += Convert.ToString(scscores[i]) + "/"; }//voegt alles toe aan a en b
            string text = a + b; //werkt naar behoren

            /*
             *
             *
             */

            string text1 = text;
            text1 = text1.ToLower();

            char[] zon = text1.ToCharArray();
            int teller = 0;

            for (int i = 0; i < zon.Length; i++)
            {
                if (teller > 41) { teller = 0; }

                for (int j = 0; j < schrijf.Length; j++)
                {
                    if (zon[i] == schrijf[j]) { tussengetal1 = j + 1; totaalgetal = tussengetal1 + teller; }
                }

                for (int h = 0; h < tekenlijst.Length; h++)
                {
                    if (totaalgetal == (h + 1)) { naam.Add(Convert.ToString(tekenlijst[h])); }
                }
                teller++;
            }

            string pllv = "";
            for (int i = 0; i < naam.Count; i++)
            {
                pllv += "" + naam[i];
            }
            text = pllv;
            naam.Clear();

            System.IO.File.WriteAllText(@"c:\memorygroep24\highscores.sav", text); //gebruik '\' niet '/'

            // // //
            //de onderstaande code is voor het opslaan van wie gewonnen/verloren heeft.
            // // //
            List<int> tussenlijst = new List<int>();
            List<string> tussenlijst2 = new List<string>();

            for (int i = 0; i < spelerscores.Count; i++) { tussenlijst.Add(spelerscores[i]); }
            tussenlijst.Sort();
            tussenlijst.Reverse();

            for (int i = 0; i < tussenlijst.Count; i++)
            {
                for (int j = 0; j < spelerscores.Count; j++)
                {
                    if (tussenlijst[i] == spelerscores[j]) { tussenlijst2.Add(spelernamen[j]); }

                }
            }

            for (int i = 0; i < tussenlijst2.Count; i++) { Console.WriteLine(tussenlijst2[i]); }

            string tekstje = "";
            for (int i = 0; i < tussenlijst2.Count; i++)
            {
                if (i == 0) { tekstje += tussenlijst2[i] + " is winnaar. "; }
                else { tekstje += tussenlijst2[i] + " is een loser. "; }
            }
            System.IO.File.WriteAllText(@"c:\memorygroep24\winverlies.sav", tekstje);
            
        }//einde 

        private void button1_Click(object sender, EventArgs e)
        {
            Hoofdmenu naam = new Hoofdmenu();
            naam.Show();
            this.Close();
        }
    }
}
