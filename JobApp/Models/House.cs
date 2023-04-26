using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace JobApp.Models
{
    public class House
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "Owner's Name")]
        [DataType(DataType.Text)]
        public string? OwnerName { get; set; }
        [Required]
        [MaxLength(150)]
        [Display(Name = "Property Name")]
        [DataType(DataType.Text)]
        public string? MyProperty { get; set; }
        [Required]
        [Display(Name = "Property Value")]
        [DataType(DataType.Currency)]
        public int PropertyValue { get; set; }
    }
}
