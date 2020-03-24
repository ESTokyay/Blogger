using EST.Mp.Core.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace EST.Mp.Entities.Concrete
{
    public class Articles : IEntity
    {   
        [Key]
        public int ArticleID { get; set; }
        public string ArticleTitle { get; set; }
        public string ArticleContent { get; set; }
        public string ArticleImage { get; set; }
        public string ArticleSeoLink { get; set; }
        public string ArticleState { get; set; }
        public DateTime ArticleDate { get; set; }
        public double ArticleReadNumber { get; set; }
        public string ArticleTagList { get; set; }

        public int UserID { get; set; }
        public Users User { get; set; }

        public int CategoryID { get; set; }
        public Categories Category { get; set; }
    

    }
}
