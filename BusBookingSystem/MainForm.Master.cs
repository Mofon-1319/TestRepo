using System;

namespace BusBookingSystem
{
    public partial class MainForm : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Home_Click(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void Login_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginMP.aspx");
        }

        protected void Register_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterMP.aspx");
        }

        protected void Book_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookBus.aspx");
        }
    }
}