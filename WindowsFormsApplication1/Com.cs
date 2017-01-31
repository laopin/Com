﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

//using System.Threading;

namespace Com
{
    public partial class Com : MetroFramework.Forms.MetroForm
    {
        //private Thread updateReceiveInformation;
        string str;

        public Com()
        {
            InitializeComponent();
        }

        
        private void Com_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cboPort.Items.AddRange(ports);
            cboPort.SelectedIndex = 0;
            btnClose.Enabled = false;
            
            //updateReceiveInformation = new Thread(new ThreadStart(updateReceiveBuffer));
            //serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = false;
            btnClose.Enabled = true;

            

            try
            {
                serialPort1.PortName = cboPort.Text;
                serialPort1.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
               if(serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(txtMessage.Text + Environment.NewLine);
                    txtMessage.Clear();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            try
            {
                
                serialPort1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    txtReceive.Text = serialPort1.ReadExisting();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Com_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
                serialPort1.Close();
        }

        //private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        //{
        //    // DateTime dt = DateTime.Now;
        //    //string dtn = dt.ToShortTimeString();

        //    //txtReceive.AppendText("["+dtn+"] " + "Received: " +serialPort1.ReadExisting() + "\n");
        //    //str = serialPort1.

        //    // txtReceive.Text = serialPort1.ReadExisting();
        //    str = serialPort1.ReadExisting();
        //}

        //public  void updateReceiveBuffer()
        //{

        //    txtReceive.Text = "Hello world ";
        //    while (true)
        //    {
        //        //txtReceive.Text = "Hello world ";//serialPort1.ReadExisting();
        //        txtReceive.AppendText("hello");
                
        //        //txtReceive.Text = str;//serialPort1.ReadExisting();
        //       // str = serialPort1.ReadExisting();
        //    }


        //}
    }
}
