using System;
using SQLite;

namespace SQLDemo.Models
{
    [Table("AUser")]
    public class User
    {
        [PrimaryKey]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
    }
}
