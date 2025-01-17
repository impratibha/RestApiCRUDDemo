﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RestApiCRUDDemo.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50,ErrorMessage ="Name can only be 50 Characters long")]
        public string Name { get; set; }
    }
}
