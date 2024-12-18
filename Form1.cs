using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace AAPersonal
{
    public partial class frmSignUp : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\vlhen\OneDrive\C# Coding\velasco-winapp\APERSONAL\AAPersonal\data\data.mdf"";Integrated Security=True;Connect Timeout=30");
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            cbShowPass = new CheckBox();
            button1 = new Button();
            label5 = new Label();
            lblClickG = new Label();
            lblExit = new Label();
            lblUsername = new Label();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 40F, FontStyle.Bold);
            label1.ForeColor = Color.DarkOrchid;
            label1.Location = new Point(50, 41);
            label1.Name = "label1";
            label1.Size = new Size(318, 63);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 10F, FontStyle.Bold);
            label2.ForeColor = Color.DarkOrchid;
            label2.Location = new Point(62, 126);
            label2.Name = "label2";
            label2.Size = new Size(110, 16);
            label2.TabIndex = 0;
            label2.Text = "Email Address:";
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Cursor = Cursors.IBeam;
            txtUsername.Font = new Font("SansSerif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtUsername.ForeColor = Color.Black;
            txtUsername.Location = new Point(62, 198);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(282, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("SansSerif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtPassword.ForeColor = Color.Black;
            txtPassword.Location = new Point(62, 252);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(282, 23);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SansSerif", 10F, FontStyle.Bold);
            label3.ForeColor = Color.DarkOrchid;
            label3.Location = new Point(62, 179);
            label3.Name = "label3";
            label3.Size = new Size(80, 16);
            label3.TabIndex = 0;
            label3.Text = "Username:";
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("SansSerif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            txtEmail.ForeColor = Color.Black;
            txtEmail.Location = new Point(62, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(282, 23);
            txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SansSerif", 10F, FontStyle.Bold);
            label4.ForeColor = Color.DarkOrchid;
            label4.Location = new Point(62, 233);
            label4.Name = "label4";
            label4.Size = new Size(79, 16);
            label4.TabIndex = 0;
            label4.Text = "Password:";
            // 
            // cbShowPass
            // 
            cbShowPass.AutoSize = true;
            cbShowPass.Cursor = Cursors.Hand;
            cbShowPass.FlatStyle = FlatStyle.Flat;
            cbShowPass.Font = new Font("SansSerif", 10F);
            cbShowPass.ForeColor = Color.DimGray;
            cbShowPass.Location = new Point(220, 281);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(124, 20);
            cbShowPass.TabIndex = 0;
            cbShowPass.Text = "Show Password";
            cbShowPass.UseVisualStyleBackColor = true;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkOrchid;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("SansSerif", 15F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(214, 324);
            button1.Name = "button1";
            button1.Size = new Size(130, 44);
            button1.TabIndex = 4;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SansSerif", 10F);
            label5.ForeColor = Color.DimGray;
            label5.Location = new Point(79, 394);
            label5.Name = "label5";
            label5.Size = new Size(176, 16);
            label5.TabIndex = 0;
            label5.Text = "Already Have An Account?";
            // 
            // lblClickG
            // 
            lblClickG.AutoSize = true;
            lblClickG.Cursor = Cursors.Hand;
            lblClickG.Font = new Font("SansSerif", 10F);
            lblClickG.ForeColor = Color.DarkOrchid;
            lblClickG.Location = new Point(252, 394);
            lblClickG.Name = "lblClickG";
            lblClickG.Size = new Size(72, 16);
            lblClickG.TabIndex = 5;
            lblClickG.Text = "Click Here";
            lblClickG.Click += lblClickG_Click;
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
            lblExit.TabIndex = 11;
            lblExit.Text = "x";
            lblExit.Click += lblExit_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("SansSerif", 9.749999F, FontStyle.Italic, GraphicsUnit.Point, 2);
            lblUsername.ForeColor = Color.Red;
            lblUsername.Location = new Point(146, 179);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(0, 15);
            lblUsername.TabIndex = 12;
            lblUsername.Click += lblUsername_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("SansSerif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 2);
            lblResult.ForeColor = Color.DimGray;
            lblResult.Location = new Point(185, 179);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 13;
            lblResult.Click += lblResult_Click;
            // 
            // frmSignUp
            // 
            BackColor = Color.White;
            ClientSize = new Size(407, 472);
            Controls.Add(lblResult);
            Controls.Add(lblUsername);
            Controls.Add(lblExit);
            Controls.Add(lblClickG);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(cbShowPass);
            Controls.Add(txtEmail);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frmSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private CheckBox cbShowPass;
        private Button button1;
        private Label label5;
        private Label lblClickG;
        private Label lblExit;

        private void frmSignUp_Load(object sender, EventArgs e)
        {
            txtEmail.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();
                        String checkUsername = "SELECT * FROM admin WHERE username = '" + txtUsername.Text.Trim() + "'";

                        using (SqlCommand checkUser = new SqlCommand(checkUsername, connect))
                        {
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                lblUsername.Text = txtUsername.Text;
                                lblResult.Text = " already exists!";

                                lblUsername.Location = new Point(146, 179); 
                                lblResult.Location = new Point(lblUsername.Right + 3, lblUsername.Top);
                            }
                            else
                            {
                                string insertData = "INSERT INTO admin (email, username, passwrd, date_created) " +
                                    "VALUES(@email, @username, @passwrd, @date)";

                                DateTime date = DateTime.Today;

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                                    cmd.Parameters.AddWithValue("@passwrd", txtPassword.Text.Trim());
                                    cmd.Parameters.AddWithValue("@date", date);

                                    cmd.ExecuteNonQuery();


                                    frmSignIn f = new frmSignIn();
                                    f.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting Database: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void lblClickG_Click(object sender, EventArgs e)
        {
            frmSignIn f = new frmSignIn();
            f.Show();
            this.Hide();
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private Label lblUsername;
        private Label lblResult;

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
