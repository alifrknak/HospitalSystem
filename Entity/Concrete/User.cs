using Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? UserName { get; set; }
        public byte[]? Password { get; set; }
        public byte[]? PasswordKey { get; set; }
        public Patient? Patient { get; set; }
    }
}