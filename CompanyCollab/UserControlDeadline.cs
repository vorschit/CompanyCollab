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

namespace CompanyCollab
{
    public partial class UserControlDeadline : UserControl
    {
        public UserControlDeadline()
        {
            InitializeComponent();

        }

        public IFirebaseClient client;

        private async void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}   
