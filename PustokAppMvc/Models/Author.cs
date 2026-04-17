using PustokAppMvc.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace PustokAppMvc.Models
{
    public class Author : BaseEntity
    {
        [Required]
        public string FullName { get; set; } = null!;
    }
}
