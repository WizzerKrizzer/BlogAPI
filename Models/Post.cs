using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Post
    {
        [Key]
        public int id { get; set; }

        //[Required]
        public string Title { get; set; }

        //[Required]
        public string Content { get; set; }

        //[Required]
        //[ForeignKey("Users")] 
        public int UserId { get; set; }

        //[Required]
        public DateTime created_on { get; set; }

        //[Required]
        public DateTime updated_on { get; set; }

        //[Required]
        public string is_visible { get; set; }
        
        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

        public ICollection<Reaction> Reactions { get; set; } = new HashSet<Reaction>();


        //[Required]
        public User User { get; set; }

        //[Required]
        public Post posts { get; set; }


        public Post(string title, string content, string is_visible, DateTime created_on, DateTime updated_on)
        {
            this.is_visible = is_visible;
            this.created_on = created_on;
            this.updated_on = updated_on;
            this.Title = title;
            this.Content = content;
        }

        public Post()
        {
        }
    }
}

