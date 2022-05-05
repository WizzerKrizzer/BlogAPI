using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Comment
    {
        [Key]
        public int id { get; set; }

        //[Required]
        public string content { get; set; }

        //[Required]
        //[ForeignKey("Users")]
        public int UserId { get; set; }

        //[Required]
        //[ForeignKey("Posts")]
        public int PostId { get; set; }

        //[Required]
        public DateTime created_on { get; set; }

        //[Required]
        public DateTime updated_on { get; set; }

        //[Required]
        public int parent_id { get; set; }

        //[Required]
        public Post Post { get; set; }

        //[Required]
        public User User { get; set; }


        public Comment(int parent_id, string content, DateTime created_on, DateTime updated_on)
        {
            this.created_on = created_on;
            this.updated_on = updated_on;
            this.parent_id = parent_id;
            this.content = content;
        }
    }
}

