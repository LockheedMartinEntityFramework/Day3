using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDMX_Database_First
{
    public partial class Customer
    {
        public string FullName { get { return String.Format("{0} {1}", FirstName, LastName); } }
    }
}
