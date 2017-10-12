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

    public partial class Form2 : Form
    {
        //timervariabelen
        int tijdeen = 0;
        int tijdtwee = 0;
        int tijddrie = 0;
        int tijdvier = 0;
        int tijdvijf = 0;
        int tijdzes = 0;
        int tijdzeven = 0;
        int tijdacht = 0;
        int tijdnegen = 0;
        int tijdtien = 0;
        int tijdelf = 0;
        int tijdtwaalf = 0;
        int tijddertien = 0;
        int tijdveertien = 0;
        int tijdvijftien = 0;
        int tijdzestien = 0;
        //vars
        List<int> arreeks = new List<int>();
        List<int> volgordelijst = new List<int>();
        int[] arree = {1,1,2,2,3,3,4,4,5,5,6,6,7,7,0,0};
        Random getal = new Random();
        Timer timer = new Timer();
        bool klik = false;
        int vorigeklik = 0;

        public Form2()
        {
            InitializeComponent();

            //stopt de timers:
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
            timer5.Stop();
            timer6.Stop();
            timer7.Stop();
            timer8.Stop();
            timer9.Stop();
            timer10.Stop();
            timer11.Stop();
            timer12.Stop();
            timer13.Stop();
            timer14.Stop();
            timer15.Stop();
            timer16.Stop();
            // // // // //

            for (int i = 0; i < 16; i++) { arreeks.Add(arree[i]); }//laadt de array in de list


            while (arreeks.Count > 0)//gooit een random getal op tussen 0 en x, waarbij x op het begin 16 is en steeds kleiner wordt. het random getal staat voor een index in de list, die waarde van die plek wordt toegevoegd aan de volgorde list, zodat de volgordelist een random volgorde krijgt. 
            {
                int a = getal.Next(0, arreeks.Count);
                volgordelijst.Add(arreeks[a]);
                arreeks.RemoveAt(a);
            }
            
            
        }

        
        
        //de pictureboxen en bijbehorende code als je erop klikt.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            if (volgordelijst[0]==1) { pictureBox1.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
            else if (volgordelijst[0] == 2) { pictureBox1.Image = Properties.Resources.blauw; }
            else if (volgordelijst[0] == 3) { pictureBox1.Image = Properties.Resources.groen; }
            else if (volgordelijst[0] == 4) { pictureBox1.Image = Properties.Resources.paars; }
            else if (volgordelijst[0] == 5) { pictureBox1.Image = Properties.Resources.grijs; }
            else if (volgordelijst[0] == 6) { pictureBox1.Image = Properties.Resources.geel; }
            else if (volgordelijst[0] == 7) { pictureBox1.Image = Properties.Resources.wit; }
            else if (volgordelijst[0] == 0) { pictureBox1.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 0; klik = true; } //dit stukje code onthoudt, wanneer dit de eerste keer is dat de gebruiker iets aanklikt, welke kaart dat was
            else if (klik == true && vorigeklik == 0) { /*ik vul hier niks in omdat we willen dat in dit geval niks gebeurt*/ } 
            else if (klik == true) 
            {
                if (volgordelijst[vorigeklik] != volgordelijst[0]) //Dit is de code die gebeurt als de twee kaarten niet matchen
                {

                    klik = false;

                    timer1.Start(); //de code die moet gebeuren na twee seconden staat in de timertick brackets


                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
            
            
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (volgordelijst[1] == 1) { pictureBox2.Image = Properties.Resources.rood; }
            else if (volgordelijst[1] == 2) { pictureBox2.Image = Properties.Resources.blauw; }
            else if (volgordelijst[1] == 3) { pictureBox2.Image = Properties.Resources.groen; }
            else if (volgordelijst[1] == 4) { pictureBox2.Image = Properties.Resources.paars; }
            else if (volgordelijst[1] == 5) { pictureBox2.Image = Properties.Resources.grijs; }
            else if (volgordelijst[1] == 6) { pictureBox2.Image = Properties.Resources.geel; }
            else if (volgordelijst[1] == 7) { pictureBox2.Image = Properties.Resources.wit; }
            else if (volgordelijst[1] == 0) { pictureBox2.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 1; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 1) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[1]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer2.Start();
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (volgordelijst[2] == 1) { pictureBox3.Image = Properties.Resources.rood; }
            else if (volgordelijst[2] == 2) { pictureBox3.Image = Properties.Resources.blauw; }
            else if (volgordelijst[2] == 3) { pictureBox3.Image = Properties.Resources.groen; }
            else if (volgordelijst[2] == 4) { pictureBox3.Image = Properties.Resources.paars; }
            else if (volgordelijst[2] == 5) { pictureBox3.Image = Properties.Resources.grijs; }
            else if (volgordelijst[2] == 6) { pictureBox3.Image = Properties.Resources.geel; }
            else if (volgordelijst[2] == 7) { pictureBox3.Image = Properties.Resources.wit; }
            else if (volgordelijst[2] == 0) { pictureBox3.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 2; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 2) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[2]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer3.Start();
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (volgordelijst[3] == 1) { pictureBox4.Image = Properties.Resources.rood; }
            else if (volgordelijst[3] == 2) { pictureBox4.Image = Properties.Resources.blauw; }
            else if (volgordelijst[3] == 3) { pictureBox4.Image = Properties.Resources.groen; }
            else if (volgordelijst[3] == 4) { pictureBox4.Image = Properties.Resources.paars; }
            else if (volgordelijst[3] == 5) { pictureBox4.Image = Properties.Resources.grijs; }
            else if (volgordelijst[3] == 6) { pictureBox4.Image = Properties.Resources.geel; }
            else if (volgordelijst[3] == 7) { pictureBox4.Image = Properties.Resources.wit; }
            else if (volgordelijst[3] == 0) { pictureBox4.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 3; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 3) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[3]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer4.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (volgordelijst[4] == 1) { pictureBox5.Image = Properties.Resources.rood; }
            else if (volgordelijst[4] == 2) { pictureBox5.Image = Properties.Resources.blauw; }
            else if (volgordelijst[4] == 3) { pictureBox5.Image = Properties.Resources.groen; }
            else if (volgordelijst[4] == 4) { pictureBox5.Image = Properties.Resources.paars; }
            else if (volgordelijst[4] == 5) { pictureBox5.Image = Properties.Resources.grijs; }
            else if (volgordelijst[4] == 6) { pictureBox5.Image = Properties.Resources.geel; }
            else if (volgordelijst[4] == 7) { pictureBox5.Image = Properties.Resources.wit; }
            else if (volgordelijst[4] == 0) { pictureBox5.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 4; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 4) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[4]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer5.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (volgordelijst[5] == 1) { pictureBox6.Image = Properties.Resources.rood; }
            else if (volgordelijst[5] == 2) { pictureBox6.Image = Properties.Resources.blauw; }
            else if (volgordelijst[5] == 3) { pictureBox6.Image = Properties.Resources.groen; }
            else if (volgordelijst[5] == 4) { pictureBox6.Image = Properties.Resources.paars; }
            else if (volgordelijst[5] == 5) { pictureBox6.Image = Properties.Resources.grijs; }
            else if (volgordelijst[5] == 6) { pictureBox6.Image = Properties.Resources.geel; }
            else if (volgordelijst[5] == 7) { pictureBox6.Image = Properties.Resources.wit; }
            else if (volgordelijst[5] == 0) { pictureBox6.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 5; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 5) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[5]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer6.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (volgordelijst[6] == 1) { pictureBox7.Image = Properties.Resources.rood; }
            else if (volgordelijst[6] == 2) { pictureBox7.Image = Properties.Resources.blauw; }
            else if (volgordelijst[6] == 3) { pictureBox7.Image = Properties.Resources.groen; }
            else if (volgordelijst[6] == 4) { pictureBox7.Image = Properties.Resources.paars; }
            else if (volgordelijst[6] == 5) { pictureBox7.Image = Properties.Resources.grijs; }
            else if (volgordelijst[6] == 6) { pictureBox7.Image = Properties.Resources.geel; }
            else if (volgordelijst[6] == 7) { pictureBox7.Image = Properties.Resources.wit; }
            else if (volgordelijst[6] == 0) { pictureBox7.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 6; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 6) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[6]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer7.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (volgordelijst[7] == 1) { pictureBox8.Image = Properties.Resources.rood; }
            else if (volgordelijst[7] == 2) { pictureBox8.Image = Properties.Resources.blauw; }
            else if (volgordelijst[7] == 3) { pictureBox8.Image = Properties.Resources.groen; }
            else if (volgordelijst[7] == 4) { pictureBox8.Image = Properties.Resources.paars; }
            else if (volgordelijst[7] == 5) { pictureBox8.Image = Properties.Resources.grijs; }
            else if (volgordelijst[7] == 6) { pictureBox8.Image = Properties.Resources.geel; }
            else if (volgordelijst[7] == 7) { pictureBox8.Image = Properties.Resources.wit; }
            else if (volgordelijst[7] == 0) { pictureBox8.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 7; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 7) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[7]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer8.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (volgordelijst[8] == 1) { pictureBox9.Image = Properties.Resources.rood; }
            else if (volgordelijst[8] == 2) { pictureBox9.Image = Properties.Resources.blauw; }
            else if (volgordelijst[8] == 3) { pictureBox9.Image = Properties.Resources.groen; }
            else if (volgordelijst[8] == 4) { pictureBox9.Image = Properties.Resources.paars; }
            else if (volgordelijst[8] == 5) { pictureBox9.Image = Properties.Resources.grijs; }
            else if (volgordelijst[8] == 6) { pictureBox9.Image = Properties.Resources.geel; }
            else if (volgordelijst[8] == 7) { pictureBox9.Image = Properties.Resources.wit; }
            else if (volgordelijst[8] == 0) { pictureBox9.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 8; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 8) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[8]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer9.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (volgordelijst[9] == 1) { pictureBox10.Image = Properties.Resources.rood; }
            else if (volgordelijst[9] == 2) { pictureBox10.Image = Properties.Resources.blauw; }
            else if (volgordelijst[9] == 3) { pictureBox10.Image = Properties.Resources.groen; }
            else if (volgordelijst[9] == 4) { pictureBox10.Image = Properties.Resources.paars; }
            else if (volgordelijst[9] == 5) { pictureBox10.Image = Properties.Resources.grijs; }
            else if (volgordelijst[9] == 6) { pictureBox10.Image = Properties.Resources.geel; }
            else if (volgordelijst[9] == 7) { pictureBox10.Image = Properties.Resources.wit; }
            else if (volgordelijst[9] == 0) { pictureBox10.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 9; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 9) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[9]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer10.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (volgordelijst[10] == 1) { pictureBox11.Image = Properties.Resources.rood; }
            else if (volgordelijst[10] == 2) { pictureBox11.Image = Properties.Resources.blauw; }
            else if (volgordelijst[10] == 3) { pictureBox11.Image = Properties.Resources.groen; }
            else if (volgordelijst[10] == 4) { pictureBox11.Image = Properties.Resources.paars; }
            else if (volgordelijst[10] == 5) { pictureBox11.Image = Properties.Resources.grijs; }
            else if (volgordelijst[10] == 6) { pictureBox11.Image = Properties.Resources.geel; }
            else if (volgordelijst[10] == 7) { pictureBox11.Image = Properties.Resources.wit; }
            else if (volgordelijst[10] == 0) { pictureBox11.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 10; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 10) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[10]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer11.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (volgordelijst[11] == 1) { pictureBox12.Image = Properties.Resources.rood; }
            else if (volgordelijst[11] == 2) { pictureBox12.Image = Properties.Resources.blauw; }
            else if (volgordelijst[11] == 3) { pictureBox12.Image = Properties.Resources.groen; }
            else if (volgordelijst[11] == 4) { pictureBox12.Image = Properties.Resources.paars; }
            else if (volgordelijst[11] == 5) { pictureBox12.Image = Properties.Resources.grijs; }
            else if (volgordelijst[11] == 6) { pictureBox12.Image = Properties.Resources.geel; }
            else if (volgordelijst[11] == 7) { pictureBox12.Image = Properties.Resources.wit; }
            else if (volgordelijst[11] == 0) { pictureBox12.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 11; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 11) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[11]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer12.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (volgordelijst[12] == 1) { pictureBox13.Image = Properties.Resources.rood; }
            else if (volgordelijst[12] == 2) { pictureBox13.Image = Properties.Resources.blauw; }
            else if (volgordelijst[12] == 3) { pictureBox13.Image = Properties.Resources.groen; }
            else if (volgordelijst[12] == 4) { pictureBox13.Image = Properties.Resources.paars; }
            else if (volgordelijst[12] == 5) { pictureBox13.Image = Properties.Resources.grijs; }
            else if (volgordelijst[12] == 6) { pictureBox13.Image = Properties.Resources.geel; }
            else if (volgordelijst[12] == 7) { pictureBox13.Image = Properties.Resources.wit; }
            else if (volgordelijst[12] == 0) { pictureBox13.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 12; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 12) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[12]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer13.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (volgordelijst[13] == 1) { pictureBox14.Image = Properties.Resources.rood; }
            else if (volgordelijst[13] == 2) { pictureBox14.Image = Properties.Resources.blauw; }
            else if (volgordelijst[13] == 3) { pictureBox14.Image = Properties.Resources.groen; }
            else if (volgordelijst[13] == 4) { pictureBox14.Image = Properties.Resources.paars; }
            else if (volgordelijst[13] == 5) { pictureBox14.Image = Properties.Resources.grijs; }
            else if (volgordelijst[13] == 6) { pictureBox14.Image = Properties.Resources.geel; }
            else if (volgordelijst[13] == 7) { pictureBox14.Image = Properties.Resources.wit; }
            else if (volgordelijst[13] == 0) { pictureBox14.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 13; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 13) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[13]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer14.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (volgordelijst[14] == 1) { pictureBox15.Image = Properties.Resources.rood; }
            else if (volgordelijst[14] == 2) { pictureBox15.Image = Properties.Resources.blauw; }
            else if (volgordelijst[14] == 3) { pictureBox15.Image = Properties.Resources.groen; }
            else if (volgordelijst[14] == 4) { pictureBox15.Image = Properties.Resources.paars; }
            else if (volgordelijst[14] == 5) { pictureBox15.Image = Properties.Resources.grijs; }
            else if (volgordelijst[14] == 6) { pictureBox15.Image = Properties.Resources.geel; }
            else if (volgordelijst[14] == 7) { pictureBox15.Image = Properties.Resources.wit; }
            else if (volgordelijst[14] == 0) { pictureBox15.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 14; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 14) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[14]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer15.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (volgordelijst[15] == 1) { pictureBox16.Image = Properties.Resources.rood; }
            else if (volgordelijst[15] == 2) { pictureBox16.Image = Properties.Resources.blauw; }
            else if (volgordelijst[15] == 3) { pictureBox16.Image = Properties.Resources.groen; }
            else if (volgordelijst[15] == 4) { pictureBox16.Image = Properties.Resources.paars; }
            else if (volgordelijst[15] == 5) { pictureBox16.Image = Properties.Resources.grijs; }
            else if (volgordelijst[15] == 6) { pictureBox16.Image = Properties.Resources.geel; }
            else if (volgordelijst[15] == 7) { pictureBox16.Image = Properties.Resources.wit; }
            else if (volgordelijst[15] == 0) { pictureBox16.Image = Properties.Resources.oranje; }

            if (klik == false) { vorigeklik = 15; klik = true; } //wijzig vorigeklik
            else if (klik == true && vorigeklik == 15) { } //wijzig vorigeklik
            else if (klik == true)
            {
                if (volgordelijst[vorigeklik] != volgordelijst[15]) //wijzig volgordelijst[]
                {

                    klik = false;

                    timer16.Start(); // wijzig timer
                }
                else // dit is de code die gebeurt als de kaarten matchen
                {
                    klik = false;

                }

            }
        }
        //timers
        private void timer1_Tick(object sender, EventArgs e)
        {
            tijdeen++;
            if (tijdeen % 2 == 0)
            {
                timer1.Stop();
                pictureBox1.Image = Properties.Resources.achterkant;
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tijdtwee++;//pas deze aan
            if (tijdtwee % 2 == 0) //pas deze aan
            {
                timer2.Stop(); //verander timer
                pictureBox2.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            tijddrie++;//pas deze aan
            if (tijddrie % 2 == 0) //pas deze aan
            {
                timer3.Stop(); //verander timer
                pictureBox3.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            tijdvier++;//pas deze aan
            if (tijdtwee % 2 == 0) //pas deze aan
            {
                timer4.Stop(); //verander timer
                pictureBox4.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            tijdvijf++;//pas deze aan
            if (tijdvijf % 2 == 0) //pas deze aan
            {
                timer5.Stop(); //verander timer
                pictureBox5.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            tijdzes++;//pas deze aan
            if (tijdzes % 2 == 0) //pas deze aan
            {
                timer6.Stop(); //verander timer
                pictureBox6.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            tijdzeven++;//pas deze aan
            if (tijdzeven % 2 == 0) //pas deze aan
            {
                timer7.Stop(); //verander timer
                pictureBox7.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            tijdacht++;//pas deze aan
            if (tijdacht % 2 == 0) //pas deze aan
            {
                timer8.Stop(); //verander timer
                pictureBox8.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            tijdnegen++;//pas deze aan
            if (tijdnegen % 2 == 0) //pas deze aan
            {
                timer9.Stop(); //verander timer
                pictureBox9.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            tijdtien++;//pas deze aan
            if (tijdtien % 2 == 0) //pas deze aan
            {
                timer10.Stop(); //verander timer
                pictureBox10.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            tijdelf++;//pas deze aan
            if (tijdelf % 2 == 0) //pas deze aan
            {
                timer11.Stop(); //verander timer
                pictureBox11.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            tijdtwaalf++;//pas deze aan
            if (tijdtwaalf % 2 == 0) //pas deze aan
            {
                timer12.Stop(); //verander timer
                pictureBox12.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer13_Tick(object sender, EventArgs e)
        {
            tijddertien++;//pas deze aan
            if (tijddertien % 2 == 0) //pas deze aan
            {
                timer13.Stop(); //verander timer
                pictureBox13.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer14_Tick(object sender, EventArgs e)
        {
            tijdveertien++;//pas deze aan
            if (tijdveertien % 2 == 0) //pas deze aan
            {
                timer14.Stop(); //verander timer
                pictureBox14.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer15_Tick(object sender, EventArgs e)
        {
            tijdvijftien++;//pas deze aan
            if (tijdvijftien % 2 == 0) //pas deze aan
            {
                timer15.Stop(); //verander timer
                pictureBox15.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }

        private void timer16_Tick(object sender, EventArgs e)
        {
            tijdzestien++;//pas deze aan
            if (tijdzestien % 2 == 0) //pas deze aan
            {
                timer16.Stop(); //verander timer
                pictureBox16.Image = Properties.Resources.achterkant; //verander picturebox
                if (vorigeklik == 0) { pictureBox1.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 1) { pictureBox2.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 2) { pictureBox3.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 3) { pictureBox4.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 4) { pictureBox5.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 5) { pictureBox6.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 6) { pictureBox7.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 7) { pictureBox8.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 8) { pictureBox9.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 9) { pictureBox10.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 10) { pictureBox11.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 11) { pictureBox12.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 12) { pictureBox13.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 13) { pictureBox14.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 14) { pictureBox15.Image = Properties.Resources.achterkant; }
                else if (vorigeklik == 15) { pictureBox16.Image = Properties.Resources.achterkant; }
            }
        }
    }
}
