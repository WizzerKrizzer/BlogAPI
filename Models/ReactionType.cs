using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ReactionType
    {
        [Key]
        public int id { get; set; }

        //[Required]
        public string name { get; set; }

        //[Required]
        public Reaction reaction { get; set; }

       //[Required]
        public int reaction_id { get; set; }


        public ReactionType(string name)
        {
            this.name = name;
        }
    }
}
