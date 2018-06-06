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
    public partial class Config : UserControl
    {
        public Config()
        {
            InitializeComponent();
        }

        Thread ReadPortAvailables;

        private int Servo;
        private int Leg;
        private int Angle;

        private void Config_Load(object sender, EventArgs e)
        {
            ConfigThreads();
        }

        private void ConfigThreads()
        {
            CheckForIllegalCrossThreadCalls = false;
            ReadPortAvailables = new Thread(new ThreadStart(showPorts));
            ReadPortAvailables.Start();
        }

        private void showPorts()
        {
            while (true)
            {
                while (!serialPort.IsOpen)
                {
                    PuertosAvailables.Items.Clear();
                    string[] ports = SerialPort.GetPortNames();
                    PuertosAvailables.Items.AddRange(ports);
                    System.Threading.Thread.Sleep(500);
                    PanelDebug.Enabled = false;
                    BotonDeConexion.Text = "Conectar";
                }
                BotonDeConexion.Text = "Desconectar";
                PanelDebug.Enabled = true;
                if (this.Visible == false && serialPort.IsOpen)
                {
                    serialPort.Close();
                }
            }
        }

        private void BotonDeConexion_Click(object sender, EventArgs e)
        {
            if (BotonDeConexion.Text == "Conectar")
            {
                if (PuertosAvailables.Text != "")
                {
                    try
                    {
                        try { serialPort.BaudRate = Convert.ToInt32(BaudRateAvailables.Text); }
                        catch
                        {
                            MessageBox.Show("Error el valor de la velocidad no es correcto",
                                "Valor erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        if (RobotAvailables.Text == "")
                        {
                            MessageBox.Show("Error seleccione un modelo de robot",
                                "Valor erroneo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (serialPort.IsOpen)
                                serialPort.Close();
                            serialPort.PortName = PuertosAvailables.Text;
                            serialPort.Open();
                            serialPort.Write("1");
                            
                            BotonDeConexion.Text = "Desconectar";
                        }
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
                try
                {
                    serialPort.Close();
                    BotonDeConexion.Text = "Conectar";
                }
                catch
                {
                    MessageBox.Show("Error al desconectar el puerto",
                            "Error de desconexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Grades_Servo_Scroll(object sender, ScrollEventArgs e)
        {
            Angle = Grades_Servo.Value;
            Grades_Text.Text = Convert.ToString(Grades_Servo.Value);
            SerialSender(Build('S'));
        }

        private void SelectorLeg1_Click(object sender, EventArgs e) { Leg = 0; }
        private void SelectorLeg2_Click(object sender, EventArgs e) { Leg = 1; }
        private void SelectorLeg3_Click(object sender, EventArgs e) { Leg = 2; }
        private void SelectorLeg4_Click(object sender, EventArgs e) { Leg = 3; }
        private void SelectorLeg5_Click(object sender, EventArgs e) { Leg = 4; }
        private void SelectorLeg6_Click(object sender, EventArgs e) { Leg = 5; }

        private void ButttonLimitBot_Click(object sender, EventArgs e)
        {
            SerialSender(Build('N'));
        }

        private void ButttonLimitTop_Click(object sender, EventArgs e)
        {
            SerialSender(Build('M'));
        }

        private void ButttonPosMax_Click(object sender, EventArgs e)
        {
            SerialSender(Build('O'));
        }

        private void ButttonPosDefault_Click(object sender, EventArgs e)
        {
            SerialSender(Build('P'));
        }

        private void ButttonPosMin_Click(object sender, EventArgs e)
        {
            SerialSender(Build('Q'));
        }
        
        private void SerialSender(String Data)
        {
            try
            {
                serialPort.WriteLine(Data);
            }
            catch
            {
                MessageBox.Show("Error al enviar datos", "COMUNICATION ERROR", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String Separator(int __VALUE__)
        {
            return (__VALUE__ < 10 ? "00" : __VALUE__ < 100 ? "0" : "") + __VALUE__;
        }

        private String Build(char Selector)
        {
            if (Selector == 'S' || Selector == 'M' || Selector == 'N')
            {
                String Builder = Selector.ToString() + ";" + Leg.ToString() + ";" + Servo.ToString() + ";" + Separator(Angle);
                return Builder;
            }
            if (Selector == 'O' || Selector == 'P' || Selector == 'Q')
            {
                String Builder = Selector.ToString() + ";" + Leg.ToString() + ";" + Servo.ToString();
                return Builder;
            }
            return "ERROR";
        }

        private void SelectorServo1_Click(object sender, EventArgs e)
        {
            SelectorServo1.Checked = true;
            SelectorServo2.Checked = false;
            Servo = 0;
        }

        private void SelectorServo2_Click(object sender, EventArgs e)
        {
            SelectorServo1.Checked = false;
            SelectorServo2.Checked = true;
            Servo = 1;
        }
    }
}
