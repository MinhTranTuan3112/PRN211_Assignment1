using DataAccess.Repository;
using MyStoreWinApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStoreWinApp.Presenter
{
    public class LoginPresenter
    {
        //Fields
        private IfrmLogin view;
        private IMemberRepository repository;
        public LoginPresenter(IfrmLogin view, IMemberRepository repository)
        {
            this.view = view;
            this.repository = repository;
            if (this.view is not null)
            {
                this.view.LoginEvent += Login;
                this.view.Show();
            }
        }

        private void Login(object sender, EventArgs e)
        {
            string Email = view.Email;
            string Password = view.Password;
            var member = repository.Login(Email, Password);
            if (member is not null)
            {
                view.IsSuccesful = true;
            } else
            {
                view.IsSuccesful = false;
            }
        }
    }
}
