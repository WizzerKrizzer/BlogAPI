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
    class UserToFollowController : IDB<UserToFollow, int>
    {
        private ModelDBContext _context;

        public UserToFollowController(ModelDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public void Create(UserToFollow item)
        {
            try
            {
                _context.UsersToFollow.Add(item);
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
                UserToFollow UsersToFollowFromDb = Read(key);

                _context.Remove(UsersToFollowFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public UserToFollow Read(int key)
        {
            try
            {
                return _context.UsersToFollow.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IEnumerable<UserToFollow> ReadAll()
        {
            try
            {
                return _context.UsersToFollow.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public void Update(UserToFollow item)
        {
            try
            {
                UserToFollow UsersToFollowFromDB = Read(item.follow_user_id);

                _context.Entry(UsersToFollowFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
