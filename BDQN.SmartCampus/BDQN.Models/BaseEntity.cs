using System;
using System.ComponentModel.DataAnnotations;

namespace BDQN.Models
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;

    }
}
