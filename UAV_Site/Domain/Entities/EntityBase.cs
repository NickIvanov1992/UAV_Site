using System.ComponentModel.DataAnnotations;

namespace UAV_Site.Domain.Entities
{
    public abstract class EntityBase
    {
        protected EntityBase() => DateAdded = DateTime.UtcNow;
        [Required]
        public Guid Id { get;set; }

        [Display(Name = "Name (Title)")]
        public virtual string? Title { get; set; }

        [Display(Name = "Short description")]
        public virtual string? Subtitle { get; set; }

        [Display(Name = "Full Description")]
        public virtual string? Text { get; set; }

        [Display(Name = "Image title")]
        public virtual string? TitleImagePath { get; set; }

        [Display(Name = "SEO metaTag Title")]
        public string? MetaTitle { get; set; }

        [Display(Name = "SEO metaTag Description")]
        public string? MetaDescription { get; set; }

        [Display(Name = "SEO metaTag Keywords")]
        public string? MetaKeywords { get; set; }

        [DataType(DataType.Time)]
        public DateTime DateAdded { get; set; }


    }
}
