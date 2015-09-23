using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;
using System.Data.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.EntityClient;

namespace AdventureWorksClient
{
    public partial class AW_LINQ : Form
    {
        public AW_LINQ()
        {
            InitializeComponent();
        }

        private void AW_LINQ_Load(object sender, EventArgs e)
        {
            using (AdventureWorks2012Entities awEntities = new AdventureWorks2012Entities())
            {
                Stopwatch stopWatch = new Stopwatch();
                stopWatch.Start();

                //// select * from SalesOrderHeaders
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    select sales;

                //var sales = awEntities.SalesOrderHeaders;


                //// select AccountNumber from SalesOrderHeaders
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    select sales.AccountNumber;

                //var sales = awEntities.SalesOrderHeaders.Select(h => new { h.AccountNumber });  


                //// select AccountNumber and CustomerID from SalesOrderHeaders
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    select new { sales.AccountNumber, sales.CustomerID };

                //var sales = awEntities.SalesOrderHeaders.Select(h => new { h.AccountNumber, h.CustomerID });  


                //// select AccountNumber as Account and CustomerID as Customer from SalesOrderHeaders
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    select new { Account = sales.AccountNumber, Customer = sales.CustomerID };

                //var sales = awEntities.SalesOrderHeaders.Select(h => new { Account = h.AccountNumber, Customer = h.CustomerID });  


                //// select * from SalesOrderHeaders where TotalDue > 5000
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue > 5000
                //    select sales;

                //var sales = awEntities.SalesOrderHeaders.Where(h => h.TotalDue > 5000);  


                //// select * from SalesOrderHeaders where TotalDue > 5000 and TotalDue < 10000
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue > 5000 && sales.TotalDue < 10000
                //    select sales;

                //var sales = awEntities.SalesOrderHeaders.Where(h => h.TotalDue > 5000 && h.TotalDue < 10000);  


                //// select * from SalesOrderHeaders where TotalDue < 5000 or TotalDue > 10000
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue < 5000 || sales.TotalDue > 10000
                //    select sales;

                //var sales = awEntities.SalesOrderHeaders.Where(h => h.TotalDue < 5000 || h.TotalDue > 10000);  


                //// select * from SalesOrderHeaders where OrderDate >= '12/1/2007'
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.OrderDate >= new DateTime(2007, 12, 1)
                //    select sales;

                //var sales = awEntities.SalesOrderHeaders.Where(h => h.OrderDate >= new DateTime(2007, 12, 1));  


                //// select * from SalesOrderHeaders where SalesOrderID in (43659, 43660, 43661)
                //int[] salesOrderIDs = { 43659, 43660, 43661 };
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where salesOrderIDs.Contains(sales.SalesOrderID)
                //    select sales;

                //int[] salesOrderIDs = { 43659, 43660, 43661 };
                //var sales = awEntities.SalesOrderHeaders.Where(h => salesOrderIDs.Contains(h.SalesOrderID));  


                //// select * from SalesOrderHeaders order by OrderDate
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    orderby sales.OrderDate
                //    select sales;

                //var sales = awEntities.SalesOrderHeaders.OrderBy(h => h.OrderDate);  


                //// select * from SalesOrderHeaders order by OrderDate desc
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    orderby sales.OrderDate descending
                //    select sales;

                //var sales = awEntities.SalesOrderHeaders.OrderByDescending(h => h.OrderDate);  


                //// select * from SalesOrderHeaders order by OrderDate, ShipDate
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    orderby sales.OrderDate, sales.ShipDate
                //    select sales;

                //var sales = awEntities.SalesOrderHeaders.OrderBy(h => h.OrderDate).ThenBy(h => h.ShipDate);  


                //// select ShipMethodID, Count(*) from SalesOrderHeaders group by ShipMethodID
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    group sales by sales.ShipMethodID into salesGroup
                //    select new { ShipMethodID = salesGroup.Key, Count = salesGroup.Count() };

                //var sales = awEntities.SalesOrderHeaders.GroupBy(h => h.ShipMethodID).Select(g => new { ShipMethodID = g.Key, Count = g.Count() });


                //// select ShipMethodID, Count(*) from SalesOrderHeaders where TotalDue > 1000 group by ShipMethodID
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue > 1000
                //    group sales by sales.ShipMethodID into salesGroup
                //    select new { ShipMethodID = salesGroup.Key, Count = salesGroup.Count() };

                //var sales = awEntities.SalesOrderHeaders
                //    .Where(h => h.TotalDue > 1000)
                //    .GroupBy(h => h.ShipMethodID)
                //    .Select(g => new { ShipMethodID = g.Key, Count = g.Count() });


                //// select ShipMethodID, Count(*) from SalesOrderHeaders where TotalDue > 1000 group by ShipMethodID having Count(*) > 1000
                //var sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue > 1000
                //    group sales by sales.ShipMethodID into salesGroup
                //    where salesGroup.Count() > 1000
                //    select new { ShipMethodID = salesGroup.Key, Count = salesGroup.Count() };

                //var sales = awEntities.SalesOrderHeaders
                //    .Where(h => h.TotalDue > 1000)
                //    .GroupBy(h => h.ShipMethodID)
                //    .Where(g => g.Count() > 1000)
                //    .Select(g => new { ShipMethodID = g.Key, Count = g.Count() });


                //// select headers.SalesOrderID, details.UnitPrice 
                //// from SalesOrderHeaders as headers join SalesOrderDetails as details on headers.SalesOrderID = details.SalesOrderID
                //var sales =
                //    from headers in awEntities.SalesOrderHeaders
                //    join details in awEntities.SalesOrderDetails
                //    on headers.SalesOrderID equals details.SalesOrderID
                //    select new { headers.SalesOrderID, details.UnitPrice };

                //var sales = awEntities.SalesOrderHeaders
                //    .Join(
                //        awEntities.SalesOrderDetails, 
                //        d => d.SalesOrderID, 
                //        h => h.SalesOrderID, 
                //        (h, d) => new { h.SalesOrderID, d.UnitPrice }
                //    );
                
                //// IQueryable vs IEnumerable Performance
                //var sales = awEntities.SalesOrderDetails
                //    .Where(s => s.UnitPrice > 1)
                //    .OrderBy(s => s.UnitPrice)
                //    .Take(1);

                //IQueryable<SalesOrderDetail> sales = awEntities.SalesOrderDetails
                //    .Where(s => s.UnitPrice > 1)
                //    .OrderBy(s => s.UnitPrice)
                //    .Take(1);

                //IEnumerable<SalesOrderDetail> sales = awEntities.SalesOrderDetails
                //    .Where(s => s.UnitPrice > 1)
                //    .OrderBy(s => s.UnitPrice)
                //    .Take(1);

                //List<SalesOrderHeader> results = sales.ToList();
                //stopWatch.Stop();
                //TimeSpan ts = stopWatch.Elapsed;
                //string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                //MessageBox.Show(String.Format("Elapsed Time = {0} and Count = {1}", elapsedTime, results.Count()));

                //this.dataGridViewQueryResults.DataSource = sales;


                //// Entity SQL
                //String entitySQL = "SELECT VALUE soh FROM SalesOrderHeaders as soh";
                //String entitySQL = "SELECT VALUE soh FROM SalesOrderHeaders as soh WHERE soh.TotalDue > 5000";
                //String entitySQL = "SELECT VALUE soh FROM SalesOrderHeaders as soh WHERE soh.TotalDue > 5000 and soh.TotalDue < 10000";
                //String entitySQL = "SELECT VALUE soh FROM SalesOrderHeaders as soh WHERE soh.SalesOrderID IN MultiSet (43659, 43660, 43661)";
                //String entitySQL = "SELECT VALUE soh FROM SalesOrderHeaders as soh order by soh.OrderDate";
                //String entitySQL = "SELECT VALUE soh FROM SalesOrderHeaders as soh order by soh.OrderDate desc";
                //String entitySQL = "SELECT VALUE soh FROM SalesOrderHeaders as soh order by soh.OrderDate, soh.ShipDate desc";
                //String entitySQL = "SELECT VALUE soh FROM SalesOrderHeaders as soh JOIN SalesOrderDetails as sod ON soh.SalesOrderID = sod.SalesOrderID";


                //// Create a query object.
                //var sales = (awEntities as IObjectContextAdapter).ObjectContext.CreateQuery<SalesOrderHeader>(entitySQL);

                //// Display Results
                //    this.dataGridViewQueryResults.DataSource = sales;
            }
        }
    }
}
