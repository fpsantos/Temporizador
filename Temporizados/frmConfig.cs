using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temporizados
{
    public partial class frmConfig : Form
    {

        private int Minutos = 0;

        private frmPrincipal _targetForm;

        public frmConfig(frmPrincipal targetForm, int minutos)
        {
            
            InitializeComponent();

            _targetForm = targetForm;
            Minutos = minutos;

            Console.WriteLine(_targetForm.Opacity);
            trackBar1.Value = (int)(_targetForm.Opacity * 100.0);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            int MinutosLocal = Minutos;
            
            try
            {
                MinutosLocal = int.Parse(EdMinutos.Text);
            }
            catch (Exception)
            {

                MinutosLocal = Minutos;
            }

            if(Minutos != MinutosLocal)
            {
                Minutos = MinutosLocal;
            }

            this.Close();
        }

        public int getMinutos() 
        {
            return Minutos;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _targetForm.Opacity = trackBar1.Value / 100.0;
        }
    }

}
