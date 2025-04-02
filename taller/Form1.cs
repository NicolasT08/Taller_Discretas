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
            InicializarTablaVerdad();
            InicializarTablaCombinaciones();

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

        bool statusSen = false;
        bool statusSen2 = false;
        bool statusSen3 = false;
        bool statusSen4 = false;

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

            if (statusAir)
            {
                checkBox9.BackgroundImage = Properties.Resources.Aire;
            }
            else
            {
                checkBox9.BackgroundImage = Properties.Resources.AireA;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            statusAir2 = !statusAir2;

            if (!statusAir2)
            {
                checkBox10.BackgroundImage = Properties.Resources.Aire;
            }
            else
            {
                checkBox10.BackgroundImage = Properties.Resources.AireA;
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            statusAir3 = !statusAir3;

            if (!statusAir3)
            {
                checkBox11.BackgroundImage = Properties.Resources.Aire;
            }
            else
            {
                checkBox11.BackgroundImage = Properties.Resources.AireA;
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            statusAir4 = !statusAir4;

            if (!statusAir4)
            {
                checkBox12.BackgroundImage = Properties.Resources.Aire;
            }
            else
            {
                checkBox12.BackgroundImage = Properties.Resources.AireA;
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            statusSen = !statusSen;

            if (statusSen)
            {
                checkBox13.BackgroundImage = Properties.Resources.sensor;
                if ( (CountDay <= 6 || CountDay >= 18) )
                {
                    pictureBox1.BackgroundImage = Properties.Resources.ComedorR;
                    
                }
                
            } else
            {
                checkBox13.BackgroundImage = Properties.Resources.sensorA;
                if ((CountDay <= 6 || CountDay >= 18))
                {
                    pictureBox1.BackgroundImage = Properties.Resources.ComedorOff;

                }
            }

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            statusSen2 = !statusSen2;

            if (statusSen2)
            {
                checkBox14.BackgroundImage = Properties.Resources.sensor;
                if ((CountDay <= 6 || CountDay >= 18))
                {
                    pictureBox2.BackgroundImage = Properties.Resources.CocinaR;
                }
            }
            else
            {
                checkBox14.BackgroundImage = Properties.Resources.sensorA;
                if ((CountDay <= 6 || CountDay >= 18))
                {
                    pictureBox2.BackgroundImage = Properties.Resources.CocinaOff;
                }
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            statusSen3 = !statusSen3;

            if (statusSen3)
            {
                checkBox15.BackgroundImage = Properties.Resources.sensor;
                if ((CountDay <= 6 || CountDay >= 18))
                {
                    pictureBox3.BackgroundImage = Properties.Resources.HabitacionR;
                }

            }
            else
            {
                checkBox15.BackgroundImage = Properties.Resources.sensorA;
                if ((CountDay <= 6 || CountDay >= 18))
                {
                    pictureBox3.BackgroundImage = Properties.Resources.HabitacionOff;
                }
            }
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            statusSen4 = !statusSen4;

            if (statusSen4)
            {
                checkBox16.BackgroundImage = Properties.Resources.sensor;
                if ((CountDay <= 6 || CountDay >= 18))
                {
                    pictureBox4.BackgroundImage = Properties.Resources.SalaR;

                }
            }
            else
            {
                checkBox16.BackgroundImage = Properties.Resources.sensorA;
                if ((CountDay <= 6 || CountDay >= 18))
                {
                    pictureBox4.BackgroundImage = Properties.Resources.SalaOff;
                }
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

            ActualizarTablaVerdad();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();

            if ( (trackBar1.Value > 22) && (statusDoor == true) && (statusDoor2 == true) && (statusWindows == true) )
            {
                checkBox9.BackgroundImage = Properties.Resources.Aire;
                statusAir = true;
            }
            if ( trackBar1.Value < 22)
            {
                checkBox9.BackgroundImage = Properties.Resources.AireA;
                statusAir = false;
            }
        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar2.Value.ToString();

            if ((trackBar2.Value > 22) && (statusDoor2 == true) && (statusDoor3 == true) && (statusWindows2 == true))
            {
                checkBox10.BackgroundImage = Properties.Resources.Aire;
                statusAir2 = true;
            }
            if (trackBar2.Value < 22)
            {
                checkBox10.BackgroundImage = Properties.Resources.AireA;
                statusAir2 = false;
            }

        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar3.Value.ToString();

            if ((trackBar3.Value > 22) && (statusDoor3 == true) && (statusDoor4 == true) && (statusWindows3 == true))
            {
                checkBox11.BackgroundImage = Properties.Resources.Aire;
                statusAir3 = true;
            }
            if (trackBar3.Value < 22)
            {
                checkBox11.BackgroundImage = Properties.Resources.AireA;
                statusAir3 = false;
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar4.Value.ToString();

            if ((trackBar3.Value > 22) && (statusDoor4 == true) && (statusWindows4 == true))
            {
                checkBox12.BackgroundImage = Properties.Resources.Aire;
                statusAir4 = true;
            }
            if (trackBar3.Value < 22)
            {
                checkBox12.BackgroundImage = Properties.Resources.AireA;
                statusAir4 = false;
            }
        }

        private void InicializarTablaVerdad()
        {
            DataTable tabla = new DataTable();

            // Columnas generales
            tabla.Columns.Add("Zona", typeof(string));          // Nombre de la habitación
            tabla.Columns.Add("Hora_6PM_6AM", typeof(bool));    // True si está entre 6PM y 6AM
            tabla.Columns.Add("Presencia", typeof(bool));       // Sensor de presencia
            tabla.Columns.Add("Temp_Sup_22C", typeof(bool));    // Temperatura > 22°C
            tabla.Columns.Add("Ventana_Cerrada", typeof(bool)); // Estado ventana
            tabla.Columns.Add("Puerta_Cerrada", typeof(bool));  // Estado puerta
            tabla.Columns.Add("Luz_Encendida", typeof(bool));   // Resultado iluminación
            tabla.Columns.Add("AC_Activo", typeof(bool));       // Resultado aire acondicionado

            dataGridView1.DataSource = tabla;
        }

        private void ActualizarTablaVerdad()
        {
            DataTable tabla = (DataTable)dataGridView1.DataSource;
            tabla.Rows.Clear(); // Limpiar filas existentes

            // Estado general de la hora
            bool hora = (CountDay >= 18 || CountDay <= 6); // 6PM a 6AM

            // Arrays para mapear los datos de cada habitación
            string[] zonas = { "Comedor", "Cocina", "Habitación", "Sala" };
            bool[] presencias = { statusSen, statusSen2, statusSen3, statusSen4 };
            int[] temperaturas = { trackBar1.Value, trackBar2.Value, trackBar3.Value, trackBar4.Value };
            bool[] ventanas = { statusWindows, statusWindows2, statusWindows3, statusWindows4 };
            bool[] puertas = { statusDoor, statusDoor2, statusDoor3, statusDoor4 };

            // Llenar la tabla para cada habitación
            for (int i = 0; i < zonas.Length; i++)
            {
                // Entradas
                bool presencia = presencias[i];
                bool tempSup22 = (temperaturas[i] > 22);
                bool ventanaCerrada = ventanas[i];
                bool puertaCerrada = puertas[i];

                // Salidas según reglas
                bool luzEncendida = hora && presencia; // Regla 1: Luz si 6PM-6AM y hay presencia
                bool acActivo = tempSup22 && ventanaCerrada && puertaCerrada; // Regla 2: AC si T > 22°C y todo cerrado

                // Agregar fila para esta habitación
                tabla.Rows.Add(zonas[i], hora, presencia, tempSup22, ventanaCerrada, puertaCerrada, luzEncendida, acActivo);
            }
        }

        private void InicializarTablaCombinaciones()
        {
            DataTable tabla = new DataTable();

            // Input columns
            tabla.Columns.Add("H (6PM-6AM)", typeof(bool));
            tabla.Columns.Add("P (Presence)", typeof(bool));
            tabla.Columns.Add("T (>22°C)", typeof(bool));
            tabla.Columns.Add("V (Window Closed)", typeof(bool));
            tabla.Columns.Add("D (Door Closed)", typeof(bool));
            // Output columns
            tabla.Columns.Add("L (Light On)", typeof(bool));
            tabla.Columns.Add("A (AC On)", typeof(bool));

            // Strings para almacenar las expresiones SOP y POS
            string sopL = "L (SOP) = ";
            string sopA = "A (SOP) = ";
            string posL = "L (POS) = ";
            string posA = "A (POS) = ";
            bool firstSopL = true, firstSopA = true, firstPosL = true, firstPosA = true;

            // Generate all 32 combinations
            for (int i = 0; i < 32; i++)
            {
                bool h = (i & 16) > 0; // Bit 4
                bool p = (i & 8) > 0;  // Bit 3
                bool t = (i & 4) > 0;  // Bit 2
                bool v = (i & 2) > 0;  // Bit 1
                bool d = (i & 1) > 0;  // Bit 0

                // Apply rules
                bool l = h && p;       // Rule 1: Light on if 6PM-6AM and presence
                bool a = t && v && d;  // Rule 2: AC on if T > 22°C and window/door closed

                // Agregar fila a la tabla
                tabla.Rows.Add(h, p, t, v, d, l, a);

                // Construir SOP para L
                if (l)
                {
                    if (!firstSopL) sopL += " + ";
                    sopL += $"({(h ? "H" : "¬H")}{(p ? "P" : "¬P")}{(t ? "T" : "¬T")}{(v ? "V" : "¬V")}{(d ? "D" : "¬D")})";
                    firstSopL = false;
                }

                // Construir SOP para A
                if (a)
                {
                    if (!firstSopA) sopA += " + ";
                    sopA += $"({(h ? "H" : "¬H")}{(p ? "P" : "¬P")}{(t ? "T" : "¬T")}{(v ? "V" : "¬V")}{(d ? "D" : "¬D")})";
                    firstSopA = false;
                }

                // Construir POS para L
                if (!l)
                {
                    if (!firstPosL) posL += "";
                    posL += $"({(h ? "¬H" : "H")}+{(p ? "¬P" : "P")}+{(t ? "¬T" : "T")}+{(v ? "¬V" : "V")}+{(d ? "¬D" : "D")})";
                    firstPosL = false;
                }

                // Construir POS para A
                if (!a)
                {
                    if (!firstPosA) posA += "";
                    posA += $"({(h ? "¬H" : "H")}+{(p ? "¬P" : "P")}+{(t ? "¬T" : "T")}+{(v ? "¬V" : "V")}+{(d ? "¬D" : "D")})";
                    firstPosA = false;
                }
            }

            dataGridView2.DataSource = tabla;

            // Mostrar las expresiones en etiquetas (asegúrate de tener label6 y label7 en tu formulario)
            label10.Text = sopL + "\n" + sopA;  // SOP en label6
            label13.Text = posL + "\n" + posA;  // POS en label7
        }

    }
}
