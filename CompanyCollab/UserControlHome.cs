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
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;


namespace CompanyCollab
{
    public partial class UserControlHome : UserControl
    {
        public UserControlHome()
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

            //locate directory from database
            FirebaseResponse res = client.Get(@"Information");

            //transform data in form of Json to Dictionary Item
            Dictionary<string, TheInformation> data = JsonConvert.DeserializeObject<Dictionary<string, TheInformation>>(res.Body.ToString());

            PopulateRTB(data);
        }

        public IFirebaseClient client;
        private void dataGridViewSyarikat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        
        private void btnLoad_Click(object sender, EventArgs e)
        {
        

        }

        void PopulateRTB(Dictionary<string, TheInformation> record)
        {
            //make sure the gridview are empty
            dataGridViewSyarikat.Rows.Clear();
            dataGridViewSyarikat.Columns.Clear();


            // create a column for the table
            //dataGridViewSyarikat.Columns.Add("Key", "Key");
            dataGridViewSyarikat.Columns.Add("iDate", "Deadline");
            dataGridViewSyarikat.Columns.Add("Agensi", "Agensi");
            dataGridViewSyarikat.Columns.Add("Aktiviti", "Aktiviti");
            dataGridViewSyarikat.Columns.Add("Skop", "Skop");
            //dataGridViewSyarikat.Columns.Add("Status", "Status");
            //dataGridViewSyarikat.Columns.Add("Tempoh", "Tempoh");
            dataGridViewSyarikat.Columns.Add("Kejayaan", "Kejayaan");

            if (record != null)
            {
                foreach (var item in record)
                {
                    dataGridViewSyarikat.Rows.Add(
                        Convert.ToDateTime(item.Value.iDate),
                        item.Key,
                        item.Value.Agensi,
                        item.Value.Aktiviti,
                        item.Value.Skop,
                        //item.Value.Status,
                        //item.Value.Tempoh,
                        item.Value.Kejayaan);
                }
                dataGridViewSyarikat.Sort(dataGridViewSyarikat.Columns[0], ListSortDirection.Ascending);
            }
            else
            {
                MessageBox.Show("Check Internet Connection");
                
            }
        }

        private void dataGridViewSyarikat_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewSyarikat.Columns[0].Index)
            {
                if (e.Value == null)
                    return;

                var now = DateTime.Now;
                var expirationDate = (DateTime)e.Value;
                var month = expirationDate.AddDays(-30);

                var row = dataGridViewSyarikat.Rows[e.RowIndex];

                // if (now > month && now < expirationDate)
                if (now < expirationDate)
                    row.DefaultCellStyle.BackColor = Color.WhiteSmoke;
                else if (now < month)
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                else if (now > expirationDate)
                    row.DefaultCellStyle.BackColor = System.Drawing.ColorTranslator.FromHtml("#FF0000");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridViewSyarikat.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridViewSyarikat.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridViewSyarikat.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridViewSyarikat.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridViewSyarikat.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
}
