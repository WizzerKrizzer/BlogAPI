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
    class ReactionController : IDB<Reaction, int>
    {
        private ModelDBContext _context;

        public ReactionController(ModelDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public void Create(Reaction item)
        {
            try
            {
                _context.Reactions.Add(item);
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
                Reaction ReactionsFromDb = Read(key);

                _context.Remove(ReactionsFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public Reaction Read(int key)
        {
            try
            {
                return _context.Reactions.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IEnumerable<Reaction> ReadAll()
        {
            try
            {
                return _context.Reactions.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public void Update(Reaction item)
        {
            try
            {
                Reaction ReactionsFromDB = Read(item.id);

                _context.Entry(ReactionsFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
