using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStoreWinApp.View
{
    public interface IfrmLogin
    {
        //Fields
        string Email { get; set; }
        string Password { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        //Events
        event EventHandler LoginEvent;

        //Methods
        void Show();
        void Hide();
    }
}
