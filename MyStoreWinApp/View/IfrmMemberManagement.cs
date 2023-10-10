using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStoreWinApp.View
{
    public interface IfrmMemberManagement
    {
        //Fields
        string MemberID { get; set; }
        string MemberName { get; set; }
        string Email { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string Password { get; set; }

        //Events
        event EventHandler SearchEvent;

        //Methods
    }
}
