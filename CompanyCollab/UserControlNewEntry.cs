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
    public partial class UserControlNewEntry : UserControl
    {
        public UserControlNewEntry()
        {
            InitializeComponent();

            panel1.AutoScroll = false;
            panel1.HorizontalScroll.Enabled = false;
            panel1.HorizontalScroll.Visible = false;
            panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }


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

        private async void button1_Click(object sender, EventArgs e)
        {
            
            client = new FireSharp.FirebaseClient(config);

            //locate directory from database
            FirebaseResponse res = client.Get(@"Information");

            //transform data in form of Json to Dictionary Item
            Dictionary<string, TheInformation> data = JsonConvert.DeserializeObject<Dictionary<string, TheInformation>>(res.Body.ToString());

            DateTime iDate;
            iDate = dateTimePicker1.Value.Date;

            var datalayer = new Data
            {
                // declaration var from textbox
                Agensi = txtAgensi.Text,
                Aktiviti = txtAktiviti.Text,
                Skop = txtSkop.Text,
                Tempoh = txtTempoh.Text,
                Kejayaan = txtKejayaan.Text,
                Status = txtStatus.Text,
                iDate = Convert.ToString(iDate)

            };

            // create no-space for parent node
            string noSpace = txtAgensi.Text;
            string nospaceActivity = txtAktiviti.Text;

            //trimming other than first word
            this.txtAgensi.Text = noSpace.Trim().Split(' ')[0];
            this.txtAktiviti.Text = nospaceActivity.Trim().Split(' ')[0];

            //writing data into database
            SetResponse resp = await client.SetTaskAsync("Information/" + txtAgensi.Text + txtAktiviti.Text , datalayer);
            Data result = resp.ResultAs<Data>();

            //notification the data has been upload upon success
            MessageBox.Show("Data" + result.Agensi + " Inserted");
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textKejayaan_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlNewEntry_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            //DateTimePicker1.Value = DateTime.Today;
            DateTime iDate;
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            iDate = dateTimePicker1.Value.Date;
            MessageBox.Show("Selected date is " + iDate);

        }
    }
}
