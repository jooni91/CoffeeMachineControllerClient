using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachineControllerClient
{
    public enum CoffeeState
    {
        Brew,
        Standby
    }
    public enum ControllerState
    {
        Automatic,
        Manual
    }

    public partial class Form1 : Form
    {
        private CoffeeState coffeeState = CoffeeState.Standby;
        private ControllerState controllerState = ControllerState.Automatic;
        private bool processing = false;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            processing = true;
            GetStatus();
            processing = false;
        }

        private void brew_btn_Click(object sender, EventArgs e)
        {
            if (!processing)
            {
                processing = true;
                Brew();
            }
        }

        private void standby_btn_Click(object sender, EventArgs e)
        {
            if (!processing)
            {
                processing = true;
                Standby();
            }
        }

        private void automatic_btn_Click(object sender, EventArgs e)
        {
            if (!processing)
            {
                processing = true;
                Automatic();
            }
        }

        private void maual_btn_Click(object sender, EventArgs e)
        {
            if (!processing)
            {
                processing = true;
                Manual();
            }
        }

        private void Brew()
        {
            if (controllerState != ControllerState.Manual)
            {
                if (SendRequest("START"))
                {
                    GetStatus();
                }
            }
        }
        private void Standby()
        {
            if (controllerState != ControllerState.Manual)
            {
                if (SendRequest("STOP"))
                {
                    Thread.Sleep(15000);
                    GetStatus();
                }
            }
        }
        private void Automatic()
        {
            if (controllerState != ControllerState.Automatic)
            {
                if (SendRequest("AUTOMATIC"))
                {
                    Thread.Sleep(15000);
                    GetStatus();
                }
            }
        }
        private void Manual()
        {
            if (controllerState != ControllerState.Manual)
            {
                if (SendRequest("MANUAL"))
                {
                    GetStatus();
                }
            }
        }

        private bool SendRequest(string Request)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create("http://192.168.1.103:80/" + Request);
                webRequest.Timeout = 3000;
                WebResponse webResp = webRequest.GetResponse();
                webRequest.Abort();
                return true;
            }
            catch(Exception ex)
            {
                return true;
            }
        }

        private void GetStatus()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://192.168.1.103:80/STATUS");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                string data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();

                if (data.IndexOf("Standby") >= 0)
                {
                    coffeeState = CoffeeState.Standby;
                    brew_btn.Enabled = true;
                    standby_btn.Enabled = false;
                    state_lbl.ForeColor = Color.Red;
                    state_lbl.Text = "Coffee machine is OFF.";
                }
                else
                {
                    coffeeState = CoffeeState.Brew;
                    brew_btn.Enabled = false;
                    standby_btn.Enabled = true;
                    state_lbl.ForeColor = Color.Green;
                    state_lbl.Text = "Coffee machine is ON.";
                }

                if (data.IndexOf("automatic") >= 0)
                {
                    controllerState = ControllerState.Automatic;
                    controllerState_lbl.ForeColor = Color.Green;
                    controllerState_lbl.Text = "Coffee machine is in AUTOMATIC mode.";
                }
                else
                {
                    controllerState = ControllerState.Manual;
                    automatic_btn.Enabled = true;
                    maual_btn.Enabled = false;
                    controllerState_lbl.ForeColor = Color.Red;
                    controllerState_lbl.Text = "Coffee machine is in MANUAL mode.";

                    coffeeState = CoffeeState.Standby;
                    brew_btn.Enabled = false;
                    standby_btn.Enabled = false;
                    state_lbl.ForeColor = Color.Green;
                    state_lbl.Text = "Coffee machine is ON.";
                }
            }
            processing = false;
        }
    }
}
