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

namespace MyStoreWinApp.Views
{
    public partial class frmMemberDetails : Form
    {
        //Fields
        public IMemberRepository repository = new MemberRepository();
        public MemberObject member { get; set; }
        string MemberID
        {
            get { return txtMemberID.Text; }
            set { txtMemberID.Text = value; }
        }
        string MemberName
        {
            get { return txtMemberName.Text; }
            set { txtMemberName.Text = value; }
        }
        string Email
        {
            get => txtEmail.Text;
            set { txtEmail.Text = value; }
        }
        string Password
        {
            get => txtPassword.Text;
            set { txtPassword.Text = value; }
        }
        string City
        {
            get => txtCity.Text;
            set { txtCity.Text = value; }
        }
        string Country
        {
            get => txtCountry.Text;
            set { txtCountry.Text = value; }
        }
        string Role
        {
            get => txtRole.Text;
            set => txtRole.Text = value;
        }
        public bool IsEdit { get; set; }
        public bool IsSuccessful { get; set; }
        public bool IsUserDetails { get; set; }

        //Constructor
        public frmMemberDetails()
        {
            InitializeComponent();
            RaiseEvent();
        }

        //Methods
        private void RaiseEvent()
        {
            this.Load += frmMemberDetails_OnLoad;
            this.btnSave.Click += delegate
            {
                var message = (IsEdit == true) ? $"Update this member with member id {MemberID}?" : "Add this member?";
                var result = MessageBox.Show(message, (IsEdit) ? "Update member" : "Create member", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveMember();
                }
            };
            btnCancel.Click += delegate
            {
                this.Close();
            };
            btnLogOut.Click += (s, e) =>
            {
                var result = MessageBox.Show("Are you sure you want to log out?", "Log Out",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    BtnLogOut_Click(s, e);
                }
            };
        }
        private void SaveMember()
        {
            try
            {
                var newMember = new MemberObject()
                {
                    MemberID = MemberID,
                    MemberName = MemberName,
                    Email = Email,
                    Password = Password,
                    City = City,
                    Country = Country,
                    Role = Role
                };
                if (!newMember.hasValidEmail())
                {
                    throw new Exception("Invalid Email");
                }
                if (IsEdit)
                {
                    repository.updateMember(newMember);
                    MessageBox.Show("Updated this member", "Update member", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                bool hasDuplicateID = this.repository.getMemberList()
                    .Any(member => member.MemberID.Equals(this.MemberID));
                if (hasDuplicateID)
                {
                    throw new Exception("This Member ID is already existed");
                }
                MessageBox.Show("Added this member", "Add member", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                repository.addNewMember(newMember);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, (IsEdit == true) ? "Update member error" : "Add member error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void frmMemberDetails_OnLoad(object sender, EventArgs e)
        {
            if (this.member is null)
            {
                return;
            }
            if (IsEdit)
            {
                this.txtMemberID.Enabled = false;
                this.txtMemberID.ReadOnly = true;
                this.MemberID = this.member.MemberID;
                this.MemberName = this.member.MemberName;
                this.Email = this.member.Email;
                this.Password = this.member.Password;
                this.City = this.member.City;
                this.Country = this.member.Country;
                this.Role = this.member.Role;
            }
            if (IsUserDetails == true)
            {
                this.btnLogOut.Visible = true;
                this.btnCancel.Visible = false;
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Close();
        }

        private void ClearText()
        {
            MemberID = string.Empty;
            MemberName = string.Empty;
            Email = string.Empty;
            Password = string.Empty;
            City = string.Empty;
            Country = string.Empty;
            Role = string.Empty;
        }
    }
}
