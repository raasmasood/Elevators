using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    /// <summary>
    /// Interface for managing floor-related operations.
    /// </summary>
    public interface IFloorService
    {
        /// <summary>
        /// Get the list of floors that the specified elevator is servicing.
        /// </summary>
        /// <param name="elevatorId">The ID of the elevator.</param>
        /// <returns>The list of servicing floors.</returns>
        List<int> GetServicingFloors(int elevatorId);

        /// <summary>
        /// Get the next floor that the specified elevator needs to service.
        /// </summary>
        /// <param name="elevatorId">The ID of the elevator.</param>
        /// <returns>The next servicing floor.</returns>
        int GetNextFloor(int elevatorId);
    }
}
