using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public List<Category> Categories { get; set; } = new List<Category>();
    }
}
