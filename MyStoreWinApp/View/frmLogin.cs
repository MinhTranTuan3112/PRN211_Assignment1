using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp.View
{
    public partial class frmLogin : Form, IfrmLogin
    {

        //Fields
        private bool isSuccessful;
        private string message;

        public string Email
        {
            get => txtEmail.Text;
            set
            {
                txtEmail.Text = value;
            }
        }
        public string Password
        {
            get => txtPassword.Text;
            set
            {
                txtPassword.Text = value;
            }
        }

        public bool IsSuccesful
        {
            get => isSuccessful;
            set
            {
                isSuccessful = value;
            }
        }
        public string Message
        {
            get => message;
            set
            {
                message = value;
            }
        }

        public event EventHandler LoginEvent;
        public frmLogin()
        {
            InitializeComponent();
            AssociateAndRaiseEvent();
        }

        private void AssociateAndRaiseEvent()
        {
            btnLogin.Click += btnLogin_Click;
            txtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnLogin_Click(s, e);
                }
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.LoginEvent?.Invoke(this, EventArgs.Empty);
            if (IsSuccesful)
            {
                MessageBox.Show("Login success");
            }
            else
            {
                MessageBox.Show("Wrong email or password", "Login error", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Error);
            }
        }
    }
}
