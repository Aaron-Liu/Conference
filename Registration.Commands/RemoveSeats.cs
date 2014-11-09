﻿using System;

namespace Registration.Commands
{
    public class RemoveSeats : SeatsAvailabilityCommand
    {
        public Guid SeatType { get; set; }
        public int Quantity { get; set; }

        public RemoveSeats(Guid conferenceId) : base(conferenceId) { }
    }
}