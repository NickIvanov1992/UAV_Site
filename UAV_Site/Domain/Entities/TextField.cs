using System.ComponentModel.DataAnnotations;

namespace UAV_Site.Domain.Entities
{
    public class TextField :EntityBase
    {
        [Required]
        public string? CodeWord { get; set; }

        [Display(Name = "Название страницы (Заголовок)")]
        public override string? Title { get; set; } = "Информация по странице";

        [Display(Name ="Содержание страницы")]
        public override string? Text { get; set; } = "Содержание заполняется администратором";
    }
}
