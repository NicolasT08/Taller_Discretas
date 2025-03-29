using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace taller
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();

        }

        int CountDay = 0;

        bool lightstatus = false;
        bool statusDoor = false;
        bool statusDoor2 = false;
        bool statusDoor3 = false;
        bool statusDoor4 = false;

        bool statusWindows = false;
        bool statusWindows2 = false;
        bool statusWindows3 = false;
        bool statusWindows4 = false;

        bool statusAir = false;
        bool statusAir2 = false;
        bool statusAir3 = false;
        bool statusAir4 = false;

        private void changeGeneral()
        {
            checkBox1.BackgroundImage = Properties.Resources.Puerta_cerrada;
            checkBox2.BackgroundImage = Properties.Resources.Puerta_cerrada;
            checkBox3.BackgroundImage = Properties.Resources.Puerta_cerrada;
            checkBox4.BackgroundImage = Properties.Resources.Puerta_cerrada;
            checkBox5.BackgroundImage = Properties.Resources.Ventana_cerrada;
            checkBox6.BackgroundImage = Properties.Resources.Ventana_cerrada;
            checkBox7.BackgroundImage = Properties.Resources.Ventana_cerrada;
            checkBox8.BackgroundImage = Properties.Resources.Ventana_cerrada;
            statusDoor = true;
            statusDoor2 = true;
            statusDoor3 = true;
            statusDoor4 = true;
            statusWindows = true;
            statusWindows2 = true;
            statusWindows3 = true;
            statusWindows4 = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lightstatus = !lightstatus;

            if (lightstatus)
            {
                pictureBox1.BackgroundImage = Properties.Resources.ComedorR;
                pictureBox2.BackgroundImage = Properties.Resources.CocinaR;
                pictureBox3.BackgroundImage = Properties.Resources.HabitacionR;
                pictureBox4.BackgroundImage = Properties.Resources.SalaR;
                button1.BackgroundImage = Properties.Resources.bombillaE;

            } else
            {
                pictureBox1.BackgroundImage = Properties.Resources.ComedorOff;
                pictureBox2.BackgroundImage = Properties.Resources.CocinaOff;
                pictureBox3.BackgroundImage = Properties.Resources.HabitacionOff;
                pictureBox4.BackgroundImage = Properties.Resources.SalaOff;
                button1.BackgroundImage = Properties.Resources.bombillaA;
            }
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            statusDoor = !statusDoor;

            if (statusDoor)
            {
                checkBox1.BackgroundImage = Properties.Resources.Puerta_cerrada;
            }
            else
            {
                checkBox1.BackgroundImage = Properties.Resources.Puerta_abierta;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            statusDoor2 = !statusDoor2;

            if (statusDoor2)
            {
                checkBox2.BackgroundImage = Properties.Resources.Puerta_cerrada;
            }
            else
            {
                checkBox2.BackgroundImage = Properties.Resources.Puerta_abierta;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            statusDoor3 = !statusDoor3;

            if (statusDoor3)
            {
                checkBox3.BackgroundImage = Properties.Resources.Puerta_cerrada;
            }
            else
            {
                checkBox3.BackgroundImage = Properties.Resources.Puerta_abierta;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            statusDoor4 = !statusDoor4;

            if (statusDoor4)
            {
                checkBox4.BackgroundImage = Properties.Resources.Puerta_cerrada;
            }
            else
            {
                checkBox4.BackgroundImage = Properties.Resources.Puerta_abierta;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            statusWindows = !statusWindows;

            if (statusWindows)
            {
                checkBox5.BackgroundImage = Properties.Resources.Ventana_cerrada;
            }
            else
            {
                checkBox5.BackgroundImage = Properties.Resources.Ventana_abierta;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            statusWindows2 = !statusWindows2;

            if (statusWindows2)
            {
                checkBox6.BackgroundImage = Properties.Resources.Ventana_cerrada;
            }
            else
            {
                checkBox6.BackgroundImage = Properties.Resources.Ventana_abierta;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            statusWindows3 = !statusWindows3;

            if (statusWindows3)
            {
                checkBox7.BackgroundImage = Properties.Resources.Ventana_cerrada;
            }
            else
            {
                checkBox7.BackgroundImage = Properties.Resources.Ventana_abierta;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            statusWindows4 = !statusWindows4;

            if (statusWindows4)
            {
                checkBox8.BackgroundImage = Properties.Resources.Ventana_cerrada;
            }
            else
            {
                checkBox8.BackgroundImage = Properties.Resources.Ventana_abierta;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            statusAir = !statusAir;

            if (!statusAir)
            {
                checkBox9.BackgroundImage = Properties.Resources.AireA;
            }
            else
            {
                checkBox9.BackgroundImage = Properties.Resources.Aire;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            statusAir2 = !statusAir2;

            if (!statusAir2)
            {
                checkBox10.BackgroundImage = Properties.Resources.AireA;
            }
            else
            {
                checkBox10.BackgroundImage = Properties.Resources.Aire;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            statusAir3 = !statusAir3;

            if (!statusAir3)
            {
                checkBox11.BackgroundImage = Properties.Resources.AireA;
            }
            else
            {
                checkBox11.BackgroundImage = Properties.Resources.Aire;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            statusAir4 = !statusAir4;

            if (!statusAir4)
            {
                checkBox12.BackgroundImage = Properties.Resources.AireA;
            }
            else
            {
                checkBox12.BackgroundImage = Properties.Resources.Aire;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text  = CountDay.ToString();
            CountDay += 1;

            if (CountDay > 24)
            {
                CountDay = 0;
            }

            if (CountDay <= 0 || CountDay >= 18)
            {
                changeGeneral();
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if(trackBar1.Value < 22)
            {
                changeGeneral();
                checkBox9.BackgroundImage = Properties.Resources.Aire;
                checkBox10.BackgroundImage = Properties.Resources.Aire;
                checkBox11.BackgroundImage = Properties.Resources.Aire;
                checkBox12.BackgroundImage = Properties.Resources.Aire;
                statusAir = false;
                statusAir2 = false;
                statusAir3 = false;
                statusAir4 = false;
            }
        }

    }
}
