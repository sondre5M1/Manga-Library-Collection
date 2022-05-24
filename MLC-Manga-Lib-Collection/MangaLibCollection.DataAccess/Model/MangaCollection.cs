using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MangaLibCollection.DataAccess.Model
{
    public class MangaCollection
    {
        public int MangaCollectionId { get; set; }

        [Required]
        public int UserId { get; set; }

        public string CollectionName { get; set; }

        public List<int> MangaSeriesUserInfoId { get; set; } 
    }
}
