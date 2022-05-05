using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BlogAPI.DAL
{
    public class ModelDBContext : DbContext
    {
        /*public ModelDBContext() : base()
        {

        }*/

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Reaction> Reactions { get; set; }

        public DbSet<ReactionType> ReactionTypes { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<UserToFollow> UsersToFollow { get; set; }

        public ModelDBContext(DbContextOptions<ModelDBContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>()
            .HasMany(u => u.Posts)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId);


            builder.Entity<Post>()
            .HasMany(p => p.Comments)
            .WithOne(c => c.Post)
            .HasForeignKey(c => c.PostId);

            builder.Entity<Post>()
            .HasMany(p => p.Reactions)
            .WithOne(c => c.Post)
            .HasForeignKey(c => c.PostId);
        }

        

    }

}
