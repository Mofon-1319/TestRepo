using System;
using BusApp;

namespace BusBookingSystem
{
    public partial class BookBus : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CustomerRepository user = new CustomerRepository();
            user.BookBus();
        }
    }
}