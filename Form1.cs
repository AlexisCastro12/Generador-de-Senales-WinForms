using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using info.lundin.math;

namespace WFProyectoGenerador
{
    public partial class Form1 : Form
    {
        bool Stp = true;

        public Form1()
        {
            InitializeComponent();
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double xi, xf, h, x, y, T, frec, Amp, omega;
            int n;
            Generador.Series["Señal Generada"].Points.Clear();
            T = DateTime.Now.Second * 0.25;

            Amp = double.Parse(tBAmpP.Text);
            frec = double.Parse(tBfrec.Text);
            omega = 2 * Math.PI * frec;

            if (RBPulsos.Checked)
            {
                xi = -2 / frec;
                xf = 2 / frec;
            }
            else
            {
                xi = -1 / frec;
                xf = 1 / frec;
            }
            
            n = Generador.Width;
            h = (xf - xi) / n;
            for (int k = 0; k < n; k++)
            {
                x = xi + k * h;
                y = 0;

                if (RBSen.Checked)
                    y = Amp * Math.Sin(omega * x - T);
                if (RBCos.Checked)
                    y = Amp * Math.Cos(omega* x - T);
                if (RBTriang.Checked)   //Generamos la señal con su serie de fourier
                {
                    for (int i = 1; i <= 15; i++)
                    {
                        y = y + (Math.Pow(-1, i + 1) * (8 * Amp / (Math.Pow(2 * i - 1, 2) * Math.Pow(Math.PI, 2))) * Math.Sin((2 * i - 1) * (omega * x - T)));
                    }
                }
                if (RBSierra.Checked)   //Generamos la señal con su serie de fourier
                {
                    if (frec % 10 == 0)
                    {
                        frec = frec - 0.1;
                        omega = 2 * Math.PI * frec;
                    }
                    for (int i = 1; i <= 15; i++)
                    {
                        y = y + (-2*Amp / (i * Math.PI) * Math.Sin(omega * i * (x - T)));
                    }
                }

                if (RBPulsos.Checked)
                {
                    y = Math.Abs(Math.Tan(Math.PI * frec * (x - T)));
                }

                if (RBCuadrada.Checked)   //Generamos la señal con su serie de fourier
                {
                    if (frec % 10 == 0)
                    {
                        frec = frec - 0.1;
                        omega = 2 * Math.PI * frec;
                    }
                    for (int i = 1; i <= 30; i++)
                    {
                        y = y + (4*Amp/((2*i-1)*Math.PI)*Math.Sin(omega*(2*i-1)*(x-T)));
                    }
                }

                if (RBContinua.Checked)
                {
                    y = Amp;
                }
                Generador.Series["Señal Generada"].Points.AddXY(x, y);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void tBAmpP_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void tBfrec_TextChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void RBSen_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void RBCos_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void RBTriang_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void RBSierra_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void RBPulsos_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void RBContinua_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void RBCuadrada_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
        }

        private void BtnRnStp_Click(object sender, EventArgs e)
        {
            if(Stp)
            {
                timer1.Stop();
                Stp = false;
            }
            else
            {
                timer1.Start();
                Stp = true;
            }
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Castro.exe");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
