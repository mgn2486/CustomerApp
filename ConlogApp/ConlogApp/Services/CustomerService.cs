using ConlogApp.DAL;
using ConlogApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConlogApp
{ 
    public interface ICustomerService
    {
        List<CustomerModel> GetAllCustomers();
    }
    public class CustomerService: ICustomerService
    {
       
        public CustomerService() 
        {
        }

        public List<CustomerModel> GetAllCustomers()
        {
            var customersList = new List<CustomerModel>();

            try
            {
                var dbContext = new ConlogDbContext();
                dbContext.Database.EnsureCreated();

                var result = dbContext.Customers.FromSqlRaw("EXECUTE dbo.[pr_GetCustomers]").ToList();

                customersList = result.Select(x => new CustomerModel()
                {
                    Id = x.Id,
                    Name = x.Name,
                    DateOfBirth = x.DateOfBirth
                }).ToList();

                return customersList;
            }
            catch (Exception ex)
            {
                /*
                 * Error log and send email to the respective persons that the customer service is failing to get the list of cutomers.
                 */
                Console.WriteLine(ex.Message);
                return customersList;
            }
        }

    }
}