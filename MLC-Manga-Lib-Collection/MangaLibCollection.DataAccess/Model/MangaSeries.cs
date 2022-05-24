using MangaLibCollection.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace MangaLibCollection.DataAccess.Model
{
    public class MangaSeries
    {
        public int MangaSeriesId { get; set; }

        [Required]
        [MinLength(2)]
        public string MangaTitle { get; set; }

        public string MangaPicture { get; set; }

        public string Synopsis { get; set; }

        public int Volumes { get; set; }

        public PublishingStatus PublishingStatus { get; set; }
    }
}
