using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Temporizados.Properties;

namespace Temporizados
{
    public partial class frmPrincipal : Form
    {
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private TimeSpan tempoRestante;

        private int Minutos = 0;

        public frmPrincipal()
        {
            //pnPrincipal.MouseDown += new MouseEventHandler(move_window);
            //this.MouseDown += new MouseEventHandler(move_window);

            InitializeComponent();

            pnPrincipal.MouseDown += new MouseEventHandler(move_window);

            Minutos = 5;

            lblClock.Text = tempoRestante.ToString(@"hh\:mm\:ss");
            
            TimeSpan duracao = TimeSpan.FromMinutes(Minutos); // Padrão: 5 minutos
            tempoRestante = duracao;

            timer1.Start();

        }

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tempoRestante.TotalSeconds > 0)
            {
                tempoRestante = tempoRestante.Subtract(TimeSpan.FromSeconds(1));
                lblClock.Text = tempoRestante.ToString(@"hh\:mm\:ss");
            }
            else
            {
                timer1.Stop();
                lblClock.Text = "00:00:00";
                lblClock.BackColor = Color.DarkRed;
            }
        }

        private void fInalizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja sair da aplicação?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pararToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmConfig frm = new frmConfig(this, Minutos);
            frm.ShowDialog();

            if (frm.getMinutos() != Minutos)  
            {

                Minutos = frm.getMinutos();

                timer1.Stop();
                lblOnOff.Image = Resources.desligar;

                TimeSpan duracao = TimeSpan.FromMinutes(Minutos);
                tempoRestante = duracao;

                timer1.Start();
                lblOnOff.Image = Resources.ligar;

            }


        }

        private void lblOnOff_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Stop();
                lblOnOff.Image = Resources.desligar;
            }
            else
            {
                timer1.Start();
                lblOnOff.Image = Resources.ligar;
            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frm = new frmSobre();
            frm.ShowDialog();

        }

    }

}
