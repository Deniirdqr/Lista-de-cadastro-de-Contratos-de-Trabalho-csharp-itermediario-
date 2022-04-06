using System;
using Quinto.Entities;
namespace Quinto.Entities.Enums
{
    class Orders
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
