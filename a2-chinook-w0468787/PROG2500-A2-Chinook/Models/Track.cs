using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2500_A3_Chinook_Linq.Models
{
    public partial class Track
    {
        public string? timeInMS { get { return $"Length: {this.Milliseconds / 1000:N0} s"; } }
        public string? sizeInBytes { get { return $"Size: {this.Bytes / 1000000:N0} mb"; } }
    }
}
