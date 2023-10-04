using ExFourProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFourProject.Interface
{
    public interface IUserInterface
    {
        public Task<bool> CreateAsync(Users user);
        public Task<string> GetNameByIDAsync(int id);

    }
}
