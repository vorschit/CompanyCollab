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

        public IFirebaseClient client;
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

         
        }

        private void dataGridViewSyarikat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

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

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new UserControlNewEntry());
        }

        private void txtAgensi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAktiviti_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSkop_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new UserControlHome());
        }
    }
}
