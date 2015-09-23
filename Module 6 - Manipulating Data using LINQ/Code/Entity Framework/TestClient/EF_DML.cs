using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EFWorkflow = EDMX_Database_First;
using System.Data.Entity;

namespace TestClient
{
    public partial class EF_DML : Form
    {
        private EFWorkflow.CustomerContextContainer customerContext = new EFWorkflow.CustomerContextContainer();

        public EF_DML()
        {
            InitializeComponent();
            customerContext.Customers.Load();
        }

        private void EF_DML_Load(object sender, EventArgs e)
        {
            this.listBoxCustomers.DataSource = this.customerContext.Customers.Local.ToBindingList();
            this.listBoxCustomers.DisplayMember = "FullName";
            this.listBoxCustomers.ValueMember = "CustomerId";
        }

        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            EFWorkflow.Customer newCustomer = this.customerContext.Customers.Create();
            newCustomer.FirstName = "First";
            newCustomer.LastName = "Last";
            newCustomer.Address = "123 Main St";
            newCustomer.City = "Gotham";
            newCustomer.State = "NY";
            newCustomer.Zip = "12345";

            this.customerContext.Customers.Add(newCustomer);
            this.customerContext.SaveChanges();
        }

        private void buttonUpdateCustomer_Click(object sender, EventArgs e)
        {
            int selectedCustomerId = Int32.Parse(this.listBoxCustomers.SelectedValue.ToString());
            var selectedCustomer = this.customerContext.Customers.Find(selectedCustomerId);
            selectedCustomer.LastName = "Updated";

            this.listBoxCustomers.DataSource = null;
            this.listBoxCustomers.DataSource = this.customerContext.Customers.Local.ToBindingList();
            this.listBoxCustomers.DisplayMember = "FullName";
            this.listBoxCustomers.ValueMember = "CustomerId";

            this.customerContext.SaveChanges();           
        }

        private void buttonDeleteCustomer_Click(object sender, EventArgs e)
        {
            int selectedCustomerId = Int32.Parse(this.listBoxCustomers.SelectedValue.ToString());
            var selectedCustomer = this.customerContext.Customers.Find(selectedCustomerId);
            this.customerContext.Customers.Remove(selectedCustomer);
            this.customerContext.SaveChanges();
        }
    }
}
