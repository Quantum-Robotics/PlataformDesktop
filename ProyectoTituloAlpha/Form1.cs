using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProyectoTituloAlpha
{
    public partial class MENU : System.Windows.Forms.Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void MENU_Load(object sender, EventArgs e)
        {
            ShowaWindow(3);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonExpand_Click(object sender, EventArgs e)
        {
            panelOptions.Visible = false;
            if (panelOptions.Width == 155)
            {
                panelOther.Width = 35;
                panelOptions.Width = 35;
                LogoBig.Visible = false;
                buttonExpand.Location = new Point(3, 5);
                menuTransition.ShowSync(panelOptions);
            }
            else
            {
                panelOptions.Width = 155;
                panelOther.Width = 155;
                buttonExpand.Location = new Point(118, 5);
                menuTransition.ShowSync(panelOptions);
                logoTransition.ShowSync(LogoBig);
            }
        }

        private void buttonCode_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Solo disponible DEMO", "En pruebas", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowaWindow(1);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pestaña proximamente", "No dispoible",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonConfig_Click(object sender, EventArgs e)
        {
            ShowaWindow(3);
        }

        private void ShowaWindow(int WindowtoOpen)
        {
            InterfaceCode.Visible    = WindowtoOpen == 1 ? true : false;
            InterfaceConnect.Visible = WindowtoOpen == 2 ? true : false;
            InterfaceConfig.Visible  = WindowtoOpen == 3 ? true : false;
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}