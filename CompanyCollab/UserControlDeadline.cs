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
    public partial class UserControlDeadline : UserControl
    {
        public UserControlDeadline()
        {
            InitializeComponent();

        }

        public IFirebaseClient client;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

            //Deadline(data);


        }
    }
}
