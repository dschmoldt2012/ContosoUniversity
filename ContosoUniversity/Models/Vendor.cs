
//
// Vendor.cs
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public class Vendor
    {
        public int VendorID { get; set; }
        public virtual ICollection<Beacon> Beacons { get; set; }
    }
}
