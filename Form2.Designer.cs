namespace AAPersonal
{
    partial class frmSignIn
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
            lblExit = new Label();
            lblClickW = new Label();
            label5 = new Label();
            btnSignIn = new Button();
            cbShowPassIn = new CheckBox();
            txtPasswordIn = new TextBox();
            label3 = new Label();
            txtUsernameIn = new TextBox();
            label2 = new Label();
            label1 = new Label();
            cbRememberMe = new CheckBox();
            SuspendLayout();
            // 
            // lblExit
            // 
            lblExit.AutoSize = true;
            lblExit.Cursor = Cursors.Hand;
            lblExit.Font = new Font("SansSerif", 20F, FontStyle.Bold);
            lblExit.ForeColor = Color.Black;
            lblExit.Location = new Point(366, 9);
            lblExit.Name = "lblExit";
            lblExit.Size = new Size(29, 31);
            lblExit.TabIndex = 23;
            lblExit.Text = "x";
            lblExit.Click += lblExit_Click;
            // 
            // lblClickW
            // 
            lblClickW.AutoSize = true;
            lblClickW.Cursor = Cursors.Hand;
            lblClickW.Font = new Font("SansSerif", 10F);
            lblClickW.ForeColor = Color.DarkOrchid;
            lblClickW.Location = new Point(235, 394);
            lblClickW.Name = "lblClickW";
            lblClickW.Size = new Size(72, 16);
            lblClickW.TabIndex = 22;
            lblClickW.Text = "Click Here";
            lblClickW.Click += lblClickW_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SansSerif", 10F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(99, 394);
            label5.Name = "label5";
            label5.Size = new Size(141, 16);
            label5.TabIndex = 21;
            label5.Text = "No Account Existing?";
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.DarkOrchid;
            btnSignIn.Cursor = Cursors.Hand;
            btnSignIn.FlatStyle = FlatStyle.Popup;
            btnSignIn.Font = new Font("SansSerif", 15F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(214, 318);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(130, 44);
            btnSignIn.TabIndex = 20;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // cbShowPassIn
            // 
            cbShowPassIn.AutoSize = true;
            cbShowPassIn.Cursor = Cursors.Hand;
            cbShowPassIn.FlatStyle = FlatStyle.Flat;
            cbShowPassIn.Font = new Font("SansSerif", 10F);
            cbShowPassIn.ForeColor = Color.DimGray;
            cbShowPassIn.Location = new Point(220, 266);
            cbShowPassIn.Name = "cbShowPassIn";
            cbShowPassIn.Size = new Size(124, 20);
            cbShowPassIn.TabIndex = 19;
            cbShowPassIn.Text = "Show Password";
            cbShowPassIn.UseVisualStyleBackColor = true;
            cbShowPassIn.CheckedChanged += cbShowPassIn_CheckedChanged;
            // 
            // txtPasswordIn
            // 
            txtPasswordIn.BorderStyle = BorderStyle.FixedSingle;
            txtPasswordIn.Cursor = Cursors.IBeam;
            txtPasswordIn.Font = new Font("SansSerif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtPasswordIn.ForeColor = Color.Black;
            txtPasswordIn.Location = new Point(62, 219);
            txtPasswordIn.Name = "txtPasswordIn";
            txtPasswordIn.PasswordChar = '*';
            txtPasswordIn.Size = new Size(282, 23);
            txtPasswordIn.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SansSerif", 10F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrchid;
            label3.Location = new Point(62, 200);
            label3.Name = "label3";
            label3.Size = new Size(79, 16);
            label3.TabIndex = 15;
            label3.Text = "Password:";
            // 
            // txtUsernameIn
            // 
            txtUsernameIn.BorderStyle = BorderStyle.FixedSingle;
            txtUsernameIn.Cursor = Cursors.IBeam;
            txtUsernameIn.Font = new Font("SansSerif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtUsernameIn.ForeColor = Color.Black;
            txtUsernameIn.Location = new Point(62, 161);
            txtUsernameIn.Name = "txtUsernameIn";
            txtUsernameIn.Size = new Size(282, 23);
            txtUsernameIn.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOrchid;
            label2.Location = new Point(62, 142);
            label2.Name = "label2";
            label2.Size = new Size(80, 16);
            label2.TabIndex = 13;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 38F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(4, 49);
            label1.Name = "label1";
            label1.Size = new Size(399, 59);
            label1.TabIndex = 12;
            label1.Text = "Welcome Back!";
            label1.Click += label1_Click;
            // 
            // cbRememberMe
            // 
            cbRememberMe.AutoSize = true;
            cbRememberMe.Cursor = Cursors.Hand;
            cbRememberMe.FlatStyle = FlatStyle.Flat;
            cbRememberMe.Font = new Font("SansSerif", 10F);
            cbRememberMe.ForeColor = Color.DimGray;
            cbRememberMe.Location = new Point(62, 266);
            cbRememberMe.Name = "cbRememberMe";
            cbRememberMe.Size = new Size(118, 20);
            cbRememberMe.TabIndex = 24;
            cbRememberMe.Text = "Remember Me";
            cbRememberMe.UseVisualStyleBackColor = true;
            cbRememberMe.CheckedChanged += cbRememberMe_CheckedChanged;
            // 
            // frmSignIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(407, 472);
            Controls.Add(cbRememberMe);
            Controls.Add(lblExit);
            Controls.Add(lblClickW);
            Controls.Add(label5);
            Controls.Add(btnSignIn);
            Controls.Add(cbShowPassIn);
            Controls.Add(txtPasswordIn);
            Controls.Add(label3);
            Controls.Add(txtUsernameIn);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sign In";
            Load += frmSignIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExit;
        private Label lblClickW;
        private Label label5;
        private Button btnSignIn;
        private CheckBox cbShowPassIn;
        private TextBox txtPasswordIn;
        private Label label3;
        private TextBox txtUsernameIn;
        private Label label2;
        private Label label1;
        private CheckBox cbRememberMe;
    }
}