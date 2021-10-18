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
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
        {
            InitializeComponent();


        }

        public IFirebaseClient client;
        private void dataGridViewSyarikat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
            // connection to the firebase
            IFirebaseConfig config = new FirebaseConfig
            {
                // database secret
                AuthSecret = "3kVy3mTEDYg9FWvEjOMwoP0rD3ttCtJDOLW2rtAK",

                // database link
                BasePath = "https://uniklintern-default-rtdb.asia-southeast1.firebasedatabase.app/"

            };

            client = new FireSharp.FirebaseClient(config);

            //locate directory from database
            FirebaseResponse res = client.Get(@"Information");

            //transform data in form of Json to Dictionary Item
            Dictionary<string, TheInformation> data = JsonConvert.DeserializeObject<Dictionary<string, TheInformation>>(res.Body.ToString());

            PopulateRTB(data);

        }

        void PopulateRTB(Dictionary<string, TheInformation> record)
        {
            //make sure the gridview are empty
            dataGridViewSyarikat.Rows.Clear();
            dataGridViewSyarikat.Columns.Clear();


            // create a column for the table
            dataGridViewSyarikat.Columns.Add("Key", "Key");
            dataGridViewSyarikat.Columns.Add("Agensi", "Agensi");
            dataGridViewSyarikat.Columns.Add("Aktiviti", "Aktiviti");
            dataGridViewSyarikat.Columns.Add("Skop", "Skop");
            dataGridViewSyarikat.Columns.Add("Status", "Status");
            dataGridViewSyarikat.Columns.Add("Tempoh", "Tempoh");
            dataGridViewSyarikat.Columns.Add("Kejayaan", "Kejayaan");

            foreach (var item in record)
            {
                dataGridViewSyarikat.Rows.Add(item.Key, item.Value.Agensi, item.Value.Aktiviti, item.Value.Skop, item.Value.Status, item.Value.Tempoh, item.Value.Kejayaan);
            }
        }
    }
}
