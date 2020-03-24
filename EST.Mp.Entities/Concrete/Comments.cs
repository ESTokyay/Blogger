using EST.Mp.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace EST.Mp.Entities.Concrete
{
    public class Comments : IEntity
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentEmail { get; set; }
        public string CommentArticle { get; set; }
        public DateTime CommentDate { get; set; }
        public bool CommentState { get; set; }

        public int UserID { get; set; }
        public Users User { get; set; }

    }

}
