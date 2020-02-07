using System;
using BusApp;

namespace BusBookingSystem
{
    public partial class RegisterMP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer(name.Text, sex.Text, userId.Text, password.Text, phone.Text, Convert.ToDateTime(dob.Text));
            CustomerRepository customerRepository = new CustomerRepository();
            int count = customerRepository.SignUp(customer);
            if (count > 1)
                Response.Write("Registration success");
            else
                Response.Write("in valid");
        }
    }
}