using EST.Mp.Core.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EST.Mp.Entities.Concrete
{
    public class Users: IEntity
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string UserEmail  { get; set; }
        public string UserName { get; set; }
        public double Password { get; set; }
        public bool Status { get; set; }
        public List<Articles> Articles { get; set; }
        public List<Comments> Comments { get; set; }

    }

}
