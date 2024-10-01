using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica___07
{
    public partial class Form1 : Form
    {
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.Open();

            this.FormClosing += Form1_FormClosing;
            this.button2.Click += button2_Click;
            this.button1.Click += button1_Click;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("a");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ArduinoPort.IsOpen) ArduinoPort.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArduinoPort.Write("b");
        }
    }
}
