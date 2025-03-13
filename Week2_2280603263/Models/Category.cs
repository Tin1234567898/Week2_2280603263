using System.ComponentModel.DataAnnotations;

namespace Week2_2280603263.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }    

    }
}
