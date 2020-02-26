using System;
using System.Collections.Generic;
using System.Text;

namespace Sep.BL.DTOs
{
    public class MessageDto
    {
        public string UserName { get; set; }
        public string MessageText { get; set; }
        public DateTime CreatedDate { get; set; }
        public string MessageView { 
            get {
                return $"{UserName} [{CreatedDate.ToShortDateString()}]: {MessageText}";
            } 
        }
    }
}
