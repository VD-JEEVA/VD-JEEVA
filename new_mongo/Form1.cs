using System;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using System.Configuration;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Policy;

namespace new_mongo
{
    public partial class Form1 : Form
    {
        IMongoCollection<MeetingRoomsModel> MeetingRoomsBooking;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void vudedata_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var employee = new MeetingRoomsModel
            {
              
                EmployeeID = txtid.Text,
                EmployeeName = txtemployee.Text,
                MeetingDate = datatime.Text,
                MeetingEndTime = endtime.Text,
                MeetingRoom = txtroom.Text,
                MeetingStartTime=starttime.Text,
                MeetingID=txtmeet.Text
            };
            long duplicate_count = MeetingRoomsBooking.Find(x => x.EmployeeID == employee.EmployeeID && x.EmployeeName == employee.EmployeeName && x.MeetingDate == employee.MeetingDate && x.MeetingEndTime == employee.MeetingEndTime).Count();
            if (duplicate_count < 1) { 
            MeetingRoomsBooking.InsertOne(employee);
            LoadMeetingRoomsModelData();
            }
            else
            {
                MessageBox.Show("Duplicate Entry");
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
                var databaseName = MongoUrl.Create(connectionString).DatabaseName;
                var mongoClient = new MongoClient(connectionString);
                var database = mongoClient.GetDatabase(databaseName);
                MeetingRoomsBooking = database.GetCollection<MeetingRoomsModel>("MeetingRoomsBooking");



                LoadMeetingRoomsModelData();



                MessageBox.Show("DataBase Connected");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void LoadMeetingRoomsModelData()
        {
            var filterDefinition = Builders<MeetingRoomsModel>.Filter.Empty;
            var details= MeetingRoomsBooking.Find(filterDefinition).ToList();
            dataGridView1.DataSource = details;
            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;//auto aligning grid

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<MeetingRoomsModel>.Filter.Eq(a => a.MeetingID, txtmeet.Text);
            var updateDefinition = Builders<MeetingRoomsModel>.Update
                .Set(a => a.EmployeeName, txtemployee.Text)
                .Set(a => a.EmployeeID, txtid.Text)
                .Set(a => a.MeetingRoom, txtroom.Text)
                .Set(a => a.MeetingDate, datatime.Text)
                .Set(a => a.MeetingStartTime, starttime.Text)
                .Set(a => a.MeetingEndTime, endtime.Text);
            MeetingRoomsBooking.UpdateOne(filterDefinition, updateDefinition);
            LoadMeetingRoomsModelData();
                }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtmeet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var filterdefinition = Builders<MeetingRoomsModel>.Filter.Eq(a => a.MeetingID, txtmeet.Text);
            MeetingRoomsBooking.DeleteOne(filterdefinition);
            LoadMeetingRoomsModelData();

        }
       

private void clear()

        {

           txtemployee .Text = "";

            txtid.Text = "";

            txtroom.Text = "";

            starttime.Text = "";

            endtime.Text = "";

            datatime.Text = "";

            txtmeet.Text = "";



            btn_save.Text = "Save";



            btn_update.Text = "Update";



            btn_delete.Enabled = false;



        }


    }
}
