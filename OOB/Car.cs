using System;

namespace OOB
{
    public class Car
    {
        private Guid Id { get; }
        public Car()
        {
            Id = new Guid();
        }
    }
}