using System.ComponentModel.DataAnnotations;

namespace UAV_Site.Domain.Entities
{
    public class TextField :EntityBase
    {
        [Required]
        public string? CodeWord { get; set; }

        [Display(Name = "Page title (Headline)")]
        public override string? Title { get; set; } = "Page information";

        [Display(Name ="Page content")]
        public override string? Text { get; set; } = "The content is filled in by the administrator";
    }
}
