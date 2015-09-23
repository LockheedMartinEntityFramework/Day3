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
    public partial class EFObjectDataSource : Form
    {
        private EFWorkflow.CustomerContextContainer customerContext = new EFWorkflow.CustomerContextContainer();

        public EFObjectDataSource()
        {
            InitializeComponent();

            //customerContext.Customers.ToList();
            customerContext.Customers.Load();
        }

        private void EFObjectDataSource_Load(object sender, EventArgs e)
        {
            customerBindingSource.DataSource = customerContext.Customers.Local;
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            customerContext.SaveChanges();
        }
    }
}
