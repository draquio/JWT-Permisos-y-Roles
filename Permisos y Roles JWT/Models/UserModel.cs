﻿namespace Permisos_y_Roles_JWT.Models
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
