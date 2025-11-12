using System;

namespace application.Models
{
    public class DataRecord
    {
        public int Id { get; set; }
        public string Version { get; set; }
        public string UserName { get; set; }

        public string Password { get; set; }

        public DateTime RegTime { get; set; }
        public DateTime ModTime { get; set; }
    }
}