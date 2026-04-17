using System.ComponentModel.DataAnnotations;

namespace PustokAppMvc.Areas.Manage.ViewModels
{
    public class AdminLoginVm
    {
        [Required]
        [MinLength(2)]
        public string Username { get; set; } = null!;

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
