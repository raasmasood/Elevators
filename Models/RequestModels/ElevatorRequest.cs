using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.RequestModels
{
    /// <summary>
    /// Represents a request for an elevator to a specific floor.
    /// </summary>
    public class ElevatorRequest
    {
        /// <summary>
        /// Gets or sets the ID of the elevator.
        /// </summary>
        public int ElevatorId { get; set; }

        /// <summary>
        /// Gets or sets the floor number.
        /// </summary>
        public int FloorNumber { get; set; }
    }
}
