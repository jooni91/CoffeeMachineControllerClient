using Newtonsoft.Json.Linq;
using System;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace CoffeeMachineControllerClient
{
    public enum TurnOffMode
    {
        Automatic,
        Manual
    }

    public partial class MainWindow : Form
    {
        private TurnOffMode TurnOffMode { get; set; } = TurnOffMode.Automatic;

        public MainWindow()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            turnOffMode_drpdown.SelectedIndex = 0;
        }

        private void GetStatus()
        {

        }

        private void turnon_btn_Click(object sender, EventArgs e)
        {
            if (CheckIpFieldNotEmpty())
            {

            }
        }

        private void turnoff_btn_Click(object sender, EventArgs e)
        {
            if (CheckIpFieldNotEmpty())
            {

            }
        }

        private void turnOffMode_drpdown_SelectedValueChanged(object sender, EventArgs e)
        {
            switch ((sender as ComboBox).SelectedItem.ToString())
            {
                case "Manual":
                    TurnOffMode = TurnOffMode.Manual;
                    break;
                default:
                    TurnOffMode = TurnOffMode.Automatic;
                    break;
            }
        }

        private bool CheckIpFieldNotEmpty()
        {
            if (String.IsNullOrEmpty(ip_txt.Text))
            {
                MessageBox.Show("You need to enter an IP address in order to connect to your coffee machine controller.", "Ip missing");
                return false;
            }
            else
                return true;
        }

        private Uri CreateUri(string path)
        {
            return new Uri(ip_txt.Text + "/" + path);
        }
        private Uri CreateUri(string path, string parameters)
        {
            return new Uri(ip_txt.Text + "/" + path + "?" + parameters);
        }
        private string CreateQueryParameters()
        {
            string queryParameters = "";

            queryParameters += "mode=";

            if (TurnOffMode == TurnOffMode.Automatic)
                queryParameters += "automatic,";
            else
                queryParameters += "manual,";

            queryParameters += "delaybrew=" + (int)brewdelay_number.Value + ",";

            queryParameters += "turnoffin" + (int)customturnoff_number.Value;

            return queryParameters;
        }

        private JToken SendGetRequest(Uri uri)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(uri);
                webRequest.Method = HttpMethod.Get.Method;
                webRequest.Timeout = 30000;
                WebResponse webResp = webRequest.GetResponse();
                webRequest.Abort();
                return true;
            }
            catch (Exception ex)
            {
                return true;
            }
        }
        private bool SendPostRequest(Uri uri)
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(uri);
                webRequest.Method = HttpMethod.Post.Method;
                webRequest.Timeout = 30000;
                WebResponse webResp = webRequest.GetResponse();
                webRequest.Abort();
                return true;
            }
            catch (Exception ex)
            {
                return true;
            }
        }
    }
}
