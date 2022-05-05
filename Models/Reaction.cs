using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reaction
    {
        [Key]
        public int id { get; set; }

        [Required]
        //[ForeignKey("ReactionTypes")]
        public int TypeId { get; set; }

        [Required]
        //[ForeignKey("Users")]
        public int UserId { get; set; }

        [Required]
        //[ForeignKey("Posts")]
        public int PostId { get; set; }

        [Required]
        public DateTime created_on { get; set; }

        [Required]
        public DateTime updated_on { get; set; }

        [Required]
        public Post Post { get; set; }

        public ICollection<ReactionType> ReactionType { get; set; } = new HashSet<ReactionType>();


        public Reaction(DateTime created_on, DateTime updated_on)
        {
            this.updated_on = updated_on;
            this.created_on = created_on;
        }
    }
}

