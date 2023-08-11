using Microsoft.AspNetCore.Mvc;
using Models.RequestModels;
using Services.Contracts;

namespace Elevators_ByRaas.Controllers
{
    /// <summary>
    /// Controller for managing transport-related operations.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class TransportController : Controller
    {
        private readonly IElevatorService _elevatorService;
        private readonly IFloorService _floorService;
        /// <summary>
        /// Initializes a new instance of the <see cref="TransportController"/> class.
        /// </summary>
        /// <param name="elevatorService">The elevator service.</param>
        /// <param name="floorService">The floor service.</param>
        public TransportController(IElevatorService elevatorService, IFloorService floorService)
        {
            _elevatorService = elevatorService;
            _floorService = floorService;
        }
        /// <summary>
        /// Request an available elevator to a specific floor.
        /// </summary>
        /// <param name="request">The requested floor.</param>
        /// <returns>The result of the elevator request.</returns>
        [Route("request")]
        [HttpPost]
        public IActionResult RequestElevator([FromBody] FloorRequest request)
        {
            
            var closestElevator = _elevatorService.RequestElevator(request);
        

            if (closestElevator != null)
            {
                return Ok($"Elevator {closestElevator.Id} requested to floor {request.FloorNumber}");
            }
            else
            {
                return NotFound("No available elevators");
            }
        }
        /// <summary>
        /// Request the elevator to a destination floor from within the elevator car.
        /// </summary>
        /// <param name="request">The elevator and destination floor details.</param>
        /// <returns>The result of the destination request.</returns>
        [HttpPost]
        [Route("destination")]
        public IActionResult RequestDestination([FromBody] ElevatorRequest request)
        {
          var requestedElevator = _elevatorService.RequestDestination(request);


            if (requestedElevator != null)
            {

                return Ok($"Elevator {requestedElevator.Id} requested to destination floor {request.FloorNumber}");
            }
            else
            {
                return NotFound($"Elevator with ID {request.ElevatorId} not found");
            }
        }
        /// <summary>
        /// Get the list of floors that the specified elevator is servicing.
        /// </summary>
        /// <param name="elevatorId">The ID of the elevator.</param>
        /// <returns>The list of servicing floors.</returns>
        [HttpGet]
        [Route("{elevatorId}/servicingfloors")]
        public IActionResult GetServicingFloors(int elevatorId)
        {
            var floors = _floorService.GetServicingFloors(elevatorId);
            if (floors != null)
            {
                return Ok(floors);
            }
            else
            {
                return NotFound($"Elevator with ID {elevatorId} not found");
            }
        }
        /// <summary>
        /// Get the next floor that the specified elevator needs to service.
        /// </summary>
        /// <param name="elevatorId">The ID of the elevator.</param>
        /// <returns>The next servicing floor.</returns>
        [HttpGet]
        [Route("{elevatorId}/nextfloor")]
        public IActionResult GetNextFloor(int elevatorId)
        {
            var nextFloor = _floorService.GetNextFloor(elevatorId);
            if (nextFloor != int.MinValue)
            {
                return Ok(nextFloor);
            }
            else
            {
                return NotFound($"Elevator with ID {elevatorId} not found OR No servicing floors for the elevator");
            }
        }
    }
}
