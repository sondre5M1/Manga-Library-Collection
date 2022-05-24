using System.Collections.Generic;

namespace MangaLibCollection.DataAccess.Model
{
    public class MangaReviewCollection
    {
        public int MangaReviewCollectionId { get; set; }

        public int UserId { get; set; }

        public List<int> MangaReviewList { get; set; }
    }
}
