using MangaLibCollection.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace MangaLibCollection.DataAccess.Model
{
    public class MangaSeriesUserInfo
    {
        public int MangaSeriesUserInfoId { get; set; }

        [Required]
        public int MangaSeriesId { get; set; }

        public int MangaReviewId { get; set; }

        public int CollectedVolumes { get; set; }

        public CollectionStatus CollectionStatus { get; set; }
    }
}
