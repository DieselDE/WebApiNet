using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dtos.Stock
{
    public class UpdateStockRequestDto
    {
        [Required]
        [MaxLength(10, ErrorMessage = "Symbol cannot be over 10 char long")]
        public string Symbol { get; set; } = string.Empty;

        [Required]
        [MaxLength(10, ErrorMessage = "Name cannot be over 10 char long")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(1, 1000000000, ErrorMessage ="must be between 1 and 1.000.000.000")]
        public decimal Purchase { get; set; }

        [Required]
        [Range(0.001, 100, ErrorMessage ="Must be between 0.001 and 100")]
        public decimal LastDiv { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Industry cannot be over 20 char long")]
        public string Industry { get; set; } = string.Empty;

        [Required]
        [Range(1, 5000000000, ErrorMessage = "must be between 1 and 5.000.000.000")]
        public long MarketCap { get; set; }
    }
}