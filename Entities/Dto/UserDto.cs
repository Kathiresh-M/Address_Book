﻿using Entities.Models;

namespace Entities.Dto
{
    public class UserDto
    {
        public Guid Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string User_Name { get; set; }
        public string Password { get; set; }
    }
}
