using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Canteen.Data.Entities
{
    public class CookShop
    {
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string CloseTime { get; set; }
        [Required]
        public string Img { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
