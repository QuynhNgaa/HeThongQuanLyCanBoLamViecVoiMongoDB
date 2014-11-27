using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Login
{
    public partial class access : Form
    {
        public access()
        {
            InitializeComponent();
            fillDataToGridView();
        }
        public void fillDataToGridView()
        {
            dataGridView1.DataSource = get_data_access();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public DataTable get_data_access()
        {

            List<Log> lst = new List<Log>();
            MongoServerSettings settings = new MongoServerSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            // Tạo đối tượng
            MongoServer server = new MongoServer(settings);
            var database = server.GetDatabase("MyDB");
            var col = database.GetCollection<Log>("Access");
            List<Log> ll = col.FindAll().ToList<Log>();
            foreach (var i in ll)
            {
                i.time = i.time.ToLocalTime();   
            }
            return ConvertToDataTable(ll);
        }

        //2. convert list ra datatable
        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

    }
}
