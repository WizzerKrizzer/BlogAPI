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
    class UserController : IDB<User, int>
    {
        private ModelDBContext _context;

        public UserController(ModelDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public void Create(User item)
        {
            try
            {
                _context.Users.Add(item);
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
                User UsersFromDb = Read(key);

                _context.Remove(UsersFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public User Read(int key)
        {
            try
            {
                return _context.Users.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IEnumerable<User> ReadAll()
        {
            try
            {
                return _context.Users.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public void Update(User item)
        {
            try
            {
                User UsersFromDB = Read(item.id);

                _context.Entry(UsersFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
