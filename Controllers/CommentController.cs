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
    class CommentController : IDB<Comment, int>
    {
        private ModelDBContext _context;

        public CommentController(ModelDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public void Create(Comment item)
        {
            try
            {
                _context.Comments.Add(item);
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
                Comment CommentsFromDb = Read(key);

                _context.Remove(CommentsFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public Comment Read(int key)
        {
            try
            {
                return _context.Comments.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IEnumerable<Comment> ReadAll()
        {
            try
            {
                return _context.Comments.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public void Update(Comment item)
        {
            try
            {
                Comment CommentsFromDB = Read(item.id);

                _context.Entry(CommentsFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
