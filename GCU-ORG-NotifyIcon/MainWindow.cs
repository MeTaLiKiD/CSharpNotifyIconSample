using System;
using System.Windows.Forms;

namespace GCU_ORG_NotifyIcon
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Resize(object sender, EventArgs e)
        {
            // On réduit la fenêtre principale
            if (WindowState == FormWindowState.Minimized)
            {
                // On ne l'affiche plus dans la barre Windows
                this.ShowInTaskbar = false;
                // On affiche l'icone dans la zone de notification
                notifyIcon.Visible = true;
            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            // On remet la fenêtre principale dans la barre Windows
            this.ShowInTaskbar = true;
            // On masque l'icone de la zone de notification
            notifyIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // On remet la fenêtre principale dans la barre Windows
            this.ShowInTaskbar = true;
            // On masque l'icone de la zone de notification
            notifyIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
            notifyIconcontextMenu.Close();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;

            // Démarage du service

            stopToolStripMenuItem.Enabled = true;
            notifyIconcontextMenu.Close();
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = false;

            // Arrêt du service
            // Démarage du service

            startToolStripMenuItem.Enabled = false;
            stopToolStripMenuItem.Enabled = true;
            notifyIconcontextMenu.Close();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stopToolStripMenuItem.Enabled = false;

            // Arrêt du service

            startToolStripMenuItem.Enabled = true;
            notifyIconcontextMenu.Close();
        }
    }
}
