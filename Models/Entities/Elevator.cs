namespace Models.Entities
{
    /// <summary>
    /// Represents an elevator in the system.
    /// </summary>
    public class Elevator
    {
        /// <summary>
        /// Gets or sets the ID of the elevator.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the current floor of the elevator.
        /// </summary>
        public int CurrentFloor { get; set; }

        /// <summary>
        /// Gets the list of floors that the elevator is servicing.
        /// </summary>
        public List<int> ServicingFloors { get; } = new List<int>();
    }
}