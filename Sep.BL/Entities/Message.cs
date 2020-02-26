using System;
using System.Collections.Generic;
using System.Text;

namespace Sep.BL.Entities
{
    public class Message
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public User From { get; set; }
    }

}
