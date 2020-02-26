using System;
using System.Collections.Generic;
using System.Text;

namespace Sep.BL.Entities
{
    public class Room
    {
        public long Id { get; set; }
        public IList<User> Users { get; set; }
        public IList<Message> Messages { get; set; }

        public string Name { get; set; }
    }
}
