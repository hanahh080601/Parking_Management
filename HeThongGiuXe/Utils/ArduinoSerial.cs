using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeThongGiuXe.Utils
{
    public class ArduinoSerial
    {
        private SerialPort serialPort;
        public ArduinoSerial(string name, int baud, LineReceivedEvent receivedEvent)
        {
            this.receivedEvent += receivedEvent;
            this.serialPort = new SerialPort(name, baud);
            this.serialPort.Open();
            this.serialPort.DataReceived += serialPort1_DataReceived;
        }
        public void SendMessage(string msg)
        {
            this.serialPort.WriteLine(msg);
        }
        public void Close()
        {
            this.serialPort.Close();
        }
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string line = ((SerialPort)(sender)).ReadLine();
            receivedEvent(line.Trim());
        }
        static void GetAllPortName()
        {

        }
        public delegate void LineReceivedEvent(string line);
        private LineReceivedEvent receivedEvent;
    }
}
/*
 using System;
using System.IO.Ports;
using System.Threading;
namespace testArduino
{
    class Program
    {
        public SerialPort _serialPort { get; set; }
        public void main()
        {
            _serialPort = new SerialPort();
            _serialPort.PortName = "COM7";//Set your board COM
            _serialPort.BaudRate = 9600;
            _serialPort.Open();
            _serialPort.DataReceived += serialPort1_DataReceived;
            while (_serialPort.IsOpen)
            {

            }
        }
        public static void Main()
        {
            Program run = new Program();
            run.main();
        }
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = ((SerialPort)(sender)).ReadLine();
            Console.WriteLine(line);
        }

        private delegate void LineReceivedEvent(string line);
    }
}
 */