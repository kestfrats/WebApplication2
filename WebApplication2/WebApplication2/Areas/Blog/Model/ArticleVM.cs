using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using WebApplication2.Areas.Identity.Data;

namespace WebApplication2.Areas.Blog.Model
{
    public class ArticleVM : IValidatableObject
    {
        public DateTime? CreationDate { get; set; }
        public DateTime? UpdateDate { get; set; }

        public ApplicationUser? Author { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Can not be longer than 10 chars")]
        public string Headline { get; set; }


        [Required(AllowEmptyStrings = false, ErrorMessage = "This field cannot be blank")]
        public string Content { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Cannot be minimum than 1")]
        public int ReadableTime { get; set; }

        public string HashtagString { get; set; }

        public int Id { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (HashtagString != "")
            {
                HashtagString = HashtagString.Replace(" ", "");
                if (!HashtagString.StartsWith('#'))
                {
                    yield return new ValidationResult("Hashtags must start with #!", new[] { "HashtagString" });
                }
            }
        }
    }
}