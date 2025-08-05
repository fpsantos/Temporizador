namespace Temporizados
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.lblOnOff = new System.Windows.Forms.Label();
            this.lblClock = new System.Windows.Forms.Label();
            this.lblIcon = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pararToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fInalizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnPrincipal.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnPrincipal.Controls.Add(this.lblOnOff);
            this.pnPrincipal.Controls.Add(this.lblClock);
            this.pnPrincipal.Controls.Add(this.lblIcon);
            this.pnPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnPrincipal.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnPrincipal.Location = new System.Drawing.Point(0, 0);
            this.pnPrincipal.Margin = new System.Windows.Forms.Padding(2);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(156, 40);
            this.pnPrincipal.TabIndex = 0;
            // 
            // lblOnOff
            // 
            this.lblOnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOnOff.ForeColor = System.Drawing.Color.Black;
            this.lblOnOff.Image = global::Temporizador.Properties.Resources.ligar;
            this.lblOnOff.Location = new System.Drawing.Point(113, 8);
            this.lblOnOff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOnOff.Name = "lblOnOff";
            this.lblOnOff.Size = new System.Drawing.Size(26, 25);
            this.lblOnOff.TabIndex = 4;
            this.lblOnOff.Click += new System.EventHandler(this.lblOnOff_Click);
            // 
            // lblClock
            // 
            this.lblClock.AutoSize = true;
            this.lblClock.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblClock.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.ForeColor = System.Drawing.Color.Black;
            this.lblClock.Location = new System.Drawing.Point(37, 11);
            this.lblClock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(72, 17);
            this.lblClock.TabIndex = 3;
            this.lblClock.Text = "00:00:00";
            // 
            // lblIcon
            // 
            this.lblIcon.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.lblIcon.ForeColor = System.Drawing.Color.Black;
            this.lblIcon.Image = global::Temporizador.Properties.Resources.relogio;
            this.lblIcon.Location = new System.Drawing.Point(7, 5);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(26, 25);
            this.lblIcon.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Temporizador";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pararToolStripMenuItem,
            this.toolStripSeparator1,
            this.sobreToolStripMenuItem,
            this.fInalizarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 100);
            // 
            // pararToolStripMenuItem
            // 
            this.pararToolStripMenuItem.Image = global::Temporizador.Properties.Resources.configuracao1;
            this.pararToolStripMenuItem.Name = "pararToolStripMenuItem";
            this.pararToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.pararToolStripMenuItem.Text = "Configuração";
            this.pararToolStripMenuItem.Click += new System.EventHandler(this.pararToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = global::Temporizador.Properties.Resources.sobre;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // fInalizarToolStripMenuItem
            // 
            this.fInalizarToolStripMenuItem.Image = global::Temporizador.Properties.Resources.porta_de_saida;
            this.fInalizarToolStripMenuItem.Name = "fInalizarToolStripMenuItem";
            this.fInalizarToolStripMenuItem.Size = new System.Drawing.Size(165, 30);
            this.fInalizarToolStripMenuItem.Text = "Finalizar";
            this.fInalizarToolStripMenuItem.Click += new System.EventHandler(this.fInalizarToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(156, 40);
            this.Controls.Add(this.pnPrincipal);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.ShowInTaskbar = false;
            this.Text = "Temporizador";
            this.TopMost = true;
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Label lblClock;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fInalizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pararToolStripMenuItem;
        private System.Windows.Forms.Label lblOnOff;
    }
}

