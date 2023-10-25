namespace MyStoreWinApp.Views
{
    partial class frmMemberDetails
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtMemberID = new TextBox();
            txtMemberName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCountry = new TextBox();
            txtCity = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            lbTitle = new Label();
            lbRole = new Label();
            txtRole = new TextBox();
            btnLogOut = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(164, 89);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 0;
            label1.Text = "MemberID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 153);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 225);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(618, 96);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(618, 229);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 4;
            label5.Text = "City";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(618, 153);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 5;
            label6.Text = "Country";
            // 
            // txtMemberID
            // 
            txtMemberID.Location = new Point(261, 89);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.PlaceholderText = "Enter MemberID ";
            txtMemberID.Size = new Size(215, 27);
            txtMemberID.TabIndex = 6;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(261, 153);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.PlaceholderText = "Enter Member Name";
            txtMemberName.Size = new Size(215, 27);
            txtMemberName.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(261, 218);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Enter Member Email";
            txtEmail.Size = new Size(215, 27);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(733, 89);
            txtPassword.Name = "txtPassword";
            txtPassword.PlaceholderText = "Enter Member Password";
            txtPassword.Size = new Size(215, 27);
            txtPassword.TabIndex = 9;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(732, 153);
            txtCountry.Name = "txtCountry";
            txtCountry.PlaceholderText = "Enter Member Country";
            txtCountry.Size = new Size(216, 27);
            txtCountry.TabIndex = 10;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(732, 222);
            txtCity.Name = "txtCity";
            txtCity.PlaceholderText = "Enter Member City";
            txtCity.Size = new Size(216, 27);
            txtCity.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(382, 370);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(618, 370);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.FromArgb(255, 128, 0);
            lbTitle.Location = new Point(471, 23);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(160, 35);
            lbTitle.TabIndex = 14;
            lbTitle.Text = "Member Info";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.ForeColor = Color.Red;
            lbRole.Location = new Point(164, 294);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(39, 20);
            lbRole.TabIndex = 15;
            lbRole.Text = "Role";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(261, 287);
            txtRole.Name = "txtRole";
            txtRole.PlaceholderText = "Enter Member Role";
            txtRole.Size = new Size(143, 27);
            txtRole.TabIndex = 16;
            // 
            // btnLogOut
            // 
            btnLogOut.ForeColor = Color.Red;
            btnLogOut.Location = new Point(26, 31);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 17;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Visible = false;
            // 
            // frmMemberDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1105, 522);
            Controls.Add(btnLogOut);
            Controls.Add(txtRole);
            Controls.Add(lbRole);
            Controls.Add(lbTitle);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCity);
            Controls.Add(txtCountry);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtMemberName);
            Controls.Add(txtMemberID);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmMemberDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtMemberID;
        private TextBox txtMemberName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCountry;
        private TextBox txtCity;
        private Button btnSave;
        private Button btnCancel;
        private Label lbTitle;
        private Label lbRole;
        private TextBox txtRole;
        private Button btnLogOut;
    }
}