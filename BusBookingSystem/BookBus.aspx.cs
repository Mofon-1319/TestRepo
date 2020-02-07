using System;
using BusApp;
using System.Data;

namespace BusBookingSystem
{
    public partial class BookBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerRepository user = new CustomerRepository();
            DataTable data = user.BookBus();
            Grid.DataSource = data;
            Grid.DataBind();
        }
    }
}