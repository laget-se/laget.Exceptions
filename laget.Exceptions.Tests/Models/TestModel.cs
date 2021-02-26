using System;
using System.Collections.Generic;
using System.Text;

namespace laget.Exceptions.Tests.Models
{
    public class TestModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public TestModel()
        {
            Id = int.MaxValue;
            FirstName = "Jane";
            LastName = "Doe";
            Email = $"{FirstName.ToLower()}.{LastName.ToLower()}@laget.se";
            CreatedAt = DateTime.Now.AddMonths(-1);
            UpdatedAt = DateTime.Now;
        }
    }
}
