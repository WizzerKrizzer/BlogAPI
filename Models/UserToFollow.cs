using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class UserToFollow
    {
        [Required]
        //[ForeignKey("Users")]
        public int user_id { get; set; }

        [Key]
        public int follow_user_id { get; set; }

        [Required]
        public User user { get; set; }


    }
}