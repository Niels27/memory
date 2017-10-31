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
    public partial class Form4 : Form
    {
        List<string> naam = new List<string>();
        int tussengetal1 = 0;
        int totaalgetal = 0;

        char[] schrijf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', ';', '/', '|', '*', ' ' };

        char[] tekenlijst = {'q','w','e','r','t','y','u','i','o','p','[',']','a','s','d','f','g','h','j','k','l',';','{','|','z','x','c','v','b','n','m',',','.','/',
                                    '1','2','3','4','5','6','7','8','9','0','!','@','#','$','%','^','&','*','(',')','_','-','=','+','Q','W','E','R','T','Y','U','I','O','P',
                                    'A','S','D','F','G','H','J','K','L','Z','X','C','V','B'};

        public Form4()
        {
            InitializeComponent();
            string highscores = System.IO.File.ReadAllText(@"c:\memorygroep24\highscores.sav");//laadt de scores

            /*
             DECODEERT DE TEKST
             */

            string text2 = highscores;

            char[] arrrey = text2.ToCharArray();
            int teller = 0;
            for (int i = 0; i < arrrey.Length; i++)
            {
                if (teller > 41) { teller = 0; }

                for (int j = 0; j < tekenlijst.Length; j++)
                {
                    if (arrrey[i] == tekenlijst[j]) { tussengetal1 = j + 1; totaalgetal = tussengetal1 - teller; }
                }

                teller++;

                for (int h = 0; h < schrijf.Length; h++)
                {
                    if (totaalgetal == h + 1) { naam.Add(Convert.ToString(schrijf[h])); }
                }
            }

            string plv = "";
            for (int i = 0; i < naam.Count; i++)
            {
                plv += "" + naam[i];
            }
            highscores = plv;
            naam.Clear();

            /*
             //EINDE DECODEREN
             */

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
                string prlv = "";
                for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                {
                    prlv += arrey[j];
                }
                scnamen.Add(prlv); //zet het in de list
            }
            detector.Clear();//maakt detector leeg

            for (int i = 0; i < arrey.Length; i++) //lokaliseert scores door de '/'s te lokaliseren.
            {
                if (arrey[i] == '/') { detector.Add(i); }
            }

            for (int i = 0; i < (detector.Count - 1); i++) //(deel 2) zet de scores vervolgens in een string en voegt het toe aan de List
            {
                string pllv = "";
                for (int j = detector[i] + 1; j < detector[i + 1]; j++)
                {
                    pllv += arrey[j];
                }
                scscores.Add(int.Parse(pllv)); //zet het in de list
            }
            detector.Clear();//maakt detector leeg


            //
            label1.Text = scnamen[0]; label6.Text = scnamen[5];
            label2.Text = scnamen[1]; label7.Text = scnamen[6];
            label3.Text = scnamen[2]; label8.Text = scnamen[7];
            label4.Text = scnamen[3]; label9.Text = scnamen[8];
            label5.Text = scnamen[4]; label10.Text = scnamen[9];

            label11.Text = Convert.ToString(scscores[0]);
            label12.Text = Convert.ToString(scscores[1]);
            label13.Text = Convert.ToString(scscores[2]);
            label14.Text = Convert.ToString(scscores[3]);
            label15.Text = Convert.ToString(scscores[4]);
            label16.Text = Convert.ToString(scscores[5]);
            label17.Text = Convert.ToString(scscores[6]);
            label18.Text = Convert.ToString(scscores[7]);
            label19.Text = Convert.ToString(scscores[8]);
            label20.Text = Convert.ToString(scscores[9]);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
