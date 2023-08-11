# Elevators-ByRaas #

## Type Elevators_ByRaas.Controllers.TransportController

 Controller for managing transport-related operations. 



---
#### Method Elevators_ByRaas.Controllers.TransportController.#ctor(Services.Contracts.IElevatorService,Services.Contracts.IFloorService)

 Initializes a new instance of the [[|T:Elevators_ByRaas.Controllers.TransportController]] class. 

|Name | Description |
|-----|------|
|elevatorService: |The elevator service.|
|floorService: |The floor service.|


---
#### Method Elevators_ByRaas.Controllers.TransportController.RequestElevator(Models.RequestModels.FloorRequest)

 Request an available elevator to a specific floor. 

|Name | Description |
|-----|------|
|request: |The requested floor.|
**Returns**: The result of the elevator request.



---
#### Method Elevators_ByRaas.Controllers.TransportController.RequestDestination(Models.RequestModels.ElevatorRequest)

 Request the elevator to a destination floor from within the elevator car. 

|Name | Description |
|-----|------|
|request: |The elevator and destination floor details.|
**Returns**: The result of the destination request.



---
#### Method Elevators_ByRaas.Controllers.TransportController.GetServicingFloors(System.Int32)

 Get the list of floors that the specified elevator is servicing. 

|Name | Description |
|-----|------|
|elevatorId: |The ID of the elevator.|
**Returns**: The list of servicing floors.



---
#### Method Elevators_ByRaas.Controllers.TransportController.GetNextFloor(System.Int32)

 Get the next floor that the specified elevator needs to service. 

|Name | Description |
|-----|------|
|elevatorId: |The ID of the elevator.|
**Returns**: The next servicing floor.



---


