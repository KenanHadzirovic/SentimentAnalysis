using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SentimentAnalysis
{
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
