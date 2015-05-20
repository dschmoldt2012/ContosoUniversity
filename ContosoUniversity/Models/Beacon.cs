
//
// Beacon.cs
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    public enum BeaconType
    {
        Unknown,
        Other,
        iBeacon
    }

    public class Beacon
    {
        public int BeaconID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Region { get; set; }
        public long Major { get; set; }
        public long Minor { get; set; }
        public virtual ICollection<BeaconType> BeaconTypes { get; set; }
        public virtual ICollection<Notification> Notifications { get; set;  }
    }
}
