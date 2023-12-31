﻿using Core.Entity.Abstract;

namespace Core.Entity.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }

        public Role Role { get; set; }
    }

}
