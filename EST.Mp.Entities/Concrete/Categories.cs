using EST.Mp.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EST.Mp.Entities.Concrete
{
    public  class Categories: IEntity
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryDurum { get; set; }
        public string CategorySeoLink { get; set; }
        public List<Articles> Articles { get; set; }

    }
}
