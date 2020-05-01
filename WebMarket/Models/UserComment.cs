﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebMarket.Models
{
    [Serializable]
    public class UserComment
    {
        [Key]
        public int ID { get; set; }
        public string Text { get; set; }
        [Required]
        public string ProductID { get; set; }
        public string UserID { get; set; }
        public float Rate { get; set; }

        public uint Stars { get => (uint)Math.Truncate((decimal)Rate); }
    }
}
