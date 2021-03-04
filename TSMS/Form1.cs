using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
       
        //Inicializando el tiempo
        int Easttimer = 0;
        int Northtimer = 0;
        int Westtimer = 0;
        int Southtimer = 0;
        int time5 = 0;

        //este temporizador funciona para comprobar qué carro está en camino 
        //y los otros 2 carros del lado para el giro

        private void Turn_timer_Tick(object sender, EventArgs e)
        {
         //comprobando la condición de que el carro 1  alcance el eje X de 410 o no donde dobla
            if (EastCar1.Left == 410)
            {

                Image img = EastCar1.BackgroundImage;
                //rotando la imagen dentro del picturebox 
                img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                EastCar1.Image = img;

                this.EastCar1.Size = new System.Drawing.Size(19, 56);
                //configurando el carro 1 x,y 
                int pictureBox1locationx = 411;//x
                int pictureBox1locationy = 170;//y
                this.EastCar1.Location = new System.Drawing.Point(pictureBox1locationx, pictureBox1locationy);


            }
         
            // entonces el coche se moverá hacia arriba
            else if (EastCar1.Left >= 411)
            {

                this.EastCar1.Location = new System.Drawing.Point(411, EastCar1.Top);
                EastCar1.Top -= 40;

            }

           
            // comprobando la condición de que el carro 2 se alcance en el eje X de 510 o no donde toma el turno
            if (EastCar2.Left == 510)
            {

                Image img = EastCar2.BackgroundImage;
                // rotando la imagen en el picture box
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                EastCar2.Image = img;
                this.EastCar2.Size = new System.Drawing.Size(19, 56);
                //car 1 x,y 
                int pictureBox2locationx = 511;//x
                int pictureBox2locationy = 260;//y
                this.EastCar2.Location = new System.Drawing.Point(pictureBox2locationx, pictureBox2locationy);

            }

            //carro se movera hacia arriba
            else if (EastCar2.Left >= 511)
            {

                this.EastCar2.Location = new System.Drawing.Point(511, EastCar2.Top);
                EastCar2.Top += 40;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //comprobando que cualquier vehículo seleccionado en la sección este o no si selecciona
            // si no se ha seleccionado algun vehiculo
            if (cmbxVehSelectEast.Text != "")
            {
                //disminuyendo el valor del temprizador 1
                Easttimer = Easttimer - 1;
                //incrementando el valor del tiempo 5 
                time5 = time5 + 1;
                label1.Text = Easttimer.ToString();
 
                if (time5 >= 0 && time5 <= 1)
                {//luz amarrillo on
                    EastovalShapeYellow.Visible = true;
                    EastovalShapeRed.Visible = false;
                    EastovalShapeGreen.Visible = false;


                }
                else if (time5 >= 1 && Easttimer >= 1)
                {//luz verder on
                    EastovalShapeYellow.Visible = false;
                    EastovalShapeRed.Visible = false;
                    EastovalShapeGreen.Visible = true;
                    //moviendo los vehiculos incrementando axis x
                    if (EastCar1.Visible == true)
                    {
                        if (EastCar1.Left < 410)
                        {
                            EastCar1.Left += 40;
                        }
                    }
                    if (EastCar2.Visible == true)
                    {
                        if (EastCar2.Left < 510)
                        {
                            EastCar2.Left += 40;
                        }
                    }
                    if (EastCar3.Visible == true)
                    {
                        EastCar3.Left += 40;
                    }

                }//repitiendo hasta cero
                else if (label1.Text == "0")
                {
                    EastovalShapeYellow.Visible = false;
                    EastovalShapeRed.Visible = true;
                    EastovalShapeGreen.Visible = false;
                    //timer 01 stop
                    timer1.Stop();
                    timer1.Enabled = false;

                    time5 = 0;
                    //comprobando que timer iniciara proximo
                    if (Northtimer != 0)
                    {
                        timer2.Start();
                    }
                    else if (Westtimer != 0)
                    {
                        timer3.Start();
                    }
                    else if (Southtimer != 0)
                    {
                        timer4.Start();
                    }
                }


            }
                // en caso que ningun carro se haya seleccionado
            else 
            {
                if (Northtimer != 0)
                {
                    timer2.Start();
                }
                else if (Westtimer != 0)
                {
                    timer3.Start();
                }
                else if (Southtimer != 0)
                {
                    timer4.Start();
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Northtimer = Northtimer - 1;
            time5 = time5 + 1;
            label2.Text = Northtimer.ToString();
            if (time5 >= 0 && time5 <= 1)
            {
                NorthtovalShapeYellow.Visible = true;
                NorthtovalShapeRed.Visible = false;
                NorthtovalShapeGreen.Visible = false;
              

            }
            else if (time5 >= 2 && Northtimer >= 2)
            {//verde
                NorthtovalShapeYellow.Visible = false;
                NorthtovalShapeRed.Visible = false;
                NorthtovalShapeGreen.Visible =true; 

                if (NorthCar1.Visible == true)
                {
                    NorthCar1.Top += 40;
                }
                if (NorthCar2.Visible == true)
                {
                    NorthCar2.Top += 40;
                }
                if (NorthCar3.Visible == true)
                {
                    NorthCar3.Top += 40;
                }

            }
            else if (label2.Text == "0")
            {
                NorthtovalShapeYellow.Visible = false;
                NorthtovalShapeRed.Visible =  true;
                NorthtovalShapeGreen.Visible = false;

                if (label6.Text == "1")
                {
                    timer1.Enabled = true;
                    timer2.Stop();
                    time5 = 2;
                }
                else if (label6.Text == "3")
                {
                    timer3.Enabled = true;
                    timer2.Stop();
                    time5 = 2;
                }
                else
                {
                    timer2.Stop();
                    time5 = 0;
                    if (Westtimer != 0)
                    {
                        timer3.Start();
                    }
                    else if (Southtimer != 0)
                    {
                        timer4.Start();
                    }

                }
            }
            else if (Northtimer == 0)
            {

                timer2.Stop();
                Northtimer = 10;
                timer3.Start();

            }
        }

         private void timer3_Tick(object sender, EventArgs e)
        {
            Westtimer = Westtimer - 1;
            time5 = time5 + 1;
            label3.Text = Westtimer.ToString();
            if (time5 >= 0 && time5 <= 1)
            {
               WesttovalShapeYellow.Visible = true;
               WesttovalShapeRed.Visible = false;
               WesttovalShapeGreen.Visible = false;

            }
            else if (time5 >= 1 && Westtimer >= 1)
            {//verde
                WesttovalShapeYellow.Visible = false;
                WesttovalShapeRed.Visible = false;
                WesttovalShapeGreen.Visible =true; 
                if (WestCar1.Visible == true)
                {
                    WestCar1.Left -= 40;
                }
                if (WestCar2.Visible == true)
                {
                    WestCar2.Left -= 40;
                }
                if (WestCar3.Visible == true)
                {
                    WestCar3.Left -= 40;
                }

            }
            else if (label3.Text == "0")
            {

                WesttovalShapeYellow.Visible = false;
                WesttovalShapeRed.Visible = true;  
                WesttovalShapeGreen.Visible =false;
                if (label6.Text == "2")
                {
                    timer2.Enabled = true;
                    timer3.Stop();
                    time5 = 2;
                }
                else if (label6.Text == "4")
                {
                    timer4.Enabled = true;
                    timer3.Stop();
                    time5 = 2;
                }
                else
                {
                    timer3.Stop();
                    time5 = 0;
                    if (Southtimer != 0)
                    {
                        timer4.Start();
                    }

                }

            }
        }
         private void timer4_Tick(object sender, EventArgs e)
         {
             Southtimer = Southtimer - 1;
             time5 = time5 + 1;
             label4.Text = Southtimer.ToString();
             if (time5 >= 0 && time5 <= 1)
             {
                 SouthtovalShapeYellow.Visible = true;
                 SouthtovalShapeRed.Visible = false;
                 SouthtovalShapeGreen.Visible = false;

             }
             else if (time5 >= 1 && Southtimer >= 1)
             {//verde
                 SouthtovalShapeYellow.Visible = false;
                 SouthtovalShapeRed.Visible = false;
                 SouthtovalShapeGreen.Visible = true;

                 if (SouthCar1.Visible == true)
                 {
                     SouthCar1.Top -= 40;
                 }
                 if (SouthCar2.Visible == true)
                 {
                     SouthCar2.Top -= 40;
                 }
                 if (SouthCar3.Visible == true)
                 {
                     SouthCar3.Top -= 40;
                 }

             }
             else if (label4.Text == "0")
             {
                 SouthtovalShapeYellow.Visible = false;
                 SouthtovalShapeRed.Visible = true;
                 SouthtovalShapeGreen.Visible = false;

                 if (label6.Text == "1")
                 {
                     timer1.Enabled = true;
                     timer4.Stop();
                     time5 = 2;
                 }
                 else if (label5.Text == "3")
                 {
                     timer3.Enabled = true;
                     timer4.Stop();
                     time5 = 2;
                 }
                 else
                 {
                     timer4.Stop();
                     time5 = 0;


                 }


             }

         }

     
        private void timer5_Tick(object sender, EventArgs e)
        {
            if (EastCar3.Visible == true && EastCar3.Left >= 470)
            {
                EastCar3.Left += 40;
            }



            if (NorthCar1.Visible == true && NorthCar1.Top >= 260)
            {
                NorthCar1.Top += 40;
            }
            if (NorthCar2.Visible == true && NorthCar2.Top >= 260)
            {
                NorthCar2.Top += 40;
            }
            if (NorthCar3.Visible == true && NorthCar3.Top >= 260)
            {
                NorthCar3.Top += 40;
            }


            if (WestCar1.Left <= 430)
            {
                WestCar1.Left -= 40;
            }
            if (WestCar2.Left <= 430)
            {
                WestCar2.Left -= 40;
            }
            if (WestCar3.Left <= 430)
            {
                WestCar3.Left -= 40;
            }



            if (SouthCar1.Top <= 270)
            {
                SouthCar1.Top -= 40;
            }
            if (SouthCar2.Top <= 270)
            {
                SouthCar2.Top -= 40;
            }
            if (SouthCar3.Top <= 270)
            {
                SouthCar3.Top -= 40;
            }
  
        }

      
        private void cmbxVehSelectEast_SelectedIndexChanged(object sender, EventArgs e)
        {
            //checking the number of cars and setting time
            if (cmbxVehSelectEast.Text == "1")
            {//mostrando carros
                EastCar1.Visible = true;
                // tiempo en segundos
                Easttimer = 8;
                label1.Text = Easttimer.ToString();
            }
            else if (cmbxVehSelectEast.Text == "2")
            {
                EastCar1.Visible = true;
                EastCar2.Visible = true;
                Easttimer = 14;
                label1.Text = Easttimer.ToString();
            }
            else if (cmbxVehSelectEast.Text == "3")
            {
                EastCar1.Visible = true;
                EastCar2.Visible = true;
                EastCar3.Visible = true;
                Easttimer = 20;
                label1.Text = Easttimer.ToString();
            }
        }

        private void cmbxVehSelectNorth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxVehSelectNorth.Text == "1")
            {
                NorthCar1.Visible = true;
                //segundos 
                Northtimer = 8;
                label2.Text = Northtimer.ToString();
            }
            else if (cmbxVehSelectNorth.Text == "2")
            {
                NorthCar1.Visible = true;
                NorthCar2.Visible = true;
                Northtimer = 14;
                label2.Text = Northtimer.ToString();
            }
            else if (cmbxVehSelectNorth.Text == "3")
            {
                NorthCar1.Visible = true;
                NorthCar2.Visible = true;
                NorthCar3.Visible = true;
                Northtimer = 16;
                label2.Text = Northtimer.ToString();
            }
        }

        private void cmbxVehSelectWest_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbxVehSelectWest.Text == "1")
            {
                WestCar1.Visible = true;
                //segundos 
                Westtimer = 8;
                label3.Text = Westtimer.ToString();
            }
            else if (cmbxVehSelectWest.Text == "2")
            {
                WestCar1.Visible = true;
                WestCar2.Visible = true;
                Westtimer = 14;
                label3.Text = Westtimer.ToString();
            }
            else if (cmbxVehSelectWest.Text == "3")
            {
                WestCar1.Visible = true;
                WestCar2.Visible = true;
                WestCar3.Visible = true;
                Westtimer = 16;
                label3.Text = Westtimer.ToString();
            }
        }

        private void cmbxVehSelectSouth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxVehSelectSouth.Text == "1")
            {
                SouthCar1.Visible = true;
                //sconds 
                Southtimer = 8;
                label4.Text = Southtimer.ToString();
            }
            else if (cmbxVehSelectSouth.Text == "2")
            {
                SouthCar1.Visible = true;
                SouthCar2.Visible = true;
                Southtimer = 14;
                label4.Text = Southtimer.ToString();
            }
            else if (cmbxVehSelectSouth.Text == "3")
            {
                SouthCar1.Visible = true;
                SouthCar2.Visible = true;
                SouthCar3.Visible = true;
                Southtimer = 16;
                label4.Text = Southtimer.ToString();
            }
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        



        private void BtnReset_Click(object sender, EventArgs e)
        {
            Application.Restart(); 
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
