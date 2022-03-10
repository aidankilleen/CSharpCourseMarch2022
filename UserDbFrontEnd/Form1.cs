using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDaoLibrary;

namespace UserDbFrontEnd
{
    public partial class Form1 : Form
    {

        private UserDao dao = new UserDao();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<User>users = dao.GetUsers();

            foreach(var user in users)
            {
                lstUsers.Items.Add(user);
            }
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            User user = (User)lstUsers.SelectedItem;

            if (user != null)
            {
                txtId.Text = $"{user.Id}";
                txtName.Text = user.Name;
                txtEmail.Text = user.Email;
                chkActive.Checked = user.Active;

            } else
            {
                txtId.Text = $"";
                txtName.Text = "";
                txtEmail.Text = "";
                chkActive.Checked = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            User user = (User)lstUsers.SelectedItem;

            if (MessageBox.Show(
                $"Delete {user.Name}?", 
                "Are you sure?", 
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dao.DeleteUser(user.Id);

                lstUsers.Items.Remove(user);

            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetMode(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = (User)lstUsers.SelectedItem;

            user.Name = txtName.Text;
            user.Email = txtEmail.Text;
            user.Active = chkActive.Checked;

            dao.UpdateUser(user);

            int index = lstUsers.SelectedIndex;

            lstUsers.Items.RemoveAt(index);
            lstUsers.Items.Insert(index, user);

            SetMode(false);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            User user = (User)lstUsers.SelectedItem;

            txtName.Text = user.Name;
            txtEmail.Text = user.Email;
            chkActive.Checked = user.Active;

            SetMode(false);

        }
        public void SetMode(bool editing)
        {
            if (editing)
            {
                txtName.ReadOnly = false;
                txtEmail.ReadOnly = false;
                chkActive.Enabled = true;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                btnEdit.Enabled = false;
            } else
            {
                txtName.ReadOnly = true;
                txtEmail.ReadOnly = true;
                chkActive.Enabled = false;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                btnEdit.Enabled = true;
            }
        }
    }
}
