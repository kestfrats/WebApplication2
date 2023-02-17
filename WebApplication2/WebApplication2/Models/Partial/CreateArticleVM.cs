using System.ComponentModel.DataAnnotations;
using WebApplication2.Areas.Blog.Data;

namespace WebApplication2.Models.Partial
{
    public class CreateArticleVM
    {
        [Required]
        [StringLength(5, ErrorMessage = "Can not be longer than 10 chars")]
        public string Headline { get; set; }
        [Required]
        [StringLength(5, ErrorMessage = "Can not be longer than 10 chars")]
        public string Content { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="Cannot be minimum than 1")]
        public int ReadableTime { get; set; }

        public ICollection<Hashtag> Hashtags { get; set; }
    }
}
