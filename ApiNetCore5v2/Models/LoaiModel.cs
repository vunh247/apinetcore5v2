using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiNetCore5v2.Models
{
    public class LoaiModel
    {
     
        [Required]
        [MaxLength(100)]
        public string TenLoai { get; set; }


    }
}
