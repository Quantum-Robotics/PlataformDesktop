using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProyectoTituloAlpha
{
    public partial class Code : UserControl
    {
        public Code() { InitializeComponent(); }
        
        String encodeString; String psCode;

        private void helpDelay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "El modulo de delay te permite poner pausa durante milisegundos.\n\n" +
                "   Esperar -> Tiempo en milisegundos que se detentra el robot.\n",
                "Ayuda modulo Delay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void helpSwitch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "El modulo de switch te permite cambiar el estado de un pin.\n\n" +
               "   Pin -> Pin del microcontrolador a parpadear.\n" +
               "   Estado -> Define si se apagara o prendera el pin.\n",
               "Ayuda modulo Switch", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpButton_RGB_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente", "Ayuda modulo RGB",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpButton_Walk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente", "Ayuda modulo Walk",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpButton_Rotar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente", "Ayuda modulo Rotar",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void HelpButton_Animate_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proximamente", "Ayuda modulo Animacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            encodeString = "";
            psCode = "";
            basicCode.Text = psCode.Replace("\n", "\r\n");
        }
            
        private void textDelay_Click(object sender, EventArgs e)
        {
            textDelay.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(encodeString, "Intrucciones codificadas para Debug", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            StreamWriter cachedCode;
            if (!File.Exists("data/"))
            {
                System.IO.Directory.CreateDirectory("data/");
            }
            cachedCode = File.CreateText(buttonComando1.Checked == true ? "data/C1.dat" : 
                buttonComando2.Checked == true ? "data/C2.dat" : "data/C3.dat");
            try
            {
                cachedCode.Write(encodeString);
            }
            catch
            {
                MessageBox.Show("Error al guardar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cachedCode.Close();
        }

        private void stateLed_Led_OnValueChange(object sender, EventArgs e)
        {
            statusSTATUS.Text = stateLed_Led.Value == true ? "ON" : "OFF";
        }

        private void buttonLed_Click(object sender, EventArgs e)
        {
            try
            {
                encodeString += "[L<" + Convert.ToInt32(SelectorPin.Text) + "," + 
                    (stateLed_Led.Value == true ? "0" : "1") + ">]";
                psCode += (stateLed_Led.Value == true ? "Prendido" : "Apagado") + 
                    " del pin:" + Convert.ToInt32(SelectorPin.Text) + "\n";
                basicCode.Text = psCode.Replace("\n", "\r\n");
            }
            catch (Exception)
            {
                MessageBox.Show("Error numero de pin", "Pin no valido",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddDelay_Click(object sender, EventArgs e)
        {
            try
            {
                int ValueInt = Convert.ToInt32(textDelay.Text);
                if (ValueInt < 1 || ValueInt > 5000)
                {
                    MessageBox.Show("Los delays validos es un valor entre 1 y 5000 milisegundos",
                        "Limite de Delay", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    encodeString += "[D<" + ValueInt + ">]";
                    psCode += "Delay por: " + ValueInt + " milisengundos \n";
                    basicCode.Text = psCode.Replace("\n", "\r\n");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error de dato, recuerda que solo puede contener numeros", 
                    "Delay no valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void SwitchRGB_Green_OnValueChange(object sender, EventArgs e)
        {
            TextRGB_GREEN.Text = SwitchRGB_GREEN.Value == true ? "ON" : "OFF";
        }

        private void SwitchRGB_RED_OnValueChange(object sender, EventArgs e)
        {
            TextRGB_RED.Text = SwitchRGB_RED.Value == true ? "ON" : "OFF";
        }

        private void SwitchRGB_BLUE_OnValueChange(object sender, EventArgs e)
        {
            TextRGB_BLUE.Text = SwitchRGB_BLUE.Value == true ? "ON" : "OFF";
        }

        private void ButtonAddRGB_Click(object sender, EventArgs e)
        {
            int SelectorRED   = SwitchRGB_RED.Value == true ? 1 : 0;
            int SelectorGREEN = SwitchRGB_GREEN.Value == true ? 1 : 0;
            int SelectorBLUE  = SwitchRGB_BLUE.Value == true ? 1 : 0;
            encodeString += "[R<" + SelectorRED + "," + SelectorGREEN + "," + SelectorBLUE + ">]";
            psCode += "Estado RGB: \n" +
                "  Rojo:  " + (SwitchRGB_RED.Value == true ? "ON " : "OFF") +
                "  Verde: " + (SwitchRGB_GREEN.Value == true ? "ON " : "OFF") +
                "  Azul:  " + (SwitchRGB_BLUE.Value == true ? "ON " : "OFF") + "\n";
            basicCode.Text = psCode.Replace("\n", "\r\n");
        }
        
        private int Selector_Leg_Check(int __SELECTOR__)
        {
            int LegSelector = 0;
            if (__SELECTOR__ == 0 ? Walk_Leg1.Checked : (__SELECTOR__ == 1 ? 
                Rotar_Leg1.Checked : Animation_Leg1.Checked))
                LegSelector = 0;
            if (__SELECTOR__ == 0 ? Walk_Leg2.Checked : (__SELECTOR__ == 1 ? 
                Rotar_Leg2.Checked : Animation_Leg2.Checked))
                LegSelector = 1;    
            if (__SELECTOR__ == 0 ? Walk_Leg3.Checked : (__SELECTOR__ == 1 ? 
                Rotar_Leg3.Checked : Animation_Leg3.Checked))
                LegSelector = 2;
            if (__SELECTOR__ == 0 ? Walk_Leg4.Checked : (__SELECTOR__ == 1 ? 
                Rotar_Leg4.Checked : Animation_Leg4.Checked))
                LegSelector = 3;
            if (__SELECTOR__ == 0 ? Walk_Leg5.Checked : (__SELECTOR__ == 1 ? 
                Rotar_Leg5.Checked : Animation_Leg5.Checked))
                LegSelector = 4;
            if (__SELECTOR__ == 0 ? Walk_Leg6.Checked : (__SELECTOR__ == 1 ? 
                Rotar_Leg6.Checked : Animation_Leg6.Checked))
                LegSelector = 5;
            return LegSelector;
        }

        private void ButtonAddWalk_Click(object sender, EventArgs e)
        {
            int LegSelector = Selector_Leg_Check(0);
            encodeString += "[W<"+ LegSelector +">]";
            psCode += "Caminata Leg_" + LegSelector.ToString() + " \n";
            basicCode.Text = psCode.Replace("\n", "\r\n");
        }

        private void ButtonAddRotar_Click(object sender, EventArgs e)
        {
            int LegSelector = Selector_Leg_Check(1);
            encodeString += "[O<" + LegSelector + ">]";
            psCode += "Rotar Leg_" + LegSelector.ToString() + " \n";
            basicCode.Text = psCode.Replace("\n", "\r\n");
        }

        private void SelectorServo_2_Click(object sender, EventArgs e)
        {
            SelectorServo_1.Checked = false;
            SelectorServo_2.Checked = true;
        }

        private void SelectorServo_1_Click(object sender, EventArgs e)
        {
            SelectorServo_1.Checked = true;
            SelectorServo_2.Checked = false;
        }

        private void TrackBar_Value_Servo_Scroll(object sender, ScrollEventArgs e)
        {
            Text_ValueTrackBar.Text = TrackBar_Value_Servo.Value.ToString();
        }

        private void ButtonAddAnimation_Click(object sender, EventArgs e)
        {
            int LegSelector = Selector_Leg_Check(2);
            int ServoSelector = (SelectorServo_1.Checked == true ? 1 : 0);
            int AnguloSelector = TrackBar_Value_Servo.Value;
            encodeString += "[A<" + LegSelector + "," + ServoSelector + "," + AnguloSelector + ">]";
            psCode += "Mover: \n" +
                "  Leg: " + LegSelector + " Servo: " + ServoSelector + "  Angulo" + AnguloSelector + "\n";
            basicCode.Text = psCode.Replace("\n", "\r\n");
        }
    }
}
