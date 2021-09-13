﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models {
    public class Product {
        
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [Required]
        [StringLength(2083)]
        [DataType( DataType.ImageUrl )]
        public string ImgUri { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column( TypeName = "decimal(18,4)" )]
        public decimal Price { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }
    }
}
