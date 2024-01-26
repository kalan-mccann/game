using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace game
{
    public partial class Form1 : Form
    {
        int page = 1;
        int turn = 1;
        string gameState = "waiting";
        string enemyattack;


        int uhealth = 100;
        int battle = 0;
        double babymanHealth = 15;
        int manHealth = 25;
        int bigmanHealth = 35;
        int MANHealth = 150;


        int attackchance;
        Random random = new Random();
        public Form1()
        {
            InitializeComponent();

        }



        public void enemyturn()
        {


            attackchance = random.Next(1, 4);

            int damageoutputvalue;
            if (attackchance == 1)
            {

                damageoutputvalue = random.Next(0, 2);
                uhealth -= damageoutputvalue;
                battlebox.Text += $"\nenemy missed {damageoutputvalue}";


            }
            else if (attackchance == 2)
            {


                damageoutputvalue = random.Next(3, 5);

                uhealth -= damageoutputvalue;
                battlebox.Text += $"\nenemy got a hit {damageoutputvalue} damage";

            }
            else if (attackchance == 3)
            {

                damageoutputvalue = random.Next(7, 12);
                uhealth -= damageoutputvalue;
                battlebox.Text += $"\nenemy got a critical strike {damageoutputvalue}";
            }
        }

        private void GUARD_Click(object sender, EventArgs e)
        {

        }

        private void up_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
         
            else if (page == 2)
            {
                if (babymanHealth < 0)
                {
                    page = 3;
                }
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 18;
            }
            else if (page == 5)
            {
                page = 6;
            }

            else if (page == 6)
            {
                page = 18;
            }

            else if (page == 18)
            {
                page = 19;
            }

            

            else if (page == 7)
            {
                page = 8;
            }
          

            else if (page == 9)
            {
                page = 10;
            }

            if (page == 11)
            {
                page = 12;
            }
            else if (page == 13)
            {


                page = 1;
            }


            else if (page == 19)
            {
                if (manHealth < 0)
                {
                    page = 20;
                }
            }

            /// game over




            else if (page == 99)
            {
                page = 2;
            }


            switch (page)
            {
                case 1:
                    break;
                case 2:
                    uhealth = 100;
                    pictureBox.Image = Properties.Resources.the_souncdral_appears;
                    description.Text = "THE BATTLE HAS BEGUN";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;

                case 3:
                    pictureBox.Image = Properties.Resources.NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO;
                    dialoug.Text = "MY SECRET FORMULAAAAAAAAAAAAA!!!!!!!!!!";
                    description.Text = "YOU WON FOR REALLLLLLLLLLLLLLLLL";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    babymanHealth = 15;
                    break;

                case 4:
                    dialoug.Text = "i got nothin rn lol";

                    pictureBox.Image = Properties.Resources.PSX_20230323_135219;
                    break;




                case 5:
                    description.Text = "a very strange passsage way";

                    break;

                case 6:
                    description.Text = "you see a very strange man run away";
                    break;

                case 7:
                    pictureBox.Image = Properties.Resources.danger;
                    description.Text = "what is this mysterious realm?"

; break;

                case 8:
                    pictureBox.Image = Properties.Resources.battle_2;
                    description.Text = "an absolutely malicous tax payer comes your way";
                    dialoug.Text = "have you payed your taxes today?";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;

                case 9:
                    pictureBox.Image = Properties.Resources.battle_end_2;
                    dialoug.Text = "you shmuck how dare you";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    break;

                case 10:
                    pictureBox.Image = Properties.Resources.download__4__5;
                    description.Text = "a silly house";
                    dialoug.Text = "still got nothin rn";
                    break;

                case 11:
                    pictureBox.Image = Properties.Resources.bad_dream;
                    description.Text = "what is this foul place?";

                    break;
                case 12:
                    pictureBox.Image = Properties.Resources.final_battle;
                    description.Text = "it is a fight against the supreme leader";
                    dialoug.Text = "you have earned obliteration";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;

                    break;

                case 13:
                    pictureBox.Image = Properties.Resources.final_battle_end;
                    description.Text = "you have zigged his zag and can now finally leave shrumbleton (press forward to escape)";
                    dialoug.Text = "goejwoijfqoihfowehwphjqwqhjoi average seven eleven enjoyer oiwhwoihfewoifwehfoiwehfe";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    break;
                case 18:
                    pictureBox.Image = Properties.Resources.SPLIKE;
                    description.Text = "YOU SPIKE I SPIKE YOU SPIKING YOUR SPIKETON";


                    break;
                case 19:
                    pictureBox.Image = Properties.Resources._234556;
                    description.Text = "I shall kill you in few swings";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;

                    break;

                case 20:
                    description.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";
                    dialoug.Text = "NO H";
                    break;
                case 98:


                    break;
                case 99:
                    description.Text = "YOUR SILLINESS IS STRONGER THAN DEATH";
                    pictureBox.Image = Properties.Resources.adach;
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;

                    break;

            }
        }
        

        private void button4_Click(object sender, EventArgs e)
        {


            attackchance = random.Next(1, 4);

            int damageoutputvalue;

            if (page == 2)
            {
                if (attackchance == 1)
                {

                    damageoutputvalue = random.Next(0, 2);
                    babymanHealth -= damageoutputvalue;
                    battlebox.Text = $"you missed {damageoutputvalue}";


                }
                else if (attackchance == 2)
                {


                    damageoutputvalue = random.Next(3, 5);

                    babymanHealth -= damageoutputvalue;
                    battlebox.Text = $"you got a hit {damageoutputvalue} damage";

                }
                else if (attackchance == 3)
                {

                    damageoutputvalue = random.Next(7, 12);
                    babymanHealth -= damageoutputvalue;
                    battlebox.Text = $"you got a critical strike {damageoutputvalue}";


                }
            }





            else if (page == 8)
            {
                if (attackchance == 1)
                {

                    damageoutputvalue = random.Next(0, 2);
                    manHealth -= damageoutputvalue;
                    battlebox.Text = $"you missed {damageoutputvalue}";


                }
                else if (attackchance == 2)
                {


                    damageoutputvalue = random.Next(3, 5);

                    manHealth -= damageoutputvalue;
                    battlebox.Text = $"you got a hit {damageoutputvalue} damage";

                }
                else if (attackchance == 3)
                {

                    damageoutputvalue = random.Next(7, 12);
                    manHealth -= damageoutputvalue;
                    battlebox.Text = $"you got a critical strike {damageoutputvalue}";


                }

            }



            else if (page == 12)
            {
                if (attackchance == 1)
                {

                    damageoutputvalue = random.Next(0, 2);
                    bigmanHealth -= damageoutputvalue;
                    battlebox.Text = $"you missed {damageoutputvalue}";


                }
                else if (attackchance == 2)
                {


                    damageoutputvalue = random.Next(3, 5);

                    bigmanHealth -= damageoutputvalue;
                    battlebox.Text = $"you got a hit {damageoutputvalue} damage";

                }
                else if (attackchance == 3)
                {

                    damageoutputvalue = random.Next(7, 12);
                    bigmanHealth -= damageoutputvalue;
                    battlebox.Text = $"you got a critical strike {damageoutputvalue}";


                }

            }




            else if (page == 19)
            {
                if (attackchance == 1)
                {

                    damageoutputvalue = random.Next(0, 2);
                    MANHealth -= damageoutputvalue;
                    battlebox.Text = $"you missed {damageoutputvalue}";


                }
                else if (attackchance == 2)
                {


                    damageoutputvalue = random.Next(3, 5);

                    MANHealth -= damageoutputvalue;
                    battlebox.Text = $"you got a hit {damageoutputvalue} damage";

                }
                else if (attackchance == 3)
                {

                    damageoutputvalue = random.Next(7, 12);
                    MANHealth -= damageoutputvalue;
                    battlebox.Text = $"you got a critical strike {damageoutputvalue}";


                }
            }
            
            
          
               







           if (babymanHealth < 0)
            {
                page = 3;
            }


            else if (uhealth < 0)
            {
                page = 99;
            }




            else if (page == 8)
                {
                    if (manHealth < 0)
                    {
                        page = 9;
                    }
                }


           else if (page == 12)
            {
                if (bigmanHealth < 0)
                    page = 13;
            }


            else if (page == 19)
            {
                if (MANHealth < 0)
                {
                    page = 20;
                }
            }
            

         
            
            

            switch (page)
            {
                case 1:
                    break;
                case 2:
                    uhealth = 100;
                    pictureBox.Image = Properties.Resources.the_souncdral_appears;
                    description.Text = "THE BATTLE HAS BEGUN";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;

                case 3:
                    pictureBox.Image = Properties.Resources.NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO;
                    dialoug.Text = "MY SECRET FORMULAAAAAAAAAAAAA!!!!!!!!!!";
                    description.Text = "YOU WON FOR REALLLLLLLLLLLLLLLLL";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    babymanHealth = 15;
                    break;

                case 4:
                    dialoug.Text = "i got nothin rn lol";

                    pictureBox.Image = Properties.Resources.PSX_20230323_135219;
                    break;




                case 5:
                 description.Text = "a very strange passsage way";

                  break;

                case 6:
                    description.Text = "you see a very strange man run away";
                    break;
                
                case 7: pictureBox.Image = Properties.Resources.danger;
                    description.Text = "what is this mysterious realm?"

;                    break;

                case 8: pictureBox.Image = Properties.Resources.battle_2;
                    description.Text = "an absolutely malicous tax payer comes your way";
                    dialoug.Text = "have you payed your taxes today?";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;

                case 9:
                    pictureBox.Image = Properties.Resources.battle_end_2;
                    dialoug.Text = "you shmuck how dare you";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    break;

                case 10:
                    pictureBox.Image = Properties.Resources.download__4__5;
                    description.Text = "a silly house";
                    dialoug.Text = "still got nothin rn";
                    break;

                case 11: pictureBox.Image = Properties.Resources.bad_dream;
                    description.Text = "what is this foul place?";
                    break;
                case 12: 
                    pictureBox.Image = Properties.Resources.final_battle;
                    description.Text = "it is a fight against the supreme leader";
                    dialoug.Text = "you have earned obliteration";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;

                    break;

                case 13:
                    pictureBox.Image = Properties.Resources.final_battle_end;
                    description.Text = "you have zigged his zag and can now finally leave shrumbleton (press forward to escape)";
                    dialoug.Text = "goejwoijfqoihfowehwphjqwqhjoi average seven eleven enjoyer oiwhwoihfewoifwehfoiwehfe";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    break;
                case 18:
                    pictureBox.Image = Properties.Resources.SPLIKE;
                    description.Text = "YOU SPIKE I SPIKE YOU SPIKING YOUR SPIKETON";
                    
                    
                    break;
                case 19:
                    pictureBox.Image = Properties.Resources._234556;
                    description.Text = "I shall kill you in few swings";
                    attack.Enabled = true;
                    up.Enabled=false;
                    left.Enabled = false;
                    right.Enabled = false;
                   
                    break;

                case 20:
                    description.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";
                    dialoug.Text = "NO H";
                    break;
                case 98:
                    
                   
                    break;
                case 99:
                    description.Text = "YOUR SILLINESS IS STRONGER THAN DEATH";
                    pictureBox.Image = Properties.Resources.adach;
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;

                    break;

            }

            enemyturn();
























        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gametimer_Tick(object sender, EventArgs e)
        {








            Refresh();
        }

        private void dialoug_Click(object sender, EventArgs e)
        {

        }

        private void left_Click(object sender, EventArgs e)
        {
            if ( page == 4)
            {
                page = 5;
            }

          else  if (page == 5)
            {
                page = 18;
            }

            else if (page == 7)
            {
                page = 8;
            }

















            switch (page)
            {
                case 1:
                    break;
                case 2:
                    uhealth = 100;
                    pictureBox.Image = Properties.Resources.the_souncdral_appears;
                    description.Text = "THE BATTLE HAS BEGUN";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;

                case 3:
                    pictureBox.Image = Properties.Resources.NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO;
                    dialoug.Text = "MY SECRET FORMULAAAAAAAAAAAAA!!!!!!!!!!";
                    description.Text = "YOU WON FOR REALLLLLLLLLLLLLLLLL";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    babymanHealth = 15;
                    break;

                case 4:
                    dialoug.Text = "i got nothin rn lol";

                    pictureBox.Image = Properties.Resources.PSX_20230323_135219;
                    break;




                case 5:
                    description.Text = "a very strange passsage way";

                    break;

                case 6:
                    description.Text = "you see a very strange man run away";
                    break;

                case 7:
                    pictureBox.Image = Properties.Resources.danger;
                    description.Text = "what is this mysterious realm?"

; break;

                case 8:
                    pictureBox.Image = Properties.Resources.battle_2;
                    description.Text = "an absolutely malicous tax payer comes your way";
                    dialoug.Text = "have you payed your taxes today?";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;

                case 9:
                    pictureBox.Image = Properties.Resources.battle_end_2;
                    dialoug.Text = "you shmuck how dare you";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    break;

                case 10:
                    pictureBox.Image = Properties.Resources.download__4__5;
                    description.Text = "a silly house";
                    dialoug.Text = "still got nothin rn";
                    break;

                case 11:
                    pictureBox.Image = Properties.Resources.bad_dream;
                    description.Text = "what is this foul place?";
                    break;
                case 12:
                    pictureBox.Image = Properties.Resources.final_battle;
                    description.Text = "it is a fight against the supreme leader";
                    dialoug.Text = "you have earned obliteration";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;

                    break;

                case 13:
                    pictureBox.Image = Properties.Resources.final_battle_end;
                    description.Text = "you have zigged his zag and can now finally leave shrumbleton (press forward to escape)";
                    dialoug.Text = "goejwoijfqoihfowehwphjqwqhjoi average seven eleven enjoyer oiwhwoihfewoifwehfoiwehfe";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    break;
                case 18:
                    pictureBox.Image = Properties.Resources.SPLIKE;
                    description.Text = "YOU SPIKE I SPIKE YOU SPIKING YOUR SPIKETON";


                    break;
                case 19:
                    pictureBox.Image = Properties.Resources._234556;
                    description.Text = "I shall kill you in few swings";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;

                    break;

                case 20:
                    description.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";
                    dialoug.Text = "NO H";
                    break;
                case 98:


                    break;
                case 99:
                    description.Text = "YOUR SILLINESS IS STRONGER THAN DEATH";
                    pictureBox.Image = Properties.Resources.adach;
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;

                    break;

            }



        }

        private void right_Click(object sender, EventArgs e)
        {
            if (page == 6)
            {
                page = 7;
            }



           else if  (page == 10)
           {

                    page = 11;

            }


















            switch (page)
            {
                case 1:
                    break;
                case 2:
                    uhealth = 100;
                    pictureBox.Image = Properties.Resources.the_souncdral_appears;
                    description.Text = "THE BATTLE HAS BEGUN";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;

                case 3:
                    pictureBox.Image = Properties.Resources.NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO;
                    dialoug.Text = "MY SECRET FORMULAAAAAAAAAAAAA!!!!!!!!!!";
                    description.Text = "YOU WON FOR REALLLLLLLLLLLLLLLLL";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    babymanHealth = 15;
                    break;

                case 4:
                    dialoug.Text = "i got nothin rn lol";

                    pictureBox.Image = Properties.Resources.PSX_20230323_135219;
                    break;




                case 5:
                    description.Text = "a very strange passsage way";

                    break;

                case 6:
                    description.Text = "you see a very strange man run away";
                    break;

                case 7:
                    pictureBox.Image = Properties.Resources.danger;
                    description.Text = "what is this mysterious realm?"

; break;

                case 8:
                    pictureBox.Image = Properties.Resources.battle_2;
                    description.Text = "an absolutely malicous tax payer comes your way";
                    dialoug.Text = "have you payed your taxes today?";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;

                case 9:
                    pictureBox.Image = Properties.Resources.battle_end_2;
                    dialoug.Text = "you shmuck how dare you";
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;
                    break;

                case 10:
                    pictureBox.Image = Properties.Resources.download__4__5;
                    description.Text = "a silly house";
                    dialoug.Text = "still got nothin rn";
                    break;

                case 11:
                    pictureBox.Image = Properties.Resources.bad_dream;
                    description.Text = "what is this foul place?";
                    break;
                case 12:
                    pictureBox.Image = Properties.Resources.final_battle;
                    description.Text = "it is a fight against the supreme leader";
                    dialoug.Text = "you have earned obliteration";
                   

                    break;

                case 13:
                    pictureBox.Image = Properties.Resources.final_battle_end;
                    description.Text = "you have zigged his zag and can now finally leave shrumbleton (press forward to escape)";
                    dialoug.Text = "goejwoijfqoihfowehwphjqwqhjoi average seven eleven enjoyer oiwhwoihfewoifwehfoiwehfe";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;
                    break;
                case 18:
                    pictureBox.Image = Properties.Resources.SPLIKE;
                    description.Text = "YOU SPIKE I SPIKE YOU SPIKING YOUR SPIKETON";


                    break;
                case 19:
                    pictureBox.Image = Properties.Resources._234556;
                    description.Text = "I shall kill you in few swings";
                    attack.Enabled = true;
                    up.Enabled = false;
                    left.Enabled = false;
                    right.Enabled = false;

                    break;

                case 20:
                    description.Text = "NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO";
                    dialoug.Text = "NO H";
                    break;
                case 98:


                    break;
                case 99:
                    description.Text = "YOUR SILLINESS IS STRONGER THAN DEATH";
                    pictureBox.Image = Properties.Resources.adach;
                    attack.Enabled = false;
                    up.Enabled = true;
                    left.Enabled = true;
                    right.Enabled = true;

                    break;

            }
        
        }
    }
}
