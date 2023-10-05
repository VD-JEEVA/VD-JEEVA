using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Web.UI.WebControls;

namespace Meeting_Room_Booking_System
{
    public partial class Meeting_Room_Booking_System : System.Web.UI.Page
    {
        string connectionString = "server=127.0.0.1;database=meeting_room_booking_systemdb;uid=root;pwd=VueData@2023";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Clear();
                GridFill();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection sqlcon = new MySqlConnection(connectionString))
                {
                    sqlcon.Open();
                    MySqlCommand sqlcmd = new MySqlCommand("employee_detialsAddOrEdit", sqlcon);
                    sqlcmd.CommandType = CommandType.StoredProcedure;
                    sqlcmd.Parameters.AddWithValue("_Employee_id", Convert.ToInt32(hfEmployee_id.Value == "" ? "0" : hfEmployee_id.Value));
                    sqlcmd.Parameters.AddWithValue("_Employee_name", txtemployee.Text.Trim());
                    sqlcmd.Parameters.AddWithValue("_meeting_rooms", txtmeetingrooms.SelectedValue); // Use SelectedValue for DropDownList
                    sqlcmd.Parameters.AddWithValue("_Booking_meetDate_meetTime", txtBooking_meetDate_meetTime.Text.Trim());
                    sqlcmd.ExecuteNonQuery();
                    GridFill();
                    Clear();
                    lblSuccessMessage.Text = "Submitted Successfully";
                }
            }
            catch (Exception ex)
            {
                lblErrorMessage.Text = ex.Message;
            }
        }

        void Clear()
        {
            hfEmployee_id.Value = "";
            txtemployee.Text = "";
            txtBooking_meetDate_meetTime.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            lblErrorMessage.Text = lblSuccessMessage.Text = "";
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        void GridFill()
        {
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("employee_detialsViewALL", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);
                gvEmployee.DataSource = dtb1;
                gvEmployee.DataBind();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (MySqlConnection sqlcon = new MySqlConnection(connectionString))
            {
                sqlcon.Open();
                MySqlCommand sqlcmd = new MySqlCommand("employee_detialsDeleteById", sqlcon);
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.Parameters.AddWithValue("_Employee_id", Convert.ToInt32(hfEmployee_id.Value == "" ? "0" : hfEmployee_id.Value));
                sqlcmd.ExecuteNonQuery();
                GridFill();
                Clear();
                lblSuccessMessage.Text = "Deleted Successfully";
            }
        }

        protected void lnkSelect_OnClick(object sender, EventArgs e)
        {
            int Employee_id = Convert.ToInt32((sender as LinkButton).CommandArgument);
            using (MySqlConnection sqlCon = new MySqlConnection(connectionString))
            {
                sqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("employee_detialsViewById", sqlCon);
                sqlDa.SelectCommand.Parameters.AddWithValue("_Employee_id", Employee_id);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataTable dtb1 = new DataTable();
                sqlDa.Fill(dtb1);

                txtemployee.Text = dtb1.Rows[0][1].ToString();
                txtmeetingrooms.SelectedValue = dtb1.Rows[0][2].ToString(); // Set the DropDownList selected value
                txtBooking_meetDate_meetTime.Text = dtb1.Rows[0][3].ToString();

                hfEmployee_id.Value = dtb1.Rows[0][0].ToString();

                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
    }
}
