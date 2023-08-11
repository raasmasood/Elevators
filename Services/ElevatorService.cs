using DataAccess;
using Models.Entities;
using Models.RequestModels;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    /// <summary>
    /// Service class for managing elevator operations.
    /// </summary>
    public class ElevatorService : IElevatorService
    {
        private ElevatorRepository _elevatorRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElevatorService"/> class.
        /// </summary>
        /// <param name="elevatorRepository">The repository for accessing elevator data.</param>
        public ElevatorService(ElevatorRepository elevatorRepository)
        {
            _elevatorRepository = elevatorRepository;
        }

        /// <summary>
        /// Requests the elevator to a destination floor from within the elevator car.
        /// </summary>
        /// <param name="request">The elevator and destination floor details.</param>
        /// <returns>The updated elevator.</returns>
        public Elevator RequestDestination(ElevatorRequest request)
        {
            int elevatorId = request.ElevatorId;

            var elevator = _elevatorRepository._elevators.FirstOrDefault(e => e.Id == elevatorId);
            if (elevator != null)
            {
                int destinationFloor = request.FloorNumber;
                elevator.ServicingFloors.Add(destinationFloor);
                return elevator;
            }
            return null;
        }

        /// <summary>
        /// Requests an available elevator to a specific floor.
        /// </summary>
        /// <param name="request">The requested floor.</param>
        /// <returns>The allocated elevator.</returns>
        public Elevator RequestElevator(FloorRequest request)
        {
            int requestedFloor = request.FloorNumber;

            Elevator closestElevator = null;
            int minDistance = int.MaxValue;

            foreach (var elevator in _elevatorRepository._elevators)
            {
                int distance = Math.Abs(elevator.CurrentFloor - requestedFloor);
                if (distance < minDistance)
                {
                    minDistance = distance;
                    closestElevator = elevator;
                }
            }

            if (closestElevator != null)
            {
                closestElevator.ServicingFloors.Add(requestedFloor);
                return closestElevator;
            }
            return null;
        }
    }
}
