//-----------------------------------------------------------------
//    <copyright file="Room.cs"
//    </copyright>
//    <date>15-11-2024</date>
//    <time>21:00</time>
//    <version>0.1</version>
//    <author>Eva Gomes</author>
//-----------------------------------------------------------------

using System;

namespace HealthClinic.Models
{
    /// <summary>
    /// Represents a room in the health clinic.
    /// This class stores the room number and its availability status.
    /// It provides methods to check and update the availability of the room.
    /// </summary>
    public class Room
    {
       
        public int ID { get; private set; }

     
        public int RoomNumber { get; private set; }

  
        protected bool IsAvailable { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Room"/> class with the specified room number.
        /// The room is initially set as available.
        /// </summary>
        /// <param name="roomNumber">The number of the room.</param>
        public Room(int roomNumber)
        {
            RoomNumber = roomNumber;
            IsAvailable = true;
        }

        /// <summary>
        /// Checks if the room is available for scheduling an appointment.
        /// </summary>
        /// <returns>True if the room is available; otherwise, false.</returns>
        public bool CheckAvailability() => IsAvailable;

        /// <summary>
        /// Marks the room as unavailable, indicating that it is in use for an appointment.
        /// </summary>
        public void MarkUnavailable() => IsAvailable = false;

        /// <summary>
        /// Marks the room as available, indicating that it is free for scheduling an appointment.
        /// </summary>
        public void MarkAvailable() => IsAvailable = true;
    }
}
