using System;
using System.ComponentModel.DataAnnotations;

namespace OhEss.Models
{
    public class Account
    {
		public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateCreated { get; set; }
        public string StoragePath { get; set; }
        public DateTime LastLoggedIn { get; set; }
		public string ProfilePicturePath { get; set; }
    }
}