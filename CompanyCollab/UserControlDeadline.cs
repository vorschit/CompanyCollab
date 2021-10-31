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
using Firebase.Database;
using Firebase.Database.Query;
using FirebaseSharp;
using FirebaseSharp.Portable;

namespace CompanyCollab
{
    public partial class UserControlDeadline : UserControl
    {
        public UserControlDeadline()
        {
            InitializeComponent();

            // connection to the firebase
            IFirebaseConfig config = new FirebaseConfig
            {
                // database secret
                AuthSecret = "3kVy3mTEDYg9FWvEjOMwoP0rD3ttCtJDOLW2rtAK",

                // database link
                BasePath = "https://uniklintern-default-rtdb.asia-southeast1.firebasedatabase.app/"

            };

            client = new FireSharp.FirebaseClient(config);
            client = new FireSharp.FirebaseClient(config);

            //locate directory from database
            FirebaseResponse res = client.Get(@"Information");

            //transform data in form of Json to Dictionary Item
            Dictionary<string, TheInformation> data = JsonConvert.DeserializeObject<Dictionary<string, TheInformation>>(res.Body.ToString());

            PopulateRTB(data);

        }

        public IFirebaseClient client;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

          

        }
        void PopulateRTB(Dictionary<string, TheInformation> record)
        {
            //make sure the gridview are empty
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            // create a column for the table
            //dataGridViewSyarikat.Columns.Add("Key", "Key");
            dataGridView1.Columns.Add("iDate", "Deadline");
            dataGridView1.Columns.Add("Agensi", "Agensi");
            dataGridView1.Columns.Add("Aktiviti", "Aktiviti");
            //dataGridViewSyarikat.Columns.Add("Skop", "Skop");
            //dataGridViewSyarikat.Columns.Add("Status", "Status");
            //dataGridViewSyarikat.Columns.Add("Tempoh", "Tempoh");
            

            if (record != null)
            {
                foreach (var item in record)
                {
                    dataGridView1.Rows.Add(
                        Convert.ToDateTime(item.Value.iDate),
                        //item.Key, item.Value.Agensi,
                        item.Value.Agensi,
                        item.Value.Aktiviti, 
                        item.Value.Skop );
                    
                    
                }

                dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                
                
                

            }
            else
            {
                MessageBox.Show("Check Internet Connection");

            }
            
           /* foreach (DataGridViewRow row in dataGridView1.Rows)
                switch ((row.Cells[0].ToString()))
                {
                    case > DateTime.Today:
                        row.DefaultCellStyle.BackColor = Color.Green;
                        break;
                    case == DateTime.Today:
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        break;
                    case < DateTime.Today:
                        row.DefaultCellStyle.BackColor = Color.Red;
                        break;
                }
           */

          
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[0].Index)
            {
                if (e.Value == null)
                    return;

                var now = DateTime.Now;
                var expirationDate = (DateTime)e.Value;
                var month = expirationDate.AddDays(-30);

                var row = dataGridView1.Rows[e.RowIndex];

                if (now > month && now < expirationDate)
                    row.DefaultCellStyle.BackColor = Color.Blue;
                else if (now > expirationDate)
                    row.DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }

}   
