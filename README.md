# Elevators
API (over http) that will be used by multiple dependent teams. It is your task to design the API and implement a minimal set of code that the other teams can use to test their integration


# TransportController

## RequestElevator

Request an available elevator to a specific floor.

`request`
The requested floor.

`returns`
The result of the elevator request.

`example`
Use code with caution. Learn more
RequestElevator(new FloorRequest { FloorNumber = 10 });


`output`
Elevator 1 requested to floor 10


## RequestDestination

Request the elevator to a destination floor from within the elevator car.

`request`
The elevator and destination floor details.

`returns`
The result of the destination request.

`example`
RequestDestination(new ElevatorRequest { ElevatorId = 1, FloorNumber = 20 });


`output`
Elevator 1 requested to destination floor 20


## GetServicingFloors

Get the list of floors that the specified elevator is servicing.

`parameters`

* **elevatorId** The ID of the elevator.

`returns`
The list of servicing floors.

`example`
GetServicingFloors(1);


`output`
[1, 2, 3, 4, 5]


## GetNextFloor

Get the next floor that the specified elevator needs to service.

`parameters`

* **elevatorId** The ID of the elevator.

`returns`
The next servicing floor.

`example`
GetNextFloor(1);


`output`
2
