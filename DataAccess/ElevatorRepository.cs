using Models.Entities;

namespace DataAccess
{
    public class ElevatorRepository
    {
        public List<Elevator> _elevators = new List<Elevator>
                    {
                        new Elevator { Id = 1, CurrentFloor = 1 },
                        new Elevator { Id = 2, CurrentFloor = 5 }
                    };
    }
}