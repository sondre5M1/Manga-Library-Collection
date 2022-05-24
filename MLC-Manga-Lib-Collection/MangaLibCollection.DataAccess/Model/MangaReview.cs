using System.ComponentModel.DataAnnotations;

namespace MangaLibCollection.DataAccess.Model
{
    public class MangaReview
    {
        public int MangaReviewId { get; set; }

        public int MangaSeriesId { get; set; }

        public int UserId { get; set; }

        [Required]
        [MinLength(2)]
        public string MangaReviewTitle { get; set; }

        [Required]
        [MinLength(10)]
        public string MangaReviewText { get; set; }

        public int Score { get; set; }
    }
}
