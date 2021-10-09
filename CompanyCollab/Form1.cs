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
using Newtonsoft.Json;

namespace CompanyCollab
{
    public partial class Form1 : Form
    {
        // (declaration) drag header of application
        bool drag = false;
        Point start_point = new Point(0, 0);

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
                // change the label to green color + "connected"
                lblConnSuccessFail.ForeColor = Color.Green; 
                lblConnSuccessFail.Text = "Connected";
            }

            else
            {
                // change the label to red color + "not connected"
                lblConnSuccessFail.ForeColor = Color.Red;
                lblConnSuccessFail.Text = "Database is not connected";
            }

            //locate directory from database
            FirebaseResponse res = client.Get(@"Information");

            //transform data in form of Json to Dictionary Item
            Dictionary<string, TheInformation> data = JsonConvert.DeserializeObject<Dictionary<string, TheInformation>>(res.Body.ToString());

            PopulateRTB(data);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var datalayer = new Data
            {
                // declaration var from textbox
                Agensi = txtAgensi.Text,
                Aktiviti = txtAktiviti.Text,
                Skop = txtSkop.Text
            };

            // create no-space for parent node
            string noSpace =txtAgensi.Text;

            //trimming other than first word
            this.txtAgensi.Text = noSpace.Trim().Split(' ')[0];

            //writing data into database
            SetResponse resp = await client.SetTaskAsync("Information/" + txtAgensi.Text, datalayer);
            Data result = resp.ResultAs<Data>();

            //notification the data has been upload upon success
            MessageBox.Show("Data" + result.Agensi + " Inserted");
        }


        private void dataGridViewSyarikat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
        
        void PopulateRTB (Dictionary<string, TheInformation> record)
        {
            //make sure the gridview are empty
            dataGridViewSyarikat.Rows.Clear();
            dataGridViewSyarikat.Columns.Clear();

            dataGridViewSyarikat.Columns.Add("Key", "Key");
            dataGridViewSyarikat.Columns.Add("Agensi", "Agensi");
            dataGridViewSyarikat.Columns.Add("Aktiviti", "Aktiviti");
            dataGridViewSyarikat.Columns.Add("Skop", "Skop");

            foreach (var item in record)
            {
                dataGridViewSyarikat.Rows.Add(item.Key, item.Value.Agensi, item.Value.Aktiviti, item.Value.Skop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_header_MouseDown(object sender, MouseEventArgs e)
        {
            //enable drag application
            drag = true;
            start_point = new Point(e.X, e.Y);

        }

        private void panel_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                Point p = PointToScreen(e.Location);
                this.Location = new Point(p.X - start_point.X, p.Y - start_point.Y);
            }
        }

        private void panel_header_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
