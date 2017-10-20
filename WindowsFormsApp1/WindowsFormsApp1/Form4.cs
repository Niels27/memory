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
        public Form4()
        {
            InitializeComponent();
            string highscores = System.IO.File.ReadAllText(@"C:\Users\Gebruiker\Desktop\highscores.sav");
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


            //
            label1.Text = scnamen[0]; label6.Text = scnamen[1];
            label2.Text = scnamen[2]; label7.Text = scnamen[3];
            label3.Text = scnamen[4]; label8.Text = scnamen[5];
            label4.Text = scnamen[6]; label9.Text = scnamen[7];
            label5.Text = scnamen[8]; label10.Text = scnamen[9];

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



    }
}
