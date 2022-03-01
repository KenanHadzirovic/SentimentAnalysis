using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SentimentAnalysis
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        public string CommentText { get; set; }
        public int ArticleId { get; set; }
    }
}
