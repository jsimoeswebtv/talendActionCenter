using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TalendActionCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox2.Text;
            string pass = textBox3.Text;
            string taskid = textBox4.Text;
            string json = "{\"actionName\":\"runTask\",\"authPass\":\"" + pass + "\",\"authUser\":\"" + user + "\",\"mode\":\"asynchronous\",\"taskId\":\"" + taskid + "\"}";

            MessageBox.Show(json);
            MessageBox.Show(convertB64(json));


        }

        private string convertB64(string inputStr)
        {
            byte[] plainTextBytes = System.Text.Encoding.UTF8.GetBytes(inputStr);

            return Convert.ToBase64String(plainTextBytes);

        }

        private void connectTalend(string json)
        {
            WebClient wc = new WebClient();
            string url = textBox1.Text + convertB64(json);


            string result = wc.DownloadString(url);

            MessageBox.Show(result);
        }
    }
}
