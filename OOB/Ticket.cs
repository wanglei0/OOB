using System;

namespace OOB
{
    public class Ticket
    {
        private Guid Id { get; set; }

        public Ticket()
        {
            Id = new Guid();
        }
    }
}