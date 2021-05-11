namespace ServiceDesk.WebApp.Models
{
    using System.ComponentModel.DataAnnotations;

    public sealed class LoginViewModel
    {
        [Required]
        [Display(Name = "Логин")]
        [DataType(DataType.Text)]
        public string Login { get; set; }

        [Required]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}