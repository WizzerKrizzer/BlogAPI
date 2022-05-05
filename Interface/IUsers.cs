using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAPI.Interface
{
    public interface IUsers
    {
        public List<User> GetUserDetails();
        public User GetUserDetails(int id);
        public void AddUser(User user);
        public void UpdateUser(User user);
        public User DeleteUser(int id);
        public bool CheckUser(int id);
    }
}
