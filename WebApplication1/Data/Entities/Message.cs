using System;

namespace WebApplication1.Data.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }
        public int ToRoomId { get; set; }
        public Room ToRoom { get; set; }
        public ManageUser FromUser { get; set; }

    }
}