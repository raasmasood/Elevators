using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestModels
{
    /// <summary>
    /// Represents a request for a specific floor.
    /// </summary>
    public class FloorRequest
    {
        /// <summary>
        /// Gets or sets the floor number.
        /// </summary>
        public int FloorNumber { get; set; }
    }
}
