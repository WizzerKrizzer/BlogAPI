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
    class ReactionTypeController : IDB<ReactionType, int>
    {
        private ModelDBContext _context;

        public ReactionTypeController(ModelDBContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public void Create(ReactionType item)
        {
            try
            {
                _context.ReactionTypes.Add(item);
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
                ReactionType ReactionTypesFromDb = Read(key);

                _context.Remove(ReactionTypesFromDb);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public ReactionType Read(int key)
        {
            try
            {
                return _context.ReactionTypes.Find(key);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public IEnumerable<ReactionType> ReadAll()
        {
            try
            {
                return _context.ReactionTypes.ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        [HttpGet]
        public void Update(ReactionType item)
        {
            try
            {
                ReactionType ReactionTypesFromDB = Read(item.id);

                _context.Entry(ReactionTypesFromDB).CurrentValues.SetValues(item);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


    }
}
