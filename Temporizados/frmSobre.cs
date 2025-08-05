using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Temporizados
{
    public partial class frmSobre : Form
    {
        public frmSobre()
        {
            InitializeComponent();

            webBrowser1.DocumentText = @"
            <p align='justify'><big><style='color: rgb(0, 0, 153);'><span style='font-weight: bold;'>Gerencie seu tempo com efici&ecirc;ncia em apresenta&ccedil;&otilde;es e tarefas.</span><br><br>
            Configure o tempo desejado e o Temporizador realizar&aacute; a contagem regressiva com precis&atilde;o. Ferramenta ideal para evitar extrapola&ccedil;&otilde;es de tempo, manter o ritmo das atividades e assegurar o cumprimento dos cronogramas definidos.<br>
            </big></p>";

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
