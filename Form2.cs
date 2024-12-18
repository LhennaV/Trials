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
using System.Linq.Expressions;

namespace AAPersonal
{
    public partial class frmSignIn : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\vlhen\OneDrive\C# Coding\velasco-winapp\APERSONAL\AAPersonal\data\data.mdf"";Integrated Security=True;Connect Timeout=30");
        public frmSignIn()
        {
            InitializeComponent();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            txtUsernameIn.Focus();

            if (Properties.Settings.Default.Username != string.Empty)
            {
                txtUsernameIn.Text = Properties.Settings.Default.Username;
                txtPasswordIn.Text = Properties.Settings.Default.Password;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblClickW_Click(object sender, EventArgs e)
        {
            frmSignUp f = new frmSignUp();
            f.Show();
            this.Hide();
        }

        private void cbShowPassIn_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassIn.Checked)
            {
                txtPasswordIn.PasswordChar = '\0';
            }
            else
            {
                txtPasswordIn.PasswordChar = '*';


            }
        }

        private void cbRememberMe_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsernameIn.Text == "" || txtPasswordIn.Text == "")
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

                        String selectData = "SELECT * FROM admin WHERE username = @username AND passwrd = @passwrd";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUsernameIn.Text);
                            cmd.Parameters.AddWithValue("@passwrd", txtPasswordIn.Text);
                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                //Form3 f = new Form3(txtUsernameIn);
                                //f.Show();
                                //this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password. Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Connecting: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }

            if (cbRememberMe.Checked == true)
            {
                Properties.Settings.Default.Username = txtUsernameIn.Text;
                Properties.Settings.Default.Password = txtPasswordIn.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
