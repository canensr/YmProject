﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(20)]
        public string SurName { get; set; }
        [StringLength(50)]
        public string Mail { get; set; }
        [StringLength(30)]
        public string Subject { get; set; }
        
        public string Message { get; set; }
        public int Id { get; set; }
    }
}
