using BusinessObject;
using DataAccess.Repository;
using Microsoft.Extensions.Configuration;
using MyStoreWinApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {

        //Fields
        IMemberRepository repository = new MemberRepository();
        BindingSource source;
        string keyword
        {
            get { return txtSearch.Text; }
            set { txtSearch.Text = value; }
        }
        string City
        {
            get => cbCity.SelectedItem?.ToString() ?? string.Empty;
        }
        string Country
        {
            get => cbCountry.SelectedItem?.ToString() ?? string.Empty;
        }
        bool hasSort
        {
            get => chbSort.Checked;
            set => chbSort.Checked = !chbSort.Checked;
        }
        bool hasDataLoaded { get; set; } = false;
        public bool IsAdmin { get; set; } = false;

        //Constructor
        public frmMemberManagement()
        {
            InitializeComponent();
            RaiseEvent();
        }

        //Methods

        private void RaiseEvent()
        {
            //For tab controls
            tcMemberManagement.SelectTab(tpMain);
            if (!hasDataLoaded)
            {
                if (tcMemberManagement.TabPages.Contains(tpFilter))
                {
                    tcMemberManagement.TabPages.Remove(tpFilter);
                }
                btnEdit.Enabled = false;
                btnCreate.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                if (!tcMemberManagement.TabPages.Contains(tpFilter))
                {
                    tcMemberManagement.TabPages.Add(tpFilter);
                }
                btnEdit.Enabled = true;
                btnCreate.Enabled = true;
                btnDelete.Enabled = true;
            }
            memberGridView.SelectionChanged += memberGridView_SelectionChanged;

            btnLoad.Click += btnLoad_Click;
            btnSearch.Click += btnSearch_Click;
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnSearch_Click(s, e);
                }
            };
            btnCreate.Click += btnCreate_Click;
            btnEdit.Click += btnUpdate_Click;
            memberGridView.CellDoubleClick += delegate
            {
                UpdateMember();
            };
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete this member?", "Delete member",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteMember();
                    LoadMemberList();
                }
            };
            btnLogOut.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to log out?", "Log Out",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                    new frmLogin().Show();
                }
            };
            btnReset.Click += delegate
            {
                var result = MessageBox.Show("Reset filter? If resetted, the inputted data in the filter will be lost",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    ResetFilter();
                }
            };
            cbCity.KeyPress += cbCity_KeyPress;
            cbCountry.KeyPress += cbCountry_KeyPress;
        }

        private void cbCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cbCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Events methods
        private void memberGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (memberGridView.SelectedRows.Count > 0)
            {
                var selectedRow = memberGridView.SelectedRows[0];
                string MemberID = selectedRow.Cells["MemberID"].Value.ToString();
                string MemberName = selectedRow.Cells["MemberName"].Value.ToString();
                string Email = selectedRow.Cells["Email"].Value.ToString();
                string Password = selectedRow.Cells["Password"].Value.ToString();
                string City = selectedRow.Cells["City"].Value.ToString();
                string Country = selectedRow.Cells["Country"].Value.ToString();
                string Role = selectedRow.Cells["Role"].Value.ToString();
                UpdateMemberDataToTextBoxes(new MemberObject()
                {
                    MemberID = MemberID,
                    MemberName = MemberName,
                    Email = Email,
                    Password = Password,
                    City = City,
                    Country = Country,
                    Role = Role
                });
            }
            else
            {
                ClearText();
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateMember();
            ResetFilter();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateMember();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchMember();
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadMemberList();
        }

        //Methods for handling data
        private void ResetFilter()
        {
            txtSearch.Clear();
            cbCity.SelectedIndex = -1;
            cbCity.Text = "Select City";
            cbCountry.SelectedIndex = -1;
            cbCountry.Text = "Select Country";
            chbSort.Checked = false;
        }

        private void InitializeFilters()
        {
            var countryList = repository.getMemberList().Select(member => member.Country).ToList();
            var cityList = repository.getMemberList().Select(member => member.City).ToList();
            cbCity.Items.AddRange(cityList.ToArray());
            cbCountry.Items.AddRange(countryList.ToArray());
        }

        private void LoadMemberList()
        {
            try
            {
                var member_list = repository.getMemberList();
                source = new BindingSource();
                source.DataSource = member_list;
                //Add data binding to text boxes
                txtMemberID.DataBindings.Clear();
                txtMemberName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtRole.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtMemberName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtPassword.DataBindings.Add("Text", source, "Password");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtRole.DataBindings.Add("Text", source, "Role");

                memberGridView.DataSource = null;
                memberGridView.DataSource = member_list;
                if (member_list.Count() == 0)
                {
                    ClearText();
                    this.btnDelete.Enabled = false;
                }
                else
                {
                    this.btnDelete.Enabled = true;
                }
                InitializeFilters();
                hasDataLoaded = true;
                if (!tcMemberManagement.TabPages.Contains(tpFilter))
                {
                    tcMemberManagement.TabPages.Add(tpFilter);
                }
                btnEdit.Enabled = true;
                btnCreate.Enabled = true;
                btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private MemberObject getCurrentMember()
        {
            var current_member = new MemberObject();
            var currentRow = memberGridView.CurrentRow;
            current_member.MemberID = currentRow.Cells["MemberID"].Value as string;
            current_member.MemberName = currentRow.Cells["MemberName"].Value as string;
            current_member.Email = currentRow.Cells["Email"].Value as string;
            current_member.Password = currentRow.Cells["Password"].Value as string;
            current_member.City = currentRow.Cells["City"].Value as string;
            current_member.Country = currentRow.Cells["Country"].Value as string;
            current_member.Role = currentRow.Cells["Role"].Value as string;
            return current_member;
        }

        private void ClearText()
        {
            txtMemberID.Clear();
            txtMemberName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtRole.Clear();
        }

        private void CreateMember()
        {
            btnCreate.Enabled = false;
            frmMemberDetails details_form = new frmMemberDetails()
            {
                Text = "Create Member",
                IsEdit = false,
                repository = this.repository
            };
            if (details_form.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                btnCreate.Enabled = true;
                source.Position = source.Count - 1;
            }
        }
        private void UpdateMember()
        {
            btnEdit.Enabled = false;
            var current_member = getCurrentMember();
            frmMemberDetails details_form = new frmMemberDetails()
            {
                Text = "Update Member",
                IsEdit = true,
                member = current_member,
                repository = this.repository
            };
            if (details_form.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                btnEdit.Enabled = true;
            }
        }
        private void SearchMember()
        {
            try
            {
                var member_list = repository.SearchAll(hasSort, keyword, City, Country);
                memberGridView.DataSource = null;
                memberGridView.DataSource = member_list;
                if (member_list.Count() == 0)
                {
                    this.btnDelete.Enabled = false;
                }
                else
                {
                    this.btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }
        private void DeleteMember()
        {
            var currentMember = getCurrentMember();
            if (currentMember is null)
            {
                MessageBox.Show("Deletion Member error");
                return;
            }
            repository.deleteMember(currentMember.MemberID);
        }

        private void UpdateMemberDataToTextBoxes(MemberObject member)
        {
            txtMemberID.Text = member.MemberID;
            txtMemberName.Text = member.MemberName;
            txtEmail.Text = member.Email;
            txtPassword.Text = member.Password;
            txtCity.Text = member.City;
            txtCountry.Text = member.Country;
            txtRole.Text = member.Role;
        }
    }
}
