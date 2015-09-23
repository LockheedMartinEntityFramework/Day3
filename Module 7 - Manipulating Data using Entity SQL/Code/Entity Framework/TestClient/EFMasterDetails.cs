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
    public partial class EFMasterDetails : Form
    {
        private EFWorkflow.CustomerContextContainer customerContext = new EFWorkflow.CustomerContextContainer();

        public EFMasterDetails()
        {
            InitializeComponent();

            customerContext.Customers.Load();
            //customerContext.Purchases.Load();
            //customerContext.Customers.Include(c => c.Purchases).Load();
        }

        private void EFMasterDetails_Load(object sender, EventArgs e)
        {
            this.customerBindingSource.DataSource = this.customerContext.Customers.Local.ToBindingList();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerContext.SaveChanges();
        }
    }
}
