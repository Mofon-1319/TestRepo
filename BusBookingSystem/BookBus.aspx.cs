using System;
using BusBookingSystem.DAL;
using System.Data;
using System.Web.UI.WebControls;
using BusBookingSystem.Entity;

namespace BusBookingSystem
{
    public partial class BookBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string script = "window.onload = function(){ alert('Logged in successfully.')};";
                ClientScript.RegisterStartupScript(this.GetType(), "SuccessMessage", script, true);
                Display();
            }
        }

        protected void Display()
        {
            CustomerRepository user = new CustomerRepository();
            DataTable data = user.BookBus();
            Grid.DataSource = data;
            Grid.DataBind();
        }
        protected void Grid_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            CustomerRepository user = new CustomerRepository();
            int id = Convert.ToInt32(Grid.DataKeys[e.RowIndex].Value.ToString());
            user.DeleteDetail(id);
            Display();
        }

        protected void Grid_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Grid.EditIndex = e.NewEditIndex;
        }

        protected void Grid_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            CustomerRepository user = new CustomerRepository();
            int id = Convert.ToInt32(Grid.DataKeys[e.RowIndex].Value.ToString());
            TextBox bustype = Grid.Rows[e.RowIndex].FindControl("txtType") as TextBox;
            TextBox seat = Grid.Rows[e.RowIndex].FindControl("txtSeats") as TextBox;
            TextBox source = Grid.Rows[e.RowIndex].FindControl("txtSource") as TextBox;
            TextBox destination = Grid.Rows[e.RowIndex].FindControl("txtDestination") as TextBox;
            TextBox aTime = Grid.Rows[e.RowIndex].FindControl("txtATime") as TextBox;
            TextBox dTime = Grid.Rows[e.RowIndex].FindControl("txtDTime") as TextBox;
            TextBox fare = Grid.Rows[e.RowIndex].FindControl("txtFare") as TextBox;
            Bus bus = new Bus(bustype.Text, Convert.ToInt32(seat.Text), source.Text, destination.Text, aTime.Text, dTime.Text, Convert.ToInt32(fare.Text));
            user.UpdateDetail(id, bus);
            Grid.EditIndex = -1;
            Display();
        }

        protected void Grid_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Grid.EditIndex = -1;
            Display();
        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            CustomerRepository user = new CustomerRepository();
            TextBox bustype = Grid.FooterRow.FindControl("BtnInsert1") as TextBox;
            TextBox seat = Grid.FooterRow.FindControl("BtnInsert2") as TextBox;
            TextBox source = Grid.FooterRow.FindControl("BtnInsert3") as TextBox;
            TextBox destination = Grid.FooterRow.FindControl("BtnInsert4") as TextBox;
            TextBox aTime = Grid.FooterRow.FindControl("BtnInsert5") as TextBox;
            TextBox dTime = Grid.FooterRow.FindControl("BtnInsert6") as TextBox;
            TextBox fare = Grid.FooterRow.FindControl("BtnInsert7") as TextBox;
            Bus bus = new Bus(bustype.Text, Convert.ToInt32(seat.Text), source.Text, destination.Text, aTime.Text, dTime.Text, Convert.ToInt32(fare.Text));
            user.InsertDetail(bus);
            Grid.EditIndex = -1;
            Display();
        }
    }
}