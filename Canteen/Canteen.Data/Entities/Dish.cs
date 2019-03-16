using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Canteen.Data.Entities
{
    public class Dish
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Img { get; set; }
        [Required]
        public Guid CategoryId { get; set; }
        [Required]
        public int Calorie { get; set; }
        public List<SizePrice> SizePrice { get; set; }
    }
}
