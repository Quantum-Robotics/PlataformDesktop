using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;

namespace ProyectoTituloAlpha
{
    public partial class Connect : UserControl
    {
        public Connect()
        {
            InitializeComponent();
        }

        Thread getPort;
        Thread comunicationPort;

        String comunicationText;

        private void Connect_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            getPort = new Thread(new ThreadStart(showPorts));
            comunicationPort = new Thread(new ThreadStart(comunicatePort));
            getPort.Start();
            comunicationPort.Start();
        }

        private void comunicatePort()
        {
            while (true)
            {
                if (serialPorts.IsOpen)
                {
                    textStatus.Text = "Conectado";
                    buttonConnect.Text = "Desconectar";
                    try { comunicationText += serialPorts.ReadLine() + "\n"; }
                    catch { }
                }
                else
                {
                    textStatus.Text = "Desconectado";
                    buttonConnect.Text = "Conectar";
                }
            }
        }

        private void showPorts()
        {
            while (true)
            {
                while (!serialPorts.IsOpen)
                {
                    boxPort.Items.Clear();
                    string[] ports = SerialPort.GetPortNames();
                    boxPort.Items.AddRange(ports);
                    System.Threading.Thread.Sleep(500);
                }
            }
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Conectar")
            {
                if (boxPort.Text != "")
                {
                    try
                    {
                        try
                        {
                            serialPorts.BaudRate = Convert.ToInt32(boxSpeed.Text);
                        }
                        catch
                        {
                            MessageBox.Show("Error dato no valido",
                                "Valor erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (serialPorts.IsOpen)
                            serialPorts.Close();
                        serialPorts.PortName = boxPort.Text;
                        serialPorts.Open();
                        buttonConnect.Text = "Desconectar";
                    }
                    catch
                    {
                        MessageBox.Show("Error para conectar al puerto",
                            "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                    MessageBox.Show("Puerto no seleccionado",
                            "Puerto vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try {
                    serialPorts.Close();
                    buttonConnect.Text = "Conectar";
                }
                catch
                {
                    MessageBox.Show("Error al desconectar el puerto",
                            "Error de desconexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
