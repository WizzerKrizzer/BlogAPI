using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogAPI.DAL;

namespace Controller
{
    [ApiController]
    [Route("[controller]")]
    class PostController : IDB<Post, int>
    {
        private ModelDBContext _context;

        public PostController(ModelDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public void Create(Post item)
        {
            try
            {
                _context.Posts.Add(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public void Delete(int key)
        {
            try
            {
                Post PostsFromDb = Read(key);

                _context.Remove(PostsFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public Post Read(int key)
        {
            try
            {
                return _context.Posts.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IEnumerable<Post> ReadAll()
        {
            try
            {
                return _context.Posts.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public void Update(Post item)
        {
            try
            {
                Post PostsFromDB = Read(item.id);

                _context.Entry(PostsFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
