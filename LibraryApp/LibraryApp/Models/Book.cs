using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LibraryApp.Models
{
    public class Book
    {
        [Key]
        public int Book_U { get; set; }

        [DisplayName("제목")]
        public string Title { get; set; }
        [DisplayName("저자")]
        public string Writer { get; set; }
        [DisplayName("요약")]
        public string Summary { get; set; }
        [DisplayName("출판사")]
        public string Publisher { get; set; }
        [DisplayName("출판일")]
        public int Published_date { get; set; }
    }
}