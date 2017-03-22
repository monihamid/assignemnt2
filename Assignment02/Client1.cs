/*
* ProjectName:  Cryptography Lab
* File name  :Client1.cs
* Programer:    Dong Qian(6573448) and Monira Sultana(7308182)
* Date:         March 23, 2017
* Description:  This Application is a client which can send messages to another client throuth the sever
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.IO.Pipes;
using System.Threading;
using System.Text.RegularExpressions;

//

using System.Windows;


using System.Windows.Input;



//

//https://www.youtube.com/watch?v=ObcGBT4ZWEU

//https://www.codeproject.com/Articles/12893/TCP-IP-Chat-Application-Using-C

namespace Assignment02
{
    public partial class IMClient1 : Form
    {
        Socket sck;
        EndPoint epLocal;
        EndPoint epRemote;
        List<string> items = new List<string>();
        //create a BlowFish object
        BlowFish blowFish = null;
        public IMClient1()
        {
            InitializeComponent();
            sck = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

           sck.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);

            //sck = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //string hIPAdd=textBoxHostIP.Text;
            //string desIPAdd = textBoxDesIP.Text;

            blowFish = new BlowFish("04B915BA43FEB5B6");
            //sck.Connect(IPAddress.Parse(textBoxDesIP.Text), Convert.ToInt32(textBoxDesPort.Text));

        }

        private void MessageCallBack(IAsyncResult aResult)
        {

            string hName=textBoxHName.Text;
            try
            {
                //get message
                int size = sck.EndReceiveFrom(aResult, ref epRemote);
                if (size >0)
                {
                    byte[] receivedData = new byte[1464];
                    receivedData = (byte[])aResult.AsyncState;
                    ASCIIEncoding eEncoding = new ASCIIEncoding();
                    string receivedMessage = eEncoding.GetString(receivedData);
                    //write message                   
                    
                    items.Add("From "+hName + ":  "+receivedMessage);
                    listBoxClient1.DataSource = null;
                    listBoxClient1.DataSource = items;
                    string newmsg = null;
                    //decrypt it if it is encrypted
                    Match srcMatch = Regex.Match(receivedMessage, @"Cry:");
                    if(srcMatch.Value== "Cry:")
                    {
                        int indexB = receivedMessage.IndexOf(":");
                        int indexE = receivedMessage.Length;
                        newmsg = receivedMessage.Substring(indexB+1, indexE);
                        receivedMessage = blowFish.Decrypt_CBC(newmsg);
                        //write message
                        items.Add("From " + hName + ":  " + receivedMessage);
                        listBoxClient1.DataSource = null;
                        listBoxClient1.DataSource = items;

                    }
                    //plainText = blowFish.Decrypt_CBC(cipherText);
                    //listBoxClient1.Items.Add((TextBox)Sender. receivedMessage);

                }

                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.ToString());

            }
        }

        private void buttConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
                //binding socket
                epLocal = new IPEndPoint(IPAddress.Parse(textBoxHostIP.Text), Convert.ToInt32(textBoxHPort.Text));
                sck.Bind(epLocal);
                //connection with remote host
                epRemote = new IPEndPoint(IPAddress.Parse(textBoxDesIP.Text), Convert.ToInt32(textBoxDesPort.Text));
                sck.Connect(epRemote);
                // listening
                byte[] buffer = new byte[1500];
                sck.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None, ref epRemote, new AsyncCallback(MessageCallBack), buffer);
                textBoxEMessage.Text = "Your friend is now connected";
                //buttConnect.Text = "Connected";
                buttConnect.Enabled = false;
                buttSend.Enabled = true;
                TextMessBoxC1.Focus();
            }
            catch (Exception exp)

            {
                MessageBox.Show(exp.ToString());
               

            }
        }

        private void buttSend_Click(object sender, EventArgs e)
        {
            try
            {

                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(TextMessBoxC1.Text);
                //send the message to other client
                sck.Send(msg);
                items.Add(" You: "+TextMessBoxC1.Text);
                listBoxClient1.DataSource = null;

                listBoxClient1.DataSource = items;

                //listBoxClient1.Items.Add("You: " + TextMessBoxC1.Text);
                TextMessBoxC1.Clear();
            }

            catch(Exception exp)

            {
                textBoxEMessage.Text = "You need to connect first";
                MessageBox.Show(exp.ToString());
                textBoxEMessage.Clear();
            }
        }

        private void UpdateChatArea(Object obj)
        {
            try
            {
                //string client2 = To.Text;
                string msg = (string)obj;
                // Add the message to the listbox and auto scroll tp last one
                //listBoxClient1.Items.Add("\t\t[ " + DateTime.Now.ToString("HH:mm") + " ]  " + msg);
                //listBoxClient1.ScrollIntoView(listBoxClient1.Items[History.Items.Count - 1]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttCrypSend_Click(object sender, EventArgs e)
        {

            // EXAMPLE
            //string plainText = "The quick brown fox jumped over the lazy dog.";

            //string cipherText = blowFish.Encrypt_CBC(plainText);
            //MessageBox.Show(cipherText);

            //plainText = blowFish.Decrypt_CBC(cipherText);
            //MessageBox.Show(plainText);

            //System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
            ////byte[] msg = new byte[1500];
            //msg = enc.GetBytes(TextMessBoxC1.Text);
            ////send the message to other client
            //sck.Send(msg);
            //items.Add(" You: " + TextMessBoxC1.Text);
            //listBoxClient1.DataSource = null;

            //listBoxClient1.DataSource = items;
            try
            {

                System.Text.ASCIIEncoding encode = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                //msg = encode.GetBytes(TextMessBoxC1.Text);
                string hmsg = TextMessBoxC1.Text;
                string encrypted = blowFish.Encrypt_CBC(hmsg);
                msg = encode.GetBytes(encrypted);
                //send the message to other client

                sck.Send(msg);
                items.Add(" You: " + TextMessBoxC1.Text);
                listBoxClient1.DataSource = null;

                listBoxClient1.DataSource = items;

                //listBoxClient1.Items.Add("You: " + TextMessBoxC1.Text);
                TextMessBoxC1.Clear();
            }

            catch (Exception exp)

            {
                textBoxEMessage.Text = "You need to connect first";
                MessageBox.Show(exp.ToString());
                textBoxEMessage.Clear();
            }
        }

        private void buttDisconnect_Click(object sender, EventArgs e)
        {

        }
    }
}
