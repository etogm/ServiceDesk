namespace ServiceDesk.WebApp.Models
{
    using System.ComponentModel.DataAnnotations;
    
    public sealed class ReportViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Полное имя")]
        [MaxLength(256)]
        public string FullName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Номер телефона")]
        [MaxLength(11)]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [Display(Name = "Текст обращения")]
        [MaxLength(1024)]
        public string Text { get; set; }
    }
}