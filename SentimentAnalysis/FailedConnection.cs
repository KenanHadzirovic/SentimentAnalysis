using System.ComponentModel.DataAnnotations;

namespace SentimentAnalysis
{
    public class FailedConnection
    {
        [Key]
        public int FailedConnectionId { get; set; }
        public string Url { get; set; }
        public string Reason { get; set; }
    }
}
