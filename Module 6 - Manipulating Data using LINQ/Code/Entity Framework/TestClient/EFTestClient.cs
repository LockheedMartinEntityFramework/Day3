using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using EFWorkflow = EDMX_Model_First;
//using EFWorkflow = Code_Model_First;
using EFWorkflow = Code_Database_First;
//using EFWorkflow = EDMX_Database_First;

namespace TestClient
{
    public partial class EFTestClient : Form
    {
        //private List<Customer> customers = EFWorkflow.ContextWrapper.getCustomers();

        //private EFWorkflow.CustomerContextContainer customerContext = new EFWorkflow.CustomerContextContainer();
        private EFWorkflow.CustomerContext customerContext = new EFWorkflow.CustomerContext();

        public EFTestClient()
        {
            InitializeComponent();

            this.labelCustomerCountValue.Text = this.customerContext.Customers.Count().ToString();
            //this.labelCustomerCountValue.Text = customers.Count().ToString();
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            EFWorkflow.Customer newCustomer = this.customerContext.Customers.Create();
            newCustomer.FirstName = "";
            newCustomer.LastName = "";
            newCustomer.Address = "";
            newCustomer.City = "";
            newCustomer.State = "";
            newCustomer.Zip = "";

            this.customerContext.Customers.Add(newCustomer);
            this.customerContext.SaveChanges();
            this.labelCustomerCountValue.Text = this.customerContext.Customers.Count().ToString();
        }
    }
}
