using Microsoft.AspNetCore.Identity;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.DAL
{
    public class Initializer
    {
        public static async Task Initialize
            (
            ModelDBContext context
            )
        {
            //Ensures the database is deleted and created everytime we run the program
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();


            var users = new[]
{
                    new User() {Username = "FirstUser"},
                     new User() {Username = "SecondUser"},
            };
            context.Users.AddRange(users);
            context.SaveChanges();

            //Seeding with Posts
            var posts = new[]
            {
                new Post() {
                    Title="FirstPost",
                    Content="A combination of two active substances with a different mode of action.n up by the roots of a sprouting plant.",
                    User=users[0]
                },
                    new Post() {
                    Title="SecondPost",
                    Content="Second Post: A combiaaanation of two active substances with a different mode of action.n up by the roots of a sprouting plant.",
                    User=users[1]
                },
            };
            context.Posts.AddRange(posts);
            context.SaveChanges();


        }
    }
}