using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        [Key]
        public int id { get; set; }

        //[Required]
        public string Username { get; set; }

        //[Required]
        public string PasswordHash { get; set; }

        //[Required]
        public string role { get; set; }

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

        public ICollection<Post> Posts { get; set; } = new HashSet<Post>();

        public ICollection<UserToFollow> userstofollow { get; set; } = new HashSet<UserToFollow>();

 

        public User(string username, string password_hash, string role)
        {
            this.Username = username;
            this.PasswordHash = password_hash;
            this.role = role;
        }

        public User()
        {
        }
    }
}

