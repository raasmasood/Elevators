using Models.Entities;
using Models.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    /// <summary>
    /// Interface for managing elevator-related operations.
    /// </summary>
    public interface IElevatorService
    {
        /// <summary>
        /// Request an available elevator to a specific floor.
        /// </summary>
        /// <param name="request">The requested floor.</param>
        /// <returns>The allocated elevator.</returns>
        Elevator RequestElevator(FloorRequest request);

        /// <summary>
        /// Request the elevator to a destination floor from within the elevator car.
        /// </summary>
        /// <param name="request">The elevator and destination floor details.</param>
        /// <returns>The updated elevator.</returns>
        Elevator RequestDestination(ElevatorRequest request);
    }
}
