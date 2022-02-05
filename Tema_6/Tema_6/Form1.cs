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
    public partial class Form1 : Form
    {
        Incepator formular1;
        Mediu formular2;
        Avansat formular3;
        public static string imagine = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.SlateBlue;
            button5.BackColor = Color.DeepSkyBlue;
            button9.BackColor = Color.DodgerBlue;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            button5.BackColor = Color.SlateBlue;
            button9.BackColor = Color.DodgerBlue;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
            button5.BackColor = Color.SlateBlue;
            button9.BackColor = Color.DodgerBlue;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
        void formular1_FormClosed1(object sender, FormClosedEventArgs e)
        {
            formular1 = null;  //If form is closed make sure reference is set to null
            Show();
        }

        void formular2_FormClosed2(object sender, FormClosedEventArgs e)
        {
            formular2 = null;  //If form is closed make sure reference is set to null
            Show();
        }

        void formular3_FormClosed3(object sender, FormClosedEventArgs e)
        {
            formular3 = null;  //If form is closed make sure reference is set to null
            Show();
        }


        private void Trecere()
        {
            while (true)
            {
                this.Opacity -= 0.05;
                Thread.Sleep(50);
                if (this.Opacity <= 0.0)
                    break;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "1";

            if (formular1 == null)
            {
                formular1 = new Incepator();   //Create form if not created
                formular1.FormClosed += formular1_FormClosed1;  //Add eventhandler to cleanup after form closes
            }
            formular1.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular1.BackColor = Color.MediumSlateBlue;
            formular1.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "1";
            if (formular2 == null)
            {
                formular2 = new Mediu();   //Create form if not created
                formular2.FormClosed += formular2_FormClosed2;  //Add eventhandler to cleanup after form closes
            }
            formular2.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular2.BackColor = Color.MediumPurple;
            formular2.Show(this);  //Show Form assigning this form as the forms owner
            Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "1";
            if (formular3 == null)
            {
                formular3 = new Avansat();   //Create form if not created
                formular3.FormClosed += formular3_FormClosed3;  //Add eventhandler to cleanup after form closes
            }
            formular3.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular3.BackColor = Color.BlueViolet;
            formular3.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "2";

            if (formular1 == null)
            {
                formular1 = new Incepator();   //Create form if not created
                formular1.FormClosed += formular1_FormClosed1;  //Add eventhandler to cleanup after form closes
            }
            formular1.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular1.BackColor = Color.MediumSlateBlue;
            formular1.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "2";
            if (formular2 == null)
            {
                formular2 = new Mediu();   //Create form if not created
                formular2.FormClosed += formular2_FormClosed2;  //Add eventhandler to cleanup after form closes
            }
            formular2.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular2.BackColor = Color.MediumPurple;
            formular2.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "2";
            if (formular3 == null)
            {
                formular3 = new Avansat();   //Create form if not created
                formular3.FormClosed += formular3_FormClosed3;  //Add eventhandler to cleanup after form closes
            }
            formular3.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular3.BackColor = Color.BlueViolet;
            formular3.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "3";

            if (formular1 == null)
            {
                formular1 = new Incepator();   //Create form if not created
                formular1.FormClosed += formular1_FormClosed1;  //Add eventhandler to cleanup after form closes
            }
            formular1.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular1.BackColor = Color.MediumSlateBlue;
            formular1.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "3";
            if (formular2 == null)
            {
                formular2 = new Mediu();   //Create form if not created
                formular2.FormClosed += formular2_FormClosed2;  //Add eventhandler to cleanup after form closes
            }
            formular2.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular2.BackColor = Color.MediumPurple;
            formular2.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Trecere();
            imagine = "3";
            if (formular3 == null)
            {
                formular3 = new Avansat();   //Create form if not created
                formular3.FormClosed += formular3_FormClosed3;  //Add eventhandler to cleanup after form closes
            }
            formular3.Opacity = 1.0;
            //frm1.Size = new Size(490, 548);
            formular3.BackColor = Color.BlueViolet;
            formular3.Show(this);  //Show Form assigning this form as the forms owner
            Hide();
        }

     
    }
}
