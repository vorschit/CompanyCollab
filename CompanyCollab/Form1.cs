using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace CompanyCollab
{
    public partial class Form1 : Form
    {
        // connection to the firebase
        IFirebaseConfig config = new FirebaseConfig
        {
            // database secret
            AuthSecret = "3kVy3mTEDYg9FWvEjOMwoP0rD3ttCtJDOLW2rtAK",

            // database link
            BasePath = "https://uniklintern-default-rtdb.asia-southeast1.firebasedatabase.app/"

        };

        IFirebaseClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            
            if (client != null)
            {
                lblConnSuccessFail.ForeColor = Color.Green; 
                lblConnSuccessFail.Text = "Connected";
            }

            else
            {
                lblConnSuccessFail.ForeColor = Color.Red;
                lblConnSuccessFail.Text = "Database is not connected";
            }
            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var datalayer = new Data
            {
                Agensi = txtAgensi.Text,
                Aktiviti = txtAktiviti.Text,
                Skop = txtSkop.Text
            };

            string noSpace =txtAgensi.Text;
            this.txtAgensi.Text = noSpace.Trim().Split(' ')[0];
            SetResponse resp = await client.SetTaskAsync("Information/" + txtAgensi.Text, datalayer);
            Data result = resp.ResultAs<Data>();
            MessageBox.Show("Data" + result.Agensi + " Inserted");
        }
    }
}
