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
        List<int> arreeks = new List<int>(); // reeks waaruit verwijderd wordt
        List<int> volgordelijst = new List<int>(); // reeks waarin toegevoegd wordt
        int[] arree = {1,1,2,2,3,3,4,4,5,5,6,6,7,7,0,0}; //reeks getallen die symbool staat voor de kaartenparen
        Random getal = new Random(); 
        Timer timer = new Timer(); 
        bool klik = false;  // geeft aan of vooraf een kaart is aangeklikt, dus of dit de eerste kaart is die aangeklikt wordt of de tweede
        bool klikdisable = false; // zodat je maar een paar per keer kan aanklikken
        int vorigeklik = 0; //de positie (0-15) van de vorig aangeklikte kaart
        bool[] disableer = tussenmenu.disableer;
        int draaitotaal = 0;
        int beurt = 0; //wiens beurt het is
        int combo = 1; //combo multiplier
        //List<int> spelerscores = new List<int>();

            //methods
        public static void check( int heya)// deze method checkt of het spel voltooid is
        {
            if (heya == 8)
            {  //code voor als het spel voltooid is, zorg voor overerving naar score scherm

                eindespel frm = new eindespel();
                frm.Show();


            }
        }

        

        //voidmainequivalent
        public Form2()
        {
            InitializeComponent();

            if (tussenmenu.spelerscores.Count==0) {//checkt of dit een nieuw spel is, bij nieuw spel is spelerscores length nul
                for (int laptop = 0; laptop < tussenmenu.speleraantal; laptop++) { tussenmenu.spelerscores.Add(0); }
            }

            // geeft spelernamen en bijbehorende scores weer, hide de rest
            


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

            if (Form1.laden == false) //checkt het tussenmenu of dit een nieuw spel is of niet. nieuw spel = volgordelijst is leeg.
            {
                for (int i = 0; i < 16; i++) { arreeks.Add(arree[i]); }//laadt de array in de list
                while (arreeks.Count > 0)//gooit een random getal op tussen 0 en x, waarbij x op het begin 16 is en steeds kleiner wordt. het random getal staat voor een index in de list, die waarde van die plek wordt toegevoegd aan de volgorde list, zodat de volgordelist een random volgorde krijgt. 
                {
                    int a = getal.Next(0, arreeks.Count);
                    volgordelijst.Add(arreeks[a]);
                    arreeks.RemoveAt(a);
                }
            }
            else { volgordelijst = tussenmenu.volgordelijst; } //als het geen nieuw spel is, dan moet ie dus laden vanuit het tussenmenu.


            // checkt de bool
            
            for (int hj = 0; hj < disableer.Length; hj++)
            {
                if (disableer[hj] == true)
                {
                    if (hj == 0)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox1.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox1.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox1.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox1.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox1.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox1.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox1.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox1.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 1)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox2.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox2.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox2.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox2.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox2.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox2.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox2.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox2.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 2)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox3.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox3.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox3.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox3.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox3.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox3.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox3.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox3.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 3)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox4.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox4.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox4.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox4.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox4.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox4.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox4.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox4.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 4)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox5.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox5.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox5.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox5.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox5.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox5.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox5.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox5.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 5)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox6.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox6.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox6.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox6.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox6.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox6.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox6.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox6.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 6)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox7.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox7.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox7.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox7.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox7.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox7.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox7.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox7.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 7)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox8.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox8.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox8.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox8.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox8.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox8.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox8.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox8.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 8)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox9.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox9.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox9.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox9.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox9.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox9.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox9.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox9.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 9)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox10.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox10.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox10.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox10.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox10.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox10.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox10.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox10.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 10)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox11.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox11.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox11.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox11.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox11.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox11.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox11.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox11.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 11)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox12.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox12.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox12.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox12.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox12.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox12.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox12.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox12.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 12)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox13.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox13.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox13.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox13.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox13.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox13.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox13.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox13.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 13)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox14.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox14.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox14.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox14.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox14.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox14.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox14.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox14.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 14)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox15.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox15.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox15.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox15.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox15.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox15.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox15.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox15.Image = Properties.Resources.oranje; }
                    }
                    else if (hj == 15)
                    {
                        if (volgordelijst[hj] == 1) { pictureBox16.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
                        else if (volgordelijst[hj] == 2) { pictureBox16.Image = Properties.Resources.blauw; }
                        else if (volgordelijst[hj] == 3) { pictureBox16.Image = Properties.Resources.groen; }
                        else if (volgordelijst[hj] == 4) { pictureBox16.Image = Properties.Resources.paars; }
                        else if (volgordelijst[hj] == 5) { pictureBox16.Image = Properties.Resources.grijs; }
                        else if (volgordelijst[hj] == 6) { pictureBox16.Image = Properties.Resources.geel; }
                        else if (volgordelijst[hj] == 7) { pictureBox16.Image = Properties.Resources.wit; }
                        else if (volgordelijst[hj] == 0) { pictureBox16.Image = Properties.Resources.oranje; }
                    }
                }

            }
            
            Form1.laden = false;
        }//einde 

        
        
        //de pictureboxen en bijbehorende code als je erop klikt.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (disableer[0]==true) { }
            else if (klikdisable == false) {
                if (volgordelijst[0] == 1) { pictureBox1.Image = Properties.Resources.rood; } //vergelijkt de waarde op de index van de volgordelist met welke kleur daarbij hoort.
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
                        klikdisable = true;
                        klik = false;
                        
                        timer1.Start(); //de code die moet gebeuren na twee seconden staat in de timertick brackets

                        combo = 1;
                        beurt++;

                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[0] = true;
                        disableer[vorigeklik] = true;
                        
                        

                        tussenmenu.spelerscores[beurt] += 10*combo;
                        combo++;
                        
                    }

                } }
            
            
            

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (disableer[1] == true) { }
            else if (klikdisable == false) {
                if (volgordelijst[1] == 1) { pictureBox2.Image = Properties.Resources.rood; }
                else if (volgordelijst[1] == 2) { pictureBox2.Image = Properties.Resources.blauw; }
                else if (volgordelijst[1] == 3) { pictureBox2.Image = Properties.Resources.groen; }
                else if (volgordelijst[1] == 4) { pictureBox2.Image = Properties.Resources.paars; }
                else if (volgordelijst[1] == 5) { pictureBox2.Image = Properties.Resources.grijs; }
                else if (volgordelijst[1] == 6) { pictureBox2.Image = Properties.Resources.geel; }
                else if (volgordelijst[1] == 7) { pictureBox2.Image = Properties.Resources.wit; }
                else if (volgordelijst[1] == 0) { pictureBox2.Image = Properties.Resources.oranje; }

                if (klik == false) { vorigeklik = 1; klik = true; }
                else if (klik == true && vorigeklik == 1) { }
                else if (klik == true)
                {
                    if (volgordelijst[vorigeklik] != volgordelijst[1])
                    {
                        klikdisable = true;
                        klik = false;

                        timer2.Start();
                        combo = 1;
                        beurt++;
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[1] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (disableer[2] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer3.Start();
                        combo = 1;
                        beurt++;
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[2] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (disableer[3] == true) { }
            else if (klikdisable==false) {
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
                        klikdisable = true;
                        klik = false;

                        timer4.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[3] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }
                } }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (disableer[4] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer5.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[4] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (disableer[5] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer6.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[5] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (disableer[6] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer7.Start();
                        combo = 1;
                        beurt++; // wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[6] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (disableer[7] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer8.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[7] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                }
            }        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (disableer[8] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer9.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[8] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (disableer[9] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer10.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[9] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (disableer[10] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer11.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[10] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (disableer[11] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer12.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[11] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (disableer[12] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer13.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[12] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }
                } }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (disableer[13] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer14.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[13] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (disableer[14] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer15.Start();
                        combo = 1;
                        beurt++;// wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[14] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (disableer[15] == true) { }
            else if (klikdisable == false) {
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
                        klikdisable = true;
                        klik = false;

                        timer16.Start();
                        combo = 1;
                        beurt++;
                        // wijzig timer
                    }
                    else // dit is de code die gebeurt als de kaarten matchen
                    {
                        klik = false;
                        disableer[15] = true;
                        disableer[vorigeklik] = true;
                        
                        
                        tussenmenu.spelerscores[beurt] += 10 * combo;
                        combo++;
                        
                    }

                } }
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
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
                klikdisable = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            beurten.Stop();
            beurt = 0;

            tussenmenu.speleraantal = tussenmenu.spelernamen.Count;

            tussenmenu.volgordelijst.Clear();
            tussenmenu.spelerscores.Clear();
            disableer[0] = false;
            disableer[1] = false;
            disableer[2] = false;
            disableer[3] = false;
            disableer[4] = false;
            disableer[5] = false;
            disableer[6] = false;
            disableer[7] = false;
            disableer[8] = false;
            disableer[9] = false;
            disableer[10] = false;
            disableer[11] = false;
            disableer[12] = false;
            disableer[13] = false;
            disableer[14] = false;
            disableer[15] = false;

            beurten.Start();

            this.Close();
            Form2 frm = new Form2();
            frm.Show();
        }

        private void name1_Click(object sender, EventArgs e)
        {

        }

        private void beurten_Tick(object sender, EventArgs e)
        {
            if (beurt>=tussenmenu.speleraantal) { beurt = 0; }
            label10.Text = tussenmenu.spelernamen[beurt];

            if (tussenmenu.speleraantal == 1) { label9.Text = Convert.ToString(tussenmenu.spelerscores[0]); }
            if (tussenmenu.speleraantal == 2) { label8.Text = Convert.ToString(tussenmenu.spelerscores[1]); label9.Text = Convert.ToString(tussenmenu.spelerscores[0]); }
            if (tussenmenu.speleraantal == 3) { label7.Text = Convert.ToString(tussenmenu.spelerscores[2]); label9.Text = Convert.ToString(tussenmenu.spelerscores[0]); label8.Text = Convert.ToString(tussenmenu.spelerscores[1]); }
            if (tussenmenu.speleraantal == 4) { label6.Text = Convert.ToString(tussenmenu.spelerscores[3]); label9.Text = Convert.ToString(tussenmenu.spelerscores[0]); label8.Text = Convert.ToString(tussenmenu.spelerscores[1]); label7.Text = Convert.ToString(tussenmenu.spelerscores[2]); }

            if (tussenmenu.speleraantal == 1)
            {
                label5.Visible = false; label10.Visible = false;
                string naam1 = tussenmenu.spelernamen[0];
                name1.Text = naam1; name2.Visible = false; name3.Visible = false; name4.Visible = false; label8.Visible = false; label7.Visible = false; label6.Visible = false;
            }
            else if (tussenmenu.speleraantal == 2)
            {
                string naam1 = tussenmenu.spelernamen[0];
                name1.Text = naam1;
                string naam2 = tussenmenu.spelernamen[1];
                name2.Text = naam2; name3.Visible = false; name4.Visible = false; label7.Visible = false; label6.Visible = false;
            }
            else if (tussenmenu.speleraantal == 3)
            {
                string naam1 = tussenmenu.spelernamen[0];
                name1.Text = naam1;
                string naam2 = tussenmenu.spelernamen[1];
                name2.Text = naam2;
                string naam3 = tussenmenu.spelernamen[2];
                name3.Text = naam3; name4.Visible = false; label6.Visible = false;
            }
            else if (tussenmenu.speleraantal == 4)
            {
                string naam1 = tussenmenu.spelernamen[0];
                name1.Text = naam1;
                string naam2 = tussenmenu.spelernamen[1];
                name2.Text = naam2;
                string naam3 = tussenmenu.spelernamen[2];
                name3.Text = naam3;
                string naam4 = tussenmenu.spelernamen[3];
                name4.Text = naam4;
            }

            //checkt ook nog eens of de int draaitotaal 8 is... voor het geval dat er een savegame geladen is.
            int teller = 0;
            for (int hy = 0; hy < disableer.Length; hy++)
            {
                if (disableer[hy]==true) { teller++; }
            }
            if (teller==16) { check(8); beurten.Stop(); this.Close(); }
          
            //combos weergeven
            if (combo == 2) { combolabel.Text = "MATCH!"; combolabel.Visible = true; }
            else if (combo == 3) { combolabel.Text = "2x COMBO!"; combolabel.Visible = true; }
            else if (combo == 4) { combolabel.Text = "3x COMBO!"; combolabel.Visible = true; }
            else if (combo == 5) { combolabel.Text = "4x COMBO!"; combolabel.Visible = true; }
            else if (combo == 6) { combolabel.Text = "5x COMBO!"; combolabel.Visible = true; }
            else if (combo == 7) { combolabel.Text = "6x COMBO!"; combolabel.Visible = true; }
            else if (combo == 8) { combolabel.Text = "7x COMBO!"; combolabel.Visible = true; }
            else if (combo == 9) { combolabel.Text = "8x COMBO!"; combolabel.Visible = true; }
            else if (combo == 10) { combolabel.Text = "9x COMBO!"; combolabel.Visible = true; }
            else { combolabel.Visible = false; }

        }

        private void button2_Click(object sender, EventArgs e)//VOOR HET SAVEN!!
        {
            
            int speleraantal = tussenmenu.spelernamen.Count;

            //strings voor de string voor de savefile
            string namen = "";
            string scores = "";
            string bools = "";
            string volgorde = "";

            //leegmaken van de textfile:
            string text = "";
            System.IO.File.WriteAllText(@"c:\memorygroep24\memory.sav", text); //gebruik '\' niet '/'

            //dingen om ervoor te zorgen dat het geheel in een string kan worden opgeslagen.

            for (int i = 0; i < tussenmenu.spelernamen.Count; i++) { namen += tussenmenu.spelernamen[i] + ";"; }//voor de spelernamen
            for (int i = 0; i < tussenmenu.spelerscores.Count; i++) { scores += tussenmenu.spelerscores[i] + "|"; }//voor de tussenmenu.spelerscores
            for (int i = 0; i < disableer.Length; i++) { bools += disableer[i] + "/"; }
            for (int i = 0; i < volgordelijst.Count; i++) { volgorde += volgordelijst[i] + "*"; }

            //vullen van de textfile:

            text = "4aantal spelers: " + speleraantal + " spelernamen: ;" + namen + " spelerscores: |" + scores + " disableerbool: /" + bools + " volgordelijst: *" + volgorde;
            
            System.IO.File.WriteAllText(@"c:\memorygroep24\memory.sav", text); //gebruik '\' niet '/'

        }

        private void button3_Click(object sender, EventArgs e)// VOOR HET LADEN!!
        {
            //blabla 
            beurten.Stop();

            Form1.laden = true;
            string savefile = System.IO.File.ReadAllText(@"c:\memorygroep24\memory.sav"); // Het pad van de savefile. Let op! geen '/' maar '\'!


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
