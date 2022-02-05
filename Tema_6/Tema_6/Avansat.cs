using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Tema_6
{
    public partial class Avansat: Form
    {
        //Variabile
        Random location = new Random();
        List<Point> points = new List<Point>();
        PictureBox click_imagine1;
        PictureBox click_imagine2;
        int scor, nr_potriviri = 0, inceput = 0;
        public Avansat()
        {
            InitializeComponent();
            generare_matrice();
        }



        private void generare_matrice()
        {

            //resetari necesare dupa fiecare executie a jocului
            label2.Text = "5";
            label5.Text = "10";
            label6.Text = "0";
            int imagine = Convert.ToInt32(Form1.imagine);
            //ScoreCounter.Text = Convert.ToString(Convert.ToInt32(0));

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
            pictureBox10.Enabled = true;
            pictureBox11.Enabled = true;
            pictureBox12.Enabled = true;
            pictureBox13.Enabled = true;
            pictureBox14.Enabled = true;
            pictureBox15.Enabled = true;
            pictureBox16.Enabled = true;
            pictureBox17.Enabled = true;
            pictureBox18.Enabled = true;
            pictureBox19.Enabled = true;
            pictureBox20.Enabled = true;

            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            pictureBox10.Visible = true;
            pictureBox11.Visible = true;
            pictureBox12.Visible = true;
            pictureBox13.Visible = true;
            pictureBox14.Visible = true;
            pictureBox15.Visible = true;
            pictureBox16.Visible = true;
            pictureBox17.Visible = true;
            pictureBox18.Visible = true;
            pictureBox19.Visible = true;
            pictureBox20.Visible = true;

            if (imagine == 1)
            {
                pictureBox1.Image = Properties.Resources.aromb;
                pictureBox2.Image = Properties.Resources.aromb;
                pictureBox3.Image = Properties.Resources.inima;
                pictureBox4.Image = Properties.Resources.inima;

                pictureBox5.Image = Properties.Resources.jcruce;
                pictureBox6.Image = Properties.Resources.jcruce;
                pictureBox7.Image = Properties.Resources.kromb;
                pictureBox8.Image = Properties.Resources.kromb;

                pictureBox9.Image = Properties.Resources.qfrunza;
                pictureBox10.Image = Properties.Resources.qfrunza;
                pictureBox11.Image = Properties.Resources.romb;
                pictureBox12.Image = Properties.Resources.romb;

                pictureBox13.Image = Properties.Resources.optinima;
                pictureBox14.Image = Properties.Resources.optinima;
                pictureBox15.Image = Properties.Resources.patruromb;
                pictureBox16.Image = Properties.Resources.patruromb;

                pictureBox17.Image = Properties.Resources.treicruce;
                pictureBox18.Image = Properties.Resources.treicruce;
                pictureBox19.Image = Properties.Resources.doifrunza;
                pictureBox20.Image = Properties.Resources.doifrunza;

            }
            else
                if (imagine == 2)
            {

                pictureBox1.Image = Properties.Resources.franta;
                pictureBox2.Image = Properties.Resources.cfranta;
                pictureBox3.Image = Properties.Resources.italia;
                pictureBox4.Image = Properties.Resources.citalia;

                pictureBox5.Image = Properties.Resources.india;
                pictureBox6.Image = Properties.Resources.cindia;
                pictureBox7.Image = Properties.Resources.romania;
                pictureBox8.Image = Properties.Resources.cromania;

                pictureBox9.Image = Properties.Resources.malta;
                pictureBox10.Image = Properties.Resources.cmalta;
                pictureBox11.Image = Properties.Resources.china;
                pictureBox12.Image = Properties.Resources.cchina;

                pictureBox13.Image = Properties.Resources.canada;
                pictureBox14.Image = Properties.Resources.ccanada;
                pictureBox15.Image = Properties.Resources.brazilia;
                pictureBox16.Image = Properties.Resources.cbrazilia;

                pictureBox17.Image = Properties.Resources.australia;
                pictureBox18.Image = Properties.Resources.caustralia;
                pictureBox19.Image = Properties.Resources.japonia;
                pictureBox20.Image = Properties.Resources.cjaponia;
            }
            else
                if (imagine == 3)
            {


                pictureBox1.Image = Properties.Resources.franta;
                pictureBox2.Image = Properties.Resources.sfranta;
                pictureBox3.Image = Properties.Resources.italia;
                pictureBox4.Image = Properties.Resources.sitalia;

                pictureBox5.Image = Properties.Resources.india;
                pictureBox6.Image = Properties.Resources.sindia;
                pictureBox7.Image = Properties.Resources.romania;
                pictureBox8.Image = Properties.Resources.sromania;

                pictureBox9.Image = Properties.Resources.malta;
                pictureBox10.Image = Properties.Resources.smalta;
                pictureBox11.Image = Properties.Resources.china;
                pictureBox12.Image = Properties.Resources.schina;


                pictureBox13.Image = Properties.Resources.canada;
                pictureBox14.Image = Properties.Resources.scanada;
                pictureBox15.Image = Properties.Resources.brazilia;
                pictureBox16.Image = Properties.Resources.sbrazilia;

                pictureBox17.Image = Properties.Resources.australia;
                pictureBox18.Image = Properties.Resources.saustralia;
                pictureBox19.Image = Properties.Resources.japonia;
                pictureBox20.Image = Properties.Resources.sjaponia;
            }

            foreach (PictureBox carte in groupBox1.Controls)
            { points.Add(carte.Location); }

            foreach (PictureBox carte in groupBox1.Controls)
            {
                int next = location.Next(points.Count);
                Point p = points[next];
                carte.Location = p;
                points.Remove(p);
            }

            timer3.Start();
            timer1.Start();
            inceput = 0;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox carte in groupBox1.Controls)
                carte.Image = Properties.Resources.spate;//atribui fiecarei carti imaginea Coperta.jpg (aceiasi imagine)

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Scor.Text = Convert.ToString(Convert.ToInt32(Scor.Text) + 1);// aici se inregistreaza numarul de incercari
            timer2.Stop();
            //click_imagine1.Image = Properties.Resources.Coperta;
            click_imagine2.Image = Properties.Resources.spate;
            //click_imagine1 = null;
            click_imagine2 = null;
        }
        //timpul alocat memorarii pozitiilor cartilor
        private void timer3_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label2.Text);
            timer = timer - 1;
            label2.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer3.Stop();
                inceput = 1;
            }
        }


        private void Resetare1()
        {
            int timer = Convert.ToInt32(label5.Text);
            timer = timer - 1;
            label5.Text = Convert.ToString(timer);
            if (timer >= 5)
            {
                timer = timer + 10;
                label5.Text = Convert.ToString(timer);
            }
            else
            {
                label5.Text = "10";
            }

        }

        private void Resetare()
        {
            label5.Text = "10";
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label5.Text);
            timer = timer - 1;
            label5.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer4.Stop();
                foreach (PictureBox img in groupBox1.Controls)
                    if (click_imagine1.Tag == img.Tag)
                    {
                        img.Visible = false;
                        click_imagine1.Visible = false;

                        timer5.Start();
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor - 500;//a expirat timpul se scad 1000 de puncte din scor
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        Resetare();//odata ce s-a incheiat timpul disponibil, pierzi toate bonusurile anterioare de timp

                    }
            }
        }



        private void timer5_Tick(object sender, EventArgs e)
        {
            timer5.Stop();
            click_imagine1 = null;
            click_imagine2 = null;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox1.Image = Properties.Resources.aromb;
                else
                        if (imagine == 2)
                    pictureBox1.Image = Properties.Resources.franta;
                else
                             if (imagine == 3)
                    pictureBox1.Image = Properties.Resources.franta;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox1;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox1;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {

                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox1.Enabled = false;
                        pictureBox2.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);

                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox2.Image = Properties.Resources.aromb;
                else
                        if (imagine == 2)
                    pictureBox2.Image = Properties.Resources.cfranta;
                else
                            if (imagine == 3)
                    pictureBox2.Image = Properties.Resources.sfranta;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox2;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox2;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {

                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox1.Enabled = false;
                        pictureBox2.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox1.Visible = false;
                        pictureBox2.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);

                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox3.Image = Properties.Resources.inima;
                else
                        if (imagine == 2)
                    pictureBox3.Image = Properties.Resources.italia;
                else
                            if (imagine == 3)
                    pictureBox3.Image = Properties.Resources.italia;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox3;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox3;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox3.Enabled = false;
                        pictureBox4.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox3.Visible = false;
                        pictureBox4.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox4.Image = Properties.Resources.inima;
                else
                        if (imagine == 2)
                    pictureBox4.Image = Properties.Resources.citalia;
                else
                            if (imagine == 3)
                    pictureBox4.Image = Properties.Resources.sitalia;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox4;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox4;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox4.Enabled = false;
                        pictureBox3.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox4.Visible = false;
                        pictureBox3.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox5.Image = Properties.Resources.jcruce;

                else
                        if (imagine == 2)
                    pictureBox5.Image = Properties.Resources.india;
                else
                            if (imagine == 3)
                    pictureBox5.Image = Properties.Resources.india;
                
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox5;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox5;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox4.Enabled = false;
                        pictureBox5.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox6.Image = Properties.Resources.jcruce;
                else
                        if (imagine == 2)
                    pictureBox6.Image = Properties.Resources.cindia;
                else
                            if (imagine == 3)
                    pictureBox6.Image = Properties.Resources.sindia;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox6;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox6;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox6.Enabled = false;
                        pictureBox5.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox5.Visible = false;
                        pictureBox6.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp
                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox7.Image = Properties.Resources.kromb;
                else
                         if (imagine == 2)
                    pictureBox7.Image = Properties.Resources.romania;
                else
                            if (imagine == 3)
                    pictureBox7.Image = Properties.Resources.romania;
           
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox7;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox7;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp
                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox8.Image = Properties.Resources.kromb;
                else
                        if (imagine == 2)
                    pictureBox8.Image = Properties.Resources.cromania;
                else
                            if (imagine == 3)
                    pictureBox8.Image = Properties.Resources.sromania;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox8;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox8;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox7.Enabled = false;
                        pictureBox8.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox7.Visible = false;
                        pictureBox8.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox9.Image = Properties.Resources.qfrunza;
                else
                        if (imagine == 2)
                    pictureBox9.Image = Properties.Resources.malta;
                else
                            if (imagine == 3)
                    pictureBox9.Image = Properties.Resources.malta;
              
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox9;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox9;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox9.Enabled = false;
                        pictureBox10.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox9.Visible = false;
                        pictureBox10.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox10.Image = Properties.Resources.qfrunza;
                else
                        if (imagine == 2)
                    pictureBox10.Image = Properties.Resources.cmalta;
                else
                             if (imagine == 3)
                    pictureBox10.Image = Properties.Resources.smalta;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox10;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox10;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox9.Enabled = false;
                        pictureBox10.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox9.Visible = false;
                        pictureBox10.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox11.Image = Properties.Resources.romb;
                else
                        if (imagine == 2)
                    pictureBox11.Image = Properties.Resources.china;
                else
                             if (imagine == 3)
                    pictureBox11.Image = Properties.Resources.china;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox11;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox11;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox11.Enabled = false;
                        pictureBox12.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox12.Image = Properties.Resources.romb;
                else
                        if (imagine == 2)
                    pictureBox12.Image = Properties.Resources.cchina;
                else
                            if (imagine == 3)
                    pictureBox12.Image = Properties.Resources.schina;
              
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox12;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox12;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox11.Enabled = false;
                        pictureBox12.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox11.Visible = false;
                        pictureBox12.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }


        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox13.Image = Properties.Resources.optinima;
                else
                        if (imagine == 2)
                    pictureBox13.Image = Properties.Resources.canada;
                else
                            if (imagine == 3)
                    pictureBox13.Image = Properties.Resources.canada;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox13;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox13;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox13.Enabled = false;
                        pictureBox14.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox13.Visible = false;
                        pictureBox14.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox14.Image = Properties.Resources.optinima;
                else
                        if (imagine == 2)
                    pictureBox14.Image = Properties.Resources.ccanada;
                else
                            if (imagine == 3)
                    pictureBox14.Image = Properties.Resources.scanada;
              
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox14;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox14;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox13.Enabled = false;
                        pictureBox14.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox13.Visible = false;
                        pictureBox14.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox15.Image = Properties.Resources.patruromb;
                else
                        if (imagine == 2)
                    pictureBox15.Image = Properties.Resources.brazilia;
                else
                            if (imagine == 3)
                    pictureBox15.Image = Properties.Resources.brazilia;
                
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox15;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox15;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox15.Enabled = false;
                        pictureBox16.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox15.Visible = false;
                        pictureBox16.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox16.Image = Properties.Resources.patruromb;
                else
                        if (imagine == 2)
                    pictureBox16.Image = Properties.Resources.cbrazilia;
                else
                            if (imagine == 3)
                    pictureBox16.Image = Properties.Resources.sbrazilia;
               
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox16;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox16;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox15.Enabled = false;
                        pictureBox16.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox15.Visible = false;
                        pictureBox16.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox17.Image = Properties.Resources.treicruce;
                else
                        if (imagine == 2)
                    pictureBox17.Image = Properties.Resources.australia;
                else
                            if (imagine == 3)
                    pictureBox17.Image = Properties.Resources.australia;
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox17;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox17;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox17.Enabled = false;
                        pictureBox18.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox17.Visible = false;
                        pictureBox18.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox18.Image = Properties.Resources.treicruce;
                else
                        if (imagine == 2)
                    pictureBox18.Image = Properties.Resources.caustralia;
                else
                            if (imagine == 3)
                    pictureBox18.Image = Properties.Resources.saustralia;
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox18;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox18;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox17.Enabled = false;
                        pictureBox18.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox17.Visible = false;
                        pictureBox18.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox19.Image = Properties.Resources.doifrunza;
                else
                        if (imagine == 2)
                    pictureBox19.Image = Properties.Resources.japonia;
                else
                            if (imagine == 3)
                    pictureBox19.Image = Properties.Resources.japonia;
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox19;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox19;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox19.Enabled = false;
                        pictureBox20.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox19.Visible = false;
                        pictureBox20.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            if (inceput == 1 && click_imagine2 == null)
            {
                int imagine = Convert.ToInt32(Form1.imagine);
                if (imagine == 1)
                    pictureBox20.Image = Properties.Resources.doifrunza;
                else
                        if (imagine == 2)
                    pictureBox20.Image = Properties.Resources.caustralia;
                else
                            if (imagine == 3)
                    pictureBox20.Image = Properties.Resources.saustralia;
                // cu ajutorul secventei de mai jos reusesc ca intorc cartile si sa verfic daca ele sunt le fel 
                if (click_imagine1 == null)
                {
                    click_imagine1 = pictureBox20;
                    timer4.Start();
                }
                else if (click_imagine1 != null && click_imagine2 == null)
                {
                    click_imagine2 = pictureBox20;
                    timer4.Start();
                }
                if (click_imagine1 != null && click_imagine2 != null)
                {
                    if (click_imagine1.Tag == click_imagine2.Tag)//aici se verifica daca cartile sunt la fel
                    {
                        click_imagine1 = null;
                        click_imagine2 = null;
                        pictureBox19.Enabled = false;
                        pictureBox20.Enabled = false;
                        Thread.Sleep(500);
                        pictureBox19.Visible = false;
                        pictureBox20.Visible = false;
                        scor = Convert.ToInt32(label6.Text);
                        scor = scor + 1000;//ai potrivit cartea primesti 1000 puncte
                        label6.Text = Convert.ToString(scor);
                        nr_potriviri++;
                        timer4.Stop();
                        int timer = Convert.ToInt32(label5.Text);
                        if (timer >= 5)//ai gasit perechea in jumatate din timpul acordat 
                        {
                            scor = Convert.ToInt32(label6.Text);
                            scor = scor + 500;//ai potrivit cartea in timp record primesti 500 puncte bonus
                            label6.Text = Convert.ToString(scor);
                        }
                        Resetare1();
                        timer4.Stop();//resetare timp

                    }
                    else
                    {
                        timer2.Start();// am folosit acest timp pentru a reusi sa se observe ce carte se intoarce
                    }

                }
            }
        }

        private void RestartJoc_Click(object sender, EventArgs e)
        {
            generare_matrice();
            timer4.Stop();
        }



        private void button1_Click(object sender, EventArgs e)
        {

            while (true)
            {
                this.Opacity -= 0.05;
                Thread.Sleep(50);
                if (this.Opacity <= 0.2)
                    break;
            }
            Owner.Opacity = 1.0;
            Owner.Show();  //Show the previous form
            //Hide();
            Close();


        }


    }
}
