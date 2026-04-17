using PustokAppMvc.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace PustokAppMvc.Models
{
    public class Setting
    {
        [Key]
        public string Key { get; set; } = null!;
        public string Value { get; set; } = null!;
    }
}
