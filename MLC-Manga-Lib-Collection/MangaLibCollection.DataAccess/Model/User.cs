using MLC.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace MangaLibCollection.DataAccess.Model
{
    public class User
    {
        public int UserId { get; set; }

        [Required]
        [MinLength(4)]
        public string UserName { get; set; }

        public string Forename { get; set; }
        public string Surname { get; set; }

        [Required]
        [MinLength(8)]
        public string Password { get; set; }

        public string Description { get; set; }

        public Gender Gender { get; set; }

        public string ProfileImage { get; set; }

        public int MangaCollectionId { get; set; }

        public int ReviewCollectionId { get; set; }
    }
}
