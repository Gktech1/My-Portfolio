using System;

namespace MyPortfolio.Models
{
    public class Contact
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
