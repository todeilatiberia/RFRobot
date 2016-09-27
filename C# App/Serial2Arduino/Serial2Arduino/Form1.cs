using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Windows.Input;
using System.Threading; 

namespace Serial2Arduino {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e) {
            LoadAvailablePorts();
        }

        private void LoadAvailablePorts() {
            cmbPort.DataSource = SerialPort.GetPortNames();
        }


        private void btnRedresh_Click(object sender, EventArgs e) {
            LoadAvailablePorts();
        }

        //obiectul ce reprezinta portul selectat
        SerialPort port;
        char arc;
        int l=0, sus=0, jos=0, st=0, dr=0;
        //la apasarea butonului connect
        private void btnConnect_Click(object sender, EventArgs e) {


            btnConnect.Enabled = false;             //incercam sa evitam dublu apel

            if (!cmbPort.Enabled) {                 //este conectat -> exc. deconectare

                //trecem - vizual - in starea deconectat
                port.Close();
                btnConnect.Text = "Connect";
                cmbPort.Enabled = upBaudRate.Enabled = btnRedresh.Enabled = true;
              indicator.Enabled=lumini.Enabled=button2.Enabled=button1.Enabled=btnUp.Enabled = btnDown.Enabled = btnLeft.Enabled = btnRight.Enabled = false;
                txtRecv.Enabled = false;
                KeyPreview = false;

            }
            else {

                //incercam sa deschidem portul selectat
                try {

                    port = new SerialPort((string)cmbPort.SelectedItem, (int)upBaudRate.Value);
                    port.Open();

                    //atasam un eveniment sa interceptam eventuale date primite
                    port.DataReceived += new SerialDataReceivedEventHandler(port_DataReceived);

                    //trecem - vizual - in starea connect
                    btnConnect.Text = "Disconnect";
                    cmbPort.Enabled = upBaudRate.Enabled = btnRedresh.Enabled = false;
                    indicator.Enabled = lumini.Enabled = button2.Enabled = button1.Enabled = btnUp.Enabled = btnDown.Enabled = btnLeft.Enabled = btnRight.Enabled = true;
                    txtRecv.Enabled = true;
                    KeyPreview = true;
                }
                catch (Exception ex) {  //a aparut o eroare la deschidere port
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            btnConnect.Enabled = true;

        }

        void port_DataReceived(object sender, SerialDataReceivedEventArgs e) {

            //acest artificiu este necesar pt. cross thread call - o prostie nu-ti bate capul cu el
            if (this.InvokeRequired) {
                Invoke(new MethodInvoker(() => {
                    ProcArduinoCmd(port.ReadLine());
                }));
            }
            else {
                ProcArduinoCmd(port.ReadLine());
            }

        }

        private void ProcArduinoCmd(string cmd) {
            if (cmd.StartsWith("CMD:")) {                   //este o comanda
                var idx = cmd.IndexOf('=');
                if (idx == -1) {                            //comanda eronata
                    MessageBox.Show(
                        string.Format("Comanda eronata: {0}.\n Format: CMD:Cod=Valoare", cmd),
                        "Comanda eronata",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                var cod = cmd.Substring(4, idx - 4).Trim();   //codul comenzii

                float val = 0;
                if (!float.TryParse(cmd.Substring(idx + 1).Trim(), out val)) {    //valoarea trebuie sa fie un numar
                    MessageBox.Show(
                      string.Format("Valoarea {0} atasata comenzii: {1} nu este un numar.\n Format: CMD:Cod=Valoare. ", cmd.Substring(idx + 1).Trim(), cmd),
                      "Comanda eronata",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                    return;

                }

                //aici poti sa-ti definesti propria mapare
                if (cod == "A1") {
                    agA1.Value = val;                    
                }
               
                else if (cod == "D1") {
                    distanta.Text =  val+" cm";
                }

                else if (cod == "X1")
                {
                    textBox1.Text=" "+(float)val/100*943/970;
                    baterie.Value = (int)val;
                }
                else if (cod == "TE")
                {
                    textBox2.Text = " " +val + " °C";
                   
                }
                else if (cod == "PR")
                {
                    textBox3.Text = " " + val +" Pa";
                   
                }
                else if (cod == "AT")
                {
                    textBox4.Text = " " + val ;
                
                }
                else if (cod == "AL")
                {
                    textBox5.Text = " " + val +" M";
                   
                }

                else if (cod == "LE")
                {
                    if (val == 1)
                        led1.Image = Serial2Arduino.Properties.Resources.led_green;
                    else led1.Image = Serial2Arduino.Properties.Resources.led_gray;
                }
                
                else {
                    Debug.Print("Unknown code {0} for comand {1}", cod, cmd);
                }


            }
            else {                                          //este un mesaj
                LogMsg(cmd);
            }
        }

        private void LogMsg(string cmd) {
            txtRecv.SelectionStart = txtRecv.Text.Length;
            txtRecv.SelectedText = cmd + '\n';
        }

        protected override void OnClosed(EventArgs e) {
            if (port != null) port.Close();
            base.OnClosed(e);
        }



        private void btnUp_Click(object sender, EventArgs e) {
            port.Write("U");
        }

        private void btnRight_Click(object sender, EventArgs e) {
            port.Write("R");
        }

        private void btnDown_Click(object sender, EventArgs e) {
            port.Write("D");
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            port.Write("L");
        }

        private void formtest(object sender, KeyEventArgs e)
        {

            
            switch (e.KeyCode)
            {
                case Keys.Up:
                    btnUp.BackColor = Color.GreenYellow;
                    sus = 1;
                 
                    break;
                case Keys.Down:
                    btnDown.BackColor = Color.GreenYellow;
                    jos = 1;
                    break;
                case Keys.Left:
                    btnLeft.BackColor = Color.GreenYellow;
                    st = 1;
                    break;
                case Keys.Right:
                    btnRight.BackColor = Color.GreenYellow;
                    dr = 1;
                    break;
                case Keys.O:
                    port.Write("O");
                    break;
                case Keys.J:
                    port.Write("J");
                    break;

                default:
                    break;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            agA1.Value =(float) indicator.Value / 256 * 3;
        }

        private void agA1_Load(object sender, EventArgs e)
        {
           
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void led6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            port.Write("N");
            Thread.Sleep(600);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            port.Write("B");
           
            led1.Image = l == 0 ? Serial2Arduino.Properties.Resources.led_gray : Serial2Arduino.Properties.Resources.led_green;
            if (l == 0) l = 1;
            else l = 0;
            Thread.Sleep(90);
            port.Write("N");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            port.Write(String.Format("O{0}", (byte)indicator.Value));
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

      

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void distanta_TextChanged(object sender, EventArgs e)
        {

        }

       


        private void dezactivare(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    btnUp.BackColor = Color.White;
                    port.Write("J");
                    sus = 0;
                    break;
                case Keys.Down:
                    btnDown.BackColor = Color.White;
                    port.Write("J");
                    jos = 0;
                    break;
                case Keys.Left:
                    btnLeft.BackColor = Color.White;
                    st = 0;
                    break;
                case Keys.Right:
                    btnRight.BackColor = Color.White;
                    dr = 0;
                    break;
              
                default:
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            if (st==1 && sus==1 && dr==0 && jos==0) port.Write("Q");
            if (st==1 && jos==1 && dr==0 && sus==0) port.Write("Z");
            if (dr==1 && sus==1 && jos==0 && st==0) port.Write("E");
            if (dr==1 && jos==1 && st==0 && sus==0) port.Write("C");
            if (sus==1 && jos==0 && st==0 && dr==0) port.Write("U");
            if (sus==0 && jos==1 && st==0 && dr==0) port.Write("D");
        
        
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void signal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void led1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }


        

        




    }
}
