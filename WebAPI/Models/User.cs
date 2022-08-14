using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName = "nvarchar(100")]
        public string fullName { get; set; }

        [Column(TypeName = "nvarchar(100")]
        public string email { get; set; }
    }


}