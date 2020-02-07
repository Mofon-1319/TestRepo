using System;
using BusApp;

namespace BusBookingSystem
{
    public partial class LoginMP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(userId.Text, password.Text);
            CustomerRepository customerRepository = new CustomerRepository();
            int count = customerRepository.LogIn(customer);
            if (count == 1)
                Response.Write("Logged in successfully");
            else
                Response.Write("in valid");
        }
    }
}