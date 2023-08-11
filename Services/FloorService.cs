using DataAccess;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Service class for managing floor-related operations.
    /// </summary>
    public class FloorService : IFloorService
    {
        private ElevatorRepository _elevatorRepository;
        /// <summary>
        /// Initializes a new instance of the <see cref="FloorService"/> class.
        /// </summary>
        /// <param name="elevatorRepository">The repository for accessing elevator data.</param>
        public FloorService(ElevatorRepository elevatorRepository)
        {
            _elevatorRepository = elevatorRepository;
        }
        /// <summary>
        /// Get the next floor that the specified elevator needs to service.
        /// </summary>
        /// <param name="elevatorId">The ID of the elevator.</param>
        /// <returns>The next servicing floor.</returns>
        public int GetNextFloor(int elevatorId)
        {
            var elevator = _elevatorRepository._elevators.FirstOrDefault(e => e.Id == elevatorId);
            if (elevator != null)
            {
                if (elevator.ServicingFloors.Any())
                {
                    int nextFloor = elevator.ServicingFloors.Min();
                    return nextFloor;
                }
            }
            return int.MinValue;
        }
        /// <summary>
        /// Get the list of floors that the specified elevator is servicing.
        /// </summary>
        /// <param name="elevatorId">The ID of the elevator.</param>
        /// <returns>The list of servicing floors.</returns>
        public List<int> GetServicingFloors(int elevatorId)
        {
            var elevator = _elevatorRepository._elevators.FirstOrDefault(e => e.Id == elevatorId);
            if (elevator != null)
            {
                return elevator.ServicingFloors;
            }

            return null;

        }
    }
}
