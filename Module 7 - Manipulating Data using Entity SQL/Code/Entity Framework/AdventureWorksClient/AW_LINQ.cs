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
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    select sales;

                //var Sales = awEntities.SalesOrderHeaders;


                //// select AccountNumber from SalesOrderHeaders
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    select sales.AccountNumber;

                //var Sales = awEntities.SalesOrderHeaders.Select(h => new { h.AccountNumber });  


                //// select AccountNumber and CustomerID from SalesOrderHeaders
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    select new { sales.AccountNumber, sales.CustomerID };

                //var Sales = awEntities.SalesOrderHeaders.Select(h => new { h.AccountNumber, h.CustomerID });  


                //// select AccountNumber as Account and CustomerID as Customer from SalesOrderHeaders
                //var SalesList =
                //    from sales in awEntities.SalesOrderHeaders
                //    select new { Account = sales.AccountNumber, Customer = sales.CustomerID };

                //var Sales = awEntities.SalesOrderHeaders.Select(h => new { Account = h.AccountNumber, Customer = h.CustomerID });  


                //// select * from SalesOrderHeaders where TotalDue > 5000
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue > 5000
                //    select sales;

                //var Sales = awEntities.SalesOrderHeaders.Where(h => h.TotalDue > 5000);  


                //// select * from SalesOrderHeaders where TotalDue > 5000 and TotalDue < 10000
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue > 5000 && sales.TotalDue < 10000
                //    select sales;

                //var Sales = awEntities.SalesOrderHeaders.Where(h => h.TotalDue > 5000 && h.TotalDue < 10000);  


                //// select * from SalesOrderHeaders where TotalDue < 5000 or TotalDue > 10000
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue < 5000 || sales.TotalDue > 10000
                //    select sales;

                //var Sales = awEntities.SalesOrderHeaders.Where(h => h.TotalDue < 5000 || h.TotalDue > 10000);  


                //// select * from SalesOrderHeaders where OrderDate >= '12/1/2007'
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.OrderDate >= new DateTime(2007, 12, 1)
                //    select sales;

                //var Sales = awEntities.SalesOrderHeaders.Where(h => h.OrderDate >= new DateTime(2007, 12, 1));  


                //// select * from SalesOrderHeaders where SalesOrderID in (43659, 43660, 43661)
                //int[] salesOrderIDs = { 43659, 43660, 43661 };
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where salesOrderIDs.Contains(sales.SalesOrderID)
                //    select sales;

                //int[] salesOrderIDs = { 43659, 43660, 43661 };
                //var Sales = awEntities.SalesOrderHeaders.Where(h => salesOrderIDs.Contains(h.SalesOrderID));  


                //// select * from SalesOrderHeaders order by OrderDate
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    orderby sales.OrderDate
                //    select sales;

                //var Sales = awEntities.SalesOrderHeaders.OrderBy(h => h.OrderDate);  


                //// select * from SalesOrderHeaders order by OrderDate desc
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    orderby sales.OrderDate descending
                //    select sales;

                //var Sales = awEntities.SalesOrderHeaders.OrderByDescending(h => h.OrderDate);  


                //// select * from SalesOrderHeaders order by OrderDate, ShipDate
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    orderby sales.OrderDate, sales.ShipDate
                //    select sales;

                //var Sales = awEntities.SalesOrderHeaders.OrderBy(h => h.OrderDate).ThenBy(h => h.ShipDate);  


                //// select ShipMethodID, Count(*) from SalesOrderHeaders group by ShipMethodID
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    group sales by sales.ShipMethodID into salesGroup
                //    select new { ShipMethodID = salesGroup.Key, Count = salesGroup.Count() };

                //var Sales = awEntities.SalesOrderHeaders.GroupBy(h => h.ShipMethodID).Select(g => new { ShipMethodID = g.Key, Count = g.Count() });


                //// select ShipMethodID, Count(*) from SalesOrderHeaders where TotalDue > 1000 group by ShipMethodID
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue > 1000
                //    group sales by sales.ShipMethodID into salesGroup
                //    select new { ShipMethodID = salesGroup.Key, Count = salesGroup.Count() };

                //var Sales = awEntities.SalesOrderHeaders
                //    .Where(h => h.TotalDue > 1000)
                //    .GroupBy(h => h.ShipMethodID)
                //    .Select(g => new { ShipMethodID = g.Key, Count = g.Count() });


                //// select ShipMethodID, Count(*) from SalesOrderHeaders where TotalDue > 1000 group by ShipMethodID having Count(*) > 1000
                //var Sales =
                //    from sales in awEntities.SalesOrderHeaders
                //    where sales.TotalDue > 1000
                //    group sales by sales.ShipMethodID into salesGroup
                //    where salesGroup.Count() > 1000
                //    select new { ShipMethodID = salesGroup.Key, Count = salesGroup.Count() };

                //var Sales = awEntities.SalesOrderHeaders
                //    .Where(h => h.TotalDue > 1000)
                //    .GroupBy(h => h.ShipMethodID)
                //    .Where(g => g.Count() > 1000)
                //    .Select(g => new { ShipMethodID = g.Key, Count = g.Count() });


                //// select headers.SalesOrderID, details.UnitPrice 
                //// from SalesOrderHeaders as headers join SalesOrderDetails as details on headers.SalesOrderID = details.SalesOrderID
                //var Sales =
                //    from headers in awEntities.SalesOrderHeaders
                //    join details in awEntities.SalesOrderDetails
                //    on headers.SalesOrderID equals details.SalesOrderID
                //    select new { headers.SalesOrderID, details.UnitPrice };

                //var Sales = awEntities.SalesOrderHeaders
                //    .Join(
                //        awEntities.SalesOrderDetails, 
                //        d => d.SalesOrderID, 
                //        h => h.SalesOrderID, 
                //        (h, d) => new { h.SalesOrderID, d.UnitPrice }
                //    );
                
                //// IQueryable vs IEnumerable Performance
                var Sales = awEntities.SalesOrderDetails
                    .Where(s => s.UnitPrice > 1)
                    .OrderBy(s => s.UnitPrice)
                    .Take(1);

                //IQueryable<SalesOrderDetail> Sales = awEntities.SalesOrderDetails
                //    .Where(s => s.UnitPrice > 1)
                //    .OrderBy(s => s.UnitPrice)
                //    .Take(1);

                //IEnumerable<SalesOrderDetail> Sales = awEntities.SalesOrderDetails
                //    .Where(s => s.UnitPrice > 1)
                //    .OrderBy(s => s.UnitPrice)
                //    .Take(1);

                var results = Sales.ToList();
                
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                MessageBox.Show(String.Format("Elapsed Time = {0} and Count = {1}", elapsedTime, Sales.Count()));

                this.dataGridViewQueryResults.DataSource = results;
            }
        }
    }
}
