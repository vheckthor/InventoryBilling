using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataManagement
{
    public interface IUsers
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
        string Contact { get; set; }
        string Address { get; set; }
        string Gender { get; set; }
        string UserType { get; set; }
        DateTime AddedDate { get; set; }
        string AddedBy { get; set; }
    }
}
