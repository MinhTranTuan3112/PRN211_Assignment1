using BusinessObject;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;
using MyStoreWinApp.Views;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        //Fields
        private IMemberRepository repository = new MemberRepository();

        //Constructor
        public frmLogin()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
        }
        //Methods
        private void AssociateAndRaiseEvent()
        {
            this.btnLogin.Click += Login;
            this.txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Login(s, e);
                }
            };
            this.btnClose.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question);
                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            };
        }
        private MemberObject GetAccountFromJsonFile()
        {
            IConfiguration config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json", true, true)
                 .Build();
            var adminUser = config["AdminAccount:Email"];
            var adminPassword = config["AdminAccount:Password"];
            var role = config["AdminAccount:Role"];
            return new MemberObject()
            {
                Email = adminUser,
                Password = adminPassword,
                Role = role
            };
        }

        private void Login(object sender, EventArgs e)
        {
            string Email = txtEmail.Text;
            string Password = txtPassword.Text;
            var AdminAccount = GetAccountFromJsonFile();
            //Login success
            bool isAdmin = (AdminAccount.Email.Equals(Email) && AdminAccount.Password.Equals(Password));
            if (isAdmin == true)
            {
                frmMemberManagement newMemberManagementForm = new frmMemberManagement();
                newMemberManagementForm.IsAdmin = true;
                newMemberManagementForm.Show();
                this.Hide();
                return;
            }
            var member = this.repository.Login(Email, Password);
            //Login failed
            if (member is null)
            {
                MessageBox.Show("Wrong Email or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmMemberDetails newMemberDetailsForm = new frmMemberDetails()
            {
                IsEdit = true,
                IsUserDetails = true,
                member = member
            };
            newMemberDetailsForm.Show();
            this.Hide();
        }
    }
}
