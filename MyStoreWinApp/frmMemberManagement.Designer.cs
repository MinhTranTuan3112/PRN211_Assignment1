namespace MyStoreWinApp
{
    partial class frmMemberManagement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            memberGridView = new DataGridView();
            btnLoad = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            cbCity = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cbCountry = new ComboBox();
            tcMemberManagement = new TabControl();
            tpMain = new TabPage();
            lbInfo = new Label();
            btnLogOut = new Button();
            tpMemberManagement = new TabPage();
            txtRole = new TextBox();
            lbRole = new Label();
            txtCountry = new TextBox();
            lbCountry = new Label();
            txtCity = new TextBox();
            lbCity = new Label();
            lbPassword = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtMemberName = new TextBox();
            lbMemberName = new Label();
            txtMemberID = new TextBox();
            lbMemberID = new Label();
            tpFilter = new TabPage();
            btnReset = new Button();
            chbSort = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)memberGridView).BeginInit();
            tcMemberManagement.SuspendLayout();
            tpMain.SuspendLayout();
            tpMemberManagement.SuspendLayout();
            tpFilter.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(380, 9);
            label1.Name = "label1";
            label1.Size = new Size(357, 46);
            label1.TabIndex = 0;
            label1.Text = "Member Management";
            // 
            // memberGridView
            // 
            memberGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberGridView.Location = new Point(12, 311);
            memberGridView.Name = "memberGridView";
            memberGridView.ReadOnly = true;
            memberGridView.RowHeadersWidth = 51;
            memberGridView.RowTemplate.Height = 29;
            memberGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            memberGridView.Size = new Size(1094, 202);
            memberGridView.TabIndex = 0;
            // 
            // btnLoad
            // 
            btnLoad.ForeColor = Color.Black;
            btnLoad.Location = new Point(20, 163);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 2;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 18);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search here";
            txtSearch.Size = new Size(512, 27);
            txtSearch.TabIndex = 3;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(15, 158);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(272, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(302, 163);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(583, 163);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(139, 163);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // cbCity
            // 
            cbCity.FormattingEnabled = true;
            cbCity.Location = new Point(93, 61);
            cbCity.Name = "cbCity";
            cbCity.Size = new Size(194, 28);
            cbCity.TabIndex = 9;
            cbCity.Text = "Select City";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 10;
            label2.Text = "City";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 116);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 11;
            label3.Text = "Country";
            // 
            // cbCountry
            // 
            cbCountry.FormattingEnabled = true;
            cbCountry.Location = new Point(93, 108);
            cbCountry.Name = "cbCountry";
            cbCountry.Size = new Size(194, 28);
            cbCountry.TabIndex = 12;
            cbCountry.Text = "Select Country";
            // 
            // tcMemberManagement
            // 
            tcMemberManagement.Controls.Add(tpMain);
            tcMemberManagement.Controls.Add(tpMemberManagement);
            tcMemberManagement.Controls.Add(tpFilter);
            tcMemberManagement.Location = new Point(12, 65);
            tcMemberManagement.Name = "tcMemberManagement";
            tcMemberManagement.SelectedIndex = 0;
            tcMemberManagement.Size = new Size(1098, 240);
            tcMemberManagement.TabIndex = 13;
            // 
            // tpMain
            // 
            tpMain.Controls.Add(lbInfo);
            tpMain.Controls.Add(btnLogOut);
            tpMain.Location = new Point(4, 29);
            tpMain.Name = "tpMain";
            tpMain.Padding = new Padding(3);
            tpMain.Size = new Size(1090, 207);
            tpMain.TabIndex = 2;
            tpMain.Text = "Main";
            tpMain.UseVisualStyleBackColor = true;
            // 
            // lbInfo
            // 
            lbInfo.AutoSize = true;
            lbInfo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lbInfo.ForeColor = Color.FromArgb(255, 128, 0);
            lbInfo.Location = new Point(29, 17);
            lbInfo.Name = "lbInfo";
            lbInfo.Size = new Size(178, 30);
            lbInfo.TabIndex = 1;
            lbInfo.Text = "Welcome, Admin";
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderColor = Color.Black;
            btnLogOut.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.Red;
            btnLogOut.Location = new Point(29, 135);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(110, 50);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            // 
            // tpMemberManagement
            // 
            tpMemberManagement.Controls.Add(txtRole);
            tpMemberManagement.Controls.Add(lbRole);
            tpMemberManagement.Controls.Add(txtCountry);
            tpMemberManagement.Controls.Add(lbCountry);
            tpMemberManagement.Controls.Add(txtCity);
            tpMemberManagement.Controls.Add(lbCity);
            tpMemberManagement.Controls.Add(lbPassword);
            tpMemberManagement.Controls.Add(txtPassword);
            tpMemberManagement.Controls.Add(txtEmail);
            tpMemberManagement.Controls.Add(lbEmail);
            tpMemberManagement.Controls.Add(txtMemberName);
            tpMemberManagement.Controls.Add(lbMemberName);
            tpMemberManagement.Controls.Add(txtMemberID);
            tpMemberManagement.Controls.Add(lbMemberID);
            tpMemberManagement.Controls.Add(btnCreate);
            tpMemberManagement.Controls.Add(btnEdit);
            tpMemberManagement.Controls.Add(btnLoad);
            tpMemberManagement.Controls.Add(btnDelete);
            tpMemberManagement.Location = new Point(4, 29);
            tpMemberManagement.Name = "tpMemberManagement";
            tpMemberManagement.Padding = new Padding(3);
            tpMemberManagement.Size = new Size(1090, 207);
            tpMemberManagement.TabIndex = 0;
            tpMemberManagement.Text = "Member Management";
            tpMemberManagement.UseVisualStyleBackColor = true;
            // 
            // txtRole
            // 
            txtRole.Enabled = false;
            txtRole.Location = new Point(931, 67);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(125, 27);
            txtRole.TabIndex = 21;
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.ForeColor = Color.Red;
            lbRole.Location = new Point(866, 69);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(39, 20);
            lbRole.TabIndex = 20;
            lbRole.Text = "Role";
            // 
            // txtCountry
            // 
            txtCountry.Enabled = false;
            txtCountry.Location = new Point(583, 120);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(223, 27);
            txtCountry.TabIndex = 19;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(492, 123);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(60, 20);
            lbCountry.TabIndex = 18;
            lbCountry.Text = "Country";
            // 
            // txtCity
            // 
            txtCity.Enabled = false;
            txtCity.Location = new Point(583, 63);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(223, 27);
            txtCity.TabIndex = 17;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(492, 66);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(34, 20);
            lbCity.TabIndex = 16;
            lbCity.Text = "City";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(492, 19);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(70, 20);
            lbPassword.TabIndex = 15;
            lbPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Enabled = false;
            txtPassword.Location = new Point(583, 12);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(223, 27);
            txtPassword.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(139, 116);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(257, 27);
            txtEmail.TabIndex = 13;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(20, 123);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 12;
            lbEmail.Text = "Email";
            // 
            // txtMemberName
            // 
            txtMemberName.Enabled = false;
            txtMemberName.Location = new Point(139, 63);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(257, 27);
            txtMemberName.TabIndex = 11;
            // 
            // lbMemberName
            // 
            lbMemberName.AutoSize = true;
            lbMemberName.Location = new Point(20, 70);
            lbMemberName.Name = "lbMemberName";
            lbMemberName.Size = new Size(109, 20);
            lbMemberName.TabIndex = 10;
            lbMemberName.Text = "Member Name";
            // 
            // txtMemberID
            // 
            txtMemberID.Enabled = false;
            txtMemberID.Location = new Point(139, 12);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.Size = new Size(257, 27);
            txtMemberID.TabIndex = 9;
            // 
            // lbMemberID
            // 
            lbMemberID.AutoSize = true;
            lbMemberID.Location = new Point(20, 19);
            lbMemberID.Name = "lbMemberID";
            lbMemberID.Size = new Size(80, 20);
            lbMemberID.TabIndex = 8;
            lbMemberID.Text = "MemberID";
            // 
            // tpFilter
            // 
            tpFilter.Controls.Add(btnReset);
            tpFilter.Controls.Add(chbSort);
            tpFilter.Controls.Add(txtSearch);
            tpFilter.Controls.Add(label2);
            tpFilter.Controls.Add(cbCountry);
            tpFilter.Controls.Add(cbCity);
            tpFilter.Controls.Add(btnSearch);
            tpFilter.Controls.Add(label3);
            tpFilter.Location = new Point(4, 29);
            tpFilter.Name = "tpFilter";
            tpFilter.Padding = new Padding(3);
            tpFilter.Size = new Size(1090, 207);
            tpFilter.TabIndex = 1;
            tpFilter.Text = "Filter";
            tpFilter.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(312, 158);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(215, 29);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset Filter";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // chbSort
            // 
            chbSort.AutoSize = true;
            chbSort.Location = new Point(312, 112);
            chbSort.Name = "chbSort";
            chbSort.Size = new Size(215, 24);
            chbSort.TabIndex = 13;
            chbSort.Text = "Sort By Name Descendingly";
            chbSort.UseVisualStyleBackColor = true;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 527);
            Controls.Add(tcMemberManagement);
            Controls.Add(memberGridView);
            Controls.Add(label1);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Management";
            ((System.ComponentModel.ISupportInitialize)memberGridView).EndInit();
            tcMemberManagement.ResumeLayout(false);
            tpMain.ResumeLayout(false);
            tpMain.PerformLayout();
            tpMemberManagement.ResumeLayout(false);
            tpMemberManagement.PerformLayout();
            tpFilter.ResumeLayout(false);
            tpFilter.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView memberGridView;
        private Button btnLoad;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnEdit;
        private ComboBox cbCity;
        private Label label2;
        private Label label3;
        private ComboBox cbCountry;
        private TabControl tcMemberManagement;
        private TabPage tpMemberManagement;
        private TabPage tpFilter;
        private Label lbMemberID;
        private Label lbEmail;
        private TextBox txtMemberName;
        private Label lbMemberName;
        private TextBox txtMemberID;
        private TextBox txtEmail;
        private Label lbPassword;
        private TextBox txtPassword;
        private Label lbCountry;
        private TextBox txtCity;
        private Label lbCity;
        private TextBox txtCountry;
        private TabPage tpMain;
        private Label lbInfo;
        private Button btnLogOut;
        private CheckBox chbSort;
        private Button btnReset;
        private TextBox txtRole;
        private Label lbRole;
    }
}