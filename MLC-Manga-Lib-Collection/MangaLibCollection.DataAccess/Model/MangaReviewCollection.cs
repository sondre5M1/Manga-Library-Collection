using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MangaLibCollection.DataAccess.Model
{
    public class MangaReviewCollection
    {
        public int MangaReviewCollectionId { get; set; }

        public int UserId { get; set; }

        public List<int> MangaReviewList { get; set; }
    }
}
